using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Rol> ListarRoles()
        {
            List<Rol> lista = new List<Rol>();
            string query = "SELECT IdRol, NombreRol FROM Roles";

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
                                lista.Add(new Rol()
                                {
                                    IdRol = Convert.ToInt32(reader["IdRol"]),
                                    NombreRol = reader["NombreRol"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Si falla, mandamos la lista vacía para que no se caiga el programa
                lista = new List<Rol>();
            }
            return lista;
        }
    }
}