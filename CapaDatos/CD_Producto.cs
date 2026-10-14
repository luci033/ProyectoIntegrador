using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Producto
    {
        public bool RegistrarProducto(Producto obj, out string mensaje)
        {
            mensaje = string.Empty;
            
            bool respuesta = false;

            string query = @"INSERT INTO Producto (NombreProducto, PrecioVenta, PrecioCompra, StockActual, StockMinimo, Descripcion, Estado, IdGenero, IdCategoria, IdProveedor)
                            VALUES (@NombreProducto, @PrecioVenta, @PrecioCompra, @StockActual, @StockMinimo, @Descripcion, @Estado, @IdGenero, @IdCategoria, @IdProveedor)";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@NombreProducto", string.IsNullOrWhiteSpace(obj.NombreProducto) ? (object)DBNull.Value : obj.NombreProducto);
                        cmd.Parameters.AddWithValue("@PrecioVenta", (object)obj.PrecioVenta ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PrecioCompra", (object)obj.PrecioCompra ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@StockActual", obj.StockActual);
                        cmd.Parameters.AddWithValue("@StockMinimo", obj.StockMinimo);
                        cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrWhiteSpace(obj.Descripcion) ? (object)DBNull.Value : obj.Descripcion);
                        cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                        cmd.Parameters.AddWithValue("@IdGenero", obj.IdGenero);
                        cmd.Parameters.AddWithValue("@IdCategoria", obj.IdCategoria);
                        cmd.Parameters.AddWithValue("@IdProveedor", obj.IdProveedor);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        respuesta = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = false;

                if (ex.Message.Contains("FK_Genero"))
                {
                    mensaje = "El género seleccionado no es válido o no existe en el sistema.";
                }
                else if (ex.Message.Contains("FK_Categoria"))
                {
                    mensaje = "La categoría seleccionada no es válida o no existe en el sistema.";
                }
                else if (ex.Message.Contains("FK_Proveedor"))
                {
                    mensaje = "El proveedor seleccionado no es válido o no existe en el sistema.";
                }
                else if (ex.Message.Contains("CK_PrecioCompra"))
                {
                    mensaje = "El precio de compra debe ser mayor a cero.";
                }
                else if (ex.Message.Contains("CK_PrecioVenta"))
                {
                    mensaje = "El precio de venta debe ser mayor a cero.";
                }
                else if (ex.Message.Contains("CK_StockMinimo"))
                {
                    mensaje = "El stock mínimo debe ser mayor a cero.";
                }
                else if (ex.Message.Contains("CK_StockActual"))
                {
                    mensaje = "El stock actual no puede ser un número negativo.";
                }
                else
                {
                    mensaje = "Error al registrar el producto: " + ex.Message;
                }
            }

            return respuesta;
        }

        public DataTable ListarProductos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = @"SELECT 
                            p.IdProducto, 
                            p.NombreProducto, 
                            p.PrecioVenta, 
                            p.PrecioCompra, 
                            p.StockActual, 
                            p.StockMinimo, 
                            p.Descripcion, 
                            p.Estado,
                            g.NombreGenero AS NombreGenero,
                            cat.NombreCategoria AS NombreCategoria,
                            pr.RazonSocial AS NombreProveedor
                         FROM PRODUCTO p
                         INNER JOIN Genero g ON p.IdGenero = g.IdGenero
                         INNER JOIN Categoria cat ON p.IdCategoria = cat.IdCategoria
                         INNER JOIN Proveedor pr ON p.IdProveedor = pr.IdProveedor";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public bool EditarProducto(Producto obj, out string mensaje)
        {
            mensaje = string.Empty;

            bool respuesta = false;

            string query = @"UPDATE Producto SET
                            NombreProducto = @NombreProducto,
                            StockMinimo = @StockMinimo,
                            Descripcion = @Descripcion,
                            IdProveedor = @IdProveedor,
                            IdCategoria = @IdCategoria,
                            IdGenero = @IdGenero
                            WHERE IdProducto = @IdProducto";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {


                        cmd.Parameters.AddWithValue("@NombreProducto", string.IsNullOrWhiteSpace(obj.NombreProducto) ? (object)DBNull.Value : obj.NombreProducto);
                        cmd.Parameters.AddWithValue("@StockMinimo", obj.StockMinimo);
                        cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrWhiteSpace(obj.Descripcion) ? (object)DBNull.Value : obj.Descripcion);
                        cmd.Parameters.AddWithValue("@IdGenero", obj.IdGenero);
                        cmd.Parameters.AddWithValue("@IdCategoria", obj.IdCategoria);
                        cmd.Parameters.AddWithValue("@IdProveedor", obj.IdProveedor);
                        cmd.Parameters.AddWithValue("@IdProducto", obj.IdProducto);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        respuesta = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = false;

                if (ex.Message.Contains("FK_Genero"))
                {
                    mensaje = "El género seleccionado no es válido o no existe en el sistema.";
                }
                else if (ex.Message.Contains("FK_Categoria"))
                {
                    mensaje = "La categoría seleccionada no es válida o no existe en el sistema.";
                }
                else if (ex.Message.Contains("FK_Proveedor"))
                {
                    mensaje = "El proveedor seleccionado no es válido o no existe en el sistema.";
                }
                else if (ex.Message.Contains("CK_PrecioCompra"))
                {
                    mensaje = "El precio de compra debe ser mayor a cero.";
                }
                else if (ex.Message.Contains("CK_PrecioVenta"))
                {
                    mensaje = "El precio de venta debe ser mayor a cero.";
                }
                else if (ex.Message.Contains("CK_StockMinimo"))
                {
                    mensaje = "El stock mínimo debe ser mayor a cero.";
                }
                else if (ex.Message.Contains("CK_StockActual"))
                {
                    mensaje = "El stock actual no puede ser un número negativo.";
                }
                else
                {
                    mensaje = "Error al registrar el producto: " + ex.Message;
                }
            }

            return respuesta;
        }
    }
}
