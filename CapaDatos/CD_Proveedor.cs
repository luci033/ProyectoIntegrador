using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        public bool RegistrarProveedor(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            string query = @"INSERT INTO Proveedor (RazonSocial, CUIT, Telefono, CorreoElectronico)
                            VALUES (@RazonSocial, @CUIT, @Telefono, @CorreoElectronico)";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@RazonSocial", string.IsNullOrWhiteSpace(obj.RazonSocial) ? (object)DBNull.Value : obj.RazonSocial.Trim());
                        cmd.Parameters.AddWithValue("@CUIT", string.IsNullOrWhiteSpace(obj.CUIT) ? (object)DBNull.Value : obj.CUIT.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(obj.Telefono) ? (object)DBNull.Value : obj.Telefono.Trim());
                        cmd.Parameters.AddWithValue("@CorreoElectronico", string.IsNullOrWhiteSpace(obj.CorreoElectronico) ? (object)DBNull.Value : obj.CorreoElectronico.Trim());

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        respuesta = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                if (ex.Message.Contains("UQ_CUIT"))
                {
                    mensaje = "Ya existe un proveedor con ese CUIT registrado en el sistema.";
                }
                else if (ex.Message.Contains("CK_Telefono"))
                {
                    mensaje = "No se admite ese formato de teléfono (solo números).";
                }
                else
                {
                    mensaje = "Error al guardar el proveedor: " + ex.Message;
                }
            }

            return respuesta;
        }

        public bool EditarProveedor(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            string query = @"UPDATE Proveedor SET 
                                RazonSocial = @RazonSocial,
                                Telefono = @Telefono, 
                                CorreoElectronico = @CorreoElectronico 
                             WHERE IdProveedor = @IdProveedor";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@RazonSocial", string.IsNullOrWhiteSpace(obj.RazonSocial) ? (object)DBNull.Value : obj.RazonSocial.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(obj.Telefono) ? (object)DBNull.Value : obj.Telefono.Trim());
                        cmd.Parameters.AddWithValue("@CorreoElectronico", string.IsNullOrWhiteSpace(obj.CorreoElectronico) ? (object)DBNull.Value : obj.CorreoElectronico.Trim());
                        cmd.Parameters.AddWithValue("@IdProveedor", obj.IdProveedor);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        respuesta = filasAfectadas > 0;
                        if (!respuesta)
                        {
                            mensaje = "No se encontró el proveedor a modificar.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                if (ex.Message.Contains("CK_Telefono"))
                {
                    mensaje = "No se admite ese formato de teléfono (solo números).";
                }
                else
                {
                    mensaje = "Error al modificar el proveedor: " + ex.Message;
                }
            }

            return respuesta;
        }

        public List<Proveedor> ListarProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();
            string query = "SELECT IdProveedor, RazonSocial, CUIT, Telefono, CorreoElectronico FROM Proveedor";
            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Proveedor()
                                {
                                    IdProveedor = Convert.ToInt32(reader["IdProveedor"]),
                                    RazonSocial = reader["RazonSocial"].ToString(),
                                    CUIT = reader["CUIT"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    CorreoElectronico = reader["CorreoElectronico"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Proveedor>();
            }

            return lista;
        }
    }
}
