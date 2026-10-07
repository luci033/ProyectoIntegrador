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
    public class CD_Categoria
    {
        public bool RegistrarCategoria(Categoria obj, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            string query = @"INSERT INTO Categoria (NombreCategoria)
                            VALUES (@NombreCategoria)";

            try
            {
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@NombreCategoria", string.IsNullOrWhiteSpace(obj.NombreCategoria) ? (object)DBNull.Value : obj.NombreCategoria);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        respuesta = filasAfectadas > 0;
                    }
                }
            }

            catch (Exception ex)
            {
                respuesta = false;

                // Si salta la restricción UNIQUE del nombre de la categoria que creamos antes en la tabla Categoria
                if (ex.Message.Contains("UQ_NombreCategoria"))
                {
                    mensaje = "Ya existe una categoría con ese nombre registrada en el sistema.";
                }
                else
                {
                    mensaje = "Error al guardar la categoría: " + ex.Message;
                }
            }

            return respuesta;
        }
    }
}
