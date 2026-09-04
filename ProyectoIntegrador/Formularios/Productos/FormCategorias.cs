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
                DGCategoria.Rows.Add(nuevoId, frmNuevaCategoria.CategoriaNueva);
            }
        }

        private void DGCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string NombreColumna = DGCategoria.Columns[e.ColumnIndex].Name;

            if (NombreColumna == "CategoriaDesactivar") 
            {
                DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea desactivar esta categoría?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
                if (respuesta == DialogResult.Yes)
                {
                    DGCategoria.Rows.RemoveAt(e.RowIndex);
                }
                
            }

            else if (NombreColumna == "CategoriaModificar")
            {
                // tomamos el dato del nombre de la categoría
                string categoriaActual = DGCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();

                // abre el formulario nueva categoria pasándole el texto
                FormNuevaCategoria frm = new FormNuevaCategoria(categoriaActual);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // si recibe un OK reescribe el valor 
                    DGCategoria.Rows[e.RowIndex].Cells[1].Value = frm.CategoriaNueva;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
