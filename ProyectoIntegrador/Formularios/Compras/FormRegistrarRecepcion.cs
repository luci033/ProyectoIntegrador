using CapaEntidades;
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

namespace ProyectoIntegrador.Formularios.Compras
{
    public partial class FormRegistrarRecepcion : Form
    {
        private int idCompra;
        private int idUsuarioLogueado = 1;
        private List<object[]> listaProductos; // Para compatibilidad hacia atrás si fuera necesario

        public string FechaSeleccionada { get; private set; }
        public string Observacion { get; private set; }

        public FormRegistrarRecepcion(int idCompra, string nroOrden, string proveedor, string fechaOrden, string nombreUsuario, int idUsuario = 0)
        {
            InitializeComponent();
            this.idCompra = idCompra;
            this.idUsuarioLogueado = idUsuario;
            TBNroOrden.Text = nroOrden;
            TBProveedor.Text = proveedor;
            TBFechaOrden.Text = fechaOrden;

            if (this.idUsuarioLogueado <= 0)
            {
                try
                {
                    var u = new CN_Usuario().Listar().FirstOrDefault(x => x.User != null && x.User.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));
                    if (u != null)
                        this.idUsuarioLogueado = u.IdUsuario;
                    else
                        this.idUsuarioLogueado = 1;
                }
                catch
                {
                    this.idUsuarioLogueado = 1;
                }
            }
        }

        // Constructor de compatibilidad
        public FormRegistrarRecepcion(string nroOrden, string proveedor, string fechaOrden, List<object[]> detalles)
        {
            InitializeComponent();
            int.TryParse(nroOrden, out this.idCompra);
            this.idUsuarioLogueado = 1;
            TBNroOrden.Text = nroOrden;
            TBProveedor.Text = proveedor;
            TBFechaOrden.Text = fechaOrden;
            this.listaProductos = detalles;
        }

