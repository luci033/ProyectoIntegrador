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
        private string nombreUsuarioLogueado;
        public FormPrincipalLogistica(string nombreUsuario)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true; // Permite que este formulario contenga a los otros

            nombreUsuarioLogueado = nombreUsuario;
            LFooter.Text = $"Sesión activa: {nombreUsuarioLogueado} | Control Total"; 
            EstiloUI.AplicarBordesRedondeados(BProductos, 14);
            EstiloUI.AplicarBordesRedondeados(BCompras, 14);
            EstiloUI.AplicarBordesRedondeados(BAjusteStock, 14);
            EstiloUI.AplicarBordesRedondeados(BCerrarSesion, 8);
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
            // Personaliza el color de fondo del espacio contenedor MDI
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient mdi)
                {
                    mdi.BackColor = EstiloUI.ColorFondo;
                }
            }

            // Inicia mostrando el catálogo de productos por defecto
            BProductos_Click(this, EventArgs.Empty);
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

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea cerrar la sesión de Logística?",
                "Cerrar Sesión - Joyería ALBA",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void FormPrincipalLogistica_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}