using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class FormProductoABM : Form
    {
        public string Codigo => textCodigo.Text.Trim();
        public string Nombre => textNombre.Text.Trim();
        //public string ImagenRuta => textImagen.ImageLocation ?? ""; // O la variable donde guardes la ruta de la foto
        public string Categoria => cmbCategoria.Text.Trim();
        public string Genero => combGenero.Text.Trim();
        public string Precio => textPrecio.Text.Trim();
        public string Stock=> textStockInicial.Text.Trim();
    
        public FormProductoABM()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.AddRange(new string[] {"Anillos", "Collares", "Pulseras", "Aros", "Relojes"});

            combGenero.Items.Clear();
            combGenero.Items.AddRange(new string[] { "Femenino", "Masculino"});

            cmbCategoria.SelectedIndex = -1;
            combGenero.SelectedIndex = -1;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

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
            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría para el producto.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            // 3. valida codigo de prod
            if (string.IsNullOrWhiteSpace(textCodigo.Text))
            {
                MessageBox.Show("Ingrese el código del producto.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCodigo.Focus();
                return false;
            }

            // 4. valida el genero
            if (combGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el género correspondiente.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combGenero.Focus();
                return false;
            }

            // 5. valida precio uni
            if (!decimal.TryParse(textPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio unitario debe ser un número válido mayor a 0.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPrecio.Focus();
                textPrecio.SelectAll();
                return false;
            }

            // 6. valida stock iniciañ
            if (!int.TryParse(textStockInicial.Text, out int stockIni) || stockIni < 0)
            {
                MessageBox.Show("El stock inicial debe ser un número entero (0 o mayor).", "Stock Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textStockInicial.Focus();
                textStockInicial.SelectAll();
                return false;
            }

            // 7. valida stock minimo
            if (!int.TryParse(textStockMinimo.Text, out int stockMin) || stockMin < 0)
            {
                MessageBox.Show("El stock mínimo debe ser un número entero (0 o mayor).", "Stock Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textStockMinimo.Focus();
                textStockMinimo.SelectAll();
                return false;
            }

            return true; // s todo es correcto, retorna verdadero
        }

        private void cobGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BCrearProducto_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "Confirma el registro del producto: " + textNombre.Text + "?",
                "¿Confirma guardado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(confirmacion == DialogResult.Yes)
            {
                MessageBox.Show("Producto registrado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show(
                "¿Está seguro de que desea cancelar?, Se perderan los datos no guardados.",
                "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if(Respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pbImagenProducto_Click(object sender, EventArgs e)
        {

        }
    }
}

