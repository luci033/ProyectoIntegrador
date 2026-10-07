using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Cliente
    {
        public bool RegistrarCliente(Cliente obj, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            string query = @"INSERT INTO CLIENTE (Nombre, Apellido, DNICUIT, IdCondicionIva, Telefono, CorreoElectronico)
                       VALUES (@Nombre, @Apellido, @DNICUIT, @IdCondicionIva, @Telefono, @CorreoElectronico)";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@Nombre", string.IsNullOrWhiteSpace(obj.Nombre) ? (object)DBNull.Value : obj.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", string.IsNullOrWhiteSpace(obj.Apellido) ? (object)DBNull.Value : obj.Apellido);
                        cmd.Parameters.AddWithValue("@DNICUIT", obj.DNICUIT);
                        cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", string.IsNullOrWhiteSpace(obj.CorreoElectronico) ? (object)DBNull.Value : obj.CorreoElectronico);
                        cmd.Parameters.AddWithValue("@IdCondicionIva", obj.IdCondicionIva);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        respuesta = filasAfectadas > 0;
                    }
                }
            }

            catch (Exception ex)
            {
                respuesta = false;

                // Si salta la restricción UNIQUE del DNI/CUIT que creamos antes en la tabla Cliente
                if (ex.Message.Contains("UQ_Cliente_DNICUIT"))
                {
                    mensaje = "Ya existe un cliente registrado con este DNI o CUIT en el sistema.";
                }
                else
                {
                    mensaje = "Error al guardar el cliente: " + ex.Message;
                }
            }

            return respuesta;
        }
    }
}
