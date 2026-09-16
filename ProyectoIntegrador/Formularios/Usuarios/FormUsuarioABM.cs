using CapaDatos;
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
        public string Correo => TBUsuario.Text.Trim();
        //public string nombreUsuario => 
        public string Rol => CBRol.Text;
        //public string Rol => CBRol.SelectedItem?.ToString() ?? "";

        public FormUsuarioABM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Pedimos los roles a la base de datos
            CD_Rol datosRol = new CD_Rol();
            List<Rol> listaRoles = datosRol.ListarRoles();

            // Le inyectamos la lista al ComboBox
            CBRol.DataSource = listaRoles;

            // Le decimos qué propiedad va a MOSTRAR visualmente al usuario
            CBRol.DisplayMember = "NombreRol";

            // Le decimos qué propiedad va a GUARDAR ocultamente (el ID)
            CBRol.ValueMember = "IdRol";

            // Lo dejamos en blanco para que el usuario tenga que elegir uno sí o sí
            CBRol.SelectedIndex = -1;
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
            // 1. Ejecutar validaciones automáticas de los controles
            if (!this.ValidateChildren()) return;

            // 2. Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(TBNombre.Text) || string.IsNullOrWhiteSpace(TBApellido.Text))
            {
                MessageBox.Show("Debe completar Nombre y Apellido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TBUsuario.Text) || string.IsNullOrWhiteSpace(TBDni.Text))
            {
                MessageBox.Show("Debe completar Usuario y DNI.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validación de coincidencia de contraseñas
            if (TBContraseña.Text != TBContraseñaRepetir.Text)
            {
                errorProvider1.SetError(TBContraseñaRepetir, "Las contraseñas no coinciden.");
                MessageBox.Show("Las contraseñas no coinciden.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            errorProvider1.SetError(TBContraseñaRepetir, "");

            // 4. Validación de selección de rol
            if (CBRol.SelectedIndex == -1)
            {
                errorProvider1.SetError(CBRol, "Debe seleccionar un rol para el usuario.");
                MessageBox.Show("Por favor, seleccione un rol del desplegable.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            errorProvider1.SetError(CBRol, "");

            // 5. Comprobar si quedó algún error pendiente en el ErrorProvider
            if (!string.IsNullOrEmpty(errorProvider1.GetError(TBNombre)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBApellido)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBDni)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBUsuario)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBContraseña)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(TBContraseñaRepetir)))
            {
                MessageBox.Show("Por favor corrija los campos marcados con error.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Atrapamos directamente el ID oculto que configuramos en ValueMember
            int idRolSeleccionado = Convert.ToInt32(CBRol.SelectedValue);

            // 7. Instanciar el objeto (Nos aseguramos que la propiedad sea DNI en mayúscula)
            Usuario nuevoUsuario = new Usuario()
            {
                User = TBUsuario.Text.Trim(),
                NombreUsuario = TBNombre.Text.Trim(),
                ApellidoUsuario = TBApellido.Text.Trim(),
                Dni = TBDni.Text.Trim(),
                Contrasena = TBContraseña.Text.Trim(),
                Foto_Perfil = "",
                IdRol = idRolSeleccionado
            };

            // 8. Llamar directo a Capa de Datos (Cero puentes, como querías)
            CD_Usuario datosUsuario = new CD_Usuario();
            string mensaje;
            bool resultado = datosUsuario.RegistrarUsuario(nuevoUsuario, out mensaje);

            // 9. Evaluar respuesta de la base de datos
            if (resultado)
            {
                MessageBox.Show("Usuario registrado con éxito en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el usuario: " + mensaje, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void LCorreo_Click(object sender, EventArgs e)
        {

        }

        private void TBUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBUsuario_Validating(object sender, CancelEventArgs e)
        {
            // Obtenemos el texto ingresado sin espacios al inicio ni al final
            string usuario = TBUsuario.Text.Trim();

            // 1. Validación de campo obligatorio
            if (string.IsNullOrEmpty(usuario))
            {
                errorProvider1.SetError(TBUsuario, "El nombre de usuario es obligatorio.");
                return;
            }

            // 2. Validación de longitud mínima (mínimo 5 caracteres)
            if (usuario.Length < 5)
            {
                errorProvider1.SetError(TBUsuario, "El usuario debe tener al menos 5 caracteres.");
                return;
            }

            // Si pasó todas las validaciones, limpiamos el ícono de error
            errorProvider1.SetError(TBUsuario, "");
        }
    }
}
