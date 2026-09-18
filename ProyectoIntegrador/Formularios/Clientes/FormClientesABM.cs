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
        public FormClientesABM()
        {
            InitializeComponent();
        }

        private void FormClientesABM_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            // validacion para los campos vacios
            if (string.IsNullOrWhiteSpace(TBNombre.Text) ||
                string.IsNullOrWhiteSpace(TBApellido.Text) ||
                string.IsNullOrWhiteSpace(TBDni.Text) ||
                string.IsNullOrWhiteSpace(TBTelefono.Text) ||
                string.IsNullOrWhiteSpace(TBCorreo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // validacion del IVA
            // Si el SelectedIndex es -1, significa que se eligio nada de la lista desplegable
            if (cmbCondicionIVA.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Condición frente al IVA.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(TBDni.Text.Trim(), out _) || TBDni.Text.Trim().Length < 7)
            {
                MessageBox.Show("El DNI debe contener solo números y tener al menos 7 dígitos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBDni.Focus();
                return false;
            }

            if (!long.TryParse(TBTelefono.Text.Trim(), out _))
            {
                MessageBox.Show("El teléfono debe contener solo números, sin guiones ni espacios.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBTelefono.Focus();
                return false;
            }
            
            if (!TBCorreo.Text.Contains("@") || !TBCorreo.Text.Contains("."))
            {
                MessageBox.Show("Ingrese un correo electrónico válido (debe contener '@' y un punto).", "Error en Correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBCorreo.Focus();
                return false;
            }

            //si paso todas las validaciones sin devolver 'false', sigue
            return true;
        }

        private void BRegistrarCliente_Click(object sender, EventArgs e)
        {
          
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                // Verifica el ComboBox manualmente porque no suele usar el evento Validating
                if (cmbCondicionIVA.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione una Condición frente al IVA.", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // si todo estta bien muestra este mensaje
                MessageBox.Show("¡Cliente validado y listo para guardar en la Base de Datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Aquí llamaremos a  CN_Cliente...  REVISAR
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Revise los campos marcados en rojo.", "Errores en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
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
