using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class AjusteStock
    {
        public int IdAjuste { get; set; }
        public DateTime FechaAjuste { get; set; }
        public string TipoAjuste { get; set; }
        public int CantidadAjuste { get; set; }
        public string Observacion { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }

        // Propiedades auxiliares para mostrar nombres en grillas si se llega a necesitar REVISAR

        public string NombreUsuario { get; set; }
        public string NombreProducto { get; set; }
    }
}
