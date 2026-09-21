using ProyectoIntegrador.ModelosSimulados;
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
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BNuevo);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 10);
            EstiloUI.AplicarEstiloGrilla(dataGridCatalogoProd);
            EstiloUI.AplicarEstiloTextBox(TBBuscarProducto);

            CBCategoria.Items.AddRange(new string[] { "Todos", "Collares", "Aros", "Anillos", "Pulseras", "Dijes", "Cadenas" });
            CBCategoria.SelectedIndex = 0;

            CBGenero.Items.AddRange(new string[] { "Todos", "Femenino", "Masculino", "Unisex" });
            CBGenero.SelectedIndex = 0;

            CargarCatalogo();
            this.Activated += (s, ev) => CargarCatalogo();
        }

        public void CargarCatalogo()
        {
            dataGridCatalogoProd.Rows.Clear();
            var catalogo = StockSimulado.ObtenerCatalogoCompleto();
            foreach (var p in catalogo)
            {
                int index = dataGridCatalogoProd.Rows.Add(
                    p.Codigo,
                    p.Nombre,
                    p.Categoria,
                    p.Genero,
                    p.PrecioVenta,
                    p.StockActual,
                    p.StockMinimo,
                    p.Descripcion,
                    p.Proveedor,
                    "Modificar",
                    p.Activo ? "Desactivar" : "Activar"
                );

                if (!p.Activo)
                {
                    dataGridCatalogoProd.Rows[index].DefaultCellStyle.BackColor = EstiloUI.ColorInactivo;
                }
            }

            AplicarFiltros();
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
                // Si el botón de la columna eliminar dice "Activar", la fila está inactiva y cortamos el evento
                if (Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells["colEliminar"].Value) == "Activar") return;
                string nombre = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[1].Value);
                string categoria = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[2].Value);
                string genero = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[3].Value);
                string precio = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[4].Value);
                string stock = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[5].Value);
                string stockMinimo = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[6].Value);
                string descripcion = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[7].Value);
                string proveedor = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[8].Value);

                FormProductoABM modalABM = new FormProductoABM();
                modalABM.ConfigurarModoEdicion(codigo, nombre, categoria, genero, precio, stock, stockMinimo, descripcion, proveedor);

                if (modalABM.ShowDialog() == DialogResult.OK)
                {
                    // Reemplazás el valor de las celdas con lo que devolvió el ABM
                    dataGridCatalogoProd.Rows[e.RowIndex].Cells[1].Value = modalABM.Nombre;
                    dataGridCatalogoProd.Rows[e.RowIndex].Cells[6].Value = modalABM.StockMinimo;
                    dataGridCatalogoProd.Rows[e.RowIndex].Cells[7].Value = modalABM.Descripcion;

                    var prod = StockSimulado.BuscarCualquieraPorCodigo(codigo);
                    if (prod != null)
                    {
                        prod.Nombre = modalABM.Nombre;
                        if (int.TryParse(modalABM.StockMinimo, out int sMin))
                            prod.StockMinimo = sMin;
                        prod.Descripcion = modalABM.Descripcion;
                    }

                    MessageBox.Show("Producto modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // --- ACCIÓN: BOTÓN ELIMINAR ---
            else if (nombreColumna == "colEliminar")
            {
                string nombre = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[1].Value);
                string accionActual = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                if (accionActual == "Desactivar")
                {
                    DialogResult respuesta = MessageBox.Show($"¿Seguro que deseas desactivar el producto {nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        dataGridCatalogoProd.Rows[e.RowIndex].DefaultCellStyle.BackColor = EstiloUI.ColorInactivo;
                        dataGridCatalogoProd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Activar";
                        StockSimulado.CambiarEstadoActivo(codigo, false);
                        MessageBox.Show("Desactivado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else // Si el botón dice "Activar"
                {
                    // Vuelve la fila a su color normal y el texto a "Desactivar"
                    dataGridCatalogoProd.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dataGridCatalogoProd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Desactivar";
                    StockSimulado.CambiarEstadoActivo(codigo, true);
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
                int.TryParse(modalProducto.Stock, out int sAct);
                int.TryParse(modalProducto.StockMinimo, out int sMin);
                decimal.TryParse(modalProducto.Precio, out decimal precio);

                string nuevoCodigo = "PROD" + (StockSimulado.ObtenerCatalogoCompleto().Count + 1).ToString("D4");

                StockSimulado.AgregarProducto(new ProductoSimulado
                {
                    Codigo = nuevoCodigo,
                    Nombre = modalProducto.Nombre,
                    Categoria = modalProducto.Categoria,
                    Genero = modalProducto.Genero,
                    PrecioVenta = precio,
                    StockActual = sAct,
                    StockMinimo = sMin,
                    Descripcion = modalProducto.Descripcion,
                    Proveedor = modalProducto.Proveedor,
                    Activo = true
                });

                CargarCatalogo();
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
                string nombreFila = Convert.ToString(fila.Cells[1].Value).ToLower();
                string categoriaFila = Convert.ToString(fila.Cells[2].Value);
                string generoFila = Convert.ToString(fila.Cells[3].Value);

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

        private void dataGridCatalogoProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nombreColumna = dataGridCatalogoProd.Columns[e.ColumnIndex].Name;

            // Evitamos que se abra el detalle si hizo doble clic justo sobre los botones
            if (nombreColumna == "colModificar" || nombreColumna == "colEliminar") return;

            string codigo = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[0].Value);
            if (string.IsNullOrWhiteSpace(codigo)) return;

            // Extraemos los datos
            string nombre = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[1].Value);
            string categoria = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[2].Value);
            string genero = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[3].Value);
            string precio = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[4].Value);
            string stock = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[5].Value);
            string stockMinimo = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[6].Value);
            string descripcion = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[7].Value);
            string proveedor = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[8].Value);

            FormProductoABM modalABM = new FormProductoABM();
            modalABM.ConfigurarModoDetalle(codigo, nombre, categoria, genero, precio, stock, stockMinimo, descripcion, proveedor);
            modalABM.ShowDialog();
        }
    }
}
    