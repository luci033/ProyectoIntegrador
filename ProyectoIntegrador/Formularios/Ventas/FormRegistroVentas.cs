using CapaEntidades;
using CapaNegocio;
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
        public int IdComprobanteRegistrado { get; private set; } = 0;

        private string usuarioLogueado;
        private int idUsuarioLogueado = 1;
        private int idClienteSeleccionado = 0;

        private class ItemVentaTag
        {
            public int IdProducto { get; set; }
            public int StockDisponible { get; set; }
        }

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

            // Obtener ID del usuario logueado en la BD
            if (SesionActual.IdUsuario > 0)
            {
                idUsuarioLogueado = SesionActual.IdUsuario;
            }
            else
            {
                try
                {
                    var usuarioObj = new CN_Usuario().Listar().FirstOrDefault(u =>
                        (u.User != null && u.User.Equals(usuarioLogueado, StringComparison.OrdinalIgnoreCase)) ||
                        ($"{u.NombreUsuario} {u.ApellidoUsuario}".Trim().Equals(usuarioLogueado, StringComparison.OrdinalIgnoreCase)));
                    if (usuarioObj != null)
                    {
                        idUsuarioLogueado = usuarioObj.IdUsuario;
                    }
                    else
                    {
                        idUsuarioLogueado = 1;
                    }
                }
                catch
                {
                    idUsuarioLogueado = 1;
                }
            }

            // Calcular próximo Nro de Comprobante
            try
            {
                var dtVentas = new CN_Venta().ListarVentas();
                int proximoId = 1;
                if (dtVentas != null && dtVentas.Rows.Count > 0)
                {
                    int maxId = 0;
                    foreach (DataRow r in dtVentas.Rows)
                    {
                        if (int.TryParse(r["IdComprobante"]?.ToString(), out int idC) && idC > maxId)
                            maxId = idC;
                    }
                    proximoId = maxId + 1;
                }
                TBNroVenta.Text = proximoId.ToString("D5");
            }
            catch
            {
                TBNroVenta.Text = (FormVentas.HistorialVentas.Count + 1).ToString("D5");
            }

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
                string valor = e.FormattedValue?.ToString();
                if (string.IsNullOrWhiteSpace(valor)) return;

                int stockDisponible = 0;
                if (dataGridProducto.Rows[e.RowIndex].Tag is ItemVentaTag tag)
                {
                    stockDisponible = tag.StockDisponible;
                }
                else
                {
                    stockDisponible = Convert.ToInt32(dataGridProducto.Rows[e.RowIndex].Tag ?? 0);
                }

                if (!int.TryParse(valor, out int cantidad) || cantidad <= 0 || (stockDisponible > 0 && cantidad > stockDisponible))
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
                MessageBox.Show("Faltan datos del cliente o agregar productos a la venta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idClienteSeleccionado <= 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la base de datos o registre uno nuevo.", "Cliente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filasValidas = dataGridProducto.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow).ToList();
            if (filasValidas.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto a la venta.", "Sin Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormCobro formCobro = new FormCobro(TBCliente.Text, TBTotal.Text))
            {
                DialogResult resultado = formCobro.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.MetodoPago = formCobro.MetodoPagoSeleccionado;

                    CN_Venta negocioVenta = new CN_Venta();
                    int idMedioPago = negocioVenta.DeterminarMedioPago(formCobro.MetodoPagoSeleccionado);
                    int idTipoComprobante = negocioVenta.DeterminarTipoComprobante(TBCondicionIVA.Text);

                    Comprobante venta = new Comprobante
                    {
                        FechaComprobante = DateTime.Now,
                        IdMedioPago = idMedioPago,
                        IdTipoComprobante = idTipoComprobante,
                        IdCliente = idClienteSeleccionado,
                        IdUsuario = idUsuarioLogueado,
                        DescripcionMedioPago = formCobro.MetodoPagoSeleccionado,
                        NombreCliente = TBCliente.Text,
                        CondicionIvaCliente = TBCondicionIVA.Text
                    };

                    foreach (DataGridViewRow fila in filasValidas)
                    {
                        int idProd = 0;
                        if (fila.Tag is ItemVentaTag tag)
                        {
                            idProd = tag.IdProducto;
                        }
                        else if (int.TryParse(fila.Cells[0].Value?.ToString(), out int parsedId))
                        {
                            idProd = parsedId;
                        }

                        int cantidad = Convert.ToInt32(fila.Cells[5].Value ?? 1);
                        decimal precio = Convert.ToDecimal(fila.Cells[4].Value ?? 0);

                        venta.Detalles.Add(new DetalleComprobante
                        {
                            IdProducto = idProd,
                            NombreProducto = fila.Cells[1].Value?.ToString() ?? "",
                            Cantidad = cantidad,
                            PrecioUnitario = precio
                        });
                    }

                    if (negocioVenta.RegistrarVenta(venta, out int idComprobanteGenerado, out string mensaje))
                    {
                        IdComprobanteRegistrado = idComprobanteGenerado;
                        TBNroVenta.Text = idComprobanteGenerado.ToString("D5");

                        MessageBox.Show($"¡Venta registrada con éxito en el sistema!\nComprobante N°: #{idComprobanteGenerado:D5}\nEl stock fue actualizado correctamente.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        try
                        {
                            using (FDetalleVenta comprobante = new FDetalleVenta(idComprobanteGenerado))
                            {
                                comprobante.ShowDialog();
                            }
                        }
                        catch { }

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error al registrar la venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (resultado == DialogResult.Abort)
                {
                    // Se presionó Cancelar en el formulario de cobro
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
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
                    idClienteSeleccionado = formBuscar.IdClienteSeleccionado;
                    TBCliente.Text = formBuscar.NombreCompleto;
                    TBCondicionIVA.Text = formBuscar.CondicionIVA;
                }
            }
        }

        private void BAgregarProducto_Click_1(object sender, EventArgs e)
        {
            using (FormBuscarProducto formProducto = new FormBuscarProducto())
            {
                formProducto.SoloConStock = true;
                formProducto.ConfigurarParaVentas();

                if (formProducto.ShowDialog() == DialogResult.OK)
                {
                    if (formProducto.Stock <= 0)
                    {
                        MessageBox.Show($"El producto '{formProducto.Nombre}' no cuenta con stock disponible actualmente.", "Sin Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 1. Verificamos si el producto ya existe en la grilla buscando por su Código o ID
                    foreach (DataGridViewRow fila in dataGridProducto.Rows)
                    {
                        if (fila.IsNewRow) continue;
                        int prodIdFila = 0;
                        if (fila.Tag is ItemVentaTag t) prodIdFila = t.IdProducto;

                        if ((fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == formProducto.Codigo) ||
                            (prodIdFila > 0 && prodIdFila == formProducto.IdProducto))
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

                    dataGridProducto.Rows[indiceFila].Tag = new ItemVentaTag
                    {
                        IdProducto = formProducto.IdProducto,
                        StockDisponible = formProducto.Stock
                    };
                    ActualizarTotalGeneral();
                }
            }
        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            using (FormClientesABM modalCliente = new FormClientesABM())
            {
                if (modalCliente.ShowDialog() == DialogResult.OK)
                {
                    idClienteSeleccionado = modalCliente.IdClienteGenerado;
                    if (modalCliente.ClienteRegistrado != null)
                    {
                        string nombreCompleto = $"{modalCliente.ClienteRegistrado.Nombre} {modalCliente.ClienteRegistrado.Apellido}".Trim();
                        TBCliente.Text = nombreCompleto;
                        TBCondicionIVA.Text = modalCliente.ClienteCreado?.CondicionIVA ?? "Consumidor Final";
                    }
                    else if (modalCliente.ClienteCreado != null)
                    {
                        string nombreCompleto = $"{modalCliente.ClienteCreado.Nombre} {modalCliente.ClienteCreado.Apellido}".Trim();
                        TBCliente.Text = nombreCompleto;
                        TBCondicionIVA.Text = modalCliente.ClienteCreado.CondicionIVA;
                    }
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (this.MdiParent != null && !this.MdiParent.IsDisposed)
            {
                Form formPadre = this.MdiParent;
                bool yaExisteOpciones = formPadre.MdiChildren.Any(h => h is FormOpcionesVenta && h.Visible);
                if (!yaExisteOpciones)
                {
                    string user = !string.IsNullOrWhiteSpace(usuarioLogueado) ? usuarioLogueado : SesionActual.LoginUsuario;
                    FormOpcionesVenta opciones = new FormOpcionesVenta(user);
                    opciones.MdiParent = formPadre;
                    opciones.WindowState = FormWindowState.Maximized;
                    opciones.Show();
                }
            }
        }

        private void TBVendedor_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
