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
    public partial class FormVerDetalle : Form
    {
        private List<object[]> listaProductos; // Variable global

        // Actualizar constructor
        public FormVerDetalle(string nro, string prov, string fecha, string recep, string obs, string total, List<object[]> detalles)
        {
            InitializeComponent();
            TBNroOrden.Text = nro;
            TBProveedor.Text = prov;
            TBFechaEmision.Text = fecha;
            TBFechaRecepcion.Text = recep;
            TBObservacion.Text = obs;
            TBTotalGeneral.Text = total;
            listaProductos = detalles; // Asignar
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormVerDetalle_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloGrilla(DGDetalleOrden);
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BCerrar);

            // Llenar grilla dinámicamente
            if (listaProductos != null)
            {
                foreach (var item in listaProductos)
                {
                    DGDetalleOrden.Rows.Add(
                        item[0], // ID
                        item[1], // Código
                        item[2], // Nombre
                        item[3], // Categoría
                        item[4], // Género
                        item[5], // Cantidad Pedida
                        item[8], // Cantidad Recibida (Índice 8 que acabamos de crear)
                        item[6], // Costo
                        item[7]  // Subtotal
                    );
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DGDetalleOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
