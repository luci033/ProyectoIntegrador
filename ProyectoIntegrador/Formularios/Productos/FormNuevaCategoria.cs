using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Productos
{
    public partial class FormNuevaCategoria : Form
    {
        public FormNuevaCategoria()
        {
            InitializeComponent();
        }

        public FormNuevaCategoria(string categoriaActual)
        {
            InitializeComponent();
            TNuevaCategoria.Text = categoriaActual; // carga el string de la categoria actual 
            this.Text = "Modificar Categoría"; // cambia el título de la ventana
            this.LTitulo.Text = "Modificar Categoria";
        }

        private void FormNuevaCategoria_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloCard(panelCard, 16);
            EstiloUI.AplicarEstiloBoton(BGuardar);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);
            EstiloUI.AplicarEstiloTextBox(TNuevaCategoria);
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void FormNuevaCategoria_Resize(object sender, EventArgs e)
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void LCategorias_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCategoria_Validating(object sender, CancelEventArgs e)
        {
            // Verifica si cada caracter es distinto a letra o espacio en blanco
            if (string.IsNullOrWhiteSpace(TNuevaCategoria.Text) || !TNuevaCategoria.Text.All(c => char.IsLetter(c)))
            {
                e.Cancel = true;
                errorProvider1.SetError(TNuevaCategoria, "El campo solo debe contener letras.");
            }
            else
            {
                errorProvider1.SetError(TNuevaCategoria, "");
            }
        }

        // creo una propiedad publica de lectura pero solo el formulario nueva categoría lo puede modificar
        public string CategoriaNueva { get; private set; }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            CategoriaNueva = TNuevaCategoria.Text;
            this.DialogResult = DialogResult.OK; // si está todo Ok se cierra el formulario
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            TNuevaCategoria.Clear(); //limpiamos el textbox donde se carga la categoría
            this.DialogResult = DialogResult.Cancel; // se cancela todo, eso devolvemos
            this.Close(); // cerramos el formulario
        }
    }
}
