using ProyectoIntegrador.Formularios.Clientes;
using ProyectoIntegrador.Formularios.Compras;
using ProyectoIntegrador.Formularios.Devoluciones;
using ProyectoIntegrador.Formularios.Inventario;
using ProyectoIntegrador.Formularios.Productos;
using ProyectoIntegrador.Formularios.Proveedores;
using ProyectoIntegrador.Formularios.Usuarios;
using ProyectoIntegrador.Formularios.Ventas;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Principal
{
    public partial class FormPrincipalAdministrador : Form
    {

        // Creamos una variable privada para guardar el nombre que viene del login
        private string nombreUsuarioLogueado;

        public FormPrincipalAdministrador(string nombreUsuario)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

            // Guardamos y mostramos el nombre en el footer
            nombreUsuarioLogueado = nombreUsuario;
            LFooter.Text = $"Sesión activa: {nombreUsuarioLogueado} | Control Total";

            EstiloUI.AplicarBordesRedondeados(BUsuarios, 14);
            EstiloUI.AplicarBordesRedondeados(BProductos, 14);
            EstiloUI.AplicarBordesRedondeados(BVentas, 14);
            EstiloUI.AplicarBordesRedondeados(BDevoluciones, 14);
            EstiloUI.AplicarBordesRedondeados(BCompras, 14);
            EstiloUI.AplicarBordesRedondeados(BProveedores, 14);
            EstiloUI.AplicarBordesRedondeados(BClientes, 14);
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

        // Método genérico para abrir cualquier formulario maximizado sin duplicados
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

        private void FormPrincipalAdministrador_Load(object sender, EventArgs e)
        {
            // Personaliza el color de fondo del espacio contenedor MDI al marfil ALBA
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient mdi)
                {
                    mdi.BackColor = EstiloUI.ColorFondo;
                }
            }

            // AQUI MOSTRAMOS EL NOMBRE REAL EN EL FOOTER
            if (!string.IsNullOrEmpty(nombreUsuarioLogueado))
            {
                LFooter.Text = $"Sesión activa: {nombreUsuarioLogueado} | Control Total";
            }

            // Inicia mostrando el catálogo de productos por defecto
            BProductos_Click(this, EventArgs.Empty);
        }

        private void BUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormUsuarios>();
        }

        private void BProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProductos>();
        }

        private void BVentas_Click(object sender, EventArgs e)
        {
            Form formAbierto = this.MdiChildren.FirstOrDefault(x => x is FormOpcionesVenta);

            if (formAbierto != null)
            {
                formAbierto.BringToFront();
                return;
            }

            CerrarFormulariosHijos();

            // Pasamos el nombre del usuario logueado al menú de opciones de venta
            FormOpcionesVenta formOpciones = new FormOpcionesVenta(nombreUsuarioLogueado);
            formOpciones.MdiParent = this;
            formOpciones.WindowState = FormWindowState.Maximized;
            formOpciones.Show();
        }

        private void BDevoluciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormDevoluciones>();
        }

        private void BCompras_Click(object sender, EventArgs e)
        {
            // Verificamos si ya está abierto para traerlo al frente y no duplicarlo
            Form formAbierto = this.MdiChildren.FirstOrDefault(x => x is FormCompras);

            if (formAbierto != null)
            {
                formAbierto.BringToFront();
                return;
            }

            CerrarFormulariosHijos();

            // Abrimos FormCompras pasándole el nombre del usuario logueado
            FormCompras nuevoForm = new FormCompras(nombreUsuarioLogueado);
            nuevoForm.MdiParent = this;
            nuevoForm.WindowState = FormWindowState.Maximized;
            nuevoForm.Show();
        }

        private void BProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProveedores>();
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormClientes>();
        }

        private void BAjusteStock_Click(object sender, EventArgs e)
        {
            // Verificamos si ya está abierto para traerlo al frente
            Form formAbierto = this.MdiChildren.FirstOrDefault(x => x is FormAjusteStock);

            if (formAbierto != null)
            {
                formAbierto.BringToFront();
                return;
            }

            CerrarFormulariosHijos();

            // Aquí le pasas la variable nombreUsuarioLogueado entre los paréntesis
            FormAjusteStock formAjuste = new FormAjusteStock(nombreUsuarioLogueado);
            formAjuste.MdiParent = this;
            formAjuste.WindowState = FormWindowState.Maximized;
            formAjuste.Show();
        }

        private void itemCatalogoProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProductos>();
        }

        private void itemGestionCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCategorias>();
        }

        private void itemOpcionesVenta_Click(object sender, EventArgs e)
        {
            Form formAbierto = this.MdiChildren.FirstOrDefault(x => x is FormVentas);

            if (formAbierto != null)
            {
                formAbierto.BringToFront();
                return;
            }

            CerrarFormulariosHijos();

            // Le pasamos el usuario logueado al abrir la gestión de ventas
            FormVentas formVentas = new FormVentas(nombreUsuarioLogueado);
            formVentas.MdiParent = this;
            formVentas.WindowState = FormWindowState.Maximized;
            formVentas.Show();
        }

        private void itemGestionVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormVentas>();
        }

        private void itemHistorialVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FHistorialVentas>();
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea cerrar la sesión de Administrador?",
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

        private void FormPrincipalAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cierra definitivamente toda la aplicación al cerrar la ventana principal
            Application.Exit();
        }
    }
}
