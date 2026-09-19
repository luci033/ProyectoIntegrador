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
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BAgregarUsuario);
            // Reemplazá "tuDataGridView" por el nombre que le hayas puesto a tu grilla
            dataGridRegistroUsuario.Rows.Add(1, "12345678", "Juan", "Pérez", "jperez", "Administrador");
            dataGridRegistroUsuario.Rows.Add(2, "23456789", "Ana", "Gómez", "agomez", "Vendedor");
            dataGridRegistroUsuario.Rows.Add(3, "34567890", "Carlos", "Ruiz", "cruiz", "Logística");
            dataGridRegistroUsuario.Rows.Add(4, "45678901", "María", "López", "mlopez", "Vendedor");
            dataGridRegistroUsuario.Rows.Add(5, "56789012", "Luis", "Sosa", "lsosa", "Administrador");

            // Opciones para Rol
            CBRol.Items.AddRange(new string[] { "Todos", "Administrador", "Vendedor", "Logística" });
            CBRol.SelectedIndex = 0; // Deja "Todos" seleccionado por defecto

            // Opciones para Estado
            CBEstado.Items.AddRange(new string[] { "Todos", "Activo", "Inactivo" });
            CBEstado.SelectedIndex = 0;

        }

        private void dataGridRegistroUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            // se atrapa el texto y se lo pasa a minuscula para que no importe si se escribe en mayuscula
            string textoFiltro = TBBuscar.Text.Trim().ToLower();

            // recorremos cada fila de la tabla 
            foreach (DataGridViewRow fila in dataGridRegistroUsuario.Rows)
            {
                // se ignora la fila en blanco que a veces aparece al final
                if (fila.IsNewRow) continue;

                bool contieneTexto = false;

                // revisamos cada celda dentro de esa fila (DNI, Nombre, Usuario...)
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value != null && celda.Value.ToString().ToLower().Contains(textoFiltro))
                    {
                        contieneTexto = true;
                        break; // si ya se encontro coincidencia en esta fila, dejamos de buscar en las demas columnas
                    }
                }

                // si encontro el texto, muestra la fila. si no, la oculta.
                fila.Visible = contieneTexto;
            }
        }

        private void CBRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rolSeleccionado = CBRol.SelectedItem.ToString();

            foreach (DataGridViewRow fila in dataGridRegistroUsuario.Rows)
            {
                if (fila.IsNewRow) continue; // Salta la fila vacía del final

                if (rolSeleccionado == "Todos")
                {
                    fila.Visible = true;
                }
                else
                {
                    // Asumiendo que tu columna se llama "Rol" en el diseño
                    fila.Visible = fila.Cells["colRol"].Value.ToString() == rolSeleccionado;
                }
            }
        }

        private void CBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSeleccionado = CBEstado.SelectedItem.ToString();

            foreach (DataGridViewRow fila in dataGridRegistroUsuario.Rows)
            {
                if (fila.IsNewRow) continue; // Salta la fila vacía del final

                if (estadoSeleccionado == "Todos")
                {
                    fila.Visible = true;
                }
                else
                {
                    // Asumiendo que tu columna se llama "Estado" en el diseño
                    fila.Visible = fila.Cells["colEstado"].Value.ToString() == estadoSeleccionado;
                }
            }
        }
    }
}
