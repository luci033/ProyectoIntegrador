using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoIntegrador.Formularios.Proveedores
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BAgregarProveedor_Click(object sender, EventArgs e)
        {
            using (FormProveedorABM formABM = new FormProveedorABM())
            {
                if (formABM.ShowDialog() == DialogResult.OK)
                {
                    // 1. Recorrer las filas actuales para validar el CUIT (Índice 1)
                    foreach (DataGridViewRow fila in DGProveedores.Rows)
                    {
                        if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == formABM.CUIT)
                        {
                            MessageBox.Show("Ese CUIT ya se encuentra registrado.", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Corta la ejecución acá para no agregarlo
                        }
                    }

                    // Se guarda el índice de la nueva fila agregada
                    int indice = DGProveedores.Rows.Add(
                        formABM.RazonSocial,
                        formABM.CUIT,
                        formABM.Telefono,
                        formABM.Correo,
                        "Editar",
                        "Desactivar"
                    );

                    // Aplicar colores a los botones recién creados
                    DGProveedores.Rows[indice].Cells[4].Style.BackColor = Color.LightGoldenrodYellow; // Amarillo suave
                    DGProveedores.Rows[indice].Cells[5].Style.BackColor = Color.LightCoral; // Rojo suave
                }
            }
        }

        private void LProveedores_Click(object sender, EventArgs e)
        {

        }

        private void DGProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = DGProveedores.Rows[e.RowIndex];

            // --- BOTÓN MODIFICAR (Índice 4) ---
            if (e.ColumnIndex == 4)
            {
                // Bloqueo: si el botón de al lado dice "Activar", es porque está desactivado
                if (fila.Cells[5].Value?.ToString() == "Activar")
                {
                    MessageBox.Show("No se puede modificar un proveedor desactivado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (FormProveedorABM formABM = new FormProveedorABM())
                {
                    formABM.ConfigurarModoEdicion(
                        fila.Cells[0].Value?.ToString(),
                        fila.Cells[1].Value?.ToString(),
                        fila.Cells[2].Value?.ToString(),
                        fila.Cells[3].Value?.ToString()
                    );

                    if (formABM.ShowDialog() == DialogResult.OK)
                    {
                        fila.Cells[2].Value = formABM.Telefono;
                        fila.Cells[3].Value = formABM.Correo;
                    }
                }
            }
            // --- BOTÓN DESACTIVAR (Índice 5) ---
            else if (e.ColumnIndex == 5)
            {
                DataGridViewCell celdaDesactivar = fila.Cells[5];
                DataGridViewCell celdaModificar = fila.Cells[4];
                string accion = celdaDesactivar.Value?.ToString() ?? "Desactivar";

                var confirmacion = MessageBox.Show($"¿Estás seguro de que querés {accion.ToLower()} este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    if (accion == "Desactivar")
                    {
                        celdaDesactivar.Value = "Activar";
                        celdaDesactivar.Style.BackColor = Color.LightGreen; // Verde al desactivarse
                        celdaDesactivar.Style.ForeColor = Color.Black;
                        celdaModificar.Style.BackColor = Color.LightGray; // Gris (inhabilitado)

                        fila.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        fila.DefaultCellStyle.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        celdaDesactivar.Value = "Desactivar";
                        celdaDesactivar.Style.BackColor = Color.LightCoral; // Vuelve a rojo suave
                        celdaModificar.Style.BackColor = Color.LightGoldenrodYellow; // Vuelve a amarillo

                        fila.DefaultCellStyle.BackColor = Color.White;
                        fila.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
