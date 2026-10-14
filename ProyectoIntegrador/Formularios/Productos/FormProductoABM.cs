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


     
            //ComboBox Categoria
            cmbCategoria.DataSource = new CN_Categoria().ListarCategorias();
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.ValueMember = "IdCategoria";
            cmbCategoria.SelectedIndex = -1;

            //ComboBox Genero
            combGenero.DataSource = new CN_Genero().ListarGeneros();
            combGenero.DisplayMember = "NombreGenero";
            combGenero.ValueMember = "IdGenero";
            combGenero.SelectedIndex = -1;

            //ComboBoxProveedor 
            cmbProveedor.DataSource = new CN_Proveedor().ListarProveedores();
            cmbProveedor.DisplayMember = "RazonSocial";
            cmbProveedor.ValueMember = "IdProveedor";
            cmbProveedor.SelectedIndex = -1;


            // 2. Solo reseteamos los campos si estamos creando un producto NUEVO
            if (!esModificacion && !esDetalle)
            {
                textPrecio.ReadOnly = true;
                textPrecio.Text = "0.00";
                textStockInicial .ReadOnly = true;
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
            if (string.IsNullOrWhiteSpace(cmbCategoria.Text))
            {
                MessageBox.Show("Seleccione una categoría para el producto.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            // 4. valida el genero
            if (string.IsNullOrWhiteSpace(combGenero.Text))
            {
                MessageBox.Show("Seleccione el género correspondiente.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combGenero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbProveedor.Text))
            {
                MessageBox.Show("Seleccione un proveedor para el producto.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProveedor.Focus();
                return false;
            }

            // 7. valida stock minimo
            if (esModificacion == false)
            {
                if (!int.TryParse(textStockMinimo.Text, out int stockMin) || stockMin < 1)
                {
                    MessageBox.Show("El stock mínimo debe ser un número entero (1 o mayor).", "Stock Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textStockMinimo.Focus();
                    textStockMinimo.SelectAll();
                    return false;
                }
            }

            return true; // s todo es correcto, retorna verdadero
        }

        private void BCrearProducto_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            Producto nuevoProducto = new Producto()
            {
                NombreProducto = textNombre.Text.Trim(),
                Descripcion = textDescripcion.Text.Trim(),
                StockMinimo = Convert.ToInt32(textStockMinimo.Text),
                StockActual = 0,
                PrecioCompra = null,
                PrecioVenta = null,
                IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue),
                IdGenero = Convert.ToInt32(combGenero.SelectedValue),
                IdProveedor = Convert.ToInt32(cmbProveedor.SelectedValue),
                Estado = true
            };

            string mensaje = string.Empty;
            CN_Producto negocioProducto = new CN_Producto();

            //si es modifiacion o alta nueva (por ahora le pongo para registrar)
            bool resultado = negocioProducto.Registrar(nuevoProducto, out mensaje);

            if (resultado)
            { 
                MessageBox.Show("Éxito", "Joyaria ALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //si la capa de engocio o la bd rechazan, mostramos el mensaje correcto
                MessageBox.Show(mensaje, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            /*
            // 3 y 4. Definimos los textos dependiendo de si es modificación o nuevo registro
            string mensajePregunta = esModificacion ? "¿Confirma la modificación del producto: " : "Confirma el registro del producto: ";
            string tituloPregunta = esModificacion ? "¿Confirma modificación?" : "¿Confirma guardado?";
            string mensajeExito = esModificacion ? "Producto modificado correctamente." : "Producto registrado correctamente.";

            // 5. Usamos las variables en los MessageBox
            DialogResult confirmacion = MessageBox.Show(
                mensajePregunta + textNombre.Text + "?",
                tituloPregunta,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                MessageBox.Show(mensajeExito, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            */
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            if (esDetalle)
            {
                this.Close();
                return; // Corta la ejecución para que no salga el MessageBox
            }

            DialogResult Respuesta = MessageBox.Show(
                "¿Está seguro de que desea cancelar?, Se perderan los datos no guardados.",
                "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if(Respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void ConfigurarModoEdicion(string codigo, string nombre, string categoria, string genero, string precio, string stock, string stockMinimo, string descripcion, string proveedor)
        {
            this.esModificacion = true;
            this.Text = "Modificar Producto";
            LTitulo.Text = "Modificar Producto";
            BCrearProducto.Text = "Guardar Cambios";

            // 1. Campos HABILITADOS para modificar
            textNombre.Text = nombre;
            textStockMinimo.Text = stockMinimo; // Asegurate de tener este TextBox creado
            textDescripcion.Text = descripcion; // Asegurate de tener este TextBox creado
            cmbProveedor.Text = proveedor;
            // 2. Campos BLOQUEADOS (se ven pero no se editan)
            cmbCategoria.Text = categoria;
            cmbCategoria.Enabled = false;

            combGenero.Text = genero;
            combGenero.Enabled = false;

            textPrecio.Text = precio;
            textPrecio.Enabled = false;

            textStockInicial.Text = stock;
            textStockInicial.Enabled = false;
        }

        public void ConfigurarModoDetalle(string codigo, string nombre, string categoria, string genero, string precio, string stock, string stockMinimo, string descripcion, string proveedor)
        {
            esDetalle = true;
            this.Text = "Detalle Producto";
            LTitulo.Text = "Detalle Producto";
            BCrearProducto.Visible = false; // Ocultamos el botón de guardar
            BCancelar.Text = "Cerrar"; // Cambiamos el texto del botón

            // Cargamos los datos
            textNombre.Text = nombre;
            cmbCategoria.Text = categoria;
            combGenero.Text = genero;
            textPrecio.Text = precio;
            textStockInicial.Text = stock;
            textStockMinimo.Text = stockMinimo;
            textDescripcion.Text = descripcion;
            cmbProveedor.Text = proveedor;

            // Bloqueamos todos los controles
            textNombre.Enabled = false;
            cmbCategoria.Enabled = false;
            combGenero.Enabled = false;
            textPrecio.Enabled = false;
            textStockInicial.Enabled = false;
            textStockMinimo.Enabled = false;
            textDescripcion.Enabled = false;
            cmbProveedor.Enabled = false;
        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

