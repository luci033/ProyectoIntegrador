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
        }

        public int IdProducto { get; private set; }
        public string Codigo { get; private set; }
        public string Nombre { get; private set; }
        public decimal CostoCompra { get; private set; }
        public string Categoria { get; private set; }
        public string Genero { get; private set; }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloGrilla(DGProductos);

            CBCategoria.Items.AddRange(new string[] { "Todos", "Collares", "Aros", "Anillos", "Pulseras", "Dijes", "Cadenas" });
            CBCategoria.SelectedIndex = 0;

            CBGenero.Items.AddRange(new string[] { "Todos", "Femenino", "Masculino", "Unisex" });
            CBGenero.SelectedIndex = 0;

            DGProductos.ColumnCount = 6;

            // Datos de prueba
            DGProductos.Rows.Add(1, "1123456", "Collar Rubí", 155760, "Collares", "Femenino");
            DGProductos.Rows.Add(2, "2234567", "Aros Luz de Luna", 98065, "Aros", "Femenino");
            DGProductos.Rows.Add(3, "3345678", "Anillo Solitario Diamante", 320500, "Anillos", "Femenino");
            DGProductos.Rows.Add(4, "4456789", "Pulsera Eslabón Oro 18k", 215400, "Pulseras", "Unisex");
            DGProductos.Rows.Add(5, "5567890", "Dije Corazón Zafiro", 85200, "Dijes", "Femenino");
            DGProductos.Rows.Add(6, "6678901", "Aros Perla Clásica", 45600, "Aros", "Femenino");
            DGProductos.Rows.Add(7, "7789012", "Cadena Plata 925", 25300, "Cadenas", "Unisex");
            DGProductos.Rows.Add(8, "8890123", "Anillo Esmeralda Imperial", 275800, "Anillos", "Femenino");
            DGProductos.Rows.Add(9, "9901234", "Gargantilla Oro Blanco", 198000, "Collares", "Femenino");
            DGProductos.Rows.Add(10, "1012345", "Pulsera Tenis Circones", 112500, "Pulseras", "Femenino");
            DGProductos.Rows.Add(11, "1123456", "Colgante Árbol de la Vida", 34900, "Dijes", "Unisex");
            DGProductos.Rows.Add(12, "1234567", "Aros Argolla Oro", 76400, "Aros", "Unisex");
            DGProductos.Rows.Add(13, "1345678", "Anillo Sello Oro 18k", 185000, "Anillos", "Masculino");
            DGProductos.Rows.Add(14, "1456789", "Cadena Espiga Plata", 42000, "Cadenas", "Masculino");
            DGProductos.Rows.Add(15, "1567890", "Pulsera Cuero y Acero", 28500, "Pulseras", "Masculino");
            DGProductos.Rows.Add(16, "1678901", "Dije Cruz Acero Quirúrgico", 15000, "Dijes", "Masculino");

            DGProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGProductos.AllowUserToAddRows = false;
            DGProductos.ReadOnly = true;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DD(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGProductos.Rows[e.RowIndex];

                IdProducto = Convert.ToInt32(fila.Cells[0].Value);
                Codigo = fila.Cells[1].Value?.ToString();
                Nombre = fila.Cells[2].Value?.ToString();
                CostoCompra = Convert.ToDecimal(fila.Cells[3].Value);
                Categoria = fila.Cells[4].Value?.ToString();
                Genero = fila.Cells[5].Value?.ToString();

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
                    string categoria = fila.Cells[4].Value?.ToString() ?? "";
                    string genero = fila.Cells[5].Value?.ToString() ?? "";

                    bool pasaNombre = nombre.Contains(filtroNombre);
                    bool pasaCat = filtroCat == "Todos" || categoria == filtroCat;
                    bool pasaGen = filtroGen == "Todos" || genero == filtroGen;

                    fila.Visible = pasaNombre && pasaCat && pasaGen;
                }
            }
        }
    }
}
