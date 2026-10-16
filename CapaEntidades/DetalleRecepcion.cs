using System;

namespace CapaEntidades
{
    public class DetalleRecepcion
    {
        public int IdDetalleRecepcion { get; set; }
        public int CantidadRecibida { get; set; }
        public int IdRecepcion { get; set; }
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }

        // Propiedad auxiliar para actualizar stock/costo del producto correspondiente
        public int IdProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
