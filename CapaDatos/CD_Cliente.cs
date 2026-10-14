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

        // Método para traer todos los clientes con su respectiva Condición IVA usando un JOIN
        public DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = @"SELECT 
                            c.IdCliente, 
                            c.Nombre, 
                            c.Apellido, 
                            c.DNICUIT, 
                            c.Telefono, 
                            c.CorreoElectronico, 
                            iv.CondicionIVA AS CondicionIVA 
                         FROM CLIENTE c
                         INNER JOIN CondicionIva iv ON c.IdCondicionIva = iv.IdCondicionIva";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        //metodo para poder modificar un cliente creado y no salte error 
        public bool EditarCliente(Cliente obj, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            string query = @"UPDATE CLIENTE SET 
                        Nombre = @Nombre, 
                        Apellido = @Apellido, 
                        DNICUIT = @DNICUIT, 
                        IdCondicionIva = @IdCondicionIva, 
                        Telefono = @Telefono, 
                        CorreoElectronico = @CorreoElectronico 
                     WHERE IdCliente = @IdCliente";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@IdCliente", obj.IdCliente); // Necesitamos el ID para saber a quién modificar
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
                if (ex.Message.Contains("UQ_DNICUIT"))
                {
                    mensaje = "Ya existe otro cliente registrado con este DNI o CUIT.";
                }
                else
                {
                    mensaje = "Error al modificar el cliente: " + ex.Message;
                }
            }

            return respuesta;
        }

        //se crea este metodo para poder cargar la condcion iva
        public DataTable ListarCondicionIva()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT IdCondicionIva, CondicionIVA FROM CondicionIva"; // REIVSAR SI SE DEFINIÓ ASÍ
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
    }
}
