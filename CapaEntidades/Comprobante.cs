using System;
using System.Collections.Generic;

namespace CapaEntidades
{
    public class Comprobante
    {
        public int IdComprobante { get; set; }
        public DateTime FechaComprobante { get; set; }
        public int IdMedioPago { get; set; }
        public int IdTipoComprobante { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }

        // Propiedades de navegación y presentación
        public string DescripcionMedioPago { get; set; }
        public string DescripcionTipoComprobante { get; set; }
        public string NombreCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string CorreoCliente { get; set; }
        public string CondicionIvaCliente { get; set; }
        public string NombreUsuario { get; set; }
        public decimal Total { get; set; }
        public int CantidadArticulos { get; set; }

        public List<DetalleComprobante> Detalles { get; set; } = new List<DetalleComprobante>();
    }
}
