using CapaEntidades;
using CapaNegocio;
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

        private string usuarioLogueado;
        public FormVentas(string nombreUsuario)
        {
            InitializeComponent();
            usuarioLogueado = nombreUsuario;
        }

        // Constructor vacío para que el método genérico no rompa
        public FormVentas() : this("Operador Venta")
        {
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

            CargarGrillaVentas();
        }

        private void CargarGrillaVentas()
        {
            dgVentas.Rows.Clear();
            try
            {
                DataTable dt = new CN_Venta().ListarVentas();
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        int nro = Convert.ToInt32(r["IdComprobante"]);
                        string fecha = Convert.ToDateTime(r["FechaComprobante"]).ToString("dd/MM/yyyy HH:mm");
                        string cliente = r["Cliente"]?.ToString() ?? "";
                        decimal total = Convert.ToDecimal(r["Total"] ?? 0);
                        dgVentas.Rows.Add(nro, fecha, cliente, total.ToString("C2"), "Ver Comprobante");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BRegistrarVenta_Click(object sender, EventArgs e)
        {
            using (FormRegistroVentas formRegistroVenta = new FormRegistroVentas(usuarioLogueado))
            {
                if (formRegistroVenta.ShowDialog() == DialogResult.OK)
                {
                    // Recargamos la grilla para mostrar la venta recién guardada en la base de datos
                    CargarGrillaVentas();
                }
            }
        }

        private void dgVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 4 || dgVentas.Columns[e.ColumnIndex].Name.ToLower().Contains("comprobante")))
            {
                int nroVenta = Convert.ToInt32(dgVentas.Rows[e.RowIndex].Cells[0].Value);

                try
                {
                    var ventaBD = new CN_Venta().ObtenerVentaPorId(nroVenta);
                    if (ventaBD != null)
                    {
                        using (FDetalleVenta comprobante = new FDetalleVenta(nroVenta))
                        {
                            comprobante.ShowDialog();
                        }
                        return;
                    }
                }
                catch { }

                if (HistorialVentas.ContainsKey(nroVenta))
                {
                    FDetalleVenta comprobante = new FDetalleVenta(HistorialVentas[nroVenta]);
                    comprobante.ShowDialog();
                }
            }
        }
    }
}
