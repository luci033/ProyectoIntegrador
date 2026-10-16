using System;
using System.Collections.Generic;

namespace CapaEntidades
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public int IdUsuario { get; set; }
        public int IdProveedor { get; set; }
        public int IdEstadoCompra { get; set; }

        // Propiedades de navegación y presentación
        public string RazonSocialProveedor { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreEstadoCompra { get; set; }
        public decimal Total { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string Observacion { get; set; }

        public List<DetalleCompra> Detalles { get; set; } = new List<DetalleCompra>();
    }
}
