using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;                // Para que reconozca a CN_Usuario
using CapaEntidades;              // Para que reconozca el objeto Usuario

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
                    MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // aca le decimos a la grilla que se recargue directo desde la base de datos
                    CargarDatosGrilla();
                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BAgregarUsuario);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 12);
            EstiloUI.AplicarEstiloTextBox(TBBuscar);
            EstiloUI.AplicarEstiloGrilla(dataGridRegistroUsuario);

            // 1. Llamamos a la Capa de Negocio para que nos traiga la lista real de SQL
            CN_Usuario negocioUsuario = new CN_Usuario();
            List<Usuario> listaUsuarios = negocioUsuario.Listar();

            // 2. Recorremos la lista y la dibujamos en la grilla
            foreach (Usuario item in listaUsuarios)
            {
                // Como SQL nos devuelve el Rol en números (1, 2), lo traducimos a palabras para que se vea lindo
                string nombreRol = "Desconocido";
                if (item.IdRol == 1) nombreRol = "Administrador";
                else if (item.IdRol == 2) nombreRol = "Vendedor";
                else if (item.IdRol == 3) nombreRol = "Logística";

                // Agregamo la fila a tu DataGridView
                int indiceFila = dataGridRegistroUsuario.Rows.Add(
                    item.IdUsuario,
                    item.Dni,
                    item.NombreUsuario,
                    item.ApellidoUsuario,
                    item.User,
                    nombreRol
                );

                //evaluamos la memoria que trajo la BD
                if(item.Activo == true)
                {
                    dataGridRegistroUsuario.Rows[indiceFila].Cells["colDesactivar"].Value = "Desactivar";

                }
                else
                {
                    // Si está inactivo: texto cambiar a Activar y pintamos de gris
                    dataGridRegistroUsuario.Rows[indiceFila].Cells["colDesactivar"].Value = "Activar";
                    dataGridRegistroUsuario.Rows[indiceFila].DefaultCellStyle.BackColor = Color.LightGray;
                    dataGridRegistroUsuario.Rows[indiceFila].DefaultCellStyle.ForeColor = Color.DimGray;
                }
            }

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

                    CargarDatosGrilla();
                }
            }

            // --- ACCIÓN: BOTÓN DESACTIVAR (BAJA LÓGICA) ---
            else if (nombreColumna == "colDesactivar")
            {
                int idUsuario = Convert.ToInt32(dataGridRegistroUsuario.Rows[e.RowIndex].Cells[0].Value);
                string nombreUsuario = Convert.ToString(dataGridRegistroUsuario.Rows[e.RowIndex].Cells[4].Value);
                DataGridViewRow fila = dataGridRegistroUsuario.Rows[e.RowIndex];

                // Detectamos el estado actual mirando el color de la fila
                bool estaInactivo = fila.DefaultCellStyle.BackColor == Color.LightGray;

                // Preparamos las variables según lo que vayamos a hacer
                string accion = estaInactivo ? "activar" : "desactivar";
                int nuevoEstadoBD = estaInactivo ? 1 : 0; // 1 = Prender, 0 = Apagar

                DialogResult respuesta = MessageBox.Show($"¿Seguro que deseas {accion} al usuario '{nombreUsuario}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    CN_Usuario negocioUsuario = new CN_Usuario();
                    string mensaje = "";
                    bool resultado = negocioUsuario.CambiarEstado(idUsuario, nuevoEstadoBD, out mensaje);

                    if (resultado == true)
                    {
                        if (estaInactivo)
                        {
                            // Lo prendemos: Vuelve a ser blanco y el botón dice "Desactivar"
                            fila.DefaultCellStyle.BackColor = Color.White;
                            fila.DefaultCellStyle.ForeColor = Color.Black;
                            fila.Cells["colDesactivar"].Value = "Desactivar";
                        }
                        else
                        {
                            // Lo apagamos: Se pone gris y el botón dice "Activar"
                            fila.DefaultCellStyle.BackColor = Color.LightGray;
                            fila.DefaultCellStyle.ForeColor = Color.DimGray;
                            fila.Cells["colDesactivar"].Value = "Activar";
                        }

                        MessageBox.Show($"Usuario {accion}do con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void CargarDatosGrilla()
        {
            // Limpiamos la grilla para que no se dupliquen los datos
            dataGridRegistroUsuario.Rows.Clear();

            // Traemos la lista actualizada de la base de datos
            CN_Usuario negocioUsuario = new CN_Usuario();
            List<Usuario> listaUsuarios = negocioUsuario.Listar();

            foreach (Usuario item in listaUsuarios)
            {
                string nombreRol = "Desconocido";
                if (item.IdRol == 1) nombreRol = "Administrador";
                else if (item.IdRol == 2) nombreRol = "Vendedor";
                else if (item.IdRol == 3) nombreRol = "Logística";

                int indiceFila = dataGridRegistroUsuario.Rows.Add(
                    item.IdUsuario,
                    item.Dni,
                    item.NombreUsuario,
                    item.ApellidoUsuario,
                    item.User,
                    nombreRol
                );

                if (item.Activo == true)
                {
                    dataGridRegistroUsuario.Rows[indiceFila].Cells["colDesactivar"].Value = "Desactivar";
                }
                else
                {
                    dataGridRegistroUsuario.Rows[indiceFila].Cells["colDesactivar"].Value = "Activar";
                    dataGridRegistroUsuario.Rows[indiceFila].DefaultCellStyle.BackColor = Color.LightGray;
                    dataGridRegistroUsuario.Rows[indiceFila].DefaultCellStyle.ForeColor = Color.DimGray;
                }
            }
        }
    }
}
    

