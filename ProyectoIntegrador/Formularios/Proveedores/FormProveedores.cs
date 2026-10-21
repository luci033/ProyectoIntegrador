using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoIntegrador.Formularios.Proveedores
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BAgregarProveedor);
            EstiloUI.AplicarEstiloGrilla(DGProveedores);

            CargarProveedores();
        }

        private void CargarProveedores()
        {
            DGProveedores.Rows.Clear();
            try
            {
                List<Proveedor> lista = new CN_Proveedor().ListarProveedores();
                foreach (var prov in lista)
                {
                    int indice = DGProveedores.Rows.Add(
                        prov.IdProveedor,
                        prov.RazonSocial,
                        prov.CUIT,
                        prov.Telefono,
                        prov.CorreoElectronico,
                        "Editar",
                        "Desactivar"
                    );

                    DGProveedores.Rows[indice].Cells[5].Style.BackColor = Color.LightGoldenrodYellow;
                    DGProveedores.Rows[indice].Cells[6].Style.BackColor = Color.LightCoral;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BAgregarProveedor_Click(object sender, EventArgs e)
        {
            using (FormProveedorABM formABM = new FormProveedorABM())
            {
                if (formABM.ShowDialog() == DialogResult.OK)
                {
                    CargarProveedores();
                }
            }
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
                    int idProveedor = Convert.ToInt32(fila.Cells[0].Value ?? 0);

                    formABM.ConfigurarModoEdicion(
                        idProveedor,
                        fila.Cells[1].Value?.ToString(), // Razón Social
                        fila.Cells[2].Value?.ToString(), // CUIT
                        fila.Cells[3].Value?.ToString(), // Teléfono
                        fila.Cells[4].Value?.ToString()  // Correo
                    );

                    if (formABM.ShowDialog() == DialogResult.OK)
                    {
                        CargarProveedores();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LProveedores_Click(object sender, EventArgs e)
        {

        }
    }
}
