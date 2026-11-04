using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objcd_Venta = new CD_Venta();

        public bool RegistrarVenta(Comprobante obj, out int idComprobanteGenerado, out string mensaje)
        {
            idComprobanteGenerado = 0;
            mensaje = string.Empty;

            if (obj == null)
            {
                mensaje = "Los datos del comprobante de venta no pueden ser nulos.";
                return false;
            }

            if (obj.IdCliente <= 0)
            {
                mensaje = "Debe seleccionar un cliente registrado en el sistema.";
                return false;
            }

            if (obj.IdUsuario <= 0)
            {
                obj.IdUsuario = 1; // Fallback al usuario del sistema
            }

            if (obj.IdMedioPago <= 0)
            {
                mensaje = "Debe seleccionar un medio de pago válido.";
                return false;
            }

            if (obj.IdTipoComprobante <= 0)
            {
                mensaje = "Debe especificar un tipo de comprobante válido.";
                return false;
            }

            if (obj.Detalles == null || obj.Detalles.Count == 0)
            {
                mensaje = "Debe agregar al menos un producto a la venta.";
                return false;
            }

            foreach (var det in obj.Detalles)
            {
                if (det.IdProducto <= 0)
                {
                    mensaje = "Uno de los productos a vender no tiene un identificador válido.";
                    return false;
                }

                if (det.Cantidad <= 0)
                {
                    mensaje = "La cantidad vendida de cada producto debe ser mayor a cero.";
                    return false;
                }

                if (det.PrecioUnitario < 0)
                {
                    mensaje = "El precio unitario de un producto no puede ser negativo.";
                    return false;
                }
            }

            return objcd_Venta.RegistrarVenta(obj, out idComprobanteGenerado, out mensaje);
        }

        public DataTable ListarVentas(DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            return objcd_Venta.ListarVentas(fechaDesde, fechaHasta);
        }

        public DataTable ObtenerDetalleVenta(int idComprobante)
        {
            if (idComprobante <= 0) return new DataTable();
            return objcd_Venta.ObtenerDetalleVenta(idComprobante);
        }

        public Comprobante ObtenerVentaPorId(int idComprobante)
        {
            if (idComprobante <= 0) return null;
            return objcd_Venta.ObtenerVentaPorId(idComprobante);
        }

        public int DeterminarTipoComprobante(string condicionIva)
        {
            if (string.IsNullOrWhiteSpace(condicionIva)) return 2; // Factura B por defecto

            string ci = condicionIva.Trim().ToLower();
            if (ci.Contains("responsable inscripto") || ci.Contains("inscripto"))
            {
                return 1; // Factura A
            }
            else if (ci.Contains("monotribut"))
            {
                return 2; // Factura B
            }
            else if (ci.Contains("exento"))
            {
                return 2; // Factura B
            }
            else
            {
                return 2; // Factura B (Consumidor Final)
            }
        }

        public int DeterminarMedioPago(string metodoPago)
        {
            if (string.IsNullOrWhiteSpace(metodoPago)) return 1; // Contado

            string mp = metodoPago.Trim().ToLower();
            if (mp.Contains("efectivo") || mp.Contains("contado"))
            {
                return 1; // Contado
            }
            else if (mp.Contains("tarjeta") || mp.Contains("debito") || mp.Contains("crédito") || mp.Contains("credito"))
            {
                return 2; // Tarjeta
            }
            else
            {
                return 3; // Otro
            }
        }
    }
}
