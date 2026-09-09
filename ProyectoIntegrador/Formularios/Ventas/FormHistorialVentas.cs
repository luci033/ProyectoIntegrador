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
            // e.RowIndex >= 0 evita clics accidentales sobre la fila de encabezados
            // Verificamos que el clic sea en la columna del botón (colDetalle)
            if (e.RowIndex >= 0 && DataGridHistorialVenta.Columns[e.ColumnIndex].Name == "colDetalle")
            {
                
                //se obtiene el ID de la fila seleccionada y se lo convierte a numero
                int IdVentaSeleccionada = Convert.ToInt32(DataGridHistorialVenta.Rows[e.RowIndex].Cells[0].Value);

                //se abre el modla pasandole el id como argumento
                FDetalleVenta modalDetalle = new FDetalleVenta(IdVentaSeleccionada);
                modalDetalle.ShowDialog();
                

                /*
                // Obtenemos el ID de la venta seleccionada leyendo la primera celda del renglón
                string idVentaSeleccionada = DataGridHistorialVenta.Rows[e.RowIndex].Cells[0].Value.ToString();

                MessageBox.Show(
                    $"Detalle de la venta N°: {idVentaSeleccionada}\n(Próximamente conectará al desglose de joyas)",
                    "Detalle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                */
                
            }
        }


        // metodo auxiliar: recibe una lista de ventas y las dibuja en el DataGridView
        private void CargarGrilla(List<VentaResumen> ventas)
        {
            // Vaciamos filas anteriores para evitar duplicar datos al filtrar
            DataGridHistorialVenta.Rows.Clear();

            foreach (var venta in ventas)
            {
                // El DataGridViewButtonColumn genera el botón automáticamente en cada fila agregada
                DataGridHistorialVenta.Rows.Add(
                    venta.IdVenta,
                    venta.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    venta.Total.ToString("C2")
                );
            }
        }

        private void FHistorialVentas_Load(object sender, EventArgs e)
        {
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
    }
}
