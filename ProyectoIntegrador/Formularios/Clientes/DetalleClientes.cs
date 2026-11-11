using CapaNegocio;
using ProyectoIntegrador.Formularios.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Formularios.Clientes
{
    public partial class DetalleClientes : Form
    {
        private int idClienteActual = 0;
        private CN_Venta objNegocioVenta = new CN_Venta();

        public DetalleClientes()
        {
            InitializeComponent();
        }

        private void DetalleClientes_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloCard(panelCard, 16);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 10);
            EstiloUI.AplicarEstiloGrilla(dataGridDetalleCliente);
            EstiloUI.AplicarEstiloBoton(BFiltrar);
            EstiloUI.AplicarEstiloBotonSecundario(BPDF);
            EstiloUI.AplicarEstiloBoton(BCerrar);
            EstiloUI.CentrarControl(panelCard, this);

            // Cargamos las opciones de Medio de Pago
            cmbDMedioPago.Items.Clear();
            cmbDMedioPago.Items.AddRange(new string[] { "Todos", "Contado", "Tarjeta", "Otro" });
            cmbDMedioPago.SelectedIndex = 0;

            // Por defecto ponemos Desde hace 1 año hasta Hoy
            DTPDesde.Value = DateTime.Today.AddYears(-1);
            DTPHasta.Value = DateTime.Today;

            // Cargamos todas las compras del cliente al abrir la ventana
            CargarHistorialCliente(false);
        }

        private void DetalleClientes_Resize(object sender, EventArgs e)
        {
            EstiloUI.CentrarControl(panelCard, this);
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarDatosCliente(int idCliente, string nombre, string correo, string condicionIVA, string dni)
        {
            idClienteActual = idCliente;
            TBNombre.Text = nombre;
            TBCorreo.Text = correo;
            cmbCondicionIVA.Text = condicionIVA;
            TBDni.Text = dni;

            cmbCondicionIVA.DataSource = null;
            cmbCondicionIVA.Items.Clear();
            cmbCondicionIVA.Items.Add(condicionIVA);
            cmbCondicionIVA.SelectedIndex = 0;
            cmbCondicionIVA.Enabled = false;
        }

        // Sobrecarga de compatibilidad
        public void CargarDatosCliente(string nombre, string correo, string condicionIVA, string dni)
        {
            CargarDatosCliente(0, nombre, correo, condicionIVA, dni);
        }

        private void CargarHistorialCliente(bool aplicarFiltroFechas)
        {
            dataGridDetalleCliente.Rows.Clear();

            DateTime? desde = null;
            DateTime? hasta = null;

            if (aplicarFiltroFechas)
            {
                desde = DTPDesde.Value.Date;
                hasta = DTPHasta.Value.Date.AddDays(1).AddSeconds(-1);
            }

            string medioSeleccionado = cmbDMedioPago.SelectedItem != null ? cmbDMedioPago.SelectedItem.ToString() : "Todos";

            DataTable tablaVentas = objNegocioVenta.ListarVentas(desde, hasta);

            foreach (DataRow row in tablaVentas.Rows)
            {
                int idCliVenta = Convert.ToInt32(row["IdCliente"]);
                string dniVenta = row["DNICUIT"].ToString().Trim();

                // Verificamos que la venta pertenezca a este cliente
                if (idCliVenta == idClienteActual || (!string.IsNullOrWhiteSpace(TBDni.Text) && dniVenta == TBDni.Text.Trim()))
                {
                    string medioPago = row["MedioPago"].ToString();

                    // Si eligió un medio de pago específico, filtramos
                    if (medioSeleccionado != "Todos" && medioPago != medioSeleccionado)
                    {
                        continue;
                    }

                    int nroVenta = Convert.ToInt32(row["IdComprobante"]);
                    DateTime fecha = Convert.ToDateTime(row["FechaComprobante"]);
                    decimal total = Convert.ToDecimal(row["Total"]);

                    int rowIdx = dataGridDetalleCliente.Rows.Add(
                        nroVenta,
                        fecha.ToString("dd/MM/yyyy HH:mm"),
                        medioPago,
                        total.ToString("C2"),
                        "Ver..."
                    );

                    dataGridDetalleCliente.Rows[rowIdx].Tag = total;
                }
            }
        }

        private void BFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DTPDesde.Value.Date;
            DateTime fechaFin = DTPHasta.Value.Date;

            // Validamos que el rango de fechas tenga sentido lógico
            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor a la fecha 'Hasta'.", "Filtro inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarHistorialCliente(true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nombreColumna = dataGridDetalleCliente.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "colDetalle")
            {
                int nroVenta = Convert.ToInt32(dataGridDetalleCliente.Rows[e.RowIndex].Cells[0].Value);

                using (FDetalleVenta formComprobante = new FDetalleVenta(nroVenta))
                {
                    formComprobante.ShowDialog();
                }
            }
        }

        private void BPDF_Click(object sender, EventArgs e)
        {
            if (dataGridDetalleCliente.Rows.Count == 0)
            {
                MessageBox.Show("El cliente no registra compras para imprimir o exportar.", "Sin Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (PrintDocument pd = new PrintDocument())
                {
                    pd.DocumentName = $"Historial_Cliente_{TBDni.Text}";
                    pd.PrintPage += new PrintPageEventHandler(ImprimirHistorial_PrintPage);

                    using (PrintPreviewDialog preview = new PrintPreviewDialog())
                    {
                        preview.Document = pd;
                        preview.Text = $"Vista Previa - Historial de Compras ({TBNombre.Text}) | Joyería ALBA";
                        preview.WindowState = FormWindowState.Maximized;
                        preview.ShowIcon = false;
                        preview.ShowDialog(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al preparar el documento para imprimir/exportar:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirHistorial_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int left = e.MarginBounds.Left;
            int top = e.MarginBounds.Top;
            int width = e.MarginBounds.Width;
            int right = e.MarginBounds.Right;
            int y = top;

            Color colorBordo = Color.FromArgb(42, 8, 12);
            Color colorSubtitulo = Color.FromArgb(141, 45, 59);
            Color colorGrisClaro = Color.FromArgb(245, 242, 238);

            using (Font fLogo = new Font("Georgia", 22, FontStyle.Bold))
            using (Font fSubLogo = new Font("Georgia", 9.5f, FontStyle.Italic))
            using (Font fTitulo = new Font("Georgia", 13, FontStyle.Bold))
            using (Font fLabel = new Font("Segoe UI", 9.5f, FontStyle.Bold))
            using (Font fValor = new Font("Segoe UI", 9.5f, FontStyle.Regular))
            using (Font fTablaHeader = new Font("Segoe UI", 9.5f, FontStyle.Bold))
            using (Font fTotal = new Font("Segoe UI", 12f, FontStyle.Bold))
            using (Pen penBorde = new Pen(colorBordo, 1.5f))
            using (Pen penFino = new Pen(Color.LightGray, 1f))
            using (SolidBrush brushBordo = new SolidBrush(colorBordo))
            using (SolidBrush brushSub = new SolidBrush(colorSubtitulo))
            using (SolidBrush brushNegro = new SolidBrush(Color.Black))
            using (SolidBrush brushBlanco = new SolidBrush(Color.White))
            using (SolidBrush brushFondoGris = new SolidBrush(colorGrisClaro))
            {
                // 1. Encabezado Joyería ALBA
                int headerHeight = 95;
                Rectangle rectHeader = new Rectangle(left, y, width, headerHeight);
                g.DrawRectangle(penBorde, rectHeader);

                g.DrawString("ALBA", fLogo, brushBordo, left + 18, y + 14);
                g.DrawString("JOYERÍA & ALTA GAMA", fSubLogo, brushSub, left + 20, y + 52);

                int rightColX = left + (width / 2) + 20;
                g.DrawString("HISTORIAL DE COMPRAS", fTitulo, brushBordo, rightColX, y + 18);
                g.DrawString("Fecha de Emisión:", fLabel, brushBordo, rightColX, y + 50);
                g.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fValor, brushNegro, rightColX + 120, y + 50);

                y += headerHeight + 12;

                // 2. Recuadro Datos del Cliente
                int clientHeight = 70;
                Rectangle rectCliente = new Rectangle(left, y, width, clientHeight);
                g.DrawRectangle(penBorde, rectCliente);

                int col1Label = left + 16;
                int col1Val = left + 150;
                int col2Label = left + (width / 2) + 10;
                int col2Val = col2Label + 115;

                g.DrawString("Nombre y Apellido:", fLabel, brushBordo, col1Label, y + 14);
                g.DrawString(TBNombre.Text, fValor, brushNegro, col1Val, y + 14);

                g.DrawString("DNI / CUIT:", fLabel, brushBordo, col1Label, y + 40);
                g.DrawString(TBDni.Text, fValor, brushNegro, col1Val, y + 40);

                g.DrawString("Condición IVA:", fLabel, brushBordo, col2Label, y + 14);
                g.DrawString(cmbCondicionIVA.Text, fValor, brushNegro, col2Val, y + 14);

                g.DrawString("Correo:", fLabel, brushBordo, col2Label, y + 40);
                g.DrawString(TBCorreo.Text, fValor, brushNegro, col2Val, y + 40);

                y += clientHeight + 16;

                // 3. Encabezado de la Grilla de Compras
                int tableHeaderHeight = 28;
                Rectangle rectTableHeader = new Rectangle(left, y, width, tableHeaderHeight);
                g.FillRectangle(brushBordo, rectTableHeader);

                int wNro = 120;
                int wFecha = 180;
                int wMedio = 180;
                int wTotal = width - (wNro + wFecha + wMedio);

                int xNro = left;
                int xFecha = xNro + wNro;
                int xMedio = xFecha + wFecha;
                int xTotal = xMedio + wMedio;

                StringFormat sfLeft = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };
                StringFormat sfRight = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };

                g.DrawString("Nro. Venta", fTablaHeader, brushBlanco, new Rectangle(xNro + 10, y, wNro - 10, tableHeaderHeight), sfLeft);
                g.DrawString("Fecha", fTablaHeader, brushBlanco, new Rectangle(xFecha + 10, y, wFecha - 10, tableHeaderHeight), sfLeft);
                g.DrawString("Medio de Pago", fTablaHeader, brushBlanco, new Rectangle(xMedio + 10, y, wMedio - 10, tableHeaderHeight), sfLeft);
                g.DrawString("Total Facturado", fTablaHeader, brushBlanco, new Rectangle(xTotal, y, wTotal - 12, tableHeaderHeight), sfRight);

                y += tableHeaderHeight;

                // 4. Filas de Compras
                int rowHeight = 26;
                int idx = 0;
                decimal sumaTotal = 0;

                foreach (DataGridViewRow row in dataGridDetalleCliente.Rows)
                {
                    if (row.IsNewRow) continue;

                    Rectangle rectRow = new Rectangle(left, y, width, rowHeight);
                    if (idx % 2 == 1)
                    {
                        g.FillRectangle(brushFondoGris, rectRow);
                    }
                    g.DrawLine(penFino, left, y + rowHeight, right, y + rowHeight);

                    string nro = "#" + Convert.ToInt32(row.Cells[0].Value).ToString("D5");
                    string fecha = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";
                    string medio = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "";
                    string totalTxt = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "$ 0,00";

                    if (row.Tag != null)
                    {
                        sumaTotal += Convert.ToDecimal(row.Tag);
                    }

                    g.DrawString(nro, fValor, brushNegro, new Rectangle(xNro + 10, y, wNro - 10, rowHeight), sfLeft);
                    g.DrawString(fecha, fValor, brushNegro, new Rectangle(xFecha + 10, y, wFecha - 10, rowHeight), sfLeft);
                    g.DrawString(medio, fValor, brushNegro, new Rectangle(xMedio + 10, y, wMedio - 10, rowHeight), sfLeft);
                    g.DrawString(totalTxt, fValor, brushNegro, new Rectangle(xTotal, y, wTotal - 12, rowHeight), sfRight);

                    y += rowHeight;
                    idx++;
                }

                g.DrawRectangle(penBorde, new Rectangle(left, y - (idx * rowHeight) - tableHeaderHeight, width, (idx * rowHeight) + tableHeaderHeight));

                y += 18;

                // 5. Total acumulado del cliente
                int totalBoxWidth = 300;
                int totalBoxHeight = 40;
                Rectangle rectTotal = new Rectangle(right - totalBoxWidth, y, totalBoxWidth, totalBoxHeight);
                g.FillRectangle(brushFondoGris, rectTotal);
                g.DrawRectangle(penBorde, rectTotal);

                g.DrawString("TOTAL ACUMULADO:", fLabel, brushBordo, new Rectangle(rectTotal.Left + 12, y, 140, totalBoxHeight), sfLeft);
                g.DrawString(sumaTotal.ToString("C2"), fTotal, brushBordo, new Rectangle(rectTotal.Left + 145, y, totalBoxWidth - 155, totalBoxHeight), sfRight);
            }
        }
    }
}
