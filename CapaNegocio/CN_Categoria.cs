using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class CN_Categoria
    {
        // Instancia para comunicarse con la capa de datos de categoria
        private CD_Categoria objCapaDato = new CD_Categoria();

        // Método para registrar una categoria siguiendo el mismo formato
        public bool Registrar(Categoria obj, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de negocio antes de ir a la base de datos
            if (string.IsNullOrWhiteSpace(obj.NombreCategoria))
            {
                mensaje = "El nombre de la categoria no puede estar vacío.";
                return false;
            }

            // Si pasa las validaciones, le pasa el objeto a la Capa de Datos
            return objCapaDato.RegistrarCategoria(obj, out mensaje);
        }
    }
}
