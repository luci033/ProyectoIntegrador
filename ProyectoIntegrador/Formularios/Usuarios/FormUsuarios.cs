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
                        formCrear.Usuario,
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

            /*
            dataGridRegistroUsuario.Rows.Add(1, "12345678", "Juan", "Pérez", "jperez", "Administrador");
            dataGridRegistroUsuario.Rows.Add(2, "23456789", "Ana", "Gómez", "agomez", "Vendedor");
            dataGridRegistroUsuario.Rows.Add(3, "34567890", "Carlos", "Ruiz", "cruiz", "Logística");
            dataGridRegistroUsuario.Rows.Add(4, "45678901", "María", "López", "mlopez", "Vendedor");
            dataGridRegistroUsuario.Rows.Add(5, "56789012", "Luis", "Sosa", "lsosa", "Administrador");

            */

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
                    fila.Visible = fila.Cells["colEstado"].Value.ToString() == estadoSeleccionado;
                }
            }
        }

        private void dataGridRegistroUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
      
            // 1. Escudo para evitar errores si tocan los títulos de las columnas
            if (e.RowIndex < 0) return;

            // 2. Averiguamos qué botón tocó el usuario
            string nombreColumna = dataGridRegistroUsuario.Columns[e.ColumnIndex].Name;

            // Atrapamos el DNI (Columna 1) para usarlo tanto al modificar como al desactivar
            string dni = Convert.ToString(dataGridRegistroUsuario.Rows[e.RowIndex].Cells[1].Value);

            // Escudo: Si el DNI está vacío, hicieron clic en la fila en blanco del final
            if (string.IsNullOrWhiteSpace(dni)) return;

            // --- ACCIÓN: BOTÓN MODIFICAR ---
            if (nombreColumna == "colModificar")
            {
                // Leemos los datos exactos según el orden de tu código
                string nombre = Convert.ToString(dataGridRegistroUsuario.Rows[e.RowIndex].Cells[2].Value);
                string apellido = Convert.ToString(dataGridRegistroUsuario.Rows[e.RowIndex].Cells[3].Value);
                string nombreUsuario = Convert.ToString(dataGridRegistroUsuario.Rows[e.RowIndex].Cells[4].Value);
                string rol = Convert.ToString(dataGridRegistroUsuario.Rows[e.RowIndex].Cells[5].Value);

                FormUsuarioABM modalABM = new FormUsuarioABM();
                modalABM.ConfigurarModoEdicion(dni, nombre, apellido, nombreUsuario, rol);

                if (modalABM.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: Acá irá la actualización (UPDATE) a la base de datos
                }
            }

            // --- ACCIÓN: BOTÓN DESACTIVAR (BAJA LÓGICA) ---
            else if (nombreColumna == "colDesactivar")
            {
                // Atrapamos el nombre de usuario (Columna 4) para hacerlo más personalizado
                string nombreUsuario = Convert.ToString(dataGridRegistroUsuario.Rows[e.RowIndex].Cells[4].Value);

                DialogResult respuesta = MessageBox.Show($"¿Seguro que deseas desactivar al usuario '{nombreUsuario}' con DNI {dni}?", "Confirmar Baja Lógica", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    // Aplicamos la baja lógica visual: pintamos la fila de gris
                    DataGridViewRow fila = dataGridRegistroUsuario.Rows[e.RowIndex];
                    fila.DefaultCellStyle.BackColor = Color.LightGray;
                    fila.DefaultCellStyle.ForeColor = Color.DimGray;

                    MessageBox.Show("Usuario desactivado. (Baja lógica aplicada con éxito)", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: Acá irá el UPDATE a la base de datos para cambiar el estado a Inactivo
                }
            }
        }
    }
    
}
