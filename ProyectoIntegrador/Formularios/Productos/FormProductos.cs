using CapaEntidades;
using CapaNegocio;
using ProyectoIntegrador.Formularios.Principal;
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
        public bool EsAdministrador { get; set; } = false;

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBotonSecundario(BGestionarCategorias);
            EstiloUI.AplicarEstiloBoton(BNuevo);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 10);
            EstiloUI.AplicarEstiloGrilla(dataGridCatalogoProd);
            EstiloUI.AplicarEstiloTextBox(TBBuscarProducto);

            CargarFiltros();
            CargarCatalogo();
        }

        private void CargarFiltros()
        {
            CBCategoria.Items.Clear();
            CBCategoria.Items.Add("Todos");
            try
            {
                foreach (var cat in new CN_Categoria().ListarCategorias())
                {
                    if (!string.IsNullOrWhiteSpace(cat.NombreCategoria))
                        CBCategoria.Items.Add(cat.NombreCategoria);
                }
            }
            catch { }
            CBCategoria.SelectedIndex = 0;

            CBGenero.Items.Clear();
            CBGenero.Items.Add("Todos");
            try
            {
                foreach (var gen in new CN_Genero().ListarGeneros())
                {
                    if (!string.IsNullOrWhiteSpace(gen.NombreGenero))
                        CBGenero.Items.Add(gen.NombreGenero);
                }
            }
            catch { }
            CBGenero.SelectedIndex = 0;
        }

        public void CargarCatalogo()
        {
            dataGridCatalogoProd.Rows.Clear();
            DataTable tabla = new CN_Producto().Listar();

            foreach (DataRow row in tabla.Rows)
            {
                int idProducto = Convert.ToInt32(row["IdProducto"]);
                string nombre = row["NombreProducto"] != DBNull.Value ? row["NombreProducto"].ToString() : "";
                string categoria = row["NombreCategoria"] != DBNull.Value ? row["NombreCategoria"].ToString() : "";
                string genero = row["NombreGenero"] != DBNull.Value ? row["NombreGenero"].ToString() : "";
                decimal precioVenta = (row["PrecioVenta"] != DBNull.Value) ? Convert.ToDecimal(row["PrecioVenta"]) : 0.00m;
                int stockActual = row["StockActual"] != DBNull.Value ? Convert.ToInt32(row["StockActual"]) : 0;
                int stockMinimo = row["StockMinimo"] != DBNull.Value ? Convert.ToInt32(row["StockMinimo"]) : 0;
                string descripcion = row["Descripcion"] != DBNull.Value ? row["Descripcion"].ToString() : "";
                string proveedor = row["NombreProveedor"] != DBNull.Value ? row["NombreProveedor"].ToString() : "";
                bool activo = row["Estado"] != DBNull.Value ? Convert.ToBoolean(row["Estado"]) : true;

                int index = dataGridCatalogoProd.Rows.Add(
                    idProducto,
                    nombre,
                    categoria,
                    genero,
                    precioVenta,
                    stockActual,
                    stockMinimo,
                    descripcion,
                    proveedor,
                    "Modificar",
                    activo ? "Desactivar" : "Activar"
                );

                if (!activo)
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
            if (string.IsNullOrWhiteSpace(codigo) || !int.TryParse(codigo, out int idProducto)) return;

            // --- ACCIÓN: BOTÓN MODIFICAR ---
            if (nombreColumna == "colModificar")
            {
                // Si el botón de la columna eliminar dice "Activar", la fila está inactiva y cortamos el evento
                if (Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells["colEliminar"].Value) == "Activar")
                {
                    MessageBox.Show("No se puede modificar un producto inactivo. Debe activarlo primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[1].Value);
                string categoria = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[2].Value);
                string genero = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[3].Value);
                string precio = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[4].Value);
                string stock = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[5].Value);
                string stockMinimo = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[6].Value);
                string descripcion = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[7].Value);
                string proveedor = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[8].Value);

                FormProductoABM modalABM = new FormProductoABM();
                bool esAdmin = EsAdministrador || (this.MdiParent is FormPrincipalAdministrador);
                modalABM.ConfigurarModoEdicion(idProducto, nombre, categoria, genero, precio, stock, stockMinimo, descripcion, proveedor, esAdmin);

                if (modalABM.ShowDialog() == DialogResult.OK)
                {
                    CargarCatalogo();
                }
            }

            // --- ACCIÓN: BOTÓN ELIMINAR / DESACTIVAR ---
            else if (nombreColumna == "colEliminar")
            {
                string nombre = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[1].Value);
                string accionActual = Convert.ToString(dataGridCatalogoProd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                if (accionActual == "Desactivar")
                {
                    DialogResult respuesta = MessageBox.Show(
                        $"¿Seguro que deseas desactivar el producto \"{nombre}\"?", 
                        "Confirmar desactivación", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Warning
                    );

                    if (respuesta == DialogResult.Yes)
                    {
                        string msg;
                        bool ok = new CN_Producto().CambiarEstado(idProducto, false, out msg);
                        if (ok)
                        {
                            dataGridCatalogoProd.Rows[e.RowIndex].DefaultCellStyle.BackColor = EstiloUI.ColorInactivo;
                            dataGridCatalogoProd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Activar";
                            MessageBox.Show("Producto desactivado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else // Si el botón dice "Activar"
                {
                    DialogResult respuesta = MessageBox.Show(
                        $"¿Deseas activar nuevamente el producto \"{nombre}\"?", 
                        "Confirmar activación", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question
                    );

                    if (respuesta == DialogResult.Yes)
                    {
                        string msg;
                        bool ok = new CN_Producto().CambiarEstado(idProducto, true, out msg);
                        if (ok)
                        {
                            dataGridCatalogoProd.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                            dataGridCatalogoProd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Desactivar";
                            MessageBox.Show("Producto activado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BGestionarCategorias_Click(object sender, EventArgs e)
        {
            using (FormCategorias formCat = new FormCategorias())
            {
                formCat.ShowDialog();
            }
            CargarFiltros();
            CargarCatalogo();
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            FormProductoABM modalProducto = new FormProductoABM();
            if (modalProducto.ShowDialog() == DialogResult.OK)
            {
                CargarCatalogo();
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
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
            string textoBusqueda = TBBuscarProducto.Text.Trim().ToLower();

            foreach (DataGridViewRow fila in dataGridCatalogoProd.Rows)
            {
                if (fila.IsNewRow) continue;

                string codigoFila = Convert.ToString(fila.Cells[0].Value).ToLower();
                string nombreFila = Convert.ToString(fila.Cells[1].Value).ToLower();
                string categoriaFila = Convert.ToString(fila.Cells[2].Value);
                string generoFila = Convert.ToString(fila.Cells[3].Value);

                bool coincideBusqueda = string.IsNullOrEmpty(textoBusqueda) || 
                                        nombreFila.Contains(textoBusqueda) || 
                                        codigoFila.Contains(textoBusqueda);
                bool coincideCategoria = (categoriaSeleccionada == "Todos" || categoriaFila.Equals(categoriaSeleccionada, StringComparison.OrdinalIgnoreCase));
                bool coincideGenero = (generoSeleccionado == "Todos" || generoFila.Equals(generoSeleccionado, StringComparison.OrdinalIgnoreCase));

                fila.Visible = coincideBusqueda && coincideCategoria && coincideGenero;
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
    