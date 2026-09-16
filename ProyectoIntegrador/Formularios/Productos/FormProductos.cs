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
    public partial class FormProductos : Form
    {

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloGrilla(dataGridCatalogoProd);

            combCategoriaForm.Items.Clear();
            combCategoriaForm.Items.AddRange(new string[] { "Anillos", "Collares", "Pulseras", "Aros", "Relojes" });
            combCategoriaForm.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            // 1. se instancia la ventana de carga de productos
            FormProductoABM ventanaABM = new FormProductoABM();

            // 2. La mostramos en modo modal (bloquea la ventana de atrás hasta que se cierre)
            ventanaABM.ShowDialog();

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
