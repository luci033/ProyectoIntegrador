using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Compras
{
    public partial class FormRegistrarRecepcion : Form
    {
        public FormRegistrarRecepcion(string nroOrden, string proveedor, string fechaOrden)
        {
            InitializeComponent();
            TBNroOrden.Text = nroOrden;
            TBProveedor.Text = proveedor;
            TBFechaOrden.Text = fechaOrden;
        }

        public string FechaSeleccionada { get; private set; }
        public string Observacion { get; private set; }

        private void FormRegistrarRecepcion_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloGrilla(DGDetalleRecepcion);
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BAceptar);
            EstiloUI.AplicarEstiloBoton(BCancelar);
            // fecha del sistema
            TBFechaRecepcion.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in DGDetalleRecepcion.Rows)
            {
                // se toman los valores
                string codigo = fila.Cells[0].Value.ToString();
                int cantPedida = Convert.ToInt32(fila.Cells[3].Value ?? 0);
                int cantRecibida = Convert.ToInt32(fila.Cells[4].Value ?? 0);

                if (cantRecibida < cantPedida)
                {
                    // aca va el cambio de estado si el proveedor entregó de menos
                }

                //aca se ajustarán las actualizaciones de stock
            }

            FechaSeleccionada = TBFechaRecepcion.Text;
            Observacion = TBObservacion.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TBNroOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LFecha_Click(object sender, EventArgs e)
        {

        }

        private void TBFechaRecepcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBObservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
