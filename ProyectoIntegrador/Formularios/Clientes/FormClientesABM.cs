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

                ClienteCreado = new ClienteSimulado
                {
                    Nombre = TBNombre.Text,
                    Apellido = TBApellido.Text,
                    DNI = TBDni.Text,
                    Correo = TBCorreo.Text
                };

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

        
        public void ConfigurarModoEdicion(string nombre, string apellido, string dni, string correo)
        {
            this.Text = "Modificar Cliente"; // Cambiamos el título de la ventana

            // Rellenamos las cajas de texto con los datos que nos mandan
            TBNombre.Text = nombre;
            TBApellido.Text = apellido;
            TBDni.Text = dni;
            TBCorreo.Text = correo;

            // Bloqueamos el DNI para que no lo puedan cambiar 
            TBDni.Enabled = false;
        }

        public class ClienteSimulado
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string DNI { get; set; }
            public string Correo { get; set; }
        }
    }
}
