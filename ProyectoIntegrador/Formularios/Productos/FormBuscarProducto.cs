using CapaEntidades;
using CapaNegocio;
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
    public partial class FormBuscarProducto : Form
    {
        private int idProveedorFiltro = 0;

        public FormBuscarProducto()
        {
            InitializeComponent();
        }

        public FormBuscarProducto(int idProveedor = 0)
        {
            InitializeComponent();
            this.idProveedorFiltro = idProveedor;
            this.WindowState = FormWindowState.Maximized;
        }

        public int IdProducto { get; private set; }
        public string Codigo { get; private set; }
        public string Nombre { get; private set; }
        public decimal CostoCompra { get; private set; }
        public string Categoria { get; private set; }
        public string Genero { get; private set; }
        public int Stock { get; private set;  }
        public decimal PrecioVenta { get; private set; }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBotonSecundario(BCancelar);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 12);
            EstiloUI.AplicarEstiloGrilla(DGProductos);
            EstiloUI.AplicarEstiloTextBox(TBBuscar);

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

            // Cargar productos desde la base de datos
            CargarProductosDesdeRepositorio();

            DGProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGProductos.AllowUserToAddRows = false;
            DGProductos.ReadOnly = true;
        }

        private void CargarProductosDesdeRepositorio()
        {
            DGProductos.Rows.Clear();
            try
            {
                DataTable dt = new CN_Producto().Listar();
                foreach (DataRow row in dt.Rows)
                {
                    bool activo = row["Estado"] != DBNull.Value ? Convert.ToBoolean(row["Estado"]) : true;
                    if (!activo) continue;

                    // Si se especificó un proveedor, mostramos solo sus productos
                    if (idProveedorFiltro > 0)
                    {
                        int idProv = (row.Table.Columns.Contains("IdProveedor") && row["IdProveedor"] != DBNull.Value) ? Convert.ToInt32(row["IdProveedor"]) : 0;
                        if (idProv != idProveedorFiltro) continue;
                    }

                    int id = Convert.ToInt32(row["IdProducto"]);
                    string nombre = row["NombreProducto"] != DBNull.Value ? row["NombreProducto"].ToString() : "";
                    string categoria = row["NombreCategoria"] != DBNull.Value ? row["NombreCategoria"].ToString() : "";
                    string genero = row["NombreGenero"] != DBNull.Value ? row["NombreGenero"].ToString() : "";
                    int stock = row["StockActual"] != DBNull.Value ? Convert.ToInt32(row["StockActual"]) : 0;
                    decimal pVenta = (row["PrecioVenta"] != DBNull.Value) ? Convert.ToDecimal(row["PrecioVenta"]) : 0.00m;
                    decimal pCompra = (row["PrecioCompra"] != DBNull.Value) ? Convert.ToDecimal(row["PrecioCompra"]) : 0.00m;

                    DGProductos.Rows.Add(id, id.ToString(), nombre, categoria, genero, stock, pVenta, pCompra);
                }
            }
            catch { }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DGProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGProductos.Rows[e.RowIndex];

                IdProducto = Convert.ToInt32(fila.Cells[0].Value);
                Codigo = fila.Cells[1].Value?.ToString();
                Nombre = fila.Cells[2].Value?.ToString();
                Categoria = fila.Cells[3].Value?.ToString();
                Genero = fila.Cells[4].Value?.ToString();
                Stock = Convert.ToInt32(fila.Cells[5].Value ?? 0);
                PrecioVenta = Convert.ToDecimal(fila.Cells[6].Value ?? 0);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e) => FiltrarGrilla();
        private void CBCategoria_SelectedIndexChanged(object sender, EventArgs e) => FiltrarGrilla();
        private void CBGenero_SelectedIndexChanged(object sender, EventArgs e) => FiltrarGrilla();

        private void FiltrarGrilla()
        {
            string filtroNombre = TBBuscar.Text.ToLower();
            string filtroCat = CBCategoria.Text;
            string filtroGen = CBGenero.Text;

            DGProductos.CurrentCell = null;

            foreach (DataGridViewRow fila in DGProductos.Rows)
            {
                if (fila.Cells[2].Value != null)
                {
                    string nombre = fila.Cells[2].Value.ToString().ToLower();
                    string categoria = fila.Cells[3].Value?.ToString() ?? "";
                    string genero = fila.Cells[4].Value?.ToString() ?? "";

                    bool pasaNombre = nombre.Contains(filtroNombre);
                    bool pasaCat = filtroCat == "Todos" || categoria == filtroCat;
                    bool pasaGen = filtroGen == "Todos" || genero == filtroGen;

                    fila.Visible = pasaNombre && pasaCat && pasaGen;
                }
            }
        }

        public void ConfigurarParaVentas()
        {
            DGProductos.Columns[6].Visible = true; // Hace visible la columna Precio Venta
        }
    }
}
