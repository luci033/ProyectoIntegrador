using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

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
                    // 1. Recorrer las filas actuales para validar el CUIT (Índice 2)
                    foreach (DataGridViewRow fila in DGProveedores.Rows)
                    {
                        if (fila.Cells[2].Value != null && fila.Cells[2].Value.ToString() == formABM.CUIT)
                        {
                            MessageBox.Show("Ese CUIT ya se encuentra registrado.", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Corta la ejecución acá para no agregarlo
                        }
                    }

                    // 2. Se agrega un string vacío "" para la columna idProveedor (Índice 0)
                    int indice = DGProveedores.Rows.Add(
                        "",                  // [0] idProveedor
                        formABM.RazonSocial, // [1] Razón Social
                        formABM.CUIT,        // [2] CUIT
                        formABM.Telefono,    // [3] Teléfono
                        formABM.Correo,      // [4] Correo
                        "Editar",            // [5] Modificar
                        "Desactivar"         // [6] Desactivar
                    );

                    // 3. Aplicar colores a los botones recién creados (Índices 5 y 6)
                    DGProveedores.Rows[indice].Cells[5].Style.BackColor = Color.LightGoldenrodYellow;
                    DGProveedores.Rows[indice].Cells[6].Style.BackColor = Color.LightCoral;
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

            // --- BOTÓN MODIFICAR (Índice 5) ---
            if (e.ColumnIndex == 5)
            {
                // Bloqueo: verificamos la columna Desactivar (Índice 6)
                if (fila.Cells[6].Value?.ToString() == "Activar")
                {
                    MessageBox.Show("No se puede modificar un proveedor desactivado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (FormProveedorABM formABM = new FormProveedorABM())
                {
                    // Mandamos los datos con los índices actualizados +1
                    formABM.ConfigurarModoEdicion(
                        fila.Cells[1].Value?.ToString(), // Razón Social
                        fila.Cells[2].Value?.ToString(), // CUIT
                        fila.Cells[3].Value?.ToString(), // Teléfono
                        fila.Cells[4].Value?.ToString()  // Correo
                    );

                    if (formABM.ShowDialog() == DialogResult.OK)
                    {
                        // Actualizamos las celdas con los índices correctos
                        fila.Cells[3].Value = formABM.Telefono;
                        fila.Cells[4].Value = formABM.Correo;
                    }
                }
            }
            // --- BOTÓN DESACTIVAR (Índice 6) ---
            else if (e.ColumnIndex == 6)
            {
                DataGridViewCell celdaDesactivar = fila.Cells[6];
                DataGridViewCell celdaModificar = fila.Cells[5];
                string accion = celdaDesactivar.Value?.ToString() ?? "Desactivar";

                var confirmacion = MessageBox.Show($"¿Estás seguro de que querés {accion.ToLower()} este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    if (accion == "Desactivar")
                    {
                        celdaDesactivar.Value = "Activar";
                        celdaDesactivar.Style.BackColor = Color.LightGreen;
                        celdaDesactivar.Style.ForeColor = Color.Black;
                        celdaModificar.Style.BackColor = Color.LightGray;

                        fila.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                        fila.DefaultCellStyle.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        celdaDesactivar.Value = "Desactivar";
                        celdaDesactivar.Style.BackColor = Color.LightCoral;
                        celdaModificar.Style.BackColor = Color.LightGoldenrodYellow;

                        fila.DefaultCellStyle.BackColor = Color.White;
                        fila.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloGrilla(DGProveedores);
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BAgregarProveedor);

            // Hardcodeo de 5 proveedores coincidiendo con las 7 columnas
            DGProveedores.Rows.Add("1", "Joyas del Norte", "30111111111", "3794111111", "ventas@joyasdelnorte.com", "Editar", "Desactivar");
            DGProveedores.Rows.Add("2", "Distribuidora Oro S.A.", "30222222222", "3794222222", "contacto@orosa.com", "Editar", "Desactivar");
            DGProveedores.Rows.Add("3", "Gemas y Piedras", "30333333333", "3794333333", "info@gemas.com", "Editar", "Desactivar");
            DGProveedores.Rows.Add("4", "Importadora Rubi", "30444444444", "3794444444", "importaciones@rubi.com", "Editar", "Desactivar");
            DGProveedores.Rows.Add("5", "Platería Central", "30555555555", "3794555555", "central@plateria.com", "Editar", "Desactivar");

            // Pintar los botones de las filas agregadas
            foreach (DataGridViewRow fila in DGProveedores.Rows)
            {
                if (!fila.IsNewRow)
                {
                    fila.Cells[5].Style.BackColor = Color.LightGoldenrodYellow;
                    fila.Cells[6].Style.BackColor = Color.LightCoral;
                }
            }
        }
    }
}