using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoIntegrador
{
    public partial class FormProductoABM : Form
    {
        private int IdProductoSeleccionado;
        private string categoriaSeleccionada;
        private string generoSeleccionado;
        private string proveedorSeleccionado;

        public string Nombre => textNombre.Text.Trim();
        public string Categoria => cmbCategoria.Text.Trim();
        public string Genero => combGenero.Text.Trim(); 
        public string Precio => textPrecio.Text.Trim();
        public string Stock => textStockInicial.Text.Trim();
        public string StockMinimo => textStockMinimo.Text.Trim();
        public string Descripcion => textDescripcion.Text.Trim();
        private bool esModificacion = false;
        private bool esDetalle = false;
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
            EstiloUI.CentrarControl(panelCard, this);

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
            }
            else
            {
                textPrecio.ReadOnly = true;
                textPrecio.Text = "0.00";
                textStockInicial.ReadOnly = true;
                textStockInicial.Text = "0";

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
            // 1. valida el nombre
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del producto.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textNombre.Focus();
                return false;
            }

            // 2. valida la categoria
            if (string.IsNullOrWhiteSpace(cmbCategoria.Text) || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría para el producto.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            // 3. valida el genero
            if (string.IsNullOrWhiteSpace(combGenero.Text) || combGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el género correspondiente.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combGenero.Focus();
                return false;
            }

            // 4. valida proveedor
            if (string.IsNullOrWhiteSpace(cmbProveedor.Text) || cmbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un proveedor para el producto.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProveedor.Focus();
                return false;
            }

            // 5. valida stock minimo
            if (!int.TryParse(textStockMinimo.Text.Trim(), out int stockMin) || stockMin < 1)
            {
                MessageBox.Show("El stock mínimo debe ser un número entero (1 o mayor).", "Stock Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textStockMinimo.Focus();
                textStockMinimo.SelectAll();
                return false;
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

            Producto producto = new Producto()
            {
                IdProducto = this.IdProductoSeleccionado,
                NombreProducto = textNombre.Text.Trim(),
                Descripcion = textDescripcion.Text.Trim(),
                StockMinimo = Convert.ToInt32(textStockMinimo.Text.Trim()),
                StockActual = 0,
                PrecioCompra = null,
                PrecioVenta = null,
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

        public void ConfigurarModoEdicion(int idProducto, string nombre, string categoria, string genero, string precio, string stock, string stockMinimo, string descripcion, string proveedor)
        {
            this.esModificacion = true;
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
            textPrecio.Enabled = false;

            textStockInicial.Text = stock;
            textStockInicial.Enabled = false;
        }

        public void ConfigurarModoEdicion(string codigo, string nombre, string categoria, string genero, string precio, string stock, string stockMinimo, string descripcion, string proveedor)
        {
            int.TryParse(codigo, out int id);
            ConfigurarModoEdicion(id, nombre, categoria, genero, precio, stock, stockMinimo, descripcion, proveedor);
        }

        public void ConfigurarModoDetalle(string codigo, string nombre, string categoria, string genero, string precio, string stock, string stockMinimo, string descripcion, string proveedor)
        {
            esDetalle = true;
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
        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

