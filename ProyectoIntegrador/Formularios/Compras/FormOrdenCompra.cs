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

namespace ProyectoIntegrador.Formularios.Compras
{
    public partial class FormOrdenCompra : Form
    {
        private string usuarioLogueado;
        public FormOrdenCompra(string nombreUsuario)
        {
            InitializeComponent();

            usuarioLogueado = nombreUsuario;

            TBUsuario.Text = usuarioLogueado;
            TBUsuario.ReadOnly = true; // Opcional: para que no lo puedan modificar a mano
        }

        private void FormOrdenCompra_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloCard(panelCard, 16);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 10);
            EstiloUI.AplicarEstiloBoton(BSeleccionarProveedor);
            EstiloUI.AplicarEstiloBoton(BAgregarProducto);
            EstiloUI.AplicarEstiloBoton(BGenerarOrden);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);
            EstiloUI.AplicarEstiloGrilla(DGDetalleOrden);
            EstiloUI.CentrarControl(panelCard, this);


            // cargo fecha del sistema
            TBFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            DGDetalleOrden.ReadOnly = false;
            // Bloqueamos todas las columnas por defecto para que no se puedan escribir datos fijos
            foreach (DataGridViewColumn col in DGDetalleOrden.Columns)
            {
                col.ReadOnly = true;
            }

            // Desbloqueamos únicamente la Cantidad (columna 5) y el Costo Unitario (columna 6) para que puedas editarlos libremente
            DGDetalleOrden.Columns[5].ReadOnly = false;
            DGDetalleOrden.Columns[6].ReadOnly = false;

            DGDetalleOrden.DataError += new DataGridViewDataErrorEventHandler(DGDetalleOrden_DataError);
        }

        private void FormOrdenCompra_Resize(object sender, EventArgs e)
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            // Asumiendo que tenés un formulario llamado FormBuscarProveedor
            using (FormBuscarProveedor formBuscar = new FormBuscarProveedor())
            {
                if (formBuscar.ShowDialog() == DialogResult.OK)
                {
                    TBRazonSocial.Text = formBuscar.RazonSocial;
                    TBCUIT.Text = formBuscar.CUIT;
                    TBContacto.Text = formBuscar.Telefono; // Puede ser el teléfono o correo
                    TBCorreo.Text = formBuscar.Correo;
                }
            }
        }

        private void BAgregarProducto_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TBRazonSocial.Text))
            {
                MessageBox.Show("Primero debés seleccionar un proveedor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (FormBuscarProducto formProducto = new FormBuscarProducto())
            {
                if (formProducto.ShowDialog() == DialogResult.OK)
                {
                    // 1. Verificamos si el producto ya fue agregado a la grilla (buscando por su IdProducto en la columna 0)
                    foreach (DataGridViewRow filaExistente in DGDetalleOrden.Rows)
                    {
                        if (filaExistente.Cells[0].Value != null && Convert.ToInt32(filaExistente.Cells[0].Value) == formProducto.IdProducto)
                        {
                            // Si ya existe, sumamos 1 a la cantidad actual (columna 5)
                            decimal cantidadActual = Convert.ToDecimal(filaExistente.Cells[5].Value ?? 0);
                            filaExistente.Cells[5].Value = cantidadActual + 1;

                            // Al cambiar la celda, el sistema recalculará el subtotal y el total solo
                            return; // Salimos para no agregar una fila nueva
                        }
                    }

                    // 2. Si no existe, lo agregamos normalmente por primera vez
                    int cantidad = 1;
                    decimal CostoCompra = 0;
                    decimal subtotal = CostoCompra * cantidad;

                    DGDetalleOrden.Rows.Add(
                        formProducto.IdProducto,
                        formProducto.Codigo,
                        formProducto.Nombre,
                        formProducto.Categoria,
                        formProducto.Genero,
                        cantidad,
                        CostoCompra,
                        subtotal
                    );

                    CalcularTotal();
                }
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in DGDetalleOrden.Rows)
            {
                // El subtotal corresponde a la columna índice 7
                if (fila.Cells[7].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells[7].Value);
                }
            }

            TBTotal.Text = total.ToString("N2");
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Propiedades para enviar al formulario principal
        public string Proveedor => TBRazonSocial.Text;
        public string Fecha => TBFecha.Text;
        public string Total => TBTotal.Text;

        public List<object[]> DetallesProductos { get; private set; } = new List<object[]>();

        private void BGenerarOrden_Click(object sender, EventArgs e)
        {
            // Validación de Total > 0
            decimal totalOrden = 0;
            decimal.TryParse(TBTotal.Text.Replace("$", "").Replace("€", "").Trim(), out totalOrden);

            if (totalOrden <= 0)
            {
                MessageBox.Show("El total de la orden debe ser mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Proveedor) || DGDetalleOrden.Rows.Count == 0)
            {
                MessageBox.Show("Faltan datos o productos.");
                return;
            }

            foreach (DataGridViewRow fila in DGDetalleOrden.Rows)
            {
                if (Convert.ToDecimal(fila.Cells[5].Value ?? 0) <= 0)
                {
                    MessageBox.Show("No podés generar una orden con productos en cantidad 0.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // NUEVA VALIDACIÓN: Verifica que el subtotal (índice 7) sea mayor a cero
                if (Convert.ToDecimal(fila.Cells[7].Value ?? 0) <= 0)
                {
                    MessageBox.Show("Todos los productos deben tener un costo unitario y subtotal mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Agregamos un noveno elemento al final ("") para la cantidad recibida
                DetallesProductos.Add(new object[] {
            fila.Cells[0].Value, // [0] ID
            fila.Cells[1].Value, // [1] Código
            fila.Cells[2].Value, // [2] Nombre
            fila.Cells[3].Value, // [3] Categoría
            fila.Cells[4].Value, // [4] Género
            fila.Cells[5].Value, // [5] Cantidad Pedida
            fila.Cells[6].Value, // [6] Costo
            fila.Cells[7].Value, // [7] Subtotal
            ""                   // [8] Cantidad Recibida (Inicia vacía)
        });
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void DGDetalleOrden_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DGDetalleOrden.IsCurrentCellDirty)
            {
                DGDetalleOrden.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DGDetalleOrden_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
    
            int colCantidad = 5;
            int colCosto = 6;
            int colSubtotal = 7;

            // Si se modificó una fila válida y la columna tocada es "Cantidad"
            if (e.RowIndex >= 0 && (e.ColumnIndex == colCantidad || e.ColumnIndex == colCosto))
            {
                DataGridViewRow fila = DGDetalleOrden.Rows[e.RowIndex];

                // Usamos TryParse para evaluar de forma segura sin que explote si hay letras
                bool esCantidadValida = decimal.TryParse(fila.Cells[colCantidad].Value?.ToString(), out decimal cantidad);
                bool esCostoValido = decimal.TryParse(fila.Cells[colCosto].Value?.ToString(), out decimal costo);

                // Si ambos valores son números válidos, calculamos; si no, dejamos en 0 
                if (esCantidadValida && esCostoValido)
                {
                    fila.Cells[colSubtotal].Value = cantidad * costo;
                    CalcularTotal();
                }
                else
                {
                    fila.Cells[colSubtotal].Value = 0;
                    CalcularTotal();
                }
            }


        }

        private void DGDetalleOrden_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Solo evitamos que la aplicación se rompa por errores internos de formato.
            // Ya eliminamos el MessageBox de acá para que no se superponga con el de CellValidating y trabe la pantalla.
            e.ThrowException = false;
        }

        private void DGDetalleOrden_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Verificamos si estamos editando la Cantidad (5) o el Costo Unitario (6)
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                string valorIngresado = e.FormattedValue.ToString();

                // Si borran todo y dejan vacío, lo dejamos pasar temporalmente
                if (string.IsNullOrWhiteSpace(valorIngresado)) return;

                // Cambiamos a <= 0 para obligar a que sea estrictamente mayor a cero
                if (!decimal.TryParse(valorIngresado, out decimal numero) || numero <= 0)
                {
                    MessageBox.Show("Por favor, ingresá un número válido que sea mayor a cero.", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Deshace el cambio y libera la celda
                    DGDetalleOrden.CancelEdit();
                }
            }
        }

        private void DGDetalleOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