        private void FormRegistrarRecepcion_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloCard(panelCard, 16);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 10);
            EstiloUI.AplicarEstiloGrilla(DGDetalleRecepcion);
            EstiloUI.AplicarEstiloBoton(BAceptar);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);
            EstiloUI.CentrarControl(panelCard, this);

            TBFechaRecepcion.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DGDetalleRecepcion.CellValidating += new DataGridViewCellValidatingEventHandler(DGDetalleRecepcion_CellValidating);
            DGDetalleRecepcion.DataError += new DataGridViewDataErrorEventHandler(DGDetalleRecepcion_DataError);

            DGDetalleRecepcion.Rows.Clear();

            // Carga de productos desde la base de datos
            if (idCompra > 0)
            {
                try
                {
                    CN_Compra negocio = new CN_Compra();
                    DataTable dt = negocio.ObtenerDetalle(idCompra);

                    foreach (DataRow row in dt.Rows)
                    {
                        int idDetalle = Convert.ToInt32(row["IdDetalleCompra"]);
                        int idProd = Convert.ToInt32(row["IdProducto"]);
                        string codigo = idProd.ToString();
                        string nombre = row["NombreProducto"] != DBNull.Value ? row["NombreProducto"].ToString() : "";
                        int cantPedida = Convert.ToInt32(row["CantidadPedida"]);
                        decimal precioUnit = Convert.ToDecimal(row["PrecioUnitario"]);

                        // Por defecto se sugiere recibir la totalidad de lo pedido
                        int idx = DGDetalleRecepcion.Rows.Add(idProd, codigo, nombre, cantPedida, cantPedida);
                        DGDetalleRecepcion.Rows[idx].Tag = new Tuple<int, int, decimal>(idDetalle, idProd, precioUnit);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los detalles de la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (listaProductos != null)
            {
                // Fallback para lista en memoria si no hubiera conexión previa
                foreach (var item in listaProductos)
                {
                    DGDetalleRecepcion.Rows.Add(item[0], item[1], item[2], item[5], item[5]);
                }
            }

            // Habilitamos la edición únicamente en la columna de Cantidad Recibida
            DGDetalleRecepcion.ReadOnly = false;
            foreach (DataGridViewColumn col in DGDetalleRecepcion.Columns)
            {
                col.ReadOnly = true;
            }

            if (DGDetalleRecepcion.Columns.Count > 4)
            {
                DGDetalleRecepcion.Columns[4].ReadOnly = false;
            }
        }

        private void FormRegistrarRecepcion_Resize(object sender, EventArgs e)
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            DGDetalleRecepcion.EndEdit();

            if (DGDetalleRecepcion.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en esta orden para recibir.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Recepcion recepcion = new Recepcion
            {
                IdCompra = this.idCompra,
                IdUsuario = this.idUsuarioLogueado,
                FechaRecepcion = DateTime.Now,
                Observacion = TBObservacion.Text.Trim()
            };

            List<DetalleRecepcion> detalles = new List<DetalleRecepcion>();
            int totalUnidadesRecibidas = 0;

            foreach (DataGridViewRow fila in DGDetalleRecepcion.Rows)
            {
                string codigo = fila.Cells[1].Value?.ToString();
                int cantPedida = Convert.ToInt32(fila.Cells[3].Value ?? 0);
                int cantRecibida = Convert.ToInt32(fila.Cells[4].Value ?? 0);

                if (cantRecibida < 0)
                {
                    MessageBox.Show($"La cantidad recibida no puede ser negativa (Producto {codigo}).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cantRecibida > cantPedida)
                {
                    MessageBox.Show($"La cantidad recibida del producto {codigo} no puede ser mayor a la cantidad pedida ({cantPedida}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var info = fila.Tag as Tuple<int, int, decimal>;
                int idDetalleCompra = info != null ? info.Item1 : 0;
                int idProducto = info != null ? info.Item2 : Convert.ToInt32(fila.Cells[0].Value ?? 0);
                decimal precioUnitario = info != null ? info.Item3 : 0m;

                detalles.Add(new DetalleRecepcion
                {
                    IdCompra = this.idCompra,
                    IdDetalleCompra = idDetalleCompra,
                    IdProducto = idProducto,
                    CantidadRecibida = cantRecibida,
                    PrecioUnitario = precioUnitario
                });

                totalUnidadesRecibidas += cantRecibida;
            }

            if (totalUnidadesRecibidas == 0)
            {
                DialogResult confirm = MessageBox.Show(
                    "Está registrando una recepción con cantidad 0 en todos los productos.\n¿Desea continuar?",
                    "Confirmar recepción en 0",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;
            }

            CN_Compra negocio = new CN_Compra();
            if (negocio.RegistrarRecepcion(recepcion, detalles, out string mensaje))
            {
                FechaSeleccionada = DateTime.Now.ToString("dd/MM/yyyy");
                Observacion = recepcion.Observacion;

                MessageBox.Show(
                    "Recepción de mercadería registrada con éxito.\nEl stock de los productos y sus precios de venta (+55%) han sido actualizados en el sistema.",
                    "Recepción Registrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error al registrar recepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DGDetalleRecepcion_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Columna 4 es "Cantidad Recibida"
            if (e.ColumnIndex == 4)
            {
                string valorIngresado = e.FormattedValue?.ToString();
                if (string.IsNullOrWhiteSpace(valorIngresado)) return;

                int cantPedida = Convert.ToInt32(DGDetalleRecepcion.Rows[e.RowIndex].Cells[3].Value ?? 0);

                if (!int.TryParse(valorIngresado, out int cantRecibida) || cantRecibida < 0 || cantRecibida > cantPedida)
                {
                    MessageBox.Show($"Por favor, ingresá un número entero entre 0 y {cantPedida}.", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DGDetalleRecepcion.CancelEdit();
                }
            }
        }

        private void DGDetalleRecepcion_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void TBNroOrden_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void LFecha_Click(object sender, EventArgs e) { }
        private void TBFechaRecepcion_TextChanged(object sender, EventArgs e) { }
        private void TBObservacion_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
