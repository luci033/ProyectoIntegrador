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

namespace ProyectoIntegrador.Formularios.Productos
{
    public partial class FormNuevaCategoria : Form
    {
        private int idCategoria = 0;
        private bool esModificacion = false;

        public FormNuevaCategoria()
        {
            InitializeComponent();
        }

        public FormNuevaCategoria(int idCategoria, string categoriaActual)
        {
            InitializeComponent();
            this.idCategoria = idCategoria;
            this.esModificacion = true;
            TNuevaCategoria.Text = categoriaActual;
            this.Text = "Modificar Categoría";
            this.LTitulo.Text = "Modificar Categoría";
            this.BGuardar.Text = "Guardar Cambios";
        }

        public FormNuevaCategoria(string categoriaActual) : this(0, categoriaActual)
        {
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
            // Verifica que contenga solo letras y espacios en blanco
            if (string.IsNullOrWhiteSpace(TNuevaCategoria.Text) || !TNuevaCategoria.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                e.Cancel = true;
                errorProvider1.SetError(TNuevaCategoria, "El campo solo debe contener letras.");
            }
            else
            {
                errorProvider1.SetError(TNuevaCategoria, "");
            }
        }

        public string CategoriaNueva { get; private set; }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string nombreIngresado = TNuevaCategoria.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreIngresado) || !nombreIngresado.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Por favor, ingrese un nombre de categoría válido (solo letras).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria categoriaObj = new Categoria()
            {
                IdCategoria = this.idCategoria,
                NombreCategoria = nombreIngresado
            };

            CN_Categoria negocio = new CN_Categoria();
            bool resultado = false;
            string mensaje = string.Empty;

            if (esModificacion)
            {
                resultado = negocio.Editar(categoriaObj, out mensaje);
            }
            else
            {
                resultado = negocio.Registrar(categoriaObj, out mensaje);
            }

            if (resultado)
            {
                CategoriaNueva = nombreIngresado;
                string mensajeExito = esModificacion ? "Categoría modificada exitosamente." : "Categoría registrada exitosamente.";
                MessageBox.Show(mensajeExito, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            TNuevaCategoria.Clear();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
