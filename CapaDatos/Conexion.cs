using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public static class Conexion
    {
        public static string Cadena = @"Data Source=DESKTOP-596J6HI\SQLEXPRESS;Initial Catalog=JoyeriaALBADB;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;"; public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(Cadena);
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
    }
}