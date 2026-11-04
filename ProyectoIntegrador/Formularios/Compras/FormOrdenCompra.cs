using CapaEntidades;
using CapaNegocio;
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
        private int idUsuarioLogueado = 1;
        private int idProveedorSeleccionado = 0;
        public int IdCompraGenerada { get; private set; } = 0;

        public FormOrdenCompra(string nombreUsuario, int idUsuario = 0)
        {
            InitializeComponent();

            usuarioLogueado = !string.IsNullOrWhiteSpace(nombreUsuario) ? nombreUsuario : SesionActual.LoginUsuario;
            idUsuarioLogueado = idUsuario > 0 ? idUsuario : (SesionActual.IdUsuario > 0 ? SesionActual.IdUsuario : 1);

            TBUsuario.Text = !string.IsNullOrWhiteSpace(SesionActual.NombreCompleto) ? SesionActual.NombreCompleto : usuarioLogueado;
            TBUsuario.ReadOnly = true;
        }

        public FormOrdenCompra(string nombreUsuario) : this(nombreUsuario, 0)
        {
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

            if (idUsuarioLogueado <= 0)
            {
                try
                {
                    var usuarioObj = new CN_Usuario().Listar().FirstOrDefault(u =>
                        (u.User != null && u.User.Equals(usuarioLogueado, StringComparison.OrdinalIgnoreCase)) ||
                        ($"{u.NombreUsuario} {u.ApellidoUsuario}".Trim().Equals(usuarioLogueado, StringComparison.OrdinalIgnoreCase)) ||
                        (u.NombreUsuario != null && u.NombreUsuario.Equals(usuarioLogueado, StringComparison.OrdinalIgnoreCase)));
                    if (usuarioObj != null)
                    {
                        idUsuarioLogueado = usuarioObj.IdUsuario;
                    }
                    else
                    {
                        idUsuarioLogueado = SesionActual.IdUsuario > 0 ? SesionActual.IdUsuario : 1;
                    }
                }
                catch
                {
                    idUsuarioLogueado = SesionActual.IdUsuario > 0 ? SesionActual.IdUsuario : 1;
                }
            }

            DGDetalleOrden.ReadOnly = false;
            // Bloqueamos todas las columnas por defecto para que no se puedan escribir datos fijos
            foreach (DataGridViewColumn col in DGDetalleOrden.Columns)
            {
                col.ReadOnly = true;
            }

            // Desbloqueamos la Cantidad, Margen (%) y Costo Unitario para que puedan editarse libremente
            if (DGDetalleOrden.Columns.Contains("cantidad"))
                DGDetalleOrden.Columns["cantidad"].ReadOnly = false;
            if (DGDetalleOrden.Columns.Contains("CMargenGanancia"))
                DGDetalleOrden.Columns["CMargenGanancia"].ReadOnly = false;
            if (DGDetalleOrden.Columns.Contains("CostoUnitario"))
                DGDetalleOrden.Columns["CostoUnitario"].ReadOnly = false;

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
            using (FormBuscarProveedor formBuscar = new FormBuscarProveedor())
            {
                if (formBuscar.ShowDialog() == DialogResult.OK)
                {
                    if (DGDetalleOrden.Rows.Count > 0 && idProveedorSeleccionado > 0 && idProveedorSeleccionado != formBuscar.IdProveedor)
                    {
                        DialogResult confirm = MessageBox.Show(
                            "Al cambiar de proveedor se vaciarán los productos agregados a la orden. ¿Desea continuar?",
                            "Cambiar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirm != DialogResult.Yes) return;

                        DGDetalleOrden.Rows.Clear();
                        CalcularTotal();
                    }

                    idProveedorSeleccionado = formBuscar.IdProveedor;
                    TBRazonSocial.Text = formBuscar.RazonSocial;
                    TBCUIT.Text = formBuscar.CUIT;
                    TBContacto.Text = formBuscar.Telefono; // Puede ser el teléfono o correo
                    TBCorreo.Text = formBuscar.CorreoElectronico;
                }
            }
        }

        private void BAgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBRazonSocial.Text) || idProveedorSeleccionado <= 0)
            {
                MessageBox.Show("Primero debés seleccionar un proveedor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormBuscarProducto formProducto = new FormBuscarProducto(idProveedorSeleccionado))
            {
                if (formProducto.ShowDialog() == DialogResult.OK)
                {
                    // 1. Verificamos si el producto ya fue agregado a la grilla (buscando por su IdProducto en la columna colIdProducto)
                    foreach (DataGridViewRow filaExistente in DGDetalleOrden.Rows)
                    {
                        if (filaExistente.Cells["colIdProducto"].Value != null && Convert.ToInt32(filaExistente.Cells["colIdProducto"].Value) == formProducto.IdProducto)
                        {
                            // Si ya existe, sumamos 1 a la cantidad actual
                            decimal cantidadActual = Convert.ToDecimal(filaExistente.Cells["cantidad"].Value ?? 0);
                            filaExistente.Cells["cantidad"].Value = cantidadActual + 1;

                            // Al cambiar la celda, el sistema recalculará el subtotal y el total solo
                            return; // Salimos para no agregar una fila nueva
                        }
                    }

                    // 2. Si no existe, lo agregamos normalmente por primera vez
                    int margenInicial = formProducto.MargenGanancia;
                    int cantidad = 1;
                    decimal CostoCompra = 0;
                    decimal subtotal = CostoCompra * cantidad;

                    int idx = DGDetalleOrden.Rows.Add();
                    DataGridViewRow row = DGDetalleOrden.Rows[idx];
                    row.Cells["colIdProducto"].Value = formProducto.IdProducto;
                    row.Cells["colCodigo"].Value = formProducto.Codigo;
                    row.Cells["nombre"].Value = formProducto.Nombre;
                    row.Cells["colCategoria"].Value = formProducto.Categoria;
                    row.Cells["colGenero"].Value = formProducto.Genero;
                    row.Cells["cantidad"].Value = cantidad;
                    row.Cells["CMargenGanancia"].Value = margenInicial > 0 ? (object)margenInicial : "";
                    row.Cells["CostoUnitario"].Value = CostoCompra;
                    row.Cells["Subtotal"].Value = subtotal;

                    CalcularTotal();
                }
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in DGDetalleOrden.Rows)
            {
                if (fila.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
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

        private void BGenerarOrden_Click(object sender, EventArgs e)
        {
            // Forzar finalización de edición para capturar el último valor tipeado
            DGDetalleOrden.EndEdit();

            // Validar que no se esté editando nada
            if (this.ValidateChildren(ValidationConstraints.Enabled) == false)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(Proveedor) || idProveedorSeleccionado <= 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DGDetalleOrden.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto a la orden.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Compra orden = new Compra
            {
                FechaCompra = DateTime.Now,
                IdUsuario = idUsuarioLogueado,
                IdProveedor = idProveedorSeleccionado,
                IdEstadoCompra = 1
            };

            foreach (DataGridViewRow fila in DGDetalleOrden.Rows)
            {
                decimal cantidad = Convert.ToDecimal(fila.Cells["cantidad"].Value ?? 0);
                decimal costo = Convert.ToDecimal(fila.Cells["CostoUnitario"].Value ?? 0);
                decimal subtotal = Convert.ToDecimal(fila.Cells["Subtotal"].Value ?? 0);

                if (cantidad <= 0)
                {
                    MessageBox.Show("No podés generar una orden con productos en cantidad 0.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (costo <= 0 || subtotal <= 0)
                {
                    MessageBox.Show("Todos los productos deben tener un costo unitario y subtotal mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int? margenFila = null;
                if (fila.Cells["CMargenGanancia"].Value != null &&
                    int.TryParse(fila.Cells["CMargenGanancia"].Value.ToString().Trim(), out int mVal) &&
                    mVal >= 1)
                {
                    margenFila = mVal;
                }

                orden.Detalles.Add(new DetalleCompra
                {
                    IdProducto = Convert.ToInt32(fila.Cells["colIdProducto"].Value),
                    CodigoProducto = fila.Cells["colCodigo"].Value?.ToString(),
                    NombreProducto = fila.Cells["nombre"].Value?.ToString(),
                    Cantidad = (int)cantidad,
                    PrecioUnitario = costo,
                    MargenGanancia = margenFila
                });
            }

            CN_Compra negocio = new CN_Compra();
            if (negocio.RegistrarOrden(orden, out int idGenerada, out string mensaje))
            {
                IdCompraGenerada = idGenerada;
                MessageBox.Show($"Orden de compra N° {idGenerada} registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = DGDetalleOrden.Columns[e.ColumnIndex].Name;

            // Si se modificó "cantidad" o "CostoUnitario", recalculamos subtotal y total
            if (colName == "cantidad" || colName == "CostoUnitario")
            {
                DataGridViewRow fila = DGDetalleOrden.Rows[e.RowIndex];

                bool esCantidadValida = decimal.TryParse(fila.Cells["cantidad"].Value?.ToString(), out decimal cantidad);
                bool esCostoValido = decimal.TryParse(fila.Cells["CostoUnitario"].Value?.ToString(), out decimal costo);

                if (esCantidadValida && esCostoValido)
                {
                    fila.Cells["Subtotal"].Value = cantidad * costo;
                    CalcularTotal();
                }
                else
                {
                    fila.Cells["Subtotal"].Value = 0;
                    CalcularTotal();
                }
            }
        }

        private void DGDetalleOrden_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void DGDetalleOrden_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = DGDetalleOrden.Columns[e.ColumnIndex].Name;

            if (colName == "cantidad" || colName == "CostoUnitario")
            {
                string valorIngresado = e.FormattedValue?.ToString();

                if (string.IsNullOrWhiteSpace(valorIngresado)) return;

                if (!decimal.TryParse(valorIngresado, out decimal numero) || numero <= 0)
                {
                    MessageBox.Show("Por favor, ingresá un número válido que sea mayor a cero.", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DGDetalleOrden.CancelEdit();
                }
            }
            else if (colName == "CMargenGanancia")
            {
                string valorIngresado = e.FormattedValue?.ToString();

                if (string.IsNullOrWhiteSpace(valorIngresado)) return;

                if (!int.TryParse(valorIngresado, out int margen) || margen < 1)
                {
                    MessageBox.Show("El margen de ganancia debe ser un número entero mayor o igual a 1.", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DGDetalleOrden.CancelEdit();
                }
            }
        }

        private void DGDetalleOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
