using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objProveedor = new CD_Proveedor();

        public bool RegistrarProveedor(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;
            // Validaciones de negocio antes de ir a la base de datos
            if (obj == null)
            {
                mensaje = "Los datos del proveedor no son válidos.";
                return false;
            }
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
            if (string.IsNullOrWhiteSpace(obj.Telefono))
            {
                mensaje = "El teléfono no puede estar vacío.";
                return false;
            }

            return objProveedor.RegistrarProveedor(obj, out mensaje);
        }

        public bool EditarProveedor(Proveedor obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj == null || obj.IdProveedor <= 0)
            {
                mensaje = "El proveedor a modificar no es válido.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(obj.RazonSocial))
            {
                mensaje = "La razón social no puede estar vacía.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(obj.Telefono))
            {
                mensaje = "El teléfono no puede estar vacío.";
                return false;
            }

            return objProveedor.EditarProveedor(obj, out mensaje);
        }

        public List<Proveedor> ListarProveedores()
        {
            return objProveedor.ListarProveedores();
        }
    }
}
