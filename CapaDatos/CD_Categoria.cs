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


        //gran procedimiento para listar las categorías
        //1ro creamos el metodo listar categorias de tipo List<Categoria> (lista de objetos de tipo Categoria)
        public List<Categoria> ListarCategorias()
        {
            //2do creamos la lista que va a devolver el método, por ahora vacia y de tipo lista de categorias
            List<Categoria> lista = new List<Categoria>();
            //3ro definimos como string la consulta que se llama query y es la que vamos a mandar a la base de datos
            string query = "SELECT IdCategoria, NombreCategoria FROM Categoria";
            //4to aca arranca el metodo que funciona
            try
            {
                //"usando" un objeto SqlConnection que se llama conexión va ser igual al metodo obtener conexión de la clase Conexion
                using (SqlConnection conexion = Conexion.ObtenerConexion())
                {
                    //"usando" un objeto SqlCommand que se llama cmd va ser igual un objeto SqlComman al que le enviamos la query y la conexión que tiene el "obtener conexión"
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //"usando" un objeto SqlDataReader que se llama reader va ser igual al cmd que definimos antes y que ejecute el método ExecuteReader
                        //que lee los datos de la base de datos.
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            //mientras el objeto que se llama reader ejecute el metodo leer propio de su clase
                            while (reader.Read())
                            {
                                //le agrega un nuevo objeto de tipo categoria a la lista donde iguala el id y el nombre de la categoria que trae 
                                //de la base de datos a los atributos de ese nuevo objeto clase categoria que estamos agregando (Add = Agregar)
                                lista.Add(new Categoria()
                                {
                                    //iguala el id y el nombre de la categoria que trae de la base de datos a
                                    //los atributos de ese nuevo objeto clase categoria que estamos agregando (Add = Agregar)
                                    IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                                    NombreCategoria = reader["NombreCategoria"].ToString()
                                });
                            }
                        }
                    }
                }
                
            }
            //este es el metodo si no funciona
            //si aaalgo falló la lista va ser igual a una nueva lista de tipo categoria pero vaciaa
            catch (Exception ex)
            {
                lista = new List<Categoria>();
            }

            //por último devuelve la lista que se generó (en el try o en el catch)
            return lista;
        }
    }
}
