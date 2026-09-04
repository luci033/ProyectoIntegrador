using CapaEntidades; // Para que reconozca tu clase Usuario
using Microsoft.Data.SqlClient; // NOTA: Acá está el using que te prometí recordar
using System;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public void Registrar(Usuario obj)
        {
            // Usa la conexión que creamos antes
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                string query = "INSERT INTO Usuarios (Usuario, NombreUsuario, ApellidoUsuario, Contrasena, IdRol, Activo) " +
                               "VALUES (@usuario, @nombre, @apellido, @pass, @idrol, 1)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", obj.User);
                    cmd.Parameters.AddWithValue("@nombre", obj.NombreUsuario);
                    cmd.Parameters.AddWithValue("@apellido", obj.ApellidoUsuario);
                    cmd.Parameters.AddWithValue("@pass", obj.Contrasena);
                    cmd.Parameters.AddWithValue("@idrol", obj.IdRol);

                    conn.Open();
                    cmd.ExecuteNonQuery(); // Ejecuta la consulta
                }
            }
        }
    }
}