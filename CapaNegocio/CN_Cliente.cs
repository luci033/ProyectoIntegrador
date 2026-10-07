using CapaEntidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        // Instancia para comunicarse con la capa de datos de cliente
        private CD_Cliente objCapaDato = new CD_Cliente();

        // Método para registrar un cliente siguiendo el mismo formato
        public bool Registrar(Cliente obj, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones de negocio antes de ir a la base de datos
            if (string.IsNullOrWhiteSpace(obj.Nombre))
            {
                mensaje = "El nombre del cliente no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(obj.DNICUIT))
            {
                mensaje = "El DNI o CUIT del cliente es obligatorio.";
                return false;
            }

            // Si pasa las validaciones, le pasa el objeto a la Capa de Datos
            return objCapaDato.RegistrarCliente(obj, out mensaje);
        }
    }
}
