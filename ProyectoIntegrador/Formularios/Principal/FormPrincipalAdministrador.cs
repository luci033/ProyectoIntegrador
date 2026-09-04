using ProyectoIntegrador.Formularios.Devoluciones;
using ProyectoIntegrador.Formularios.Productos;
using ProyectoIntegrador.Formularios.Usuarios;
using ProyectoIntegrador.Formularios.Ventas;
using System;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Principal
{
    public partial class FormPrincipalAdministrador : Form
    {
        public FormPrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void CerrarFormulariosHijos()
        {
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestiónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            FormProductos frmProductos = new FormProductos();
            frmProductos.MdiParent = this;
            frmProductos.WindowState = FormWindowState.Maximized;
            frmProductos.Show();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            FormUsuarios frmUsuarios = new FormUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.WindowState = FormWindowState.Maximized;
            frmUsuarios.Show();
        }

        private void geToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            FormVentas frmVentas = new FormVentas();
            frmVentas.MdiParent = this;
            frmVentas.WindowState = FormWindowState.Maximized;
            frmVentas.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            FormDevoluciones frmDevoluciones = new FormDevoluciones();
            frmDevoluciones.MdiParent = this;
            frmDevoluciones.WindowState = FormWindowState.Maximized;
            frmDevoluciones.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void gestiónDeCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategorias frmCategorias = new FormCategorias();
            frmCategorias.MdiParent = this;
            frmCategorias.WindowState = FormWindowState.Maximized;
            frmCategorias.Show();
        }

        private void gestiónDeDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
