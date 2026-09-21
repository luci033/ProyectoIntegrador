using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProyectoIntegrador.Formularios.Proveedores
{
    public partial class FormProveedorABM : Form
    {
        public FormProveedorABM()
        {
            InitializeComponent();
        }

        // Propiedades para pasar los datos al formulario principal
        public string RazonSocial => TBRazonSocial.Text;
        public string CUIT => TBCUIT.Text;
        public string Telefono => TBTelefono.Text;
        public string Correo => TBCorreo.Text;

        private void BGuardar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            errorProvider1.Clear(); // Limpia errores previos

            // Validar Razón Social
            if (TBRazonSocial.Text.Length < 3 || TBRazonSocial.Text.Length > 25)
            {
                errorProvider1.SetError(TBRazonSocial, "Debe tener entre 3 y 25 caracteres.");
                valido = false;
            }

            // Validar CUIT (Solo 11 números)
            if (!Regex.IsMatch(TBCUIT.Text, @"^\d{11}$"))
            {
                errorProvider1.SetError(TBCUIT, "Debe contener exactamente 11 números.");
                valido = false;
            }

            // Validar Teléfono (Solo 10 números)
            if (!Regex.IsMatch(TBTelefono.Text, @"^\d{10}$"))
            {
                errorProvider1.SetError(TBTelefono, "Debe contener exactamente 10 números.");
                valido = false;
            }

            // Validar Correo
            if (!Regex.IsMatch(TBCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(TBCorreo, "Formato de correo inválido.");
                valido = false;
            }

            // Si todo es correcto, cerramos devolviendo "OK"
            if (valido)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            TBRazonSocial.Clear();
            TBCUIT.Clear();
            TBTelefono.Clear();
            TBCorreo.Clear();
            errorProvider1.Clear();

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormProveedorABM_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BCancelar);
            EstiloUI.AplicarEstiloBoton(BGuardar);
        }

        public void ConfigurarModoEdicion(string razon, string cuit, string tel, string correo)
        {
            this.Text = "Modificar Proveedor"; // Título de la ventana

            LTitulo.Text = "Modificar Proveedor"; 

            TBRazonSocial.Text = razon;
            TBRazonSocial.Enabled = false; // Impide modificar

            TBCUIT.Text = cuit;
            TBCUIT.Enabled = false; // Impide modificar

            TBTelefono.Text = tel;
            TBCorreo.Text = correo;
        }
    }
}
