using ProyectoIntegrador.Formularios.Clientes;
using ProyectoIntegrador.Formularios.Devoluciones;
using ProyectoIntegrador.Formularios.Productos;
using ProyectoIntegrador.Formularios.Ventas;
// Agregá los using de las otras carpetas si te los marca en rojo (ej: .Productos, .Clientes, .Inventario)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // Necesario para FirstOrDefault
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Principal
{
    public partial class FormPrincipalVendedor : Form
    {
        private string nombreUsuarioLogueado;
        public FormPrincipalVendedor(string nombreUsuario)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

            nombreUsuarioLogueado = nombreUsuario;
            LFooter.Text = $"Sesión activa: {nombreUsuarioLogueado} | Control Total";

            EstiloUI.AplicarBordesRedondeados(BProductos, 14);
            EstiloUI.AplicarBordesRedondeados(BVentas, 14);
            EstiloUI.AplicarBordesRedondeados(BDevoluciones, 14);
            EstiloUI.AplicarBordesRedondeados(BClientes, 14);
            EstiloUI.AplicarBordesRedondeados(BCerrarSesion, 8);
        }

        private void CerrarFormulariosHijos()
        {
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }
        }

        // Método genérico para abrir cualquier formulario sin duplicados
        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formAbierto = this.MdiChildren.FirstOrDefault(x => x is T);

            if (formAbierto != null)
            {
                formAbierto.BringToFront();
                return;
            }

            CerrarFormulariosHijos();

            T nuevoForm = new T();
            nuevoForm.MdiParent = this;
            nuevoForm.WindowState = FormWindowState.Maximized;
            nuevoForm.Show();
        }

        private void BProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscarProducto>();
        }

        private void BDevoluciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRegistrarDevolucion>();
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormClientes>();
        }

        private void BVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormOpcionesVenta>();
        }

        private void FormPrincipalVendedor_Load(object sender, EventArgs e)
        {
            // Personaliza el fondo del espacio MDI al color institucional
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient mdi)
                {
                    mdi.BackColor = EstiloUI.ColorFondo;
                }
            }

            // Inicia abriendo el módulo de ventas por defecto
            BVentas_Click(this, EventArgs.Empty);
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea cerrar la sesión de Vendedor?",
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

        private void FormPrincipalVendedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void s(object sender, EventArgs e)
        {
            FormPrincipalVendedor_Load(sender, e);
        }

        private void listarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}