using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Genero
    {
        private CD_Genero objCapaDato = new CD_Genero();

        public List<Genero> ListarGeneros()
        {
            return objCapaDato.ListarGeneros();
        }


    }
}
