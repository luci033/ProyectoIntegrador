using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_AjusteStock
    {
        public bool RegistrarAjuste(int IdProducto, int IdUsuario, string tipoAjuste, int cantidadAjuste, string observacion, out string mensaje)
        {
            mensaje = string.Empty;

            using(SqlConnection conexion = Conexion.ObtenerConexion())
            {
                using (SqlTransaction trans = conexion.BeginTransaction())
                {
                    try
                    {
                        // Se inserta el registro en la tabla AjusteStock
                        string queryAjuste = @"
                            INSERT INTO AjusteStock (FechaAjuste, TipoAjuste, CantidadAjuste, Observacion, IdUsuario, IdProducto)
                            VALUES (GETDATE(), @TipoAjuste, @CantidadAjuste, @Observacion, @IdUsuario, @IdProducto);";

                        using (SqlCommand cmdAjuste = new SqlCommand(queryAjuste, conexion, trans))
                        {
                            cmdAjuste.Parameters.AddWithValue("@TipoAjuste", tipoAjuste);
                            cmdAjuste.Parameters.AddWithValue("@CantidadAjuste", cantidadAjuste);
                            cmdAjuste.Parameters.AddWithValue("@Observacion", string.IsNullOrWhiteSpace(observacion) ? (object)DBNull.Value : observacion.Trim());
                            cmdAjuste.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                            cmdAjuste.Parameters.AddWithValue("@IdProducto", IdProducto);
                            cmdAjuste.ExecuteNonQuery();
                        }

                        // Se actuliza el Stock Actual en la tabla Producto (Suma si es Ingreso, Resta si es Egreso)
                        string queryUpdateStock = "";
                        if (tipoAjuste.Equals("Ingreso", StringComparison.OrdinalIgnoreCase))
                        {
                            queryUpdateStock = "UPDATE Producto SET StockActual = ISNULL(StockActual, 0) + @Cantidad WHERE IdProducto = @IdProducto;";
                        }
                        else // Egreso
                        {
                            queryUpdateStock = "UPDATE Producto SET StockActual = ISNULL(StockActual, 0) - @Cantidad WHERE IdProducto = @IdProducto;";
                        }

                        using (SqlCommand cmdStock = new SqlCommand(queryUpdateStock, conexion, trans))
                        {
                            cmdStock.Parameters.AddWithValue("@Cantidad", cantidadAjuste);
                            cmdStock.Parameters.AddWithValue("@IdProducto", IdProducto);
                            cmdStock.ExecuteNonQuery();
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        mensaje = "Error al registrar el ajuste de stock: " + ex.Message;
                        return false;
                    }
                }
            }
        }
    }
}
