using CapaNegocio;
using CapaEntidades; 
using ProyectoIntegrador.Formularios.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Usuarios
{
    public partial class FormLogin : Form
    {
        //Es necesario?
        public string RolUsuario { get; set; } = "";
        public string NombreUsuarioLogueado { get; set; } = ""; // se hace esto para capturar el usuario logueado y mostrarlo en el dashboard

        public FormLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloCard(panelCard, 16);
            EstiloUI.AplicarEstiloBoton(BLogin);
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void FormLogin_Resize(object sender, EventArgs e)
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void TBUsuario_Enter(object sender, EventArgs e)
        {
            if (TBUsuario.Text == "Usuario")
            {
                TBUsuario.Text = "";
                TBUsuario.ForeColor = Color.Black;
            }
        }

        private void TBUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBUsuario.Text))
            {
                TBUsuario.Text = "Usuario";
                TBUsuario.ForeColor = Color.Gray;
            }
        }

        private void TBContrasena_Enter(object sender, EventArgs e)
        {
            if (TBContrasena.Text == "Contraseña")
            {
                TBContrasena.Text = "";
                TBContrasena.ForeColor = Color.Black;
            }
        }

        private void TBContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBContrasena.Text))
            {
                TBContrasena.Text = "Contraseña";
                TBContrasena.ForeColor = Color.Gray;
            }
        }

        private void BVerContraena_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TBUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBUsuario_Validating(object sender, CancelEventArgs e)
        {
            // 1. Ignorar si está vacío o tiene la marca de agua
            if (string.IsNullOrWhiteSpace(TBUsuario.Text) || TBUsuario.Text == "Usuario")
            {
                errorProvider1.SetError(TBUsuario, "");
                return;
            }

            // 2. Validar formato si contiene texto
            if (!TBUsuario.Text.All(char.IsLetterOrDigit))
            {
                errorProvider1.SetError(TBUsuario, "Ingrese un usuario válido (letras y números).");
            }
            else
            {
                errorProvider1.SetError(TBUsuario, "");
            }
        }

        private void TBContrasena_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(TBContrasena, "");
        }

        private void BVerContraena_Click_1(object sender, EventArgs e)
        {

        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            
            string usuario = TBUsuario.Text.Trim();
            string clave = TBContrasena.Text.Trim();
            string mensajeError = string.Empty;

            // se valida que no haya campos vacios
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //se llama a la capa de negocio para ppreguntar a la base de datos
            CN_Usuario negocio = new CN_Usuario();
            Usuario usuarioLogueado = negocio.Login(usuario, clave, out mensajeError);

            //se comprueba si las credenciales son correctas (si encontro al usuario)
            if (usuarioLogueado != null)
            {
                //se evalua el numero de tol que se trajo de la bd
                if (usuarioLogueado.IdRol == 1)
                {
                    RolUsuario = "Administrador";
                }
                else if (usuarioLogueado.IdRol == 2)
                {
                    RolUsuario = "Gerente";
                }
                else if (usuarioLogueado.IdRol == 3)
                {
                    RolUsuario = "Vendedor";
                }
                else if (usuarioLogueado.IdRol == 4) 
                {
                    RolUsuario = "Logistica"; 
                }

                // Guardamos el nombre que vino de la base de datos 
                // (Fijate si en tu entidad se llama .Nombre o .NombreUsuario)
                NombreUsuarioLogueado = usuarioLogueado.NombreUsuario;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //en caso de que no coincida o la contraseña este mal
                string errorMostrar = string.IsNullOrEmpty(mensajeError) ? "Usuario o contraseña incorrectos." : mensajeError;
                MessageBox.Show(errorMostrar, "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                TBContrasena.Clear();
                TBContrasena.Focus();
            }
            

            /*
            string usuario = TBUsuario.Text.Trim();
            string clave = TBContrasena.Text.Trim();

            // se valida que no haya campos vacios
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // comprobamos las credenciales y abrimos la pantalla correspondiente
            if (usuario == "admin" && clave == "1234")
            {
                // Abre el formulario del Administrador
                RolUsuario = "Administrador";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (usuario == "vendedor" && clave == "1234")
            {
                // Abre el formulario del Vendedor
                RolUsuario = "Vendedor";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (usuario == "logistica" && clave == "1234")
            {
                // Abre el formulario de Logística
                RolUsuario = "Logistica";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (usuario == "gerente" && clave == "1234")
            {
                // Abre el formulario de Gerente
                RolUsuario = "Gerente";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Si no coincide con ninguno
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBContrasena.Clear();
                TBContrasena.Focus();
            }
            */
        }
    }
}


            
        
        
     

