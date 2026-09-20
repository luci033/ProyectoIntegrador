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
        private List<ClienteSimulado> listaTemporalClientes = new List<ClienteSimulado>();

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloGrilla(DGClientes);
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BNuevoCliente);

            // 1. Hardcodeo de 6 clientes
            listaTemporalClientes.Add(new ClienteSimulado { Nombre = "Juan", Apellido = "Pérez", DNI = "11222333", Telefono = "3794111111", Correo = "juan@mail.com", CondicionIVA = "Consumidor Final" });
            listaTemporalClientes.Add(new ClienteSimulado { Nombre = "María", Apellido = "Gómez", DNI = "22333444", Telefono = "3794222222", Correo = "maria@mail.com", CondicionIVA = "Monotributo" });
            listaTemporalClientes.Add(new ClienteSimulado { Nombre = "Carlos", Apellido = "López", DNI = "33444555", Telefono = "3794333333", Correo = "carlos@mail.com", CondicionIVA = "Responsable Inscripto" });
            listaTemporalClientes.Add(new ClienteSimulado { Nombre = "Ana", Apellido = "Díaz", DNI = "44555666", Telefono = "3794444444", Correo = "ana@mail.com", CondicionIVA = "Consumidor Final" });
            listaTemporalClientes.Add(new ClienteSimulado { Nombre = "Luis", Apellido = "Martínez", DNI = "55666777", Telefono = "3794555555", Correo = "luis@mail.com", CondicionIVA = "Exento" });
            listaTemporalClientes.Add(new ClienteSimulado { Nombre = "Laura", Apellido = "Romero", DNI = "66777888", Telefono = "3794666666", Correo = "laura@mail.com", CondicionIVA = "Monotributo" });

            CargarGrillaClientes();
        }

        private void CargarGrillaClientes()
        {
            DGClientes.Rows.Clear(); // Limpiamos para no duplicar datos
            int numeroFila = 1;

            foreach (var cliente in listaTemporalClientes)
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

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario y le ponemos de nombre modalCliente
            FormClientesABM modalCliente = new FormClientesABM();

            // Si el ABM se cerró correctamente con el botón Registrar...
            if (modalCliente.ShowDialog() == DialogResult.OK)
            {
                // Atrapamos el paquete y lo guardamos en la lista
                listaTemporalClientes.Add(modalCliente.ClienteCreado);

                // Mandamos a dibujar la tabla
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

                // Le enviamos la lista de DNIs actuales extraídos de la lista temporal
                modalABM.DnisExistentes = listaTemporalClientes.Select(c => c.DNI).ToList();

                modalABM.ConfigurarModoEdicion(nombre, apellido, dni, telefono, correo, condicionIVA);

                    if (modalABM.ShowDialog() == DialogResult.OK)
                {
                    // Actualizamos la fila directamente
                    DGClientes.Rows[e.RowIndex].Cells[2].Value = modalABM.ClienteCreado.Nombre;
                    DGClientes.Rows[e.RowIndex].Cells[3].Value = modalABM.ClienteCreado.Apellido;
                    DGClientes.Rows[e.RowIndex].Cells[5].Value = modalABM.ClienteCreado.Telefono;
                    DGClientes.Rows[e.RowIndex].Cells[6].Value = modalABM.ClienteCreado.Correo;
                    DGClientes.Rows[e.RowIndex].Cells[7].Value = modalABM.ClienteCreado.CondicionIVA;

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
    }
}
