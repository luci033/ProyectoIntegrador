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
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BNuevo);

            CBCategoria.Items.AddRange(new string[] { "Todos", "Collares", "Aros", "Anillos", "Pulseras", "Dijes", "Cadenas" });
            CBCategoria.SelectedIndex = 0;

            CBGenero.Items.AddRange(new string[] { "Todos", "Femenino", "Masculino", "Unisex" });
            CBGenero.SelectedIndex = 0;

            dataGridCatalogoProd.Rows.Add("1123456", "Collar Rubí", "Collares", "Femenino", 155760, 10, 5, "Collar de oro blanco con rubí central.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("2234567", "Aros Luz de Luna", "Aros", "Femenino", 98065, 15, 5, "Aros colgantes de plata con diseño de media luna.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("3345678", "Anillo Solitario Diamante", "Anillos", "Femenino", 320500, 2, 1, "Anillo de compromiso en oro blanco.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("4456789", "Pulsera Eslabón Oro 18k", "Pulseras", "Unisex", 215400, 5, 2, "Pulsera de eslabones gruesos.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("5567890", "Dije Corazón Zafiro", "Dijes", "Femenino", 85200, 8, 3, "Dije pequeño en forma de corazón con zafiro.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("6678901", "Aros Perla Clásica", "Aros", "Femenino", 45600, 20, 8, "Aros pasantes con perlas de 8mm.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("7789012", "Cadena Plata 925", "Cadenas", "Unisex", 25300, 25, 10, "Cadena tradicional de 45 cm.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("8890123", "Anillo Esmeralda Imperial", "Anillos", "Femenino", 275800, 3, 1, "Anillo con esmeralda colombiana.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("9901234", "Gargantilla Oro Blanco", "Collares", "Femenino", 198000, 4, 2, "Gargantilla elegante y minimalista.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("1012345", "Pulsera Tenis Circones", "Pulseras", "Femenino", 112500, 7, 3, "Pulsera estilo tenis con brillos.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("1123456", "Colgante Árbol de la Vida", "Dijes", "Unisex", 34900, 12, 5, "Colgante circular en acero quirúrgico.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("1234567", "Aros Argolla Oro", "Aros", "Unisex", 76400, 9, 4, "Aros clásicos tipo argolla mediana.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("1345678", "Anillo Sello Oro 18k", "Anillos", "Masculino", 185000, 6, 2, "Anillo tipo sello liso para caballero.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("1456789", "Cadena Espiga Plata", "Cadenas", "Masculino", 42000, 14, 5, "Cadena plana de eslabón trenzado.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("1567890", "Pulsera Cuero y Acero", "Pulseras", "Masculino", 28500, 30, 10, "Pulsera de cuero negro con cierre magnético.", "Modificar", "Desactivar");
            dataGridCatalogoProd.Rows.Add("1678901", "Dije Cruz Acero Quirúrgico", "Dijes", "Masculino", 15000, 40, 15, "Dije liso antialérgico.", "Modificar", "Desactivar");
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
                string nombre = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[1].Value);
                string categoria = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[2].Value);
                string genero = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[3].Value);
                string precio = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[4].Value);
                string stock = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[5].Value);

                // Capturás los datos desde las nuevas columnas
                string stockMinimo = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[6].Value);
                string descripcion = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[7].Value);

                FormProductoABM modalABM = new FormProductoABM();
                modalABM.ConfigurarModoEdicion(codigo, nombre, categoria, genero, precio, stock, stockMinimo, descripcion);

                if (modalABM.ShowDialog() == DialogResult.OK)
                {
                    // Reemplazás el valor de las celdas con lo que devolvió el ABM
                    dataGridCatalogoProd.Rows[e.RowIndex].Cells[1].Value = modalABM.Nombre;
                    dataGridCatalogoProd.Rows[e.RowIndex].Cells[6].Value = modalABM.StockMinimo;
                    dataGridCatalogoProd.Rows[e.RowIndex].Cells[7].Value = modalABM.Descripcion; // Asumiendo que creaste esta propiedad

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
                    "NUEVO",                       // [0] Código 
                    modalProducto.Nombre,          // [1] Nombre
                    modalProducto.Categoria,       // [2] Categoría
                    modalProducto.Genero,          // [3] Género
                    Convert.ToDecimal(modalProducto.Precio),  // [4] Precio
                    modalProducto.Stock,           // [5] Stock
                    modalProducto.StockMinimo,     // [6] Stock Mínimo
                    modalProducto.Descripcion,     // [7] Descripción (Te faltaba esta propiedad)
                    "Modificar",                   // [8] Botón Modificar (Te faltaba este)
                    "Desactivar"                   // [9] Botón Desactivar (Te faltaba este)
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

        private void AplicarFiltros()
        {
            string categoriaSeleccionada = CBCategoria.SelectedItem?.ToString() ?? "Todos";
            string generoSeleccionado = CBGenero.SelectedItem?.ToString() ?? "Todos";

            // Obtenemos el texto del buscador y lo pasamos a minúsculas
            string textoBusqueda = TBBuscarProducto.Text.Trim().ToLower();

            foreach (DataGridViewRow fila in dataGridCatalogoProd.Rows)
            {
                if (fila.IsNewRow) continue;

                // Índice 1 es Nombre, 2 es Categoría, 3 es Género
                string nombreFila = fila.Cells[1].Value.ToString().ToLower();
                string categoriaFila = fila.Cells[2].Value.ToString();
                string generoFila = fila.Cells[3].Value.ToString();

                // Verificamos si cumple cada filtro
                bool coincideNombre = string.IsNullOrEmpty(textoBusqueda) || nombreFila.Contains(textoBusqueda);
                bool coincideCategoria = (categoriaSeleccionada == "Todos" || categoriaFila == categoriaSeleccionada);
                bool coincideGenero = (generoSeleccionado == "Todos" || generoFila == generoSeleccionado);

                // La fila se muestra solo si cumple las TRES condiciones al mismo tiempo
                fila.Visible = coincideNombre && coincideCategoria && coincideGenero;
            }
        }

        // 2. Llamamos al método desde el evento de Categoría
        private void CBCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        // 3. Llamamos al mismo método desde el evento de Género
        private void CBGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void TBBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void LCatalogoProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
    