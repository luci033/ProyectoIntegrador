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
        public static List<ClienteSimulado> ListaClientes = new List<ClienteSimulado>();

        static FormClientes()
        {
            InicializarClientesSiEsNecesario();
        }

        public static void InicializarClientesSiEsNecesario()
        {
            if (ListaClientes.Count == 0)
            {
                ListaClientes.Add(new ClienteSimulado { Nombre = "Juan", Apellido = "Pérez", DNI = "11222333", Telefono = "3794111111", Correo = "juan@mail.com", CondicionIVA = "Consumidor Final" });
                ListaClientes.Add(new ClienteSimulado { Nombre = "María", Apellido = "Gómez", DNI = "22333444", Telefono = "3794222222", Correo = "maria@mail.com", CondicionIVA = "Monotributo" });
                ListaClientes.Add(new ClienteSimulado { Nombre = "Carlos", Apellido = "López", DNI = "33444555", Telefono = "3794333333", Correo = "carlos@mail.com", CondicionIVA = "Responsable Inscripto" });
                ListaClientes.Add(new ClienteSimulado { Nombre = "Ana", Apellido = "Díaz", DNI = "44555666", Telefono = "3794444444", Correo = "ana@mail.com", CondicionIVA = "Consumidor Final" });
                ListaClientes.Add(new ClienteSimulado { Nombre = "Luis", Apellido = "Martínez", DNI = "55666777", Telefono = "3794555555", Correo = "luis@mail.com", CondicionIVA = "Exento" });
                ListaClientes.Add(new ClienteSimulado { Nombre = "Laura", Apellido = "Romero", DNI = "66777888", Telefono = "3794666666", Correo = "laura@mail.com", CondicionIVA = "Monotributo" });
            }
        }

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

            InicializarClientesSiEsNecesario();

            CargarGrillaClientes();

            CBCondiciónIVA.Items.Clear();
            CBCondiciónIVA.Items.AddRange(new string[] { "Todos", "Consumidor Final", "Monotributo", "Responsable Inscripto", "Exento" });
            CBCondiciónIVA.SelectedIndex = 0;
        }

        private void CargarGrillaClientes()
        {
            DGClientes.Rows.Clear(); // Limpiamos para no duplicar datos
            int numeroFila = 1;

            foreach (var cliente in ListaClientes)
            {
                DGClientes.Rows.Add(
                    "",                   // [0] ID Oculto 
                    numeroFila,           // [1] Nro
                    cliente.Nombre,       // [2] Nombre
                    cliente.Apellido,     // [3] Apellido
                    cliente.DNI,          // [4] DNI
                    cliente.Telefono,       // [5] Telefono
                    cliente.Correo,         // [6] Correo
                    cliente.CondicionIVA,       // [7] Condición IVA
                    "Ver..",                 // [8] Botón Historial
                    "Modificar"             // [9] Botón Modificar
                );
                numeroFila++;
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

            // Pasamos la lista de DNIs registrados al formulario nuevo
            modalCliente.DnisExistentes = ListaClientes.Select(c => c.DNI).ToList();

            if (modalCliente.ShowDialog() == DialogResult.OK)
            {
                ListaClientes.Add(modalCliente.ClienteCreado);
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
                string nombre = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[2].Value);
                string apellido = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[3].Value);
                string dni = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[4].Value);
                string telefono = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[5].Value);
                string correo = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[6].Value);
                string condicionIVA = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[7].Value);

                if (string.IsNullOrWhiteSpace(dni)) return;

                FormClientesABM modalABM = new FormClientesABM();

                // Le enviamos la lista de DNIs actuales extraídos de la lista estática
                modalABM.DnisExistentes = ListaClientes.Select(c => c.DNI).ToList();

                modalABM.ConfigurarModoEdicion(nombre, apellido, dni, telefono, correo, condicionIVA);

                if (modalABM.ShowDialog() == DialogResult.OK)
                {
                    // Actualizamos la fila directamente
                    DGClientes.Rows[e.RowIndex].Cells[2].Value = modalABM.ClienteCreado.Nombre;
                    DGClientes.Rows[e.RowIndex].Cells[3].Value = modalABM.ClienteCreado.Apellido;
                    DGClientes.Rows[e.RowIndex].Cells[5].Value = modalABM.ClienteCreado.Telefono;
                    DGClientes.Rows[e.RowIndex].Cells[6].Value = modalABM.ClienteCreado.Correo;
                    DGClientes.Rows[e.RowIndex].Cells[7].Value = modalABM.ClienteCreado.CondicionIVA;

                    // Actualizamos en la lista estática
                    var clienteExistente = ListaClientes.FirstOrDefault(c => c.DNI == dni);
                    if (clienteExistente != null)
                    {
                        clienteExistente.Nombre = modalABM.ClienteCreado.Nombre;
                        clienteExistente.Apellido = modalABM.ClienteCreado.Apellido;
                        clienteExistente.DNI = modalABM.ClienteCreado.DNI;
                        clienteExistente.Telefono = modalABM.ClienteCreado.Telefono;
                        clienteExistente.Correo = modalABM.ClienteCreado.Correo;
                        clienteExistente.CondicionIVA = modalABM.ClienteCreado.CondicionIVA;
                    }

                    MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // --- ACCIÓN: boton historial ---
            else if (nombreColumna == "colHistorial")
            {
                // 1. Atrapamos todos los datos de la fila seleccionada
                string nombre = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[2].Value);
                string apellido = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[3].Value);
                string dni = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[4].Value);
                string correo = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[5].Value);

                // Escudo: Verificamos que no sea una fila vacía
                if (!string.IsNullOrWhiteSpace(dni))
                {
                    // 2. Instanciamos tu formulario de detalle
                    DetalleClientes formDetalle = new DetalleClientes();
                    formDetalle.Text = "Historial de Compras - DNI: " + dni;

                    // 3. Unimos el nombre y apellido para que se vea más completo en la caja de texto
                    string nombreCompleto = nombre + " " + apellido;


                    formDetalle.CargarDatosCliente(nombreCompleto, correo, "Consumidor Final", dni);

                    // 5. Mostramos la pantalla
                    formDetalle.ShowDialog();
                }

                // --- ACCIÓN: boton desactivar ---
                else if (nombreColumna == "colDesactivar")
                {
                    string dniParaDesactivar = Convert.ToString(DGClientes.Rows[e.RowIndex].Cells[4].Value);
                    if (!string.IsNullOrWhiteSpace(dniParaDesactivar))
                    {
                        DialogResult respuesta = MessageBox.Show($"¿Seguro que deseas desactivar al cliente con DNI {dniParaDesactivar}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
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
