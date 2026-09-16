using ProyectoIntegrador.Formularios.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Principal
{
    public partial class FormPrincipalVendedor : Form
    {
        public FormPrincipalVendedor()
        {
            InitializeComponent();
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void listarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciamos la pantalla de historial y buscador
            FHistorialVentas pantallaHistorial = new FHistorialVentas();
            pantallaHistorial.ShowDialog();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciamos la pantalla de carga y cobro
            FormRegistroVentas pantallaVentas = new FormRegistroVentas();

            //lo abrimos como modal para que termine la vetna antes de vovler al menu
            pantallaVentas.ShowDialog();
        }
    }
}
