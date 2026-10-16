using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Compra
    {
        public DataTable ListarCompras()
        {
            DataTable tabla = new DataTable();
            string query = @"
                SELECT 
                    c.IdCompra,
                    c.FechaCompra,
                    c.IdUsuario,
                    u.Usuario AS NombreUsuario,
                    c.IdProveedor,
                    p.RazonSocial AS Proveedor,
                    c.IdEstadoCompra,
                    ec.NombreEstadoCompra AS Estado,
                    ISNULL(tot.Total, 0) AS Total,
                    r.FechaRecepcion,
                    r.Observacion
                FROM Compra c
                LEFT JOIN Proveedor p ON c.IdProveedor = p.IdProveedor
                LEFT JOIN Usuarios u ON c.IdUsuario = u.IdUsuario
                LEFT JOIN EstadoCompra ec ON c.IdEstadoCompra = ec.IdEstadoCompra
                LEFT JOIN (
                    SELECT IdCompra, SUM(Cantidad * PrecioUnitario) AS Total
                    FROM DetalleCompra
                    GROUP BY IdCompra
                ) tot ON c.IdCompra = tot.IdCompra
                LEFT JOIN (
                    SELECT IdCompra, MAX(FechaRecepcion) AS FechaRecepcion, MAX(Observacion) AS Observacion
                    FROM Recepcion
                    GROUP BY IdCompra
                ) r ON c.IdCompra = r.IdCompra
                ORDER BY c.IdCompra DESC;";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public DataTable ObtenerDetalleCompra(int idCompra)
        {
            DataTable tabla = new DataTable();
            string query = @"
                SELECT 
                    dc.IdDetalleCompra,
                    dc.IdCompra,
                    dc.IdProducto,
                    prod.NombreProducto,
                    prod.Descripcion,
                    cat.NombreCategoria AS Categoria,
                    gen.NombreGenero AS Genero,
                    dc.Cantidad AS CantidadPedida,
                    ISNULL(dr.CantidadRecibida, 0) AS CantidadRecibida,
                    dc.PrecioUnitario,
                    (dc.Cantidad * dc.PrecioUnitario) AS Subtotal
                FROM DetalleCompra dc
                INNER JOIN Producto prod ON dc.IdProducto = prod.IdProducto
                LEFT JOIN Categoria cat ON prod.IdCategoria = cat.IdCategoria
                LEFT JOIN Genero gen ON prod.IdGenero = gen.IdGenero
                LEFT JOIN (
                    SELECT IdDetalleCompra, IdCompra, SUM(CantidadRecibida) AS CantidadRecibida
                    FROM DetalleRecepcion
                    WHERE IdCompra = @IdCompra
                    GROUP BY IdDetalleCompra, IdCompra
                ) dr ON dc.IdDetalleCompra = dr.IdDetalleCompra AND dc.IdCompra = dr.IdCompra
                WHERE dc.IdCompra = @IdCompra;";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@IdCompra", idCompra);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public bool RegistrarOrdenCompra(Compra obj, out int idCompraGenerada, out string mensaje)
        {
            idCompraGenerada = 0;
            mensaje = string.Empty;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlTransaction trans = conexion.BeginTransaction())
                {
                    try
                    {
                        string queryCompra = @"
                            INSERT INTO Compra (FechaCompra, IdUsuario, IdProveedor, IdEstadoCompra)
                            VALUES (@FechaCompra, @IdUsuario, @IdProveedor, @IdEstadoCompra);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        using (SqlCommand cmdCompra = new SqlCommand(queryCompra, conexion, trans))
                        {
                            cmdCompra.Parameters.AddWithValue("@FechaCompra", obj.FechaCompra);
                            cmdCompra.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);
                            cmdCompra.Parameters.AddWithValue("@IdProveedor", obj.IdProveedor);
                            cmdCompra.Parameters.AddWithValue("@IdEstadoCompra", 1); // 1 = Pendiente

                            idCompraGenerada = (int)cmdCompra.ExecuteScalar();
                        }

                        string queryDetalle = @"
                            INSERT INTO DetalleCompra (IdCompra, Cantidad, PrecioUnitario, IdProducto)
                            VALUES (@IdCompra, @Cantidad, @PrecioUnitario, @IdProducto);";

                        foreach (var item in obj.Detalles)
                        {
                            using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion, trans))
                            {
                                cmdDetalle.Parameters.AddWithValue("@IdCompra", idCompraGenerada);
                                cmdDetalle.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                                cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", item.PrecioUnitario);
                                cmdDetalle.Parameters.AddWithValue("@IdProducto", item.IdProducto);
                                cmdDetalle.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        mensaje = "Error al registrar la orden de compra: " + ex.Message;
                        return false;
                    }
                }
            }
        }

        public bool RegistrarRecepcion(Recepcion recepcion, List<DetalleRecepcion> detalles, decimal margenGanancia, out string mensaje)
        {
            mensaje = string.Empty;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlTransaction trans = conexion.BeginTransaction())
                {
                    try
                    {
                        // 1. Insertar cabecera de Recepcion
                        string queryRecepcion = @"
                            INSERT INTO Recepcion (FechaRecepcion, IdCompra, IdUsuario, Observacion)
                            VALUES (@FechaRecepcion, @IdCompra, @IdUsuario, @Observacion);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        int idRecepcionGenerada;
                        using (SqlCommand cmdRec = new SqlCommand(queryRecepcion, conexion, trans))
                        {
                            cmdRec.Parameters.AddWithValue("@FechaRecepcion", recepcion.FechaRecepcion);
                            cmdRec.Parameters.AddWithValue("@IdCompra", recepcion.IdCompra);
                            cmdRec.Parameters.AddWithValue("@IdUsuario", recepcion.IdUsuario);
                            cmdRec.Parameters.AddWithValue("@Observacion", string.IsNullOrWhiteSpace(recepcion.Observacion) ? (object)DBNull.Value : recepcion.Observacion.Trim());

                            idRecepcionGenerada = (int)cmdRec.ExecuteScalar();
                        }

                        // 2. Insertar DetalleRecepcion y actualizar Stock y Precios en Producto
                        string queryDetalleRec = @"
                            INSERT INTO DetalleRecepcion (CantidadRecibida, IdRecepcion, IdDetalleCompra, IdCompra)
                            VALUES (@CantidadRecibida, @IdRecepcion, @IdDetalleCompra, @IdCompra);";

                        string queryUpdateProducto = @"
                            UPDATE Producto SET
                                StockActual = ISNULL(StockActual, 0) + @CantidadRecibida,
                                PrecioCompra = @PrecioCompra,
                                PrecioVenta = ROUND(@PrecioCompra * (1.0 + @Margen), 2)
                            WHERE IdProducto = @IdProducto;";

                        foreach (var item in detalles)
                        {
                            // Inserción en DetalleRecepcion
                            using (SqlCommand cmdDet = new SqlCommand(queryDetalleRec, conexion, trans))
                            {
                                cmdDet.Parameters.AddWithValue("@CantidadRecibida", item.CantidadRecibida);
                                cmdDet.Parameters.AddWithValue("@IdRecepcion", idRecepcionGenerada);
                                cmdDet.Parameters.AddWithValue("@IdDetalleCompra", item.IdDetalleCompra);
                                cmdDet.Parameters.AddWithValue("@IdCompra", recepcion.IdCompra);
                                cmdDet.ExecuteNonQuery();
                            }

                            // Actualización de producto si se recibió al menos una unidad
                            if (item.CantidadRecibida > 0)
                            {
                                using (SqlCommand cmdProd = new SqlCommand(queryUpdateProducto, conexion, trans))
                                {
                                    cmdProd.Parameters.AddWithValue("@CantidadRecibida", item.CantidadRecibida);
                                    cmdProd.Parameters.AddWithValue("@PrecioCompra", item.PrecioUnitario);
                                    cmdProd.Parameters.AddWithValue("@Margen", margenGanancia);
                                    cmdProd.Parameters.AddWithValue("@IdProducto", item.IdProducto);
                                    cmdProd.ExecuteNonQuery();
                                }
                            }
                        }

                        // 3. Determinar estado de la compra: Recibido Conforme (2) o Recibido Disconforme (3)
                        string queryVerificarCantidades = @"
                            SELECT 
                                SUM(dc.Cantidad) AS CantidadPedidaTotal,
                                SUM(ISNULL(dr.CantidadRecibida, 0)) AS CantidadRecibidaTotal
                            FROM DetalleCompra dc
                            LEFT JOIN DetalleRecepcion dr ON dc.IdDetalleCompra = dr.IdDetalleCompra AND dc.IdCompra = dr.IdCompra
                            WHERE dc.IdCompra = @IdCompra;";

                        int nuevoEstado = 2; // Conforme por defecto
                        using (SqlCommand cmdVerif = new SqlCommand(queryVerificarCantidades, conexion, trans))
                        {
                            cmdVerif.Parameters.AddWithValue("@IdCompra", recepcion.IdCompra);
                            using (SqlDataReader reader = cmdVerif.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int pedida = reader["CantidadPedidaTotal"] != DBNull.Value ? Convert.ToInt32(reader["CantidadPedidaTotal"]) : 0;
                                    int recibida = reader["CantidadRecibidaTotal"] != DBNull.Value ? Convert.ToInt32(reader["CantidadRecibidaTotal"]) : 0;

                                    if (recibida < pedida)
                                    {
                                        nuevoEstado = 3; // Recibido Disconforme
                                    }
                                }
                            }
                        }

                        string queryUpdateEstado = "UPDATE Compra SET IdEstadoCompra = @NuevoEstado WHERE IdCompra = @IdCompra;";
                        using (SqlCommand cmdEstado = new SqlCommand(queryUpdateEstado, conexion, trans))
                        {
                            cmdEstado.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                            cmdEstado.Parameters.AddWithValue("@IdCompra", recepcion.IdCompra);
                            cmdEstado.ExecuteNonQuery();
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        mensaje = "Error al registrar la recepción de mercadería: " + ex.Message;
                        return false;
                    }
                }
            }
        }
    }
}
