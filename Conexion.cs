using System;
using System.Data;
using Microsoft.Data.SqlClient; // O System.Data.SqlClient según el paquete que tengas instalado

namespace ProyectoIntegrador
{
    public static class Conexion
    {
        public static string Cadena = "Data Source=MARTINAGUILAR;Initial Catalog=JoyeriaALBA;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";

        // Método para obtener una conexión abierta
        public static SqlConnection ObtenerConexion()
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