using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_AjusteStock
    {

        private CD_AjusteStock objCapaDato = new CD_AjusteStock();

        public bool RegistrarAjuste(int idProducto, int idUsuario, string tipoAjuste, int cantidadAjuste, string observacion, int stockActual, out string mensaje)
        {
            mensaje = string.Empty;

            if (idProducto <= 0)
            {
                mensaje = "Debe seleccionar un producto válido.";
                return false;
            }

            if (idUsuario <= 0)
            {
                mensaje = "El usuario operador no es válido.";
                return false;
            }

            if (cantidadAjuste <= 0)
            {
                mensaje = "La cantidad a ajustar debe ser mayor a cero.";
                return false;
            }

            // Validación de stock negativo en caso de egresos
            if (tipoAjuste.Equals("Egreso", StringComparison.OrdinalIgnoreCase))
            {
                if (stockActual - cantidadAjuste < 0)
                {
                    mensaje = $"No se puede realizar el egreso. El stock actual ({stockActual}) es menor a la cantidad a retirar ({cantidadAjuste}).";
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(observacion) || observacion.Trim().Length < 5)
            {
                mensaje = "Debe ingresar un motivo u observación válida (mínimo 5 caracteres).";
                return false;
            }

            return objCapaDato.RegistrarAjuste(idProducto, idUsuario, tipoAjuste, cantidadAjuste, observacion, out mensaje);
        }
    }
}

