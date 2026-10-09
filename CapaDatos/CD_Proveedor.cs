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
                            VALUES (@RazonSocial, @CUIT, @Telefono, @CorreElectronico)";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@RazonSocial", string.IsNullOrWhiteSpace(obj.RazonSocial) ? (object)DBNull.Value : obj.RazonSocial);
                        cmd.Parameters.AddWithValue("@CUIT", string.IsNullOrWhiteSpace(obj.CUIT) ? (object)DBNull.Value : obj.CUIT);
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(obj.Telefono) ? (object)DBNull.Value : obj.Telefono);
                        cmd.Parameters.AddWithValue("@CorreElectronico", string.IsNullOrWhiteSpace(obj.CorreElectronico) ? (object)DBNull.Value : obj.CorreElectronico);

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
               
                //Si salta la restricción telefono con el formato, mandamos el mensaje.
                if (ex.Message.Contains("CK_Telefono"))
                {
                    mensaje = "No se admite ese formato de teléfono.";
                }
                else
                {
                    mensaje = "Error al guardar el proveedor: " + ex.Message;
                }
            }

            return respuesta;
        }
    }
}
