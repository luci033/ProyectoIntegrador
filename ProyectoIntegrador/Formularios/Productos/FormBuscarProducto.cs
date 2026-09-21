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
            EstiloUI.AplicarEstiloGrilla(DGProductos);
            EstiloUI.AplicarEstiloTextBox(TBBuscar);

            CBCategoria.Items.AddRange(new string[] { "Todos", "Collares", "Aros", "Anillos", "Pulseras", "Dijes", "Cadenas" });
            CBCategoria.SelectedIndex = 0;

            CBGenero.Items.AddRange(new string[] { "Todos", "Femenino", "Masculino", "Unisex" });
            CBGenero.SelectedIndex = 0;

            // Datos de prueba (Id, Código, Nombre, Categoría, Género, Stock, Precio Venta, Precio Compra)
            DGProductos.Rows.Add(1, "1123456", "Collar Rubí", "Collares", "Femenino", 15, 150000.00m, 100000.00m);
            DGProductos.Rows.Add(2, "2234567", "Aros Luz de Luna", "Aros", "Femenino", 20, 85000.00m, 50000.00m);
            DGProductos.Rows.Add(3, "3345678", "Anillo Solitario Diamante", "Anillos", "Femenino", 5, 350000.00m, 200000.00m);
            DGProductos.Rows.Add(4, "4456789", "Pulsera Eslabón Oro 18k", "Pulseras", "Unisex", 10, 250000.00m, 180000.00m);
            DGProductos.Rows.Add(5, "5567890", "Dije Corazón Zafiro", "Dijes", "Femenino", 8, 95000.00m, 60000.00m);
            DGProductos.Rows.Add(6, "6678901", "Aros Perla Clásica", "Aros", "Femenino", 25, 45000.00m, 25000.00m);
            DGProductos.Rows.Add(7, "7789012", "Cadena Plata 925", "Cadenas", "Unisex", 30, 65000.00m, 35000.00m);
            DGProductos.Rows.Add(8, "8890123", "Anillo Esmeralda Imperial", "Anillos", "Femenino", 3, 420000.00m, 280000.00m);
            DGProductos.Rows.Add(9, "9901234", "Gargantilla Oro Blanco", "Collares", "Femenino", 12, 310000.00m, 210000.00m);
            DGProductos.Rows.Add(10, "1012345", "Pulsera Tenis Circones", "Pulseras", "Femenino", 18, 120000.00m, 75000.00m);
            DGProductos.Rows.Add(11, "1123456", "Colgante Árbol de la Vida", "Dijes", "Unisex", 40, 35000.00m, 18000.00m);
            DGProductos.Rows.Add(12, "1234567", "Aros Argolla Oro", "Aros", "Unisex", 22, 110000.00m, 70000.00m);
            DGProductos.Rows.Add(13, "1345678", "Anillo Sello Oro 18k", "Anillos", "Masculino", 7, 185000.00m, 120000.00m);
            DGProductos.Rows.Add(14, "1456789", "Cadena Espiga Plata", "Cadenas", "Masculino", 15, 85000.00m, 45000.00m);
            DGProductos.Rows.Add(15, "1567890", "Pulsera Cuero y Acero", "Pulseras", "Masculino", 50, 25000.00m, 12000.00m);
            DGProductos.Rows.Add(16, "1678901", "Dije Cruz Acero Quirúrgico", "Dijes", "Masculino", 60, 15000.00m, 7000.00m);

            DGProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGProductos.AllowUserToAddRows = false;
            DGProductos.ReadOnly = true;
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
