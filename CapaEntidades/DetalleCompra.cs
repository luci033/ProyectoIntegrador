using System;

namespace CapaEntidades
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        // Propiedades auxiliares para visualización en grillas
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string NombreCategoria { get; set; }
        public string NombreGenero { get; set; }
        public int CantidadRecibida { get; set; }

        public decimal Subtotal => Cantidad * PrecioUnitario;
    }
}
