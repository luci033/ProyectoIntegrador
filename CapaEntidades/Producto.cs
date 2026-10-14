using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? PrecioCompra { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public int IdGenero { get; set; }
        public int IdCategoria { get; set; }
        public int IdProveedor { get; set; }
    }
}
