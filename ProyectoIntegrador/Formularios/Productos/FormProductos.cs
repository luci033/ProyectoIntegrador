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

            /*
            combCategoriaForm.Items.Clear();
            combCategoriaForm.Items.AddRange(new string[] { "Anillos", "Collares", "Pulseras", "Aros", "Relojes" });
            combCategoriaForm.SelectedIndex = -1;
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nombreColumna = dataGridCatalogoProd.Columns[e.ColumnIndex].Name;

            // Atrapamos el código del producto (Columna 0)
            string codigo = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[0].Value);

            // Escudo anti-filas vacías
            if (string.IsNullOrWhiteSpace(codigo)) return;

            // --- ACCIÓN: BOTÓN MODIFICAR ---
            if (nombreColumna == "colModificar")
            {
                string nombre = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[2].Value);
                string categoria = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[3].Value);
                string genero = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[4].Value);
                string precio = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[5].Value);
                string stock = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[6].Value);

                FormProductoABM modalABM = new FormProductoABM();
                modalABM.ConfigurarModoEdicion(codigo, nombre, categoria, genero, precio, stock);

                if (modalABM.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Producto modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // --- ACCIÓN: BOTÓN ELIMINAR ---
            else if (nombreColumna == "colEliminar")
            {
                string nombre = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[1].Value);
                DialogResult respuesta = MessageBox.Show($"¿Seguro que deseas eliminar el producto {nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    MessageBox.Show("Producto eliminado de la vista.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // dataGridProductos.Rows.RemoveAt(e.RowIndex); // Esta línea borraría la fila visualmente
                }
            }
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            // 1. Instanciamos la ventana del ABM
            FormProductoABM modalProducto = new FormProductoABM();

            // 2. Si el usuario le dio a "Crear" y el ABM devolvió el sello de "OK"...
            if (modalProducto.ShowDialog() == DialogResult.OK)
            {
                // 3. Cargamos los datos en la grilla respetando tu orden exacto de columnas:
                dataGridCatalogoProd.Rows.Add(
                    "",                            // [0] IdProducto (oculto, lo dejamos vacío)
                    modalProducto.Codigo,          // [1] Codigo
                    modalProducto.Nombre,          // [2] Nombre
                    modalProducto.Categoria,       // [3] Categoría
                    modalProducto.Genero,          // [4] Género
                    modalProducto.Precio,          // [5] Precio
                    modalProducto.Stock,           // [6] Stock (Inicial)
                    modalProducto.StockMinimo      // [7] Stock Mínimo
                );
            }
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

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            FormBuscarProducto modalBusqueda = new FormBuscarProducto();
            modalBusqueda.ShowDialog();
        }
    }
}
    