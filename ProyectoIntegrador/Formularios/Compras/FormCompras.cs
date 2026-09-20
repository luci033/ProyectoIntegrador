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
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void LProveedores_Click(object sender, EventArgs e)
        {

        }

        private void BAgregarOrden_Click(object sender, EventArgs e)
        {
            using (FormOrdenCompra formNueva = new FormOrdenCompra())
            {
                if (formNueva.ShowDialog() == DialogResult.OK)
                {
                    int nro = DGCompras.Rows.Count + 1;
                    // agregar fila 
                    DGCompras.Rows.Add(nro, formNueva.Fecha, formNueva.Proveedor, "Registrar Recepción", "", formNueva.Total, "Ver...");
                }
            }
        }

        private void DGProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // para no clickear los titulos

            // fecha recepción es columna 3
            if (e.ColumnIndex == 3 && DGCompras.Rows[e.RowIndex].Cells[3].Value.ToString() == "Registrar Recepción")
            {
                string nro = DGCompras.Rows[e.RowIndex].Cells[1].Value.ToString();
                string fecha = DGCompras.Rows[e.RowIndex].Cells[2].Value.ToString();
                string prov = DGCompras.Rows[e.RowIndex].Cells[3].Value.ToString();
                using (FormRegistrarRecepcion formRecepcion = new FormRegistrarRecepcion(nro, prov, fecha))
                {
                    if (formRecepcion.ShowDialog() == DialogResult.OK)
                    {
                        // reemplazo el boton por la fecha seleccionada y la observacion
                        DGCompras.Rows[e.RowIndex].Cells[3].Value = formRecepcion.FechaSeleccionada;
                        DGCompras.Rows[e.RowIndex].Cells[4].Value = formRecepcion.Observacion;
                    }
                }
            }
            // detalle es la col index 6
            else if (e.ColumnIndex == 6)
            {
                DataGridViewRow fila = DGCompras.Rows[e.RowIndex];

                string nro = fila.Cells[0].Value?.ToString();
                string fecha = fila.Cells[1].Value?.ToString();
                string prov = fila.Cells[2].Value?.ToString();
                string recep = fila.Cells[3].Value?.ToString();
                string obs = fila.Cells[4].Value?.ToString();
                string total = fila.Cells[5].Value?.ToString();

                using (FormVerDetalle formDetalle = new FormVerDetalle(nro, prov, fecha, recep, obs, total))
                {
                    formDetalle.ShowDialog();
                }
            }
        }

        private void BRegistrarCompra_Click(object sender, EventArgs e)
        {

        }

        private void FormCompras_Load(object sender, EventArgs e)
        {

        }
    }
}
