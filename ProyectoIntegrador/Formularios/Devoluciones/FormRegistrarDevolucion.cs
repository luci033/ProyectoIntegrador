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
    public partial class FormRegistrarDevolucion : Form
    {
        public FormRegistrarDevolucion()
        {
            InitializeComponent();
        }

        private void DGDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGDetalleVenta_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DGDetalleVenta.IsCurrentCellDirty)
            {
                DGDetalleVenta.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DGDetalleVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Solo validamos si modifican la columna "Cantidad a Devolver"
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                int cantComprada = Convert.ToInt32(DGDetalleVenta.Rows[e.RowIndex].Cells[4].Value ?? 0);
                int cantDevolver = Convert.ToInt32(DGDetalleVenta.Rows[e.RowIndex].Cells[5].Value ?? 0);

                if (cantDevolver > cantComprada)
                {
                    MessageBox.Show("No se pueden devolver más unidades de las que se compraron.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DGDetalleVenta.Rows[e.RowIndex].Cells[5].Value = 0; // Resetea el valor
                }
            }
        }

        private void BRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            bool hayDevolucion = false;

            foreach (DataGridViewRow fila in DGDetalleVenta.Rows)
            {
                int cantDevolver = Convert.ToInt32(fila.Cells[5].Value ?? 0);

                if (cantDevolver > 0)
                {
                    hayDevolucion = true;

                    // Verifica que la columna Motivo (índice 6) no esté vacía
                    if (fila.Cells[6].Value == null || string.IsNullOrWhiteSpace(fila.Cells[6].Value.ToString()))
                    {
                        MessageBox.Show("Falta seleccionar el motivo en uno de los productos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Corta la ejecución
                    }
                }
            }

            if (!hayDevolucion)
            {
                MessageBox.Show("Debes ingresar al menos una cantidad a devolver.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BBuscarVenta_Click(object sender, EventArgs e)
        {
            // 1. Validar que ingresaron un número
            if (string.IsNullOrWhiteSpace(TBNroVenta.Text))
            {
                MessageBox.Show("Ingresá un número de venta.");
                return;
            }

            // 2. Cargar datos del cliente y fecha (Ejemplo estático)
            TBCliente.Text = "Juan Pérez";
            TBFecha.Text = "15/09/2026";

            // 3. Limpiar la grilla por si había otra venta cargada antes
            DGDetalleVenta.Rows.Clear();

            // 4. Agregar los productos respetando el orden exacto de tus 7 columnas
            // (Detalle, Cód, Nombre, Precio Unitario, Cant. Comprada, Cant. a Devolver, Motivo)
            DGDetalleVenta.Rows.Add("Ver", "112345", "Collar Rubí", 155760, 2, 0, null);
            DGDetalleVenta.Rows.Add("Ver", "223456", "Aros Luz de Luna", 45000, 1, 0, null);
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormRegistrarDevolucion_Load(object sender, EventArgs e)
        {

        }
    }
}
