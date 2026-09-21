using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Productos
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FCategorias_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BAgregarCategoria);
            EstiloUI.AplicarEstiloGrilla(DGCategoria);
            DGCategoria.Rows.Add(1, "Anillos", "Modificar", "Desactivar");
            DGCategoria.Rows.Add(2, "Collares", "Modificar", "Desactivar");
            DGCategoria.Rows.Add(3, "Pulseras", "Modificar", "Desactivar");
        }
        private void BAgregarCategoria_Click(object sender, EventArgs e)
        {

            // se instancia un nuevo formulario de la clase FormNuevaCategoría
            FormNuevaCategoria frmNuevaCategoria = new FormNuevaCategoria(); 


            // Si el formulario de nueva categoría viene con un Ok se agrega la propiedad creada al datagrid
            if (frmNuevaCategoria.ShowDialog() == DialogResult.OK)
            {

                //creamos un id que va contando de 1 en 1
                int nuevoId = DGCategoria.Rows.Count + 1;

                // Agrega el id contador y el nombre de la categoría
                DGCategoria.Rows.Add(nuevoId, frmNuevaCategoria.CategoriaNueva, "Modificar", "Desactivar");
            }
        }

        private void DGCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string NombreColumna = DGCategoria.Columns[e.ColumnIndex].Name;

            if (NombreColumna == "colDesactivar")
            {
                string accionActual = Convert.ToString(DGCategoria.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                if (accionActual == "Desactivar")
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea desactivar esta categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        DGCategoria.Rows[e.RowIndex].DefaultCellStyle.BackColor = EstiloUI.ColorInactivo;
                        DGCategoria.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Activar";
                    }
                }
                else
                {
                    DGCategoria.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    DGCategoria.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Desactivar";
                }
            }
            else if (NombreColumna == "colModificar")
            {
                // Validación para bloquear el botón si la fila está desactivada
                if (Convert.ToString(DGCategoria.Rows[e.RowIndex].Cells["colDesactivar"].Value) == "Activar") return;

                string categoriaActual = DGCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormNuevaCategoria frm = new FormNuevaCategoria(categoriaActual);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DGCategoria.Rows[e.RowIndex].Cells[1].Value = frm.CategoriaNueva;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
