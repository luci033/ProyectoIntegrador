using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades; 

namespace CapaDatos
{
    public class CD_Usuario
    {
        public bool RegistrarUsuario(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            string query = @"INSERT INTO Usuarios (Usuario, NombreUsuario, ApellidoUsuario, Contrasena, Foto_Perfil, IdRol, DNI, Activo) 
                             VALUES (@Usuario, @Nombre, @Apellido, @Contrasena, @Foto, @IdRol, @DNI, 1)";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@Usuario", obj.User);
                        cmd.Parameters.AddWithValue("@Nombre", string.IsNullOrWhiteSpace(obj.NombreUsuario) ? (object)DBNull.Value : obj.NombreUsuario);
                        cmd.Parameters.AddWithValue("@Apellido", string.IsNullOrWhiteSpace(obj.ApellidoUsuario) ? (object)DBNull.Value : obj.ApellidoUsuario);
                        cmd.Parameters.AddWithValue("@Contrasena", obj.Contrasena);
                        cmd.Parameters.AddWithValue("@Foto", string.IsNullOrWhiteSpace(obj.Foto_Perfil) ? (object)DBNull.Value : obj.Foto_Perfil);
                        cmd.Parameters.AddWithValue("@IdRol", obj.IdRol);
                        cmd.Parameters.AddWithValue("@DNI", string.IsNullOrWhiteSpace(obj.Dni) ? (object)DBNull.Value : obj.Dni);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        respuesta = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = false;

                // 1. Primero buscamos el dni
                if (ex.Message.Contains("UQ_Usuario_DNI"))
                {
                    mensaje = "Ya existe una persona registrada con este DNI en el sistema.";
                }
                // 2. Si no saltó el DNI, buscamos el usuario
                else if (ex.Message.Contains("UQ_Usuario"))
                {
                    mensaje = "El nombre de usuario ya está en uso. Por favor, elija otro.";
                }
                // 3. Cualquier otra cosa rara de SQL, se muestra
                else
                {
                    mensaje = "Error al guardar: " + ex.Message;
                }
            }

            return respuesta;
        }

        public Usuario Login(string usuario, string contrasena)
        {
            Usuario objUsuario = null; // Arranca nulo por si no encuentra a nadie

            // se busca a alguien que coincida exactamente y que este Activo
            string query = "SELECT IdUsuario, Usuario, NombreUsuario, ApellidoUsuario, IdRol FROM Usuarios WHERE Usuario = @usuario AND Contrasena = @contrasena AND Activo = 1";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // si encontro una fila que coincide
                            {
                                objUsuario = new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                    User = reader["Usuario"].ToString(),
                                    NombreUsuario = reader["NombreUsuario"].ToString(),
                                    ApellidoUsuario = reader["ApellidoUsuario"].ToString(),
                                    IdRol = Convert.ToInt32(reader["IdRol"]),
                                    Contrasena = contrasena
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objUsuario = null; // Si algo explota, no entra nadie
            }

            return objUsuario; // Devuelve los datos del usuario o null si falló
        }
    }
}