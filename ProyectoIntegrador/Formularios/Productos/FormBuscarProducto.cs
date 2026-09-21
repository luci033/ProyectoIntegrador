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
        public FormBuscarProducto()
        {
            InitializeComponent();
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

            CBCategoria.Items.AddRange(new string[] { "Todos", "Collares", "Aros", "Anillos", "Pulseras", "Dijes", "Cadenas" });
            CBCategoria.SelectedIndex = 0;

            CBGenero.Items.AddRange(new string[] { "Todos", "Femenino", "Masculino", "Unisex" });
            CBGenero.SelectedIndex = 0;

            // Cargar productos desde el repositorio compartido en memoria
            CargarProductosDesdeRepositorio();

            DGProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGProductos.AllowUserToAddRows = false;
            DGProductos.ReadOnly = true;
        }

        private void CargarProductosDesdeRepositorio()
        {
            DGProductos.Rows.Clear();
            var lista = StockSimulado.ObtenerTodos();
            foreach (var p in lista)
            {
                DGProductos.Rows.Add(p.IdProducto, p.Codigo, p.Nombre, p.Categoria, p.Genero, p.StockActual, p.PrecioVenta, p.PrecioCompra);
            }
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
