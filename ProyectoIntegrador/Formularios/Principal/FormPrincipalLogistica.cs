using ProyectoIntegrador.Formularios.Compras;
using ProyectoIntegrador.Formularios.Inventario;
using ProyectoIntegrador.Formularios.Productos;
using ProyectoIntegrador.Formularios.Proveedores;
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
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true; // Permite que este formulario contenga a los otros
        }

        private void CerrarFormulariosHijos()
        {
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }
        }

        private void FormPrincipalLogistica_Load(object sender, EventArgs e)
        {

        }

        // Dejo vacíos los eventos del menú superior viejo por si los borraste del diseño
        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajusteStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BProductos_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            FormProductos frmProductos = new FormProductos();
            frmProductos.MdiParent = this;
            frmProductos.WindowState = FormWindowState.Maximized;
            frmProductos.Show();
        }

        private void BCompras_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            FormCompras frmCompras = new FormCompras();
            frmCompras.MdiParent = this;
            frmCompras.WindowState = FormWindowState.Maximized;
            frmCompras.Show();
        }

        private void BAjusteStock_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            FormAjusteStock frmAjuste = new FormAjusteStock();
            frmAjuste.MdiParent = this;
            frmAjuste.WindowState = FormWindowState.Maximized;
            frmAjuste.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}