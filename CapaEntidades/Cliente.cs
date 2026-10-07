using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
            public int IdCliente { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string DNICUIT { get; set; }
            public string Telefono { get; set; }
            public string CorreoElectronico { get; set; }
            public int IdCondicionIva { get; set; }
    }
}
