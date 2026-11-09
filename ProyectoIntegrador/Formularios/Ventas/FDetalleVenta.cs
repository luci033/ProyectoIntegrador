using CapaEntidades;
using CapaNegocio;
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

namespace ProyectoIntegrador.Formularios.Ventas
{
    public partial class FDetalleVenta : Form
    {
        private string tipoComprobanteDescripcion = "";
        private int indiceImpresionActual = 0;

        // Modelo para representar un renglón del detalle
        public class ItemDetalle
        {
            public string Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Subtotal => Cantidad * PrecioUnitario;
        }

        // Constructor con persistencia real desde la base de datos
        public FDetalleVenta(int idComprobante)
        {
            InitializeComponent();

            BloquearCampos();

            try
            {
                Comprobante venta = new CN_Venta().ObtenerVentaPorId(idComprobante);
                if (venta != null)
                {
                    tipoComprobanteDescripcion = venta.DescripcionTipoComprobante ?? "";
                    LInfoVenta.Text = $"Detalle del Comprobante N°: {venta.IdComprobante:D5}";
                    TBNroVenta.Text = venta.IdComprobante.ToString("D5");
                    textBox5.Text = venta.FechaComprobante.ToString("dd/MM/yyyy HH:mm");
                    TBVendedor.Text = !string.IsNullOrWhiteSpace(venta.NombreUsuario)
                        ? venta.NombreUsuario
                        : (!string.IsNullOrWhiteSpace(SesionActual.NombreCompleto) ? SesionActual.NombreCompleto : "Vendedor");
                    textBox3.Text = !string.IsNullOrWhiteSpace(venta.DescripcionMedioPago) ? venta.DescripcionMedioPago : "Contado";
                    TBRazonSocial.Text = venta.NombreCliente;
                    TBCondicionIVA.Text = !string.IsNullOrWhiteSpace(venta.CondicionIvaCliente) ? venta.CondicionIvaCliente : "Consumidor Final";
                    TBCUITDNI.Text = !string.IsNullOrWhiteSpace(venta.DocumentoCliente) ? venta.DocumentoCliente : "-";
                    TBTeléfono.Text = !string.IsNullOrWhiteSpace(venta.TelefonoCliente) ? venta.TelefonoCliente : "-";

                    dataGridDetalle.Rows.Clear();
                    decimal totalGeneral = 0;

                    foreach (var item in venta.Detalles)
                    {
                        dataGridDetalle.Rows.Add(
                            item.IdProducto,
                            item.NombreProducto,
                            item.Cantidad,
                            item.PrecioUnitario.ToString("C2"),
                            item.Subtotal.ToString("C2")
                        );
                        totalGeneral += item.Subtotal;
                    }

                    TBTotal.Text = totalGeneral.ToString("C2");
                }
                else
                {
                    MessageBox.Show("No se encontró el comprobante solicitado en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle del comprobante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Constructor para compatibilidad previa
        public FDetalleVenta(FormVentas.DatosVenta ventaData)
        {
            InitializeComponent();

            BloquearCampos();

            if (ventaData != null)
            {
                LInfoVenta.Text = $"Detalle del Comprobante N°: {ventaData.Nro:D5}";
                TBNroVenta.Text = ventaData.Nro.ToString("D5");
                textBox5.Text = ventaData.Fecha;
                TBVendedor.Text = !string.IsNullOrWhiteSpace(SesionActual.NombreCompleto)
                    ? SesionActual.NombreCompleto
                    : (!string.IsNullOrWhiteSpace(SesionActual.LoginUsuario) ? SesionActual.LoginUsuario : "Vendedor");
                textBox3.Text = ventaData.MetodoPago;
                TBRazonSocial.Text = ventaData.Cliente;
                TBCondicionIVA.Text = ventaData.Iva;

                TBCUITDNI.Text = "-";
                TBTeléfono.Text = "-";

                CargarArticulosDinámicos(ventaData);
            }
        }

        private void BloquearCampos()
        {
            TBNroVenta.ReadOnly = true;
            textBox5.ReadOnly = true;
            TBVendedor.ReadOnly = true;
            textBox3.ReadOnly = true;
            TBRazonSocial.ReadOnly = true;
            TBCondicionIVA.ReadOnly = true;
            TBCUITDNI.ReadOnly = true;
            TBTeléfono.ReadOnly = true;
            TBTotal.ReadOnly = true;
        }

        private void CargarArticulosDinámicos(FormVentas.DatosVenta ventaData)
        {
            dataGridDetalle.Rows.Clear();
            decimal totalGeneral = 0;

            foreach (var item in ventaData.Articulos)
            {
                dataGridDetalle.Rows.Add(
                    "",
                    item.Producto,
                    item.Cantidad,
                    item.PrecioUnitario.ToString("C2"),
                    item.Subtotal.ToString("C2")
                );
                totalGeneral += item.Subtotal;
            }

            TBTotal.Text = totalGeneral.ToString("C2");
        }

        private void FDetalleVenta_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloPanelSeccion(panel1, 10);
            EstiloUI.AplicarEstiloPanelSeccion(panel2, 10);
            EstiloUI.AplicarEstiloCard(panelCard, 12);
            EstiloUI.AplicarEstiloBotonSecundario(BImprimir);
            EstiloUI.AplicarEstiloBoton(BCerrar);
            EstiloUI.AplicarEstiloGrilla(dataGridDetalle);

            EstiloUI.AplicarEstiloTextBox(TBNroVenta);
            EstiloUI.AplicarEstiloTextBox(textBox5);
            EstiloUI.AplicarEstiloTextBox(TBVendedor);
            EstiloUI.AplicarEstiloTextBox(TBCUITDNI);
            EstiloUI.AplicarEstiloTextBox(TBRazonSocial);
            EstiloUI.AplicarEstiloTextBox(TBCondicionIVA);
            EstiloUI.AplicarEstiloTextBox(TBTeléfono);
            EstiloUI.AplicarEstiloTextBox(textBox3);
            EstiloUI.AplicarEstiloTextBox(TBTotal);
        }

        private void BImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                indiceImpresionActual = 0;
                using (PrintDocument pd = new PrintDocument())
                {
                    pd.DocumentName = $"Factura_ALBA_{TBNroVenta.Text}";
                    pd.BeginPrint += (s, ev) => { indiceImpresionActual = 0; };
                    pd.PrintPage += ImprimirFactura_PrintPage;

                    using (PrintPreviewDialog preview = new PrintPreviewDialog())
                    {
                        preview.Document = pd;
                        preview.Text = $"Vista Previa - Factura N° {TBNroVenta.Text} | Joyería ALBA";
                        preview.WindowState = FormWindowState.Maximized;
                        preview.ShowIcon = false;
                        preview.ShowDialog(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al preparar la impresión de la factura:\n" + ex.Message, "Error de Impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirFactura_PrintPage(object sender, PrintPageEventArgs e)
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
            using (Font fLetra = new Font("Georgia", 20, FontStyle.Bold))
            using (Font fTitulo = new Font("Georgia", 12, FontStyle.Bold))
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
                // Determinar letra de factura (A o B)
                string condicionIva = TBCondicionIVA.Text ?? "";
                string letraFactura = "B";
                if ((!string.IsNullOrWhiteSpace(tipoComprobanteDescripcion) && tipoComprobanteDescripcion.ToUpper().Contains("FACTURA A")) ||
                    condicionIva.ToLower().Contains("inscripto"))
                {
                    letraFactura = "A";
                }

                // 1. Recuadro de Encabezado
                int headerHeight = 115;
                Rectangle rectHeader = new Rectangle(left, y, width, headerHeight);
                g.DrawRectangle(penBorde, rectHeader);

                // Recuadro central de la Letra (A / B)
                int boxSize = 46;
                int boxX = left + (width / 2) - (boxSize / 2);
                Rectangle rectLetra = new Rectangle(boxX, y, boxSize, boxSize);
                g.FillRectangle(brushFondoGris, rectLetra);
                g.DrawRectangle(penBorde, rectLetra);

                StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(letraFactura, fLetra, brushBordo, rectLetra, sfCenter);
                g.DrawLine(penFino, left + (width / 2), y + boxSize, left + (width / 2), y + headerHeight);

                // Lado Izquierdo: Datos de la Joyería
                g.DrawString("ALBA", fLogo, brushBordo, left + 18, y + 16);
                g.DrawString("JOYERÍA & ALTA GAMA", fSubLogo, brushSub, left + 20, y + 54);
                g.DrawString("Condición frente al IVA: Responsable Inscripto", fValor, brushNegro, left + 20, y + 80);

                // Lado Derecho: Datos del Comprobante y Vendedor
                int rightColX = left + (width / 2) + 32;
                g.DrawString("COMPROBANTE DE VENTA", fTitulo, brushBordo, rightColX, y + 12);

                g.DrawString("Nro. Venta:", fLabel, brushBordo, rightColX, y + 40);
                g.DrawString($"#{TBNroVenta.Text}", fValor, brushNegro, rightColX + 105, y + 40);

                g.DrawString("Fecha Emisión:", fLabel, brushBordo, rightColX, y + 63);
                g.DrawString(textBox5.Text, fValor, brushNegro, rightColX + 105, y + 63);

                g.DrawString("Vendedor:", fLabel, brushBordo, rightColX, y + 86);
                g.DrawString(TBVendedor.Text, fValor, brushNegro, rightColX + 105, y + 86);

                y += headerHeight + 12;

                // 2. Recuadro de Datos del Cliente
                int clientHeight = 85;
                Rectangle rectCliente = new Rectangle(left, y, width, clientHeight);
                g.DrawRectangle(penBorde, rectCliente);

                int col1Label = left + 16;
                int col1Val = left + 145;
                int col2Label = left + (width / 2) + 10;
                int col2Val = col2Label + 95;

                g.DrawString("CUIT / DNI:", fLabel, brushBordo, col1Label, y + 12);
                g.DrawString(TBCUITDNI.Text, fValor, brushNegro, col1Val, y + 12);

                g.DrawString("Condición IVA:", fLabel, brushBordo, col1Label, y + 36);
                g.DrawString(TBCondicionIVA.Text, fValor, brushNegro, col1Val, y + 36);

                g.DrawString("Condición de Venta:", fLabel, brushBordo, col1Label, y + 60);
                g.DrawString(textBox3.Text, fValor, brushNegro, col1Val, y + 60);

                g.DrawString("Razón Social:", fLabel, brushBordo, col2Label, y + 12);
                g.DrawString(TBRazonSocial.Text, fValor, brushNegro, col2Val, y + 12);

                g.DrawString("Teléfono:", fLabel, brushBordo, col2Label, y + 36);
                g.DrawString(TBTeléfono.Text, fValor, brushNegro, col2Val, y + 36);

                y += clientHeight + 16;

                // 3. Encabezado de la Grilla de Productos
                int tableHeaderHeight = 28;
                Rectangle rectTableHeader = new Rectangle(left, y, width, tableHeaderHeight);
                g.FillRectangle(brushBordo, rectTableHeader);

                int wCodigo = 70;
                int wCant = 80;
                int wPrecio = 120;
                int wSubtotal = 120;
                int wProd = width - (wCodigo + wCant + wPrecio + wSubtotal);

                int xCod = left;
                int xProd = xCod + wCodigo;
                int xCant = xProd + wProd;
                int xPrecio = xCant + wCant;
                int xSub = xPrecio + wPrecio;

                StringFormat sfLeft = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };
                StringFormat sfRight = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };

                g.DrawString("Cód.", fTablaHeader, brushBlanco, new Rectangle(xCod + 6, y, wCodigo - 12, tableHeaderHeight), sfLeft);
                g.DrawString("Producto", fTablaHeader, brushBlanco, new Rectangle(xProd + 6, y, wProd - 12, tableHeaderHeight), sfLeft);
                g.DrawString("Cant.", fTablaHeader, brushBlanco, new Rectangle(xCant, y, wCant, tableHeaderHeight), sfCenter);
                g.DrawString("Precio Unit.", fTablaHeader, brushBlanco, new Rectangle(xPrecio, y, wPrecio - 8, tableHeaderHeight), sfRight);
                g.DrawString("SubTotal", fTablaHeader, brushBlanco, new Rectangle(xSub, y, wSubtotal - 8, tableHeaderHeight), sfRight);

                y += tableHeaderHeight;

                // 4. Filas del Detalle
                int rowHeight = 26;
                int maxBottom = e.MarginBounds.Bottom - 90;

                while (indiceImpresionActual < dataGridDetalle.Rows.Count)
                {
                    DataGridViewRow row = dataGridDetalle.Rows[indiceImpresionActual];
                    if (row.IsNewRow)
                    {
                        indiceImpresionActual++;
                        continue;
                    }

                    if (y + rowHeight > maxBottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    if (indiceImpresionActual % 2 == 1)
                    {
                        g.FillRectangle(brushFondoGris, new Rectangle(left, y, width, rowHeight));
                    }

                    string cod = row.Cells[0].Value?.ToString() ?? "";
                    string prod = row.Cells[1].Value?.ToString() ?? "";
                    string cant = row.Cells[2].Value?.ToString() ?? "";
                    string prec = row.Cells[3].Value?.ToString() ?? "";
                    string sub = row.Cells[4].Value?.ToString() ?? "";

                    g.DrawString(cod, fValor, brushNegro, new Rectangle(xCod + 6, y, wCodigo - 12, rowHeight), sfLeft);
                    g.DrawString(prod, fValor, brushNegro, new Rectangle(xProd + 6, y, wProd - 12, rowHeight), sfLeft);
                    g.DrawString(cant, fValor, brushNegro, new Rectangle(xCant, y, wCant, rowHeight), sfCenter);
                    g.DrawString(prec, fValor, brushNegro, new Rectangle(xPrecio, y, wPrecio - 8, rowHeight), sfRight);
                    g.DrawString(sub, fValor, brushNegro, new Rectangle(xSub, y, wSubtotal - 8, rowHeight), sfRight);

                    g.DrawLine(penFino, left, y + rowHeight, right, y + rowHeight);

                    y += rowHeight;
                    indiceImpresionActual++;
                }

                // 5. Total General al pie
                y += 16;
                int totalBoxWidth = 250;
                int totalBoxHeight = 38;
                Rectangle rectTotal = new Rectangle(right - totalBoxWidth, y, totalBoxWidth, totalBoxHeight);
                g.FillRectangle(brushFondoGris, rectTotal);
                g.DrawRectangle(penBorde, rectTotal);

                g.DrawString("TOTAL:", fTotal, brushBordo, new Rectangle(rectTotal.X + 12, rectTotal.Y, 90, totalBoxHeight), sfLeft);
                g.DrawString(TBTotal.Text, fTotal, brushBordo, new Rectangle(rectTotal.X + 90, rectTotal.Y, totalBoxWidth - 102, totalBoxHeight), sfRight);

                y += totalBoxHeight + 18;
                g.DrawString("Gracias por su compra - Joyería ALBA", fSubLogo, brushSub, new Rectangle(left, y, width, 22), sfCenter);

                e.HasMorePages = false;
            }
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
