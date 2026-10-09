using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objProveedor = new CD_Proveedor();

        public bool RegistrarProveedor(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;
            // Validaciones de negocio antes de ir a la base de datos
            if (string.IsNullOrWhiteSpace(obj.RazonSocial))
            {
                mensaje = "La razón social no puede estar vacía.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(obj.CUIT))
            {
                mensaje = "El CUIT no puede estar vacío.";
                return false;
            }
            // Si pasa las validaciones, le pasa el objeto a la Capa de Datos
            return objProveedor.RegistrarProveedor(obj, out mensaje);
        }
    }
}
