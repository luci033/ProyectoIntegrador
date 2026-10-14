using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Genero
    {

        public List<Genero> ListarGeneros()
        {
            List<Genero> lista = new List<Genero>();

            string query = "SELECT IdGenero, NombreGenero FROM Genero";

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
                                lista.Add(new Genero()
                                {
                                    IdGenero = Convert.ToInt32(reader["IdGenero"]),
                                    NombreGenero = reader["NombreGenero"].ToString()
                                });

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Genero>();
            }

            return lista;
        }


    }
}
