using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Devoluciones
{
    public partial class FormDevoluciones : Form
    {
        public FormDevoluciones()
        {
            InitializeComponent();
        }

        private void FormDevoluciones_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            using (FormRegistrarDevolucion formRegistro = new FormRegistrarDevolucion())
            {
                if (formRegistro.ShowDialog() == DialogResult.OK)
                {
                    // Acá iría tu función para recargar la grilla si se registró con éxito
                    // CargarGrillaDevoluciones(); 
                }
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = TBBuscar.Text.ToLower();
            DGDevoluciones.CurrentCell = null;

            foreach (DataGridViewRow fila in DGDevoluciones.Rows)
            {
                if (fila.IsNewRow) continue;

                string nroVenta = fila.Cells[1].Value?.ToString().ToLower() ?? "";
                string cliente = fila.Cells[3].Value?.ToString().ToLower() ?? "";

                // muestra la fila si el filtro coincide con la venta o el cliente
                fila.Visible = nroVenta.Contains(filtro) || cliente.Contains(filtro);
            }
        }

        private void DGDevoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            
            if (e.ColumnIndex == 5)
            {
                // Captura el ID de la devolución (asumiendo que está en la columna 0)
                string idDevolucion = DGDevoluciones.Rows[e.RowIndex].Cells[0].Value?.ToString();

                MessageBox.Show("Acá abrís el detalle de la devolución ID: " + idDevolucion);

                // El código real sería similar a este:
                // using (FormVerDetalle formDetalle = new FormVerDetalle(idDevolucion))
                // {
                //     formDetalle.ShowDialog();
                // }
            }
        }
    }
}
