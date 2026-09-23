using ProyectoIntegrador.Formularios.Clientes;
using ProyectoIntegrador.Formularios.Productos;
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

namespace ProyectoIntegrador.Formularios.Ventas
{
    public partial class FormRegistroVentas : Form
    {
        public string NroVenta => TBNroVenta.Text;
        public string FechaVenta => TBFecha.Text;
        public string ClienteVenta => TBCliente.Text;
        public string TotalVenta => TBTotal.Text;
        public DataGridViewRowCollection ProductosVendidos => dataGridProducto.Rows; // Para leer las cantidades y descontar stock
        public string MetodoPago { get; private set; }
        public string CondicionIVAVenta => TBCondicionIVA.Text;

        private string usuarioLogueado;

        public FormRegistroVentas(string nombreUsuario)
        {
            InitializeComponent();

            usuarioLogueado = nombreUsuario;

            // Asignamos el usuario a la caja de texto correspondiente
            TBVendedor.Text = usuarioLogueado;
            TBVendedor.ReadOnly = true;
        }

        // Constructor vacío para que el método genérico no rompa
        public FormRegistroVentas() : this("Operador Venta")
        {
        }

        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel3, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 12);
            EstiloUI.AplicarEstiloBoton(BAgregarProducto);
            EstiloUI.AplicarEstiloBoton(BBuscarCliente);
            EstiloUI.AplicarEstiloBoton(BNuevoCliente);
            EstiloUI.AplicarEstiloBoton(BCobrar);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);
            EstiloUI.AplicarEstiloTextBox(TBNroVenta);
            EstiloUI.AplicarEstiloTextBox(TBVendedor);
            EstiloUI.AplicarEstiloTextBox(TBFecha);
            EstiloUI.AplicarEstiloTextBox(TBCliente);
            EstiloUI.AplicarEstiloTextBox(TBCondicionIVA);
            EstiloUI.AplicarEstiloTextBox(TBTotal);
            EstiloUI.AplicarEstiloGrilla(dataGridProducto);

            TBNroVenta.Text = (FormVentas.HistorialVentas.Count + 1).ToString("D5");

            TBVendedor.Text = "Vendedor Prueba";
            TBFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");



            // Configuración de edición
            dataGridProducto.ReadOnly = false;
            foreach (DataGridViewColumn col in dataGridProducto.Columns)
            {
                col.ReadOnly = true;
            }
            dataGridProducto.Columns[5].ReadOnly = false; // Desbloquea columna Cantidad

            // Vincular eventos de validación
            dataGridProducto.CellValidating += new DataGridViewCellValidatingEventHandler(dataGridProducto_CellValidating);
            dataGridProducto.CellValueChanged += new DataGridViewCellEventHandler(dataGridProducto_CellValueChanged);
            dataGridProducto.DataError += new DataGridViewDataErrorEventHandler(dataGridProducto_DataError);
        }

        private void dataGridProducto_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 5) // Columna Cantidad
            {
                string valor = e.FormattedValue.ToString();
                if (string.IsNullOrWhiteSpace(valor)) return;

                // Recuperamos el stock que escondimos en el Tag
                int stockDisponible = Convert.ToInt32(dataGridProducto.Rows[e.RowIndex].Tag ?? 0);

                if (!int.TryParse(valor, out int cantidad) || cantidad <= 0 || cantidad > stockDisponible)
                {
                    MessageBox.Show($"La cantidad debe ser mayor a cero y no superar el stock disponible ({stockDisponible}).", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridProducto.CancelEdit(); // Deshace el cambio sin trabar la pantalla
                }
            }
        }

        private void dataGridProducto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Si cambia la cantidad, actualizamos el subtotal automáticamente
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                DataGridViewRow fila = dataGridProducto.Rows[e.RowIndex];
                decimal precioUnitario = Convert.ToDecimal(fila.Cells[4].Value ?? 0);
                int cantidad = Convert.ToInt32(fila.Cells[5].Value ?? 0);

                fila.Cells[7].Value = precioUnitario * cantidad; // Actualiza el Sub Total
                ActualizarTotalGeneral();
            }
        }

        private void dataGridProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el clic sea en una fila válida y en la columna "Eliminar"
            if (e.RowIndex >= 0 && (dataGridProducto.Columns[e.ColumnIndex].Name == "colEliminar" || e.ColumnIndex == 6))
            {
                dataGridProducto.Rows.RemoveAt(e.RowIndex);
                ActualizarTotalGeneral(); // Recalcula el total de la venta
            }
        }

        private void dataGridProducto_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false; // Evita cierres abruptos por formato
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BCobrar_Click(object sender, EventArgs e)
        {
            // Validar que haya cliente y productos
            if (string.IsNullOrWhiteSpace(TBCliente.Text) || dataGridProducto.Rows.Count == 0)
            {
                MessageBox.Show("Faltan datos del cliente o agregar productos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormCobro formCobro = new FormCobro(TBCliente.Text, TBTotal.Text))
            {
                DialogResult resultado = formCobro.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.MetodoPago = formCobro.MetodoPagoSeleccionado; // Captura el método de pago
                    MessageBox.Show("Venta registrada con éxito. acá se actualiza el stock", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (resultado == DialogResult.Abort)
                {
                    // Se presionó Cancelar en el formulario de cobro
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                // Si el resultado es Cancel (Botón Volver), no hace nada y vuelve a la grilla
            }
        }



        private void ActualizarTotalGeneral()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dataGridProducto.Rows)
            {
                if (fila.Cells[7].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells[7].Value);
                }
            }

            // Muestra el total con formato de moneda (ej: $ 1.500,00)
            TBTotal.Text = total.ToString("C2");
        }

        private void AgregarOActualizarProducto(int idProducto, string nombreJoya, decimal precioUnitario, int cantidadAAgregar)
        {

        }

        private void BAgregarProducto_Click(object sender, EventArgs e)
        {
            
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de que querés cancelar la venta actual?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            using (FormBuscarCliente formBuscar = new FormBuscarCliente())
            {
                if (formBuscar.ShowDialog() == DialogResult.OK)
                {
                    // int idClienteBD = formBuscar.IdCliente; // Reservado para la BD
                    TBCliente.Text = formBuscar.NombreCompleto;
                    TBCondicionIVA.Text = formBuscar.CondicionIVA;
                }
            }
        }

        private void BAgregarProducto_Click_1(object sender, EventArgs e)
        {
            using (FormBuscarProducto formProducto = new FormBuscarProducto())
            {
                formProducto.ConfigurarParaVentas();

                if (formProducto.ShowDialog() == DialogResult.OK)
                {
                    // 1. Verificamos si el producto ya existe en la grilla buscando por su Código
                    foreach (DataGridViewRow fila in dataGridProducto.Rows)
                    {
                        if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == formProducto.Codigo)
                        {
                            int cantidadActual = Convert.ToInt32(fila.Cells[5].Value ?? 0);

                            // Validamos si hay stock suficiente para sumar 1 más
                            if (cantidadActual + 1 > formProducto.Stock)
                            {
                                MessageBox.Show($"No hay suficiente stock. Stock disponible: {formProducto.Stock}", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Sumamos 1 a la cantidad (esto dispara CellValueChanged y actualiza el subtotal solo)
                            fila.Cells[5].Value = cantidadActual + 1;
                            return; // Salimos para no agregar una fila nueva
                        }
                    }

                    // 2. Si el producto no estaba en la grilla, lo agregamos como fila nueva
                    int indiceFila = dataGridProducto.Rows.Add(
                        formProducto.Codigo,
                        formProducto.Nombre,
                        formProducto.Categoria,
                        formProducto.Genero,
                        formProducto.PrecioVenta,
                        1,
                        "Eliminar",
                        formProducto.PrecioVenta
                    );

                    dataGridProducto.Rows[indiceFila].Tag = formProducto.Stock;
                    ActualizarTotalGeneral();
                }
            }
        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            FormClientes.InicializarClientesSiEsNecesario();

            using (FormClientesABM modalCliente = new FormClientesABM())
            {
                // Pasamos la lista de DNIs ya registrados en el sistema
                modalCliente.DnisExistentes = FormClientes.ListaClientes.Select(c => c.DNI).ToList();

                if (modalCliente.ShowDialog() == DialogResult.OK && modalCliente.ClienteCreado != null)
                {
                    // Validación preventiva de unicidad de DNI
                    string dniNuevo = modalCliente.ClienteCreado.DNI?.Trim();
                    if (!string.IsNullOrEmpty(dniNuevo) && FormClientes.ListaClientes.Any(c => c.DNI != null && c.DNI.Trim() == dniNuevo))
                    {
                        MessageBox.Show("Ese DNI ya se encuentra registrado en el sistema.", "DNI Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Se agrega a los datos estáticos compartidos de clientes
                    FormClientes.ListaClientes.Add(modalCliente.ClienteCreado);

                    // Se cargan automáticamente los datos en los TextBox correspondientes
                    string nombreCompleto = $"{modalCliente.ClienteCreado.Nombre} {modalCliente.ClienteCreado.Apellido}".Trim();
                    TBCliente.Text = nombreCompleto;
                    TBCondicionIVA.Text = modalCliente.ClienteCreado.CondicionIVA;
                }
            }
        }
    }
}

    
    

