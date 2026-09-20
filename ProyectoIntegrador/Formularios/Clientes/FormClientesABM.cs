using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Clientes
{
    public partial class FormClientesABM : Form
    {
        public ClienteSimulado ClienteCreado { get; private set; }
        public List<string> DnisExistentes = new List<string>();
        private string dniOriginal = "";
        public FormClientesABM()
        {
            InitializeComponent();
        }

        public class ClienteSimulado
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string DNI { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string CondicionIVA { get; set; }
        }

        private void FormClientesABM_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BCancelar);
            EstiloUI.AplicarEstiloBoton(BRegistrarCliente);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BRegistrarCliente_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(TBNombre.Text) || !TBNombre.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            { errorProvider1.SetError(TBNombre, "Inválido"); esValido = false; }

            if (string.IsNullOrWhiteSpace(TBApellido.Text) || !TBApellido.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            { errorProvider1.SetError(TBApellido, "Inválido"); esValido = false; }

            if (string.IsNullOrWhiteSpace(TBDni.Text) || !TBDni.Text.All(char.IsDigit) || TBDni.Text.Length < 7)
            { errorProvider1.SetError(TBDni, "Inválido"); esValido = false; }

            // 2. Validación de Teléfono (solo números)
            if (string.IsNullOrWhiteSpace(TBTelefono.Text) || !TBTelefono.Text.All(char.IsDigit))
            { errorProvider1.SetError(TBTelefono, "Solo números"); esValido = false; }

            if (!string.IsNullOrWhiteSpace(TBCorreo.Text))
            {
                try { new MailAddress(TBCorreo.Text); }
                catch { errorProvider1.SetError(TBCorreo, "Inválido"); esValido = false; }

                if (cmbCondicionIVA.SelectedIndex == -1)
                { errorProvider1.SetError(cmbCondicionIVA, "Seleccione IVA"); esValido = false; }

                if (!esValido)
                {
                    MessageBox.Show("Revise los campos en rojo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validación de DNI duplicado
                if (DnisExistentes.Contains(TBDni.Text) && TBDni.Text != dniOriginal)
                {
                    MessageBox.Show("Ese DNI ya se encuentra registrado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClienteCreado = new ClienteSimulado
                {
                    Nombre = TBNombre.Text,
                    Apellido = TBApellido.Text,
                    DNI = TBDni.Text,
                    Telefono = TBTelefono.Text,
                    Correo = TBCorreo.Text,
                    CondicionIVA = cmbCondicionIVA.Text
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable; // Apaga la validación forzada
            this.Close();
        }

        private void TBNombre_Validating(object sender, CancelEventArgs e)
        {
            string nombre = TBNombre.Text.Trim();

            // verifica si esta vacio
            if (string.IsNullOrWhiteSpace(nombre))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBNombre, "El nombre es obligatorio.");
            }
           
            // verifica que cada carácter sea una letra o un espacio en blanco
            else if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBNombre, "El nombre solo puede contener letras.");
            }
            else
            {
                //si todo esta bien
                e.Cancel = false;
                errorProvider1.SetError(TBNombre, "");
            }
        }

        public void ConfigurarModoEdicion(string nombre, string apellido, string dni, string telefono, string correo, string condicionIVA)
        {
            this.Text = "Modificar Cliente";
            LTitulo.Text = "Modificar Cliente";
            BRegistrarCliente.Text = "Modificar";

            TBNombre.Text = nombre;
            TBApellido.Text = apellido;
            TBDni.Text = dni;
            TBTelefono.Text = telefono;
            TBCorreo.Text = correo;
            cmbCondicionIVA.Text = condicionIVA;
            // Guardamos el DNI original para compararlo luego
            dniOriginal = dni;
        }

        public void ConfigurarModoDetalle(string nombre, string apellido, string dni, string telefono, string correo, string condicionIVA)
        {
            this.Text = "Detalle Cliente";
            LTitulo.Text = "Detalle Cliente";

            TBNombre.Text = nombre;
            TBApellido.Text = apellido;
            TBDni.Text = dni;
            TBTelefono.Text = telefono;
            TBCorreo.Text = correo;
            cmbCondicionIVA.Text = condicionIVA;

            // Bloquear controles
            TBNombre.ReadOnly = true;
            TBApellido.ReadOnly = true;
            TBDni.ReadOnly = true;
            TBTelefono.ReadOnly = true;
            TBCorreo.ReadOnly = true;
            cmbCondicionIVA.Enabled = false;

            // Ajustar botones
            BRegistrarCliente.Visible = false;
            BCancelar.Text = "Cerrar";
        }

        private void TBApellido_Validating(object sender, CancelEventArgs e)
        {
            string apellido = TBApellido.Text.Trim();

            if (string.IsNullOrWhiteSpace(apellido))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBApellido, "El apellido es obligatorio.");
            }
            else if (!apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                e.Cancel = true;
                errorProvider1.SetError(TBApellido, "El apellido solo puede contener letras.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TBApellido, "");
            }
        }

        private void TBDni_Validating(object sender, CancelEventArgs e)
        {
            string dni = TBDni.Text.Trim();
            // se verifica que no este vacio, que solo contenga numeros de menos de 7 dijistos
            if (string.IsNullOrWhiteSpace(dni) || !int.TryParse(dni, out _) || dni.Length < 7)
            {
                e.Cancel = true;
                errorProvider1.SetError(TBDni, "Ingrese un DNI válido (solo números, mínimo 7 dígitos).");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TBDni, "");
            }
        }

        private void TBCorreo_Validating(object sender, CancelEventArgs e)
        {
            string email = TBCorreo.Text.Trim();

            //En caso de que el correo sea obligatorio REVISAR
            if (string.IsNullOrWhiteSpace(email))
            {
                e.Cancel = false;
                errorProvider1.SetError(TBCorreo, "");
                return;
            }

            try
            {

                MailAddress m = new MailAddress(email);
                e.Cancel = false;
                errorProvider1.SetError(TBCorreo, "");
            }
            catch (FormatException)
            {
                e.Cancel = true;
                errorProvider1.SetError(TBCorreo, "El formato del correo no es válido (ej: nombre@dominio.com).");
            }
        }
    }
}
