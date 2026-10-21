using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        // Instancia para comunicarse con la capa de datos de categoria
        private CD_Categoria objCapaDato = new CD_Categoria();

        // Método para registrar una categoria siguiendo el mismo formato
        public bool Registrar(Categoria obj, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de negocio antes de ir a la base de datos
            if (obj == null || string.IsNullOrWhiteSpace(obj.NombreCategoria))
            {
                mensaje = "El nombre de la categoria no puede estar vacío.";
                return false;
            }

            // Si pasa las validaciones, le pasa el objeto a la Capa de Datos
            return objCapaDato.RegistrarCategoria(obj, out mensaje);
        }

        // Método para editar una categoria existente
        public bool Editar(Categoria obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj == null || obj.IdCategoria <= 0)
            {
                mensaje = "La categoría a modificar no es válida.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(obj.NombreCategoria))
            {
                mensaje = "El nombre de la categoría no puede estar vacío.";
                return false;
            }

            return objCapaDato.EditarCategoria(obj, out mensaje);
        }

        public List<Categoria> ListarCategorias()
        {
            return objCapaDato.ListarCategorias();
        }
    }
}
