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
        public bool ExisteDni(string dnicuit, int idClienteExcluir = 0)
        {
            bool existe = false;
            string query = @"SELECT COUNT(1) FROM CLIENTE 
                             WHERE DNICUIT = @DNICUIT 
                             AND (@IdClienteExcluir = 0 OR IdCliente <> @IdClienteExcluir)";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@DNICUIT", dnicuit.Trim());
                        cmd.Parameters.AddWithValue("@IdClienteExcluir", idClienteExcluir);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        existe = count > 0;
                    }
                }
            }
            catch
            {
                existe = false;
            }

            return existe;
        }

        public bool RegistrarCliente(Cliente obj, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            string query = @"INSERT INTO CLIENTE (Nombre, Apellido, DNICUIT, IdCondicionIva, Telefono, CorreoElectronico)
                       VALUES (@Nombre, @Apellido, @DNICUIT, @IdCondicionIva, @Telefono, @CorreoElectronico);
                       SELECT CAST(SCOPE_IDENTITY() AS INT);";

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

                        object idResult = cmd.ExecuteScalar();
                        if (idResult != null && int.TryParse(idResult.ToString(), out int idGen) && idGen > 0)
                        {
                            obj.IdCliente = idGen;
                            respuesta = true;
                        }
                        else
                        {
                            respuesta = false;
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                respuesta = false;
                if (ex.Number == 2627 || ex.Number == 2601 ||
                    ex.Message.Contains("UQ_DNICUIT") || ex.Message.Contains("UQ_Cliente_DNICUIT") ||
                    ex.Message.Contains("UNIQUE KEY") || ex.Message.Contains("duplicate key"))
                {
                    mensaje = "No se pueden registrar dos clientes con el mismo DNI/CUIT.";
                }
                else
                {
                    mensaje = "Error al guardar el cliente: " + ex.Message;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                if (ex.Message.Contains("UQ_DNICUIT") || ex.Message.Contains("UQ_Cliente_DNICUIT") ||
                    ex.Message.Contains("UNIQUE KEY") || ex.Message.Contains("duplicate key"))
                {
                    mensaje = "No se pueden registrar dos clientes con el mismo DNI/CUIT.";
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
                            c.IdCondicionIva,
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
            catch (SqlException ex)
            {
                respuesta = false;
                if (ex.Number == 2627 || ex.Number == 2601 ||
                    ex.Message.Contains("UQ_DNICUIT") || ex.Message.Contains("UQ_Cliente_DNICUIT") ||
                    ex.Message.Contains("UNIQUE KEY") || ex.Message.Contains("duplicate key"))
                {
                    mensaje = "No se pueden registrar dos clientes con el mismo DNI/CUIT.";
                }
                else
                {
                    mensaje = "Error al modificar el cliente: " + ex.Message;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                if (ex.Message.Contains("UQ_DNICUIT") || ex.Message.Contains("UQ_Cliente_DNICUIT") ||
                    ex.Message.Contains("UNIQUE KEY") || ex.Message.Contains("duplicate key"))
                {
                    mensaje = "No se pueden registrar dos clientes con el mismo DNI/CUIT.";
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
