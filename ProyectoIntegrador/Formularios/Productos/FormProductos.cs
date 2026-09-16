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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            // 1. se instancia la ventana de carga de productos
            using (FormProductoABM ventanaABM = new FormProductoABM())
            {
                if (ventanaABM.ShowDialog() == DialogResult.OK)
                {

                    //se hace un control de duplicado por codigo antes de insertar
                    foreach (DataGridViewRow fila in dataGridCatalogoProd.Rows)
                    {
                        if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == ventanaABM.Codigo.ToUpper())
                        {
                            MessageBox.Show("Ya existe un producto con el código: " + ventanaABM.Codigo,
                                            "Producto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // para y no agrega el duplicado
                        }
                    }

                    // insercion en el orden de las columnas de la grilla
                    dataGridCatalogoProd.Rows.Add(
                        ventanaABM.Codigo,
                        ventanaABM.Nombre,
                        //ventanaABM.ImagenRuta,
                        ventanaABM.Categoria,
                        ventanaABM.Genero,
                        ventanaABM.Precio,
                        ventanaABM.Stock
                    );
                }
            }

            // 2. La mostramos en modo modal (bloquea la ventana de atrás hasta que se cierre)



        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridCatalogoProd.CurrentRow == null || dataGridCatalogoProd.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione el producto que desea eliminar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //RESTRICCIoN: Confirmar accion destructiva (Por ahora solo es diseño hasta hacer la coneccion)
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar este producto?",
                                                     "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                dataGridCatalogoProd.Rows.Remove(dataGridCatalogoProd.CurrentRow);
            }
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            //RESTRICCION: verifica que se haya seleccionado una fila
            if (dataGridCatalogoProd.CurrentRow == null || dataGridCatalogoProd.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, seleccione un producto de la tabla para modificar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow filaSeleccionada = dataGridCatalogoProd.CurrentRow;

            using (FormProductoABM ventanaABM = new FormProductoABM())
            {
                {
                    //se pasa los valores de la fila seleccionada a modificar
                    /*ventanaABM.CargarDatosParaModificar(
                        filaSeleccionada.Cells
                        );*/
                }

            }
        }
    }
}
    