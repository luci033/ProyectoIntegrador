using ProyectoIntegrador.Formularios.Clientes;
using ProyectoIntegrador.Formularios.Compras;
using ProyectoIntegrador.Formularios.Devoluciones;
using ProyectoIntegrador.Formularios.Inventario;
using ProyectoIntegrador.Formularios.Productos;
using ProyectoIntegrador.Formularios.Proveedores;
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
            // 1. Recorremos los formularios hijos abiertos
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is FormProveedores)
                {
                    // Si ya está abierto, lo traemos al frente y cortamos la ejecución
                    formulario.BringToFront();
                    return;
                }
            }

            // 2. Si el bucle termina sin encontrarlo, lo creamos
            FormProveedores formProveedores = new FormProveedores();
            formProveedores.MdiParent = this;
            formProveedores.WindowState = FormWindowState.Maximized;
            formProveedores.Show();
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Recorremos los formularios hijos abiertos
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is FormProveedores)
                {
                    // Si ya está abierto, lo traemos al frente y cortamos la ejecución
                    formulario.BringToFront();
                    return;
                }
            }

            // 2. Si el bucle termina sin encontrarlo, lo creamos
            FormCompras formCompras = new FormCompras();
            formCompras.MdiParent = this;
            formCompras.Show();
        }

        private void listarDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Devoluciones.FormDevoluciones frmDevoluciones = new Devoluciones.FormDevoluciones();
            frmDevoluciones.MdiParent = this;
            frmDevoluciones.WindowState = FormWindowState.Maximized;
            frmDevoluciones.Show();
        }

        private void FormPrincipalAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            // cierra definitivamente toda la aplicación al cerrar la ventana principal
            Application.Exit();
        }

        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Recorremos los formularios hijos abiertos
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is FormClientes)
                {
                    // Si ya está abierto, lo traemos al frente y cortamos la ejecución
                    formulario.BringToFront();
                    return;
                }
            }

            // 1. Instancias el formulario hijo
            FormClientes formularioHijo = new FormClientes();

            // 2. Le indicas quién es su contenedor (this es el formulario padre)
            formularioHijo.MdiParent = this;

            // 3. Forzas a que se abra maximizado dentro del contenedor
            formularioHijo.WindowState = FormWindowState.Maximized;

            // 4. Lo muestras
            formularioHijo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PanelSubMenuUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void BGestionUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creamos la instancia del formulario 
            Formularios.Ventas.FHistorialVentas pantallaHistorial = new Formularios.Ventas.FHistorialVentas();

            // 2. Lo mostramos en pantalla
            pantallaHistorial.ShowDialog();
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
