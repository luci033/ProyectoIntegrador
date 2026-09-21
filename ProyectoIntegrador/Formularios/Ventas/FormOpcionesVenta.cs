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

        private void FormOpcionesVenta_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloCard(panelCard, 16);
            EstiloUI.AplicarBordesRedondeados(BRegistrarVenta, 14);
            EstiloUI.AplicarBordesRedondeados(BHistorialVenta, 14);
            BRegistrarVenta.Cursor = Cursors.Hand;
            BHistorialVenta.Cursor = Cursors.Hand;
            CentrarTarjeta();
        }

        private void CentrarTarjeta()
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void FormOpcionesVenta_Resize(object sender, EventArgs e)
        {
            CentrarTarjeta();
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