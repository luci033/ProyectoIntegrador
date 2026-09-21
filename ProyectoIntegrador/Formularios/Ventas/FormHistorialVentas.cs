using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Ventas
{
    public partial class FHistorialVentas : Form
    {
        // Clase simple para representar una venta en memoria. REVISAR
        public class VentaResumen
        {
            public int IdVenta { get; set; }
            public string Vendedor { get; set; }
            public DateTime Fecha { get; set; }
            public decimal Total { get; set; }
        }

        // Lista que simula los registros que luego iran de la Base de Datos
        private List<VentaResumen> listaVentas = new List<VentaResumen>();

        public FHistorialVentas()

        {
            InitializeComponent();
        }

        private void dataGridHistorialVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que el clic sea en la columna del botón
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                // Se obtiene el ID de la fila seleccionada
                int IdVentaSeleccionada = Convert.ToInt32(DataGridHistorialVenta.Rows[e.RowIndex].Cells[0].Value);

                // Buscamos si ese ID existe en el diccionario de memoria de FormVentas
                if (FormVentas.HistorialVentas.ContainsKey(IdVentaSeleccionada))
                {
                    // Le pasamos el paquete completo de DatosVenta al comprobante
                    FDetalleVenta modalDetalle = new FDetalleVenta(FormVentas.HistorialVentas[IdVentaSeleccionada]);
                    modalDetalle.ShowDialog();
                }
                else
                {
                    // Si no está en el diccionario, es uno de tus registros simulados del Load
                    MessageBox.Show("Esta venta es simulada de prueba y no contiene un detalle guardado en memoria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        // metodo auxiliar: recibe una lista de ventas y las dibuja en el DataGridView
        private void CargarGrilla(List<VentaResumen> ventas)
        {
            // cremoas una variable en cero para ir guardando la suma
            decimal totalSuma = 0;

            // Vaciamos filas anteriores para evitar duplicar datos al filtrar
            DataGridHistorialVenta.Rows.Clear();

            foreach (var venta in ventas)
            {
                // El DataGridViewButtonColumn genera el botón automáticamente en cada fila agregada
                DataGridHistorialVenta.Rows.Add(
                    venta.IdVenta,
                    "",
                    venta.IdVenta,
                    venta.Vendedor,
                    venta.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    venta.Total.ToString("C2")
                );

                // a medida que dibuja la fila, le sumamos la plata a nuestra variable
                totalSuma += venta.Total;
            }

            // al terminar de dibujar todas las filas, mostramos el total en tu control
            // OJO: Cambia "TBTotalFiltrado" por el nombre real que le pusiste a tu cajita o Label en el diseño
            TBTotalFiltrado.Text = totalSuma.ToString("C2");
        }

        private void FHistorialVentas_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LHistorialVenta);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 12);
            EstiloUI.AplicarEstiloPanelSeccion(panelGrid, 14);
            EstiloUI.AplicarEstiloBoton(BBuscar);
            EstiloUI.AplicarEstiloBotonSecundario(BLimpiar);
            EstiloUI.AplicarEstiloTextBox(TBBuscar);
            EstiloUI.AplicarEstiloTextBox(TBTotalFiltrado);
            EstiloUI.AplicarEstiloGrilla(DataGridHistorialVenta);

            // Llenamos el ComboBox con las opciones de búsqueda
            cmbBuscar.Items.Add("Nro. Venta");
            cmbBuscar.Items.Add("Vendedor");
            cmbBuscar.SelectedIndex = 0; // Selecciona el primero por defecto

            // se cargan registros simulados para verificar el funcionamiento de la grilla
            listaVentas = new List<VentaResumen>
            {
                new VentaResumen { IdVenta = 1001, Fecha = DateTime.Now.AddDays(-2), Total = 150000m },
                new VentaResumen { IdVenta = 1002, Fecha = DateTime.Now.AddDays(-1), Total = 45500.50m },
                new VentaResumen { IdVenta = 1003, Fecha = DateTime.Now, Total = 320000m }
            };

            // Poblamos el DataGridView con la lista inicial
            CargarGrilla(listaVentas);
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoFiltro = TBBuscar.Text.Trim();

            // si el buscador esta vacio, mostramos el listado completo original
            if (string.IsNullOrEmpty(textoFiltro))
            {
                CargarGrilla(listaVentas);
                return;
            }

            // filtramos la lista buscando coincidencias en el ID de la venta mediante LINQ (evalua de forma rapida si el texto ingresado
            // en el buscador, coincide .
            List<VentaResumen> ventasFiltradas = listaVentas
                .Where(v => v.IdVenta.ToString().Contains(textoFiltro))
                .ToList();

            CargarGrilla(ventasFiltradas);
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            // Atrapamos las fechas (al "Hasta" le sumamos 1 día para incluir todo ese día hasta las 23:59)
            DateTime fechaDesde = DTPFechaDesde.Value.Date;
            DateTime fechaHasta = DTPFechaHasta.Value.Date.AddDays(1).AddSeconds(-1);

            // filtramos por rango de fechas
            var ventasFiltradas = listaVentas
                .Where(v => v.Fecha >= fechaDesde && v.Fecha <= fechaHasta)
                .ToList();

            // filtramos por el ComboBox y el TextBox
            string criterio = cmbBuscar.Text;
            string texto = TBBuscar.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(texto))
            {
                if (criterio == "Nro. Venta")
                {
                    ventasFiltradas = ventasFiltradas.Where(v => v.IdVenta.ToString().Contains(texto)).ToList();
                }
                else if (criterio == "Vendedor")
                {
                    ventasFiltradas = ventasFiltradas.Where(v => v.Vendedor.ToLower().Contains(texto)).ToList();
                }
            }
            // mostramos el resultado final en la grilla
            CargarGrilla(ventasFiltradas);
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TBBuscar.Clear();
            cmbBuscar.SelectedIndex = 0;
            DTPFechaDesde.Value = DateTime.Now.AddMonths(-1);
            DTPFechaHasta.Value = DateTime.Now;

            CargarGrilla(listaVentas);
        }
    }
}


