using System;

namespace CapaEntidades
{
    public class DetalleComprobante
    {
        public int IdDetalleComprobante { get; set; }
        public int IdComprobante { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        // Propiedades de navegación y presentación en grillas / comprobantes
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string NombreCategoria { get; set; }
        public string NombreGenero { get; set; }

        public decimal Subtotal => Cantidad * PrecioUnitario;
    }
}
