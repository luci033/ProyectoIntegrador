using CapaEntidades;
using CapaNegocio;
using ProyectoIntegrador.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoIntegrador
{
    public partial class FormUsuarioABM : Form
    {
        // Propiedades públicas para transferir el usuario nuevo al formulario principal
        public string Nombre => TBNombre.Text.Trim();
        public string Apellido => TBApellido.Text.Trim();
        public string Dni => TBDni.Text.Trim();
        public string Correo => TBCorreo.Text.Trim();
        //public string nombreUsuario => 
        public string Rol => CBRol.Text;
        //public string Rol => CBRol.SelectedItem?.ToString() ?? "";

        public FormUsuarioABM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void TBNombre_Validating(object sender, CancelEventArgs e)
        {
            string nombre = TBNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider1.SetError(TBNombre, "El nombre es obligatorio.");
                return;
            }

            // Valida solo letras (incluye acentos y ñ) y espacios
            if (!Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(TBNombre, "El nombre solo puede contener letras.");
                return;
            }

            errorProvider1.SetError(TBNombre, "");
        }

        private void BCrearUsuario_Click(object sender, EventArgs e)
        {
            //  se hacen las validaciones
            if (!this.ValidateChildren()) return;

            // validacion de campos vacios
            if (string.IsNullOrWhiteSpace(TBNombre.Text) || string.IsNullOrWhiteSpace(TBApellido.Text))
            {
                MessageBox.Show("Debe completar Nombre y Apellido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //se valida la seleccion del rol
            if (CBRol.SelectedIndex == -1)
            {
                errorProvider1.SetError(CBRol, "Debe seleccionar un rol para el usuario.");
                MessageBox.Show("Por favor, seleccione un rol del desplegable.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            errorProvider1.SetError(CBRol, "");

            // se comprueba si quedo algun error pendiente en el ErrorProvider
            if (!string.IsNullOrEmpty(errorProvider1.GetError(TBNombre)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBApellido)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBDni)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBCorreo)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBContraseña)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBContraseñaRepetir)))
            {
                MessageBox.Show("Por favor corrija los campos marcados con error.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // se mapea los el texto del ComboBox al ID de rol correspondiente en tu base de datos
            int idRolSeleccionado = 1;
            string rolTexto = CBRol.Text.Trim();

            if (rolTexto == "Administrador")
            {
                idRolSeleccionado = 1;
            }
            else if (rolTexto == "Vendedor")
            {
                idRolSeleccionado = 2;
            }
            else if (rolTexto == "Logistica" || rolTexto == "Logística")
            {
                idRolSeleccionado = 3;
            }

            // 5. Instanciar Entidad y Capa de Negocio
            Usuario nuevoUsuario = new Usuario()
            {
                User = TBDni.Text.Trim(), // O el campo de usuario que uses
                NombreUsuario = TBNombre.Text.Trim(),
                ApellidoUsuario = TBApellido.Text.Trim(),
                Contrasena = TBContraseña.Text.Trim(),
                //Correo = TBCorreo.Text.Trim(),
                IdRol = idRolSeleccionado
            };

            //DESCOMENTAR DESPUES DE HACER LA CONEXION CON LA BD
            /*
            CN_Usuario negocioUsuario = new CN_Usuario();
            string mensaje;

            negocioUsuario.Registrar(nuevoUsuario, out mensaje);
            
            // 6. Evaluar respuesta de la Base de Datos
            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
            MessageBox.Show("Usuario registrado con éxito (Modo diseño).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BBuscarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Seleccionar foto de perfil";
                dialog.Filter = "Imágenes (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxUsuario.Image = System.Drawing.Image.FromFile(dialog.FileName);
                }
            }
        }

        private void TBDni_Validating(object sender, CancelEventArgs e)
        {
            string dni = TBDni.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                errorProvider1.SetError(TBDni, "El DNI es obligatorio.");
                return;
            }

            if (dni.Length < 7 || dni.Length > 8 || !long.TryParse(dni, out _))
            {
                errorProvider1.SetError(TBDni, "El DNI debe tener 7 u 8 números.");
                return;
            }

            errorProvider1.SetError(TBDni, "");
        }

        private void TBCorreo_Validating(object sender, CancelEventArgs e)
        {
            string email = TBCorreo.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(TBCorreo, "El correo electrónico es obligatorio.");
                return;
            }

            // expesion regular estandar para comprobar formato x@x.com
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, patron))
            {
                errorProvider1.SetError(TBCorreo, "Ingrese un correo electrónico válido (ej: usuario@mail.com).");
                return;
            }

            errorProvider1.SetError(TBCorreo, "");
        }

        private void TBContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (TBContraseña.Text.Length < 4)
            {
                errorProvider1.SetError(TBContraseña, "La contraseña debe tener al menos 4 caracteres.");
                return;
            }

            errorProvider1.SetError(TBContraseña, "");
        }

        private void TBContraseñaRepetir_Validating(object sender, CancelEventArgs e)
        {
            if (TBContraseñaRepetir.Text != TBContraseña.Text)
            {
                errorProvider1.SetError(TBContraseñaRepetir, "Las contraseñas no coinciden.");
                return;
            }

            errorProvider1.SetError(TBContraseñaRepetir, "");
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TBApellido_Validating(object sender, CancelEventArgs e)
        {
            string apellido = TBApellido.Text.Trim();

            if (string.IsNullOrEmpty(apellido))
            {
                errorProvider1.SetError(TBApellido, "El apellido es obligatorio.");
                return;
            }

            if (!Regex.IsMatch(apellido, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(TBApellido, "El apellido solo puede contener letras.");
                return;
            }

            errorProvider1.SetError(TBApellido, "");
        }
    }
}
