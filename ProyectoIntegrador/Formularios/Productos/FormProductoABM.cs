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
        public string Genero => combGenero.Text.Trim(); // Revisá si le pusiste comGenero o combGenero
        public string Precio => textPrecio.Text.Trim();
        public string Stock => textStockInicial.Text.Trim();
        public string StockMinimo => textStockMinimo.Text.Trim(); // <- Agregá esta línea
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
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BCancelar);
            EstiloUI.AplicarEstiloBoton(BCrearProducto);
            EstiloUI.AplicarEstiloFormulario(this);
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.AddRange(new string[] {"Anillos", "Collares", "Pulseras", "Aros", "Relojes"});
            cmbProveedor.Items.AddRange(new string[] { "Joyas del Norte", "Distribuidora Oro S.A.", "Gemas y Piedras", "Importadora Rubi", "Platería Central" });
            textPrecio.Text = "0.01";
            textStockInicial.Text = "1";


            combGenero.Items.Clear();
            combGenero.Items.AddRange(new string[] { "Femenino", "Masculino"});

            cmbProveedor.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            combGenero.SelectedIndex = -1;
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

                // 5. valida precio uni
                if (esModificacion == false)
            {
                if (!decimal.TryParse(textPrecio.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("El precio unitario debe ser un número válido mayor a 0.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textPrecio.Focus();
                    textPrecio.SelectAll();
                    return false;
                }
            }

            // 6. valida stock iniciañ
            if (esModificacion == false)
            {
                if (!int.TryParse(textStockInicial.Text, out int stockIni) || stockIni < 0)
                {
                    MessageBox.Show("El stock inicial debe ser un número entero (0 o mayor).", "Stock Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textStockInicial.Focus();
                    textStockInicial.SelectAll();
                    return false;
                }
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

            // 2. Campos BLOQUEADOS (se ven pero no se editan)
            cmbCategoria.Text = categoria;
            cmbCategoria.Enabled = false;

            combGenero.Text = genero;
            combGenero.Enabled = false;

            textPrecio.Text = precio;
            textPrecio.Enabled = false;

            textStockInicial.Text = stock;
            textStockInicial.Enabled = false;

            cmbProveedor.Text = proveedor;
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

