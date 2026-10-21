using CapaEntidades;
using CapaNegocio;
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
            if (this.MdiParent != null)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterParent;
            }
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BAgregarCategoria);
            EstiloUI.AplicarEstiloGrilla(DGCategoria);

            CargarCategorias();
        }

        private void CargarCategorias()
        {
            DGCategoria.Rows.Clear();
            try
            {
                List<Categoria> lista = new CN_Categoria().ListarCategorias();
                foreach (var cat in lista)
                {
                    DGCategoria.Rows.Add(cat.IdCategoria, cat.NombreCategoria, "Modificar");
                }
            }
            catch { }
        }

        private void BAgregarCategoria_Click(object sender, EventArgs e)
        {
            FormNuevaCategoria frmNuevaCategoria = new FormNuevaCategoria(); 
            if (frmNuevaCategoria.ShowDialog() == DialogResult.OK)
            {
                CargarCategorias();
            }
        }

        private void DGCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string NombreColumna = DGCategoria.Columns[e.ColumnIndex].Name;

            if (NombreColumna == "colModificar")
            {
                int idCategoria = Convert.ToInt32(DGCategoria.Rows[e.RowIndex].Cells[0].Value ?? 0);
                string categoriaActual = DGCategoria.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                FormNuevaCategoria frm = new FormNuevaCategoria(idCategoria, categoriaActual);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarCategorias();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
