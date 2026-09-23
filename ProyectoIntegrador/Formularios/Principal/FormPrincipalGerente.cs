using ProyectoIntegrador.Formularios.Gerente;
using ProyectoIntegrador.Formularios.Inventario;
using ProyectoIntegrador.Formularios.Ventas;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Principal
{
    public partial class FormPrincipalGerente : Form
    {
        private string nombreUsuarioLogueado;
        private Button botonSeleccionado = null;

        public FormPrincipalGerente(string nombreUsuario)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;


            nombreUsuarioLogueado = nombreUsuario;
            LFooter.Text = $"Sesión activa: {nombreUsuarioLogueado} | Control Total";

            EstiloUI.AplicarBordesRedondeados(BDashboard, 8);
            EstiloUI.AplicarBordesRedondeados(BInformes, 8);
            EstiloUI.AplicarBordesRedondeados(BAjusteStock, 8);
            EstiloUI.AplicarBordesRedondeados(BVentas, 8);
            EstiloUI.AplicarBordesRedondeados(BCerrarSesion, 8);
        }

        private void FormPrincipalGerente_Load(object sender, EventArgs e)
        {
            // Personaliza el color de fondo del espacio contenedor MDI al marfil ALBA
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient mdi)
                {
                    mdi.BackColor = EstiloUI.ColorFondo;
                }
            }

            // Inicia mostrando el Dashboard General por defecto
            BDashboard_Click(this, EventArgs.Empty);
        }

        private void ResaltarBotonActivo(Button boton)
        {
            Color colorBotonNormal = Color.FromArgb(42, 8, 12);
            Color colorTextoNormal = Color.FromArgb(220, 215, 210);

            Color colorBotonActivo = Color.FromArgb(85, 22, 32);
            Color colorTextoActivo = Color.White;

            Button[] botones = { BDashboard, BInformes, BAjusteStock, BVentas };
            foreach (Button b in botones)
            {
                b.BackColor = colorBotonNormal;
                b.ForeColor = colorTextoNormal;
            }

            if (boton != null)
            {
                boton.BackColor = colorBotonActivo;
                boton.ForeColor = colorTextoActivo;
                botonSeleccionado = boton;
            }
        }

        private void CerrarFormulariosHijos()
        {
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }
        }

        private void AbrirFormulario<T>(Button botonMenu) where T : Form, new()
        {
            ResaltarBotonActivo(botonMenu);

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

        private void BDashboard_Click(object sender, EventArgs e)
        {
            ResaltarBotonActivo(BDashboard);

            // Verificamos si ya está abierto para traerlo al frente
            Form formAbierto = this.MdiChildren.FirstOrDefault(x => x is FormDashboardGerente);
            if (formAbierto != null)
            {
                formAbierto.BringToFront();
                return;
            }

            CerrarFormulariosHijos();

            FormDashboardGerente nuevoForm = new FormDashboardGerente(nombreUsuarioLogueado);
            nuevoForm.MdiParent = this;
            nuevoForm.WindowState = FormWindowState.Maximized;
            nuevoForm.Show();
        }

        private void BInformes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormInformesEstadisticos>(BInformes);
        }

        private void BAjusteStock_Click(object sender, EventArgs e)
        {
            ResaltarBotonActivo(BAjusteStock);

            // Verificamos si ya está abierto para traerlo al frente
            Form formAbierto = this.MdiChildren.FirstOrDefault(x => x is FormAjusteStock);
            if (formAbierto != null)
            {
                formAbierto.BringToFront();
                return;
            }

            CerrarFormulariosHijos();

            // Abrimos FormAjusteStock pasándole el usuario logueado
            FormAjusteStock nuevoForm = new FormAjusteStock(nombreUsuarioLogueado);
            nuevoForm.MdiParent = this;
            nuevoForm.WindowState = FormWindowState.Maximized;
            nuevoForm.Show();
        }

        private void BVentas_Click(object sender, EventArgs e)
        {
            // Verificamos si ya está abierto para traerlo al frente
            Form formAbierto = this.MdiChildren.FirstOrDefault(x => x is FormRegistroVentas);

            if (formAbierto != null)
            {
                formAbierto.BringToFront();
                return;
            }

            CerrarFormulariosHijos();

            FormRegistroVentas formVenta = new FormRegistroVentas(nombreUsuarioLogueado);
            formVenta.MdiParent = this;
            formVenta.WindowState = FormWindowState.Maximized;
            formVenta.Show();
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea cerrar la sesión de Gerente?",
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

        private void FormPrincipalGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LSesionUsuario_Click(object sender, EventArgs e)
        {

        }

        private void LFooter_Click(object sender, EventArgs e)
        {

        }
    }
}
