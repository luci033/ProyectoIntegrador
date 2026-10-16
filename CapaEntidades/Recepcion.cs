using System;

namespace CapaEntidades
{
    public class Recepcion
    {
        public int IdRecepcion { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public int IdCompra { get; set; }
        public int IdUsuario { get; set; }
        public string Observacion { get; set; }
    }
}
