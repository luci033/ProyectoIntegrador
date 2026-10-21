using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoIntegrador.Formularios.Clientes.FormClientesABM;

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
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BNuevoCliente);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 12);
            EstiloUI.AplicarEstiloGrilla(DGClientes);
            EstiloUI.AplicarEstiloTextBox(TBBuscar);

            CargarGrillaClientes();

            CBCondiciónIVA.Items.Clear();
            CBCondiciónIVA.Items.AddRange(new string[] { "Todos", "Consumidor Final", "Monotributo", "Responsable Inscripto", "Exento" });
            CBCondiciónIVA.SelectedIndex = 0;
        }

        private void CargarGrillaClientes()
        {
            try
            {
                CN_Cliente negocioCliente = new CN_Cliente();
                DataTable dtClientes = negocioCliente.Listar(); //

                DGClientes.Rows.Clear(); //se limpia la grilla
                int numeroFila = 1;

                foreach (DataRow row in dtClientes.Rows)
                {
                    DGClientes.Rows.Add(
                        row["IdCliente"].ToString(),
                        numeroFila,
                        row["Nombre"].ToString(),
                        row["Apellido"].ToString(),
                        row["DNICUIT"].ToString(),
                        row["Telefono"].ToString(),
                        row["CorreoElectronico"].ToString(),
                        row["CondicionIVA"].ToString(),
                        "Ver..",
                        "Modificar"
                        );
                    numeroFila++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla desde la base de datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrarGrilla()
        {
            string busqueda = TBBuscar.Text.Trim().ToLower();
            string condicion = CBCondiciónIVA.SelectedItem?.ToString() ?? "Todos";

            // Quitamos el foco de la celda actual para evitar errores al ocultar filas
            DGClientes.CurrentCell = null;

            foreach (DataGridViewRow fila in DGClientes.Rows)
            {
                if (fila.IsNewRow) continue;

                string nombre = fila.Cells[2].Value?.ToString().ToLower() ?? "";
                string apellido = fila.Cells[3].Value?.ToString().ToLower() ?? "";
                string dni = fila.Cells[4].Value?.ToString().ToLower() ?? "";
                string iva = fila.Cells[7].Value?.ToString() ?? "";

                bool coincideBusqueda = string.IsNullOrEmpty(busqueda) ||
                                        nombre.Contains(busqueda) ||
                                        apellido.Contains(busqueda) ||
                                        dni.Contains(busqueda);

                bool coincideIva = (condicion == "Todos" || iva == condicion);

                fila.Visible = coincideBusqueda && coincideIva;
            }
        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            FormClientesABM modalCliente = new FormClientesABM();

            if (modalCliente.ShowDialog() == DialogResult.OK)
            {
                CargarGrillaClientes();
            }
        }



        private void dataGridHistorialClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Evitamos que explote al tocar los títulos
            if (e.RowIndex < 0) return;

            // 2. Averiguamos qué columna tocó el usuario
            string nombreColumna = DGClientes.Columns[e.ColumnIndex].Name;

            // --- ACCIÓN: BOTÓN MODIFICAR ---
            if (nombreColumna == "colModificar")
            {
                //Atrapamos el ID oculto de la celda [0] y se lo convierte a entero
                int idClienteSeleccionado = Convert.ToInt32(DGClientes.Rows[e.RowIndex].Cells[0].Value);

                string nombre = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[2].Value);
                string apellido = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[3].Value);
                string dni = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[4].Value);
                string telefono = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[5].Value);
                string correo = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[6].Value);
                string condicionIVA = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[7].Value);

                if (string.IsNullOrWhiteSpace(dni)) return;

                FormClientesABM modalABM = new FormClientesABM();

                // se le pasa el ID y los datos al formulario en modo edición
                modalABM.ConfigurarModoEdicion(idClienteSeleccionado, nombre, apellido, dni, telefono, correo, condicionIVA);

                if (modalABM.ShowDialog() == DialogResult.OK)
                {
                    CargarGrillaClientes(); 
                }

            }

            // --- ACCIÓN: boton historial ---
            else if (nombreColumna == "colHistorial")
            {
                // 1. Atrapamos todos los datos de la fila seleccionada
                string nombre = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[2].Value);
                string apellido = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[3].Value);
                string dni = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[4].Value);
                string telefono = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[5].Value);
                string correo = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[6].Value);
                string condicionIVA = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[7].Value); 

                // Escudo: Verificamos que no sea una fila vacía
                if (!string.IsNullOrWhiteSpace(dni))
                {
                    // 2. Instanciamos tu formulario de detalle
                    DetalleClientes formDetalle = new DetalleClientes();
                    formDetalle.Text = "Historial de Compras - DNI: " + dni;

                    // 3. Unimos el nombre y apellido para que se vea más completo en la caja de texto
                    string nombreCompleto = nombre + " " + apellido;


                    formDetalle.CargarDatosCliente(nombre, correo, condicionIVA, dni);

                    // 5. Mostramos la pantalla
                    formDetalle.ShowDialog();
                }
            }
            // --- ACCIÓN: boton desactivar DONDE ESTA ESTE BOTOON?---
            else if (nombreColumna == "colDesactivar")
            {
                string dniParaDesactivar = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[4].Value);
                if (!string.IsNullOrWhiteSpace(dniParaDesactivar))
                {
                    DialogResult respuesta = MessageBox.Show($"¿Seguro que deseas desactivar al cliente con DNI {dniParaDesactivar}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
        }

        private void DGClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitamos errores si hacen doble clic en los títulos
            if (e.RowIndex < 0) return;

            // Evitamos que se abra el detalle si hacen doble clic justo sobre un botón
            string nombreColumna = DGClientes.Columns[e.ColumnIndex].Name;
            if (nombreColumna == "colModificar" || nombreColumna == "colHistorial" || nombreColumna == "colDesactivar") return;

            string dni = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[4].Value);

            // Si la fila está vacía, no hacemos nada
            if (string.IsNullOrWhiteSpace(dni)) return;

            string nombre = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[2].Value);
            string apellido = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[3].Value);
            string telefono = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[5].Value);
            string correo = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[6].Value);
            string condicionIVA = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[7].Value);

            FormClientesABM modalDetalle = new FormClientesABM();
            modalDetalle.ConfigurarModoDetalle(nombre, apellido, dni, telefono, correo, condicionIVA);
            modalDetalle.ShowDialog();
        }

        private void TBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarGrilla();
        }

        private void CBCondiciónIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarGrilla();
        }
    }
}
