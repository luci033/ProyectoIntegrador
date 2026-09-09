using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Compras
{
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void LProveedores_Click(object sender, EventArgs e)
        {

        }

        private void BAgregarOrden_Click(object sender, EventArgs e)
        {
            using (FormOrdenCompra formOrdenCompra = new FormOrdenCompra())
            {
                if (formOrdenCompra.ShowDialog() == DialogResult.OK)
                {
                    // Aquí procesas los datos devueltos por la orden cuando se confirme
                }
            }
        }

        private void DGProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BRegistrarCompra_Click(object sender, EventArgs e)
        {

        }
    }
}
