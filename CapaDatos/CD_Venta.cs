using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Venta
    {
        public bool RegistrarVenta(Comprobante obj, out int idComprobanteGenerado, out string mensaje)
        {
            idComprobanteGenerado = 0;
            mensaje = string.Empty;

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlTransaction trans = conexion.BeginTransaction())
                {
                    try
                    {
                        // 1. Insertar cabecera del comprobante
                        string queryComprobante = @"
                            INSERT INTO Comprobante (FechaComprobante, IdMedioPago, IdTipoComprobante, IdCliente, IdUsuario)
                            VALUES (@FechaComprobante, @IdMedioPago, @IdTipoComprobante, @IdCliente, @IdUsuario);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        using (SqlCommand cmdComprobante = new SqlCommand(queryComprobante, conexion, trans))
                        {
                            cmdComprobante.Parameters.AddWithValue("@FechaComprobante", obj.FechaComprobante);
                            cmdComprobante.Parameters.AddWithValue("@IdMedioPago", obj.IdMedioPago);
                            cmdComprobante.Parameters.AddWithValue("@IdTipoComprobante", obj.IdTipoComprobante);
                            cmdComprobante.Parameters.AddWithValue("@IdCliente", obj.IdCliente);
                            cmdComprobante.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);

                            idComprobanteGenerado = (int)cmdComprobante.ExecuteScalar();
                        }

                        // 2. Insertar cada detalle y descontar stock atómicamente
                        string queryStock = @"
                            UPDATE Producto 
                            SET StockActual = StockActual - @Cantidad 
                            WHERE IdProducto = @IdProducto AND StockActual >= @Cantidad;";

                        string queryDetalle = @"
                            INSERT INTO DetalleComprobante (IdComprobante, Cantidad, PrecioUnitario, IdProducto)
                            VALUES (@IdComprobante, @Cantidad, @PrecioUnitario, @IdProducto);";

                        foreach (DetalleComprobante det in obj.Detalles)
                        {
                            // Descontar stock
                            using (SqlCommand cmdStock = new SqlCommand(queryStock, conexion, trans))
                            {
                                cmdStock.Parameters.AddWithValue("@Cantidad", det.Cantidad);
                                cmdStock.Parameters.AddWithValue("@IdProducto", det.IdProducto);

                                int filasAfectadas = cmdStock.ExecuteNonQuery();
                                if (filasAfectadas == 0)
                                {
                                    // Stock insuficiente
                                    string nombreProd = !string.IsNullOrWhiteSpace(det.NombreProducto) ? det.NombreProducto : $"ID {det.IdProducto}";
                                    throw new InvalidOperationException($"No hay suficiente stock disponible para el producto '{nombreProd}' (se solicitaron {det.Cantidad} unidades).");
                                }
                            }

                            // Insertar renglón del detalle
                            using (SqlCommand cmdDet = new SqlCommand(queryDetalle, conexion, trans))
                            {
                                cmdDet.Parameters.AddWithValue("@IdComprobante", idComprobanteGenerado);
                                cmdDet.Parameters.AddWithValue("@Cantidad", det.Cantidad);
                                cmdDet.Parameters.AddWithValue("@PrecioUnitario", det.PrecioUnitario);
                                cmdDet.Parameters.AddWithValue("@IdProducto", det.IdProducto);

                                cmdDet.ExecuteNonQuery();
                            }
                        }

                        // Si todo salió bien, confirmamos la transacción
                        trans.Commit();
                        mensaje = "Venta registrada con éxito.";
                        return true;
                    }
                    catch (Exception ex)
                    {
                        try { trans.Rollback(); } catch { }
                        idComprobanteGenerado = 0;
                        mensaje = "Error al registrar la venta: " + ex.Message;
                        return false;
                    }
                }
            }
        }

        public DataTable ListarVentas(DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            DataTable tabla = new DataTable();
            string query = @"
                SELECT 
                    c.IdComprobante,
                    c.FechaComprobante,
                    c.IdMedioPago,
                    mp.NombreMedioPago AS MedioPago,
                    c.IdTipoComprobante,
                    tc.TipoComprobante,
                    c.IdCliente,
                    LTRIM(RTRIM(CONCAT(cl.Nombre, ' ', cl.Apellido))) AS Cliente,
                    cl.DNICUIT,
                    cl.Telefono,
                    cl.CorreoElectronico,
                    ci.CondicionIVA,
                    c.IdUsuario,
                    u.Usuario AS NombreUsuario,
                    ISNULL(NULLIF(LTRIM(RTRIM(CONCAT(u.NombreUsuario, ' ', u.ApellidoUsuario))), ''), u.Usuario) AS UsuarioVendedor,
                    ISNULL(tot.Total, 0) AS Total,
                    ISNULL(tot.CantidadArticulos, 0) AS CantidadArticulos
                FROM Comprobante c
                LEFT JOIN MedioPago mp ON c.IdMedioPago = mp.IdMedioPago
                LEFT JOIN TipoComprobante tc ON c.IdTipoComprobante = tc.IdTipoComprobante
                LEFT JOIN Cliente cl ON c.IdCliente = cl.IdCliente
                LEFT JOIN CondicionIVA ci ON cl.IdCondicionIVA = ci.IdCondicionIVA
                LEFT JOIN Usuarios u ON c.IdUsuario = u.IdUsuario
                LEFT JOIN (
                    SELECT 
                        IdComprobante, 
                        SUM(Cantidad * PrecioUnitario) AS Total,
                        SUM(Cantidad) AS CantidadArticulos
                    FROM DetalleComprobante
                    GROUP BY IdComprobante
                ) tot ON c.IdComprobante = tot.IdComprobante
                WHERE (@FechaDesde IS NULL OR c.FechaComprobante >= @FechaDesde)
                  AND (@FechaHasta IS NULL OR c.FechaComprobante <= @FechaHasta)
                ORDER BY c.IdComprobante DESC;";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@FechaDesde", (object)fechaDesde ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaHasta", (object)fechaHasta ?? DBNull.Value);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public DataTable ObtenerDetalleVenta(int idComprobante)
        {
            DataTable tabla = new DataTable();
            string query = @"
                SELECT 
                    dc.IdDetalleComprobante,
                    dc.IdComprobante,
                    dc.IdProducto,
                    CAST(dc.IdProducto AS VARCHAR(20)) AS Codigo,
                    p.NombreProducto AS Producto,
                    cat.NombreCategoria AS Categoria,
                    gen.NombreGenero AS Genero,
                    dc.Cantidad,
                    dc.PrecioUnitario,
                    (dc.Cantidad * dc.PrecioUnitario) AS Subtotal
                FROM DetalleComprobante dc
                INNER JOIN Producto p ON dc.IdProducto = p.IdProducto
                LEFT JOIN Categoria cat ON p.IdCategoria = cat.IdCategoria
                LEFT JOIN Genero gen ON p.IdGenero = gen.IdGenero
                WHERE dc.IdComprobante = @IdComprobante
                ORDER BY dc.IdDetalleComprobante ASC;";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@IdComprobante", idComprobante);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public Comprobante ObtenerVentaPorId(int idComprobante)
        {
            Comprobante venta = null;
            string query = @"
                SELECT 
                    c.IdComprobante,
                    c.FechaComprobante,
                    c.IdMedioPago,
                    mp.NombreMedioPago AS MedioPago,
                    c.IdTipoComprobante,
                    tc.TipoComprobante,
                    c.IdCliente,
                    LTRIM(RTRIM(CONCAT(cl.Nombre, ' ', cl.Apellido))) AS Cliente,
                    cl.DNICUIT,
                    cl.Telefono,
                    cl.CorreoElectronico,
                    ci.CondicionIVA,
                    c.IdUsuario,
                    u.Usuario AS NombreUsuario,
                    ISNULL(NULLIF(LTRIM(RTRIM(CONCAT(u.NombreUsuario, ' ', u.ApellidoUsuario))), ''), u.Usuario) AS UsuarioVendedor,
                    ISNULL(tot.Total, 0) AS Total,
                    ISNULL(tot.CantidadArticulos, 0) AS CantidadArticulos
                FROM Comprobante c
                LEFT JOIN MedioPago mp ON c.IdMedioPago = mp.IdMedioPago
                LEFT JOIN TipoComprobante tc ON c.IdTipoComprobante = tc.IdTipoComprobante
                LEFT JOIN Cliente cl ON c.IdCliente = cl.IdCliente
                LEFT JOIN CondicionIVA ci ON cl.IdCondicionIVA = ci.IdCondicionIVA
                LEFT JOIN Usuarios u ON c.IdUsuario = u.IdUsuario
                LEFT JOIN (
                    SELECT 
                        IdComprobante, 
                        SUM(Cantidad * PrecioUnitario) AS Total,
                        SUM(Cantidad) AS CantidadArticulos
                    FROM DetalleComprobante
                    GROUP BY IdComprobante
                ) tot ON c.IdComprobante = tot.IdComprobante
                WHERE c.IdComprobante = @IdComprobante;";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@IdComprobante", idComprobante);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            venta = new Comprobante
                            {
                                IdComprobante = Convert.ToInt32(reader["IdComprobante"]),
                                FechaComprobante = Convert.ToDateTime(reader["FechaComprobante"]),
                                IdMedioPago = Convert.ToInt32(reader["IdMedioPago"]),
                                DescripcionMedioPago = reader["MedioPago"]?.ToString() ?? "",
                                IdTipoComprobante = Convert.ToInt32(reader["IdTipoComprobante"]),
                                DescripcionTipoComprobante = reader["TipoComprobante"]?.ToString() ?? "",
                                IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                NombreCliente = reader["Cliente"]?.ToString() ?? "",
                                DocumentoCliente = reader["DNICUIT"]?.ToString() ?? "",
                                TelefonoCliente = reader["Telefono"]?.ToString() ?? "",
                                CorreoCliente = reader["CorreoElectronico"]?.ToString() ?? "",
                                CondicionIvaCliente = reader["CondicionIVA"]?.ToString() ?? "",
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                NombreUsuario = reader["UsuarioVendedor"]?.ToString() ?? reader["NombreUsuario"]?.ToString() ?? "",
                                Total = Convert.ToDecimal(reader["Total"] ?? 0),
                                CantidadArticulos = Convert.ToInt32(reader["CantidadArticulos"] ?? 0)
                            };
                        }
                    }
                }
            }

            if (venta != null)
            {
                DataTable dtDetalle = ObtenerDetalleVenta(idComprobante);
                foreach (DataRow row in dtDetalle.Rows)
                {
                    venta.Detalles.Add(new DetalleComprobante
                    {
                        IdDetalleComprobante = Convert.ToInt32(row["IdDetalleComprobante"]),
                        IdComprobante = Convert.ToInt32(row["IdComprobante"]),
                        IdProducto = Convert.ToInt32(row["IdProducto"]),
                        CodigoProducto = row["Codigo"]?.ToString() ?? row["IdProducto"].ToString(),
                        NombreProducto = row["Producto"]?.ToString() ?? "",
                        NombreCategoria = row["Categoria"]?.ToString() ?? "",
                        NombreGenero = row["Genero"]?.ToString() ?? "",
                        Cantidad = Convert.ToInt32(row["Cantidad"]),
                        PrecioUnitario = Convert.ToDecimal(row["PrecioUnitario"])
                    });
                }
            }

            return venta;
        }
    }
}
