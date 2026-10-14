using CapaEntidades;
using System;
using System.Collections.Generic;
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

            string query = @"INSERT INTO Producto (NombreProducto, PrecioVenta, PrecioCompra, StockActual, StockMinimo, Descripcion, Estado, IdGenero, IdCategoria, IdProveedor)";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@NombreProducto", string.IsNullOrWhiteSpace(obj.NombreProducto) ? (object)DBNull.Value : obj.NombreProducto);
                        cmd.Parameters.AddWithValue("@PrecioVenta", (object)obj.PrecioVenta ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PrecioCompra", (object)obj.PrecioVenta ?? DBNull.Value);
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
                //aca las restricciones
                //if
            }

            return respuesta;
        }
    }
}
