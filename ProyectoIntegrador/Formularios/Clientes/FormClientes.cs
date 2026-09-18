using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Clientes
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            // instanciamos el formulario de ABM
            FormClientesABM formNuevoCliente = new FormClientesABM();

            // se de forma modal (bloquea el fondo hasta que se termine de registrar o cancelar)
            formNuevoCliente.ShowDialog();
        }

        private void dataGridHistorialClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Evitamos que explote al tocar los títulos
            if (e.RowIndex < 0) return;

            // 2. Averiguamos qué columna tocó el usuario
            string nombreColumna = dataGridHistorialClientes.Columns[e.ColumnIndex].Name;

            // --- ACCIÓN: BOTÓN MODIFICAR ---
            if (nombreColumna == "colModificar")
            {
                // LA SOLUCIÓN: Usamos Convert.ToString() para que no explote si la celda es nula
                string nombre = Convert.ToString(dataGridHistorialClientes.Rows[e.RowIndex].Cells[2].Value);
                string apellido = Convert.ToString(dataGridHistorialClientes.Rows[e.RowIndex].Cells[3].Value);
                string dni = Convert.ToString(dataGridHistorialClientes.Rows[e.RowIndex].Cells[4].Value);
                string correo = Convert.ToString(dataGridHistorialClientes.Rows[e.RowIndex].Cells[5].Value);

                // Escudo: Si el DNI está vacío, es porque hicieron clic en una fila en blanco
                if (string.IsNullOrWhiteSpace(dni))
                {
                    MessageBox.Show("No puedes modificar una fila que está vacía.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Cortamos acá, no abrimos el ABM
                }

                // Si pasamos el escudo, abrimos la ventana normal
                FormClientesABM modalABM = new FormClientesABM();
                modalABM.ConfigurarModoEdicion(nombre, apellido, dni, correo);

                if (modalABM.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // --- ACCIÓN: BOTÓN HISTORIAL ---
            else if (nombreColumna == "colHistorial")
            {
                string dniParaHistorial = Convert.ToString(dataGridHistorialClientes.Rows[e.RowIndex].Cells[4].Value);
                if (!string.IsNullOrWhiteSpace(dniParaHistorial))
                {
                    MessageBox.Show($"Abriendo el historial del DNI: {dniParaHistorial}");
                }
            }

            // --- ACCIÓN: BOTÓN DESACTIVAR ---
            else if (nombreColumna == "colDesactivar")
            {
                string dniParaDesactivar = Convert.ToString(dataGridHistorialClientes.Rows[e.RowIndex].Cells[4].Value);
                if (!string.IsNullOrWhiteSpace(dniParaDesactivar))
                {
                    DialogResult respuesta = MessageBox.Show($"¿Seguro que deseas desactivar al cliente con DNI {dniParaDesactivar}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
