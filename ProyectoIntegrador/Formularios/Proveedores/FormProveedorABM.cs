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
using CapaEntidades;
using CapaNegocio;

namespace ProyectoIntegrador.Formularios.Proveedores
{
    public partial class FormProveedorABM : Form
    {
        private int idProveedorSeleccionado = 0;
        private bool esModificacion = false;

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
            if (TBRazonSocial.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(TBRazonSocial, "Debe tener entre 3 y 125 caracteres.");
                valido = false;
            }

            // Validar CUIT (Solo 11 números)
            if (!Regex.IsMatch(TBCUIT.Text.Trim(), @"^\d{11}$"))
            {
                errorProvider1.SetError(TBCUIT, "Debe contener exactamente 11 números.");
                valido = false;
            }

            // Validar Teléfono (Solo números, entre 7 y 25 caracteres según la BD)
            if (!Regex.IsMatch(TBTelefono.Text.Trim(), @"^\d{7,25}$"))
            {
                errorProvider1.SetError(TBTelefono, "Debe contener solo números (mínimo 7 dígitos).");
                valido = false;
            }

            // Validar Correo (opcional o con formato válido si no está vacío)
            if (!string.IsNullOrWhiteSpace(TBCorreo.Text) && !Regex.IsMatch(TBCorreo.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(TBCorreo, "Formato de correo inválido.");
                valido = false;
            }

            // Si todo es correcto, guardamos
            if (valido)
            {
                Proveedor prov = new Proveedor()
                {
                    IdProveedor = this.idProveedorSeleccionado,
                    RazonSocial = TBRazonSocial.Text.Trim(),
                    CUIT = TBCUIT.Text.Trim(),
                    Telefono = TBTelefono.Text.Trim(),
                    CorreoElectronico = TBCorreo.Text.Trim()
                };

                CN_Proveedor negocio = new CN_Proveedor();
                bool resultado = false;
                string mensaje = string.Empty;

                if (esModificacion)
                {
                    resultado = negocio.EditarProveedor(prov, out mensaje);
                }
                else
                {
                    resultado = negocio.RegistrarProveedor(prov, out mensaje);
                }

                if (resultado)
                {
                    string mensajeExito = esModificacion ? "Proveedor modificado exitosamente." : "Proveedor registrado exitosamente.";
                    MessageBox.Show(mensajeExito, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloCard(panelCard, 16);
            EstiloUI.AplicarEstiloBoton(BGuardar);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);
            EstiloUI.AplicarEstiloTextBox(TBRazonSocial);
            EstiloUI.AplicarEstiloTextBox(TBCUIT);
            EstiloUI.AplicarEstiloTextBox(TBTelefono);
            EstiloUI.AplicarEstiloTextBox(TBCorreo);
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void FormProveedorABM_Resize(object sender, EventArgs e)
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        public void ConfigurarModoEdicion(int idProveedor, string razon, string cuit, string tel, string correo)
        {
            this.esModificacion = true;
            this.idProveedorSeleccionado = idProveedor;

            this.Text = "Modificar Proveedor";
            LTitulo.Text = "Modificar Proveedor";
            BGuardar.Text = "Guardar Cambios";

            TBRazonSocial.Text = razon;
            TBRazonSocial.Enabled = false;

            TBCUIT.Text = cuit;
            TBCUIT.Enabled = false;

            TBTelefono.Text = tel;
            TBCorreo.Text = correo;
        }

        public void ConfigurarModoEdicion(string razon, string cuit, string tel, string correo)
        {
            ConfigurarModoEdicion(0, razon, cuit, tel, correo);
        }
    }
}
