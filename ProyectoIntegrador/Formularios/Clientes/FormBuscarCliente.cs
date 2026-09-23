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
    public partial class FormBuscarCliente : Form
    {

        private List<ClienteSimulado> listaTemporalClientes = new List<ClienteSimulado>();
        public FormBuscarCliente()
        {
            InitializeComponent();
        }

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(label1);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 12);
            EstiloUI.AplicarEstiloGrilla(DGClientes);
            EstiloUI.AplicarEstiloTextBox(TBBuscar);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);

            FormClientes.InicializarClientesSiEsNecesario();
            listaTemporalClientes = FormClientes.ListaClientes;

            CargarGrillaClientes();

            CBCondiciónIVA.Items.Clear();
            CBCondiciónIVA.Items.AddRange(new string[] { "Todos", "Consumidor Final", "Monotributo", "Responsable Inscripto", "Exento" });
            CBCondiciónIVA.SelectedIndex = 0;
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

        private void TBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarGrilla();
        }

        private void CBCondiciónIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarGrilla();
        }

        //public int IdCliente { get; private set; }
        public string NombreCompleto { get; private set; }
        public string CondicionIVA { get; private set; }

        private void DGClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGClientes.Rows[e.RowIndex];

                // Ajustá los índices (0, 2, 3, 7) según las columnas reales de tu grilla
                //IdCliente = Convert.ToInt32(fila.Cells[0].Value ?? 0);

                string nombre = fila.Cells[2].Value?.ToString() ?? "";
                string apellido = fila.Cells[3].Value?.ToString() ?? "";
                NombreCompleto = $"{nombre} {apellido}".Trim();

                CondicionIVA = fila.Cells[7].Value?.ToString() ?? "";

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
