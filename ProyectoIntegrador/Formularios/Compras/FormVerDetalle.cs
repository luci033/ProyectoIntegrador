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

namespace ProyectoIntegrador.Formularios.Compras
{
    public partial class FormVerDetalle : Form
    {
        private int idCompra;
        private string nroOrden;
        private string proveedor;
        private string fechaEmision;
        private string fechaRecepcion;
        private string observacion;
        private string totalGeneral;
        private List<object[]> listaProductosFallback;

        public FormVerDetalle(int idCompra, string nro, string prov, string fecha, string recep, string obs, string total)
        {
            InitializeComponent();
            this.idCompra = idCompra;
            this.nroOrden = nro;
            this.proveedor = prov;
            this.fechaEmision = fecha;
            this.fechaRecepcion = recep;
            this.observacion = obs;
            this.totalGeneral = total;
        }

        // Constructor de compatibilidad previa
        public FormVerDetalle(string nro, string prov, string fecha, string recep, string obs, string total, List<object[]> detalles = null)
            : this(int.TryParse(nro, out int id) ? id : 0, nro, prov, fecha, recep, obs, total)
        {
            this.listaProductosFallback = detalles;
        }

        private void FormVerDetalle_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloCard(panelCard, 16);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 10);
            EstiloUI.AplicarEstiloGrilla(DGDetalleOrden);
            EstiloUI.AplicarEstiloBoton(BCerrar);
            EstiloUI.CentrarControl(panelCard, this);

            TBNroOrden.Text = nroOrden;
            TBProveedor.Text = proveedor;
            TBFechaEmision.Text = fechaEmision;
            TBFechaRecepcion.Text = string.IsNullOrWhiteSpace(fechaRecepcion) || fechaRecepcion == "Registrar Recepción" ? "Pendiente" : fechaRecepcion;
            TBObservacion.Text = observacion;
            TBTotalGeneral.Text = totalGeneral;

            CargarDetalles();
        }

        private void CargarDetalles()
        {
            DGDetalleOrden.Rows.Clear();

            if (idCompra > 0)
            {
                try
                {
                    CN_Compra negocio = new CN_Compra();
                    DataTable dt = negocio.ObtenerDetalle(idCompra);

                    foreach (DataRow row in dt.Rows)
                    {
                        int idProducto = Convert.ToInt32(row["IdProducto"]);
                        string codigo = idProducto.ToString();
                        string nombre = row["NombreProducto"] != DBNull.Value ? row["NombreProducto"].ToString() : "";
                        string categoria = row["Categoria"] != DBNull.Value ? row["Categoria"].ToString() : "";
                        string genero = row["Genero"] != DBNull.Value ? row["Genero"].ToString() : "";
                        int cantPedida = Convert.ToInt32(row["CantidadPedida"]);
                        int cantRecibida = Convert.ToInt32(row["CantidadRecibida"]);
                        decimal costo = Convert.ToDecimal(row["PrecioUnitario"]);
                        decimal subtotal = Convert.ToDecimal(row["Subtotal"]);

                        DGDetalleOrden.Rows.Add(
                            idProducto,
                            codigo,
                            nombre,
                            categoria,
                            genero,
                            cantPedida,
                            cantRecibida,
                            costo,
                            subtotal
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los detalles de la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (listaProductosFallback != null)
            {
                foreach (var item in listaProductosFallback)
                {
                    DGDetalleOrden.Rows.Add(
                        item[0],
                        item[1],
                        item[2],
                        item[3],
                        item[4],
                        item[5],
                        item[8],
                        item[6],
                        item[7]
                    );
                }
            }
        }

        private void FormVerDetalle_Resize(object sender, EventArgs e)
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void DGDetalleOrden_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
