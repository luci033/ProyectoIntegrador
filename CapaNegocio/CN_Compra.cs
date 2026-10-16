using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra objCapaDato = new CD_Compra();

        // Margen de ganancia comercial para la fijación del precio de venta (55%)
        public const decimal MARGEN_GANANCIA = 0.55m;

        public DataTable Listar()
        {
            return objCapaDato.ListarCompras();
        }

        public DataTable ObtenerDetalle(int idCompra)
        {
            if (idCompra <= 0)
            {
                return new DataTable();
            }
            return objCapaDato.ObtenerDetalleCompra(idCompra);
        }

        public bool RegistrarOrden(Compra obj, out int idCompraGenerada, out string mensaje)
        {
            idCompraGenerada = 0;
            mensaje = string.Empty;

            // Validaciones de negocio
            if (obj == null)
            {
                mensaje = "Los datos de la orden de compra no son válidos.";
                return false;
            }

            if (obj.IdProveedor <= 0)
            {
                mensaje = "Debe seleccionar un proveedor válido para la orden.";
                return false;
            }

            if (obj.IdUsuario <= 0)
            {
                mensaje = "El usuario emisor no es válido.";
                return false;
            }

            if (obj.Detalles == null || obj.Detalles.Count == 0)
            {
                mensaje = "Debe agregar al menos un producto a la orden de compra.";
                return false;
            }

            foreach (var item in obj.Detalles)
            {
                if (item.IdProducto <= 0)
                {
                    mensaje = "Uno de los productos seleccionados no es válido.";
                    return false;
                }

                if (item.Cantidad <= 0)
                {
                    mensaje = $"La cantidad del producto '{item.NombreProducto}' debe ser mayor a cero.";
                    return false;
                }

                if (item.PrecioUnitario <= 0)
                {
                    mensaje = $"El costo unitario del producto '{item.NombreProducto}' debe ser mayor a cero.";
                    return false;
                }
            }

            return objCapaDato.RegistrarOrdenCompra(obj, out idCompraGenerada, out mensaje);
        }

        public bool RegistrarRecepcion(Recepcion recepcion, List<DetalleRecepcion> detalles, out string mensaje)
        {
            mensaje = string.Empty;

            if (recepcion == null)
            {
                mensaje = "Los datos de recepción no son válidos.";
                return false;
            }

            if (recepcion.IdCompra <= 0)
            {
                mensaje = "La orden de compra asociada no es válida.";
                return false;
            }

            if (recepcion.IdUsuario <= 0)
            {
                mensaje = "El usuario receptor no es válido.";
                return false;
            }

            if (detalles == null || detalles.Count == 0)
            {
                mensaje = "No se recibieron productos para registrar.";
                return false;
            }

            foreach (var item in detalles)
            {
                if (item.CantidadRecibida < 0)
                {
                    mensaje = "La cantidad recibida no puede ser negativa.";
                    return false;
                }
            }

            return objCapaDato.RegistrarRecepcion(recepcion, detalles, MARGEN_GANANCIA, out mensaje);
        }
    }
}
