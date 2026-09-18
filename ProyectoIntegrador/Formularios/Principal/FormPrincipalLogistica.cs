using ProyectoIntegrador.Formularios.Inventario;
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
    public partial class FormPrincipalLogistica : Form
    {
        public FormPrincipalLogistica()
        {
            InitializeComponent();
        }

        private void FormPrincipalLogistica_Load(object sender, EventArgs e)
        {

        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajusteStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAjusteStock formAjuste = new FormAjusteStock())
            {
                formAjuste.ShowDialog();
            }
        }
    }
}
