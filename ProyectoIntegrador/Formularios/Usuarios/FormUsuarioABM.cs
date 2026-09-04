using ProyectoIntegrador.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoIntegrador
{
    public partial class FormUsuarioABM : Form
    {
        public FormUsuarioABM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LDNI_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Armar el objeto con los datos de los TextBox
            Usuario nuevoUsuario = new Usuario()
            {
                User = " ", // Propiedad corregida
                NombreUsuario = TBNombre.Text,
                ApellidoUsuario = TBApellido.Text,
                Contrasena = TBContraseña.Text,
                // Asume que el ID del rol viene del valor seleccionado de un ComboBox
                IdRol = Convert.ToInt32(CBRol.SelectedValue)
            };

            // 2. Instanciar la lógica de negocio y preparar el mensaje
            CN_Usuario negocioUsuario = new CN_Usuario();
            string mensaje;

            // 3. Ejecutar el registro
            negocioUsuario.Registrar(nuevoUsuario, out mensaje);

            // 4. Mostrar resultados según las validaciones
            if (mensaje == string.Empty)
            {
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Acá podés agregar un método para limpiar los campos
            }
            else
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNombre_Validating(object sender, CancelEventArgs e)
        {

        }

        private void BCrearUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
