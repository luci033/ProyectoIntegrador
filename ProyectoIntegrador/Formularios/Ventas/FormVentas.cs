using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Ventas
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void BRegistrarVenta_Click(object sender, EventArgs e)
        {
            //Se abre el formulario de carga como dialogo
            using (FormRegistroVentas formRegistroVenta = new FormRegistroVentas())
            {
                DialogResult resultado = formRegistroVenta.ShowDialog();
                if(resultado == DialogResult.OK)
                {
                    /*
                    CargarVenta();
                    */
                }
            }
            
        }
    }
}
