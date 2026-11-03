using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FormProductoABM : Form
    {
        private int IdProductoSeleccionado;
        private string categoriaSeleccionada;
        private string generoSeleccionado;
        private string proveedorSeleccionado;
        private decimal precioCompraActual = 0m;
        private bool actualizandoCalculo = false;

        public string Nombre => textNombre.Text.Trim();
        public string Categoria => cmbCategoria.Text.Trim();
        public string Genero => combGenero.Text.Trim(); 
        public string Precio => textPrecio.Text.Trim();
        public string Stock => textStockInicial.Text.Trim();
        public string StockMinimo => textStockMinimo.Text.Trim();
        public string Descripcion => textDescripcion.Text.Trim();
        public string MargenGanancia => textMargenGanancia.Text.Trim();
        private bool esModificacion = false;
        private bool esDetalle = false;
        private bool esAdmin = false;
        public string Proveedor => cmbProveedor.Text.Trim();

        public FormProductoABM()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloCard(panelCard, 16);
            EstiloUI.AplicarBordesRedondeados(pictureBox1, 8);
            EstiloUI.AplicarEstiloBoton(BCrearProducto);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);
            EstiloUI.AplicarEstiloTextBox(textNombre);
            EstiloUI.AplicarEstiloTextBox(textPrecio);
            EstiloUI.AplicarEstiloTextBox(textStockInicial);
            EstiloUI.AplicarEstiloTextBox(textStockMinimo);
            EstiloUI.AplicarEstiloTextBox(textDescripcion);
            EstiloUI.AplicarEstiloTextBox(textMargenGanancia);
            EstiloUI.CentrarControl(panelCard, this);

            // Vinculamos el evento de cálculo en vivo para el margen de ganancia
            textMargenGanancia.TextChanged += textMargenGanancia_TextChanged;

            // ComboBox Categoria
            cmbCategoria.DataSource = new CN_Categoria().ListarCategorias();
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.ValueMember = "IdCategoria";

            // ComboBox Genero
            combGenero.DataSource = new CN_Genero().ListarGeneros();
            combGenero.DisplayMember = "NombreGenero";
            combGenero.ValueMember = "IdGenero";

            // ComboBox Proveedor 
            cmbProveedor.DataSource = new CN_Proveedor().ListarProveedores();
            cmbProveedor.DisplayMember = "RazonSocial";
            cmbProveedor.ValueMember = "IdProveedor";

            if (esModificacion || esDetalle)
            {
                if (!string.IsNullOrEmpty(categoriaSeleccionada))
                {
                    int index = cmbCategoria.FindStringExact(categoriaSeleccionada);
                    if (index < 0) index = cmbCategoria.FindString(categoriaSeleccionada);
                    if (index >= 0) cmbCategoria.SelectedIndex = index;
                    else cmbCategoria.Text = categoriaSeleccionada;
                }
                if (!string.IsNullOrEmpty(generoSeleccionado))
                {
                    int index = combGenero.FindStringExact(generoSeleccionado);
                    if (index < 0) index = combGenero.FindString(generoSeleccionado);
                    if (index >= 0) combGenero.SelectedIndex = index;
                    else combGenero.Text = generoSeleccionado;
                }
                if (!string.IsNullOrEmpty(proveedorSeleccionado))
                {
                    int index = cmbProveedor.FindStringExact(proveedorSeleccionado);
                    if (index < 0) index = cmbProveedor.FindString(proveedorSeleccionado);
                    if (index >= 0) cmbProveedor.SelectedIndex = index;
                    else cmbProveedor.Text = proveedorSeleccionado;
                }

                if (esModificacion)
                {
                    textMargenGanancia.ReadOnly = !esAdmin;
                    textMargenGanancia.Enabled = esAdmin;
                    textPrecio.ReadOnly = !esAdmin;
                    textPrecio.Enabled = esAdmin;
                }
                else if (esDetalle)
                {
                    LMargenGanancia.Visible = esAdmin;
                    textMargenGanancia.Visible = esAdmin;
                }
            }
            else
            {
                textPrecio.ReadOnly = true;
                textPrecio.Text = "0.00";
                textStockInicial.ReadOnly = true;
                textStockInicial.Text = "0";

                textMargenGanancia.ReadOnly = true;
                textMargenGanancia.Enabled = false;
                textMargenGanancia.Text = "";

                cmbProveedor.SelectedIndex = -1;
                cmbCategoria.SelectedIndex = -1;
                combGenero.SelectedIndex = -1;
            }
        }

        private void FormProductoABM_Resize(object sender, EventArgs e)
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        private bool ValidarCampos()
        {
            // 1. Validar Nombre
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("El nombre del producto no puede estar vacío.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textNombre.Focus();
                return false;
            }

            // 2. Validar Categoría
            if (cmbCategoria.SelectedIndex == -1 || cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            // 3. Validar Género
            if (combGenero.SelectedIndex == -1 || combGenero.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un género.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combGenero.Focus();
                return false;
            }

            // 4. Validar Proveedor
            if (cmbProveedor.SelectedIndex == -1 || cmbProveedor.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProveedor.Focus();
                return false;
            }

            // 5. Validar Stock Mínimo
            if (!int.TryParse(textStockMinimo.Text.Trim(), out int stockMinimo) || stockMinimo <= 0)
            {
                MessageBox.Show("El stock mínimo debe ser un número entero mayor a cero.", "Stock Mínimo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textStockMinimo.Focus();
                textStockMinimo.SelectAll();
                return false;
            }

            // 6. Validar Precio de Venta (sólo si no está vacío)
            if (!string.IsNullOrWhiteSpace(textPrecio.Text))
            {
                string rawP = textPrecio.Text.Replace("$", "").Replace("€", "").Trim();
                if ((!decimal.TryParse(rawP, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out decimal p) &&
                     !decimal.TryParse(rawP, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out p)) || p < 0)
                {
                    MessageBox.Show("El precio de venta debe ser un número válido mayor o igual a cero.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textPrecio.Focus();
                    textPrecio.SelectAll();
                    return false;
                }
            }

            // 7. Validar Margen de Ganancia (sólo si se ingresó texto)
            if (!string.IsNullOrWhiteSpace(textMargenGanancia.Text))
            {
                if (!int.TryParse(textMargenGanancia.Text.Trim(), out int margen) || margen < 1)
                {
                    MessageBox.Show("El margen de ganancia debe ser un número entero mayor o igual a 1.", "Margen Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textMargenGanancia.Focus();
                    textMargenGanancia.SelectAll();
                    return false;
                }
            }

            return true;
        }

        private void BCrearProducto_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            int idCategoria = 0;
            if (cmbCategoria.SelectedValue != null)
                int.TryParse(cmbCategoria.SelectedValue.ToString(), out idCategoria);

            int idGenero = 0;
            if (combGenero.SelectedValue != null)
                int.TryParse(combGenero.SelectedValue.ToString(), out idGenero);

            int idProveedor = 0;
            if (cmbProveedor.SelectedValue != null)
                int.TryParse(cmbProveedor.SelectedValue.ToString(), out idProveedor);

            decimal? precioVenta = null;
            if (!string.IsNullOrWhiteSpace(textPrecio.Text))
            {
                string rawPrecio = textPrecio.Text.Replace("$", "").Replace("€", "").Trim();
                if (decimal.TryParse(rawPrecio, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out decimal pVenta) ||
                    decimal.TryParse(rawPrecio, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out pVenta))
                {
                    if (pVenta > 0)
                    {
                        precioVenta = pVenta;
                    }
                }
            }

            int? margenNullable = null;
            if (int.TryParse(textMargenGanancia.Text.Trim(), out int mg) && mg >= 1)
            {
                margenNullable = mg;
            }

            Producto producto = new Producto()
            {
                IdProducto = this.IdProductoSeleccionado,
                NombreProducto = textNombre.Text.Trim(),
                Descripcion = textDescripcion.Text.Trim(),
                StockMinimo = Convert.ToInt32(textStockMinimo.Text.Trim()),
                StockActual = 0,
                PrecioCompra = null,
                PrecioVenta = precioVenta,
                MargenGanancia = margenNullable,
                IdCategoria = idCategoria,
                IdGenero = idGenero,
                IdProveedor = idProveedor,
                Estado = true
            };

            string mensaje = string.Empty;
            CN_Producto negocioProducto = new CN_Producto();
            bool resultado = false;

            if (esModificacion)
            {
                resultado = negocioProducto.Editar(producto, out mensaje);
            }
            else
            {
                resultado = negocioProducto.Registrar(producto, out mensaje);
            }

            if (resultado)
            { 
                string mensajeExito = esModificacion ? "Producto modificado exitosamente." : "Producto registrado exitosamente.";
                MessageBox.Show(mensajeExito, "Joyería ALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            if (esDetalle)
            {
                this.Close();
                return;
            }

            DialogResult Respuesta = MessageBox.Show(
                "¿Está seguro de que desea cancelar?, Se perderan los datos no guardados.",
                "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(Respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void ConfigurarModoEdicion(int idProducto, string nombre, string categoria, string genero, string precio, string stock, string stockMinimo, string descripcion, string proveedor, string margenGanancia, decimal precioCompra = 0m, bool esAdmin = false)
        {
            this.esModificacion = true;
            this.esAdmin = esAdmin;
            this.precioCompraActual = precioCompra;
            this.IdProductoSeleccionado = idProducto;
            this.Text = "Modificar Producto";
            LTitulo.Text = "Modificar Producto";
            BCrearProducto.Text = "Guardar Cambios";

            textNombre.Text = nombre;
            textStockMinimo.Text = stockMinimo;
            textDescripcion.Text = descripcion;
            cmbProveedor.Text = proveedor;

            categoriaSeleccionada = categoria;
            generoSeleccionado = genero;
            proveedorSeleccionado = proveedor;

            cmbCategoria.Text = categoria;
            cmbCategoria.Enabled = false;

            combGenero.Text = genero;
            combGenero.Enabled = false;

            textPrecio.Text = precio;
            textPrecio.ReadOnly = !esAdmin;
            textPrecio.Enabled = esAdmin;

            textStockInicial.Text = stock;
            textStockInicial.ReadOnly = true;
            textStockInicial.Enabled = false;

            textMargenGanancia.Text = margenGanancia;
            textMargenGanancia.ReadOnly = !esAdmin;
            textMargenGanancia.Enabled = esAdmin;

            if (precioCompraActual > 0)
            {
                LMargenGanancia.Text = $"Margen de Ganancia (%) - Costo: ${precioCompraActual:N2}";
            }
            else
            {
                LMargenGanancia.Text = "Margen de Ganancia (%):";
            }
        }

        public void ConfigurarModoEdicion(string codigo, string nombre, string categoria, string genero, string precio, string stock, string stockMinimo, string descripcion, string proveedor, string margenGanancia, decimal precioCompra = 0m, bool esAdmin = false)
        {
            int.TryParse(codigo, out int id);
            ConfigurarModoEdicion(id, nombre, categoria, genero, precio, stock, stockMinimo, descripcion, proveedor, margenGanancia, precioCompra, esAdmin);
        }

        public void ConfigurarModoDetalle(string codigo, string nombre, string categoria, string genero, string precio, string stock, string stockMinimo, string descripcion, string proveedor, string margenGanancia = "", decimal precioCompra = 0m, bool esAdmin = true)
        {
            esDetalle = true;
            this.esAdmin = esAdmin;
            this.precioCompraActual = precioCompra;
            this.Text = "Detalle Producto";
            LTitulo.Text = "Detalle Producto";
            BCrearProducto.Visible = false;
            BCancelar.Text = "Cerrar";

            textNombre.Text = nombre;
            textNombre.Enabled = false;

            categoriaSeleccionada = categoria;
            generoSeleccionado = genero;
            proveedorSeleccionado = proveedor;

            cmbCategoria.Text = categoria;
            cmbCategoria.Enabled = false;

            combGenero.Text = genero;
            combGenero.Enabled = false;

            textPrecio.Text = precio;
            textPrecio.Enabled = false;

            textStockInicial.Text = stock;
            textStockInicial.Enabled = false;

            textStockMinimo.Text = stockMinimo;
            textStockMinimo.Enabled = false;

            textDescripcion.Text = descripcion;
            textDescripcion.Enabled = false;

            cmbProveedor.Text = proveedor;
            cmbProveedor.Enabled = false;

            textMargenGanancia.Text = margenGanancia;
            textMargenGanancia.Enabled = false;

            if (esAdmin)
            {
                LMargenGanancia.Visible = true;
                textMargenGanancia.Visible = true;
                if (precioCompraActual > 0)
                {
                    LMargenGanancia.Text = $"Margen de Ganancia (%) - Costo: ${precioCompraActual:N2}";
                }
                else
                {
                    LMargenGanancia.Text = "Margen de Ganancia (%):";
                }
            }
            else
            {
                LMargenGanancia.Visible = false;
                textMargenGanancia.Visible = false;
            }
        }

        private void textMargenGanancia_TextChanged(object sender, EventArgs e)
        {
            if (actualizandoCalculo) return;
            if (!esModificacion || !esAdmin) return;
            if (precioCompraActual <= 0) return;

            string rawMargen = textMargenGanancia.Text.Trim();
            if (decimal.TryParse(rawMargen, out decimal margen) && margen >= 0)
            {
                actualizandoCalculo = true;
                try
                {
                    decimal nuevoPrecio = Math.Round(precioCompraActual * (1.0m + (margen / 100.0m)), 2);
                    textPrecio.Text = nuevoPrecio.ToString("0.00");
                }
                finally
                {
                    actualizandoCalculo = false;
                }
            }
        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {
            if (actualizandoCalculo) return;
            if (!esModificacion || !esAdmin) return;
            if (precioCompraActual <= 0) return;

            string rawPrecio = textPrecio.Text.Replace("$", "").Replace("€", "").Trim();
            if (decimal.TryParse(rawPrecio, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out decimal precio) ||
                decimal.TryParse(rawPrecio, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out precio))
            {
                if (precio >= precioCompraActual)
                {
                    actualizandoCalculo = true;
                    try
                    {
                        decimal nuevoMargen = Math.Round(((precio - precioCompraActual) / precioCompraActual) * 100.0m, 0);
                        textMargenGanancia.Text = ((int)nuevoMargen).ToString();
                    }
                    finally
                    {
                        actualizandoCalculo = false;
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
