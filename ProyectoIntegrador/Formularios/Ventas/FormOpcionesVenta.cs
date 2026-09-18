using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Ventas
{
    public partial class FormOpcionesVenta : Form
    {
        public FormOpcionesVenta()
        {
            InitializeComponent();
        }

        // Método genérico para abrir el nuevo form en el contenedor principal
        private void AbrirFormularioDesdeOpciones<T>() where T : Form, new()
        {
            Form formPadre = this.MdiParent;

            if (formPadre != null)
            {
                // 1. Cierra todos los formularios hijos actuales (incluido este menú)
                foreach (Form hijo in formPadre.MdiChildren.ToList())
                {
                    hijo.Close();
                }

                // 2. Instancia y abre el nuevo formulario maximizado
                T nuevoForm = new T();
                nuevoForm.MdiParent = formPadre;
                nuevoForm.WindowState = FormWindowState.Maximized;
                nuevoForm.Show();
            }
        }

        private void BRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioDesdeOpciones<FormRegistroVentas>();
        }

        private void BHistorialVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioDesdeOpciones<FHistorialVentas>();
        }
    }
}