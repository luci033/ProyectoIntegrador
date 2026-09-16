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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void BAgregarUsuario_Click(object sender, EventArgs e)
        {
            using (FormUsuarioABM formCrear = new FormUsuarioABM())
            {
                // Abre el formulario como modal
                if (formCrear.ShowDialog() == DialogResult.OK)
                {
                    // 1. Revisamos si el DNI ya existe en la grilla
                    foreach (DataGridViewRow fila in dataGridRegistroUsuario.Rows)
                    {
                        if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == formCrear.Dni)
                        {
                            MessageBox.Show("Ya existe un usuario registrado con el DNI: " + formCrear.Dni,
                                            "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Frena la ejecución y NO agrega la fila
                        }
                    }

                    //int nuevoId = 1; //temporal hasta hacer la conexion con la BD
                    // Agregamos la nueva fila directamente a la grilla con los datos cargados
                    dataGridRegistroUsuario.Rows.Add(
                        0,
                        formCrear.Dni,
                        formCrear.Nombre,
                        formCrear.Apellido,
                        formCrear.Correo,
                        formCrear.Rol
                    );
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloGrilla(dataGridRegistroUsuario);

        }

        private void dataGridRegistroUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
