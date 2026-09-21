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
    public partial class FormVentas : Form
    {
        public static Dictionary<int, DatosVenta> HistorialVentas = new Dictionary<int, DatosVenta>();
        public class DatosVenta
        {
            public int Nro { get; set; }
            public string Fecha { get; set; }
            public string Cliente { get; set; }
            public string Iva { get; set; }
            public string MetodoPago { get; set; }
            public string Total { get; set; }
            public List<FDetalleVenta.ItemDetalle> Articulos { get; set; } = new List<FDetalleVenta.ItemDetalle>();
        }
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load_1(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BRegistrarVenta);
            EstiloUI.AplicarEstiloPanelSeccion(panelGrid, 12);
            EstiloUI.AplicarEstiloGrilla(dgVentas);

            // Enlazar el evento de la columna "Ver Comprobante"
            dgVentas.CellContentClick += new DataGridViewCellEventHandler(dgVentas_CellContentClick);
        }

        private void BRegistrarVenta_Click(object sender, EventArgs e)
        {
            using (FormRegistroVentas formRegistroVenta = new FormRegistroVentas())
            {
                if (formRegistroVenta.ShowDialog() == DialogResult.OK)
                {
                    int nroVenta = Convert.ToInt32(formRegistroVenta.NroVenta);

                    // Armamos el "paquete" con toda la info
                    DatosVenta nuevaVenta = new DatosVenta
                    {
                        Nro = nroVenta,
                        Fecha = formRegistroVenta.FechaVenta,
                        Cliente = formRegistroVenta.ClienteVenta,
                        Iva = formRegistroVenta.CondicionIVAVenta,
                        MetodoPago = formRegistroVenta.MetodoPago,
                        Total = formRegistroVenta.TotalVenta
                    };

                    // Traspasamos los artículos
                    foreach (DataGridViewRow fila in formRegistroVenta.ProductosVendidos)
                    {
                        if (fila.IsNewRow) continue;
                        nuevaVenta.Articulos.Add(new FDetalleVenta.ItemDetalle
                        {
                            Producto = fila.Cells[1].Value.ToString(),
                            Cantidad = Convert.ToInt32(fila.Cells[5].Value),
                            PrecioUnitario = Convert.ToDecimal(fila.Cells[4].Value)
                        });

                        // NOTA: Acá deberías restar la cantidad de tu lista estática de productos.
                    }

                    // Guardamos en memoria y en la grilla
                    HistorialVentas.Add(nroVenta, nuevaVenta);
                    dgVentas.Rows.Add(nroVenta, nuevaVenta.Fecha, nuevaVenta.Cliente, nuevaVenta.Total, "Ver Comprobante");

                    // Abrimos el comprobante pasándole el paquete de datos
                    FDetalleVenta comprobante = new FDetalleVenta(nuevaVenta);
                    comprobante.ShowDialog();
                }
            }
        }

        private void dgVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4) // 
            {
                int nroVenta = Convert.ToInt32(dgVentas.Rows[e.RowIndex].Cells[0].Value);

                if (HistorialVentas.ContainsKey(nroVenta))
                {
                    // Recupera los datos de la memoria estática y abre el comprobante
                    FDetalleVenta comprobante = new FDetalleVenta(HistorialVentas[nroVenta]);
                    comprobante.ShowDialog();
                }
            }
        }


    }
}
