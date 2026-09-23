using ProyectoIntegrador.Formularios.Devoluciones;
using ProyectoIntegrador.Formularios.Inventario;
using ProyectoIntegrador.Formularios.Ventas;
using ProyectoIntegrador.ModelosSimulados;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoIntegrador.Formularios.Gerente
{
    public partial class FormDashboardGerente : Form
    {
        private string nombreUsuarioLogueado;
        public FormDashboardGerente(string nombreUsuario)
        {
            InitializeComponent();

            nombreUsuarioLogueado = nombreUsuario;
        }

        // Constructor vacío para que el método genérico no rompa
        public FormDashboardGerente() : this("Gerente")
        {
        }

        private void FormDashboardGerente_Load(object sender, EventArgs e)
        {
            EstiloUI.AplicarEstiloFormulario(this);
            EstiloUI.AplicarEstiloTitulo(LTitulo);
            EstiloUI.AplicarEstiloBoton(BRefrescar);

            // Estilos de Cards superiores
            EstiloUI.AplicarEstiloCard(cardVentasDia, 12);
            EstiloUI.AplicarEstiloCard(cardRecaudacionMes, 12);
            EstiloUI.AplicarEstiloCard(cardAlertasStock, 12);

            // Estilos de Cards de Gráficos
            EstiloUI.AplicarEstiloCard(cardChartEvolucion, 12);
            EstiloUI.AplicarEstiloCard(cardChartCategorias, 12);

            // Estilos de Cards inferiores
            EstiloUI.AplicarEstiloCard(cardUltimasVentas, 12);
            EstiloUI.AplicarEstiloCard(cardProductosCriticos, 12);
            EstiloUI.AplicarEstiloCard(cardAcciones, 12);

            // Grillas compactas
            EstiloUI.AplicarEstiloGrilla(DGUltimasVentas);
            EstiloUI.AplicarEstiloGrilla(DGProductosCriticos);

            // Botones de acciones rápidas
            EstiloUI.AplicarEstiloBoton(BNuevaVenta);
            EstiloUI.AplicarEstiloBoton(BIngresoStock);
            EstiloUI.AplicarEstiloBoton(BDevoluciones);
            EstiloUI.AplicarEstiloBotonSecundario(BVerInformes);

            ConfigurarGrillas();
            ConfigurarGraficos();
            CargarDatosDashboard();
            AjustarLayoutResponsive();
        }

        private void ConfigurarGrillas()
        {
            // Grilla Últimas Ventas
            DGUltimasVentas.Columns.Clear();
            DGUltimasVentas.Columns.Add("colNro", "Nro.");
            DGUltimasVentas.Columns.Add("colCliente", "Cliente");
            DGUltimasVentas.Columns.Add("colFecha", "Fecha");
            DGUltimasVentas.Columns.Add("colTotal", "Total");

            DGUltimasVentas.Columns["colNro"].FillWeight = 20;
            DGUltimasVentas.Columns["colCliente"].FillWeight = 45;
            DGUltimasVentas.Columns["colFecha"].FillWeight = 35;
            DGUltimasVentas.Columns["colTotal"].FillWeight = 30;

            // Grilla Productos Críticos
            DGProductosCriticos.Columns.Clear();
            DGProductosCriticos.Columns.Add("colCodigo", "Cód.");
            DGProductosCriticos.Columns.Add("colJoya", "Joya");
            DGProductosCriticos.Columns.Add("colStock", "Stock");
            DGProductosCriticos.Columns.Add("colMinimo", "Mínimo");

            DGProductosCriticos.Columns["colCodigo"].FillWeight = 25;
            DGProductosCriticos.Columns["colJoya"].FillWeight = 50;
            DGProductosCriticos.Columns["colStock"].FillWeight = 20;
            DGProductosCriticos.Columns["colMinimo"].FillWeight = 20;
        }

        private void ConfigurarGraficos()
        {
            // 1. Gráfico de Evolución de Recaudación (Área / Líneas estilizada)
            chartEvolucion.BackColor = Color.White;
            var areaEvo = chartEvolucion.ChartAreas["ChartAreaEvolucion"];
            areaEvo.BackColor = Color.White;
            areaEvo.AxisX.MajorGrid.LineColor = Color.FromArgb(240, 235, 230);
            areaEvo.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 235, 230);
            areaEvo.AxisX.LabelStyle.Font = new Font("Segoe UI", 8f);
            areaEvo.AxisY.LabelStyle.Font = new Font("Segoe UI", 8f);
            areaEvo.AxisY.LabelStyle.Format = "${0:N0}";

            var serieEvo = chartEvolucion.Series["Recaudacion"];
            serieEvo.ChartType = SeriesChartType.SplineArea;
            serieEvo.BorderWidth = 3;
            serieEvo.Color = Color.FromArgb(180, 42, 8, 12); // Borgoña ALBA traslúcido
            serieEvo.BorderColor = EstiloUI.ColorBorgoña;
            serieEvo.MarkerStyle = MarkerStyle.Circle;
            serieEvo.MarkerSize = 6;
            serieEvo.MarkerColor = EstiloUI.ColorBorgoña;

            // 2. Gráfico de Ventas por Categoría (Dona)
            chartCategorias.BackColor = Color.White;
            var areaCat = chartCategorias.ChartAreas["ChartAreaCategorias"];
            areaCat.BackColor = Color.White;

            var serieCat = chartCategorias.Series["Categorias"];
            serieCat.ChartType = SeriesChartType.Doughnut;
            serieCat["PieLabelStyle"] = "Disabled"; // Etiquetas en leyenda para que quede limpio
            serieCat["DoughnutRadius"] = "55";

            var legend = chartCategorias.Legends["LegendCategorias"];
            legend.Docking = Docking.Right;
            legend.Alignment = StringAlignment.Center;
            legend.Font = new Font("Segoe UI", 8.5f);
            legend.BackColor = Color.Transparent;
        }

        public void CargarDatosDashboard()
        {
            // --- 1. TARJETAS DE INDICADORES (KPIs) ---
            EstadisticasSimuladas.ObtenerVentasDelDia(out decimal montoDia, out int opsDia);
            LVentasDiaMonto.Text = montoDia.ToString("C0");
            LVentasDiaOps.Text = $"{opsDia} operaciones registradas hoy";

            EstadisticasSimuladas.ObtenerRecaudacionMensual(out decimal montoMes, out int opsMes);
            LRecaudacionMesMonto.Text = montoMes.ToString("C0");
            LRecaudacionMesOps.Text = $"Total acumulado ({opsMes} ventas)";

            EstadisticasSimuladas.ObtenerAlertasStock(out int cantAlertas);
            LAlertasStockCant.Text = $"{cantAlertas} Joyas";
            LAlertasStockSub.Text = cantAlertas > 0 ? "Requieren reposición urgente" : "Stock en niveles óptimos";

            // --- 2. GRÁFICOS ESTADÍSTICOS ---
            // A. Evolución Recaudación
            var serieEvo = chartEvolucion.Series["Recaudacion"];
            serieEvo.Points.Clear();

            var datosEvo = EstadisticasSimuladas.ObtenerEvolucionRecaudacion(7);
            foreach (var kvp in datosEvo)
            {
                serieEvo.Points.AddXY(kvp.Key, (double)kvp.Value);
            }

            // B. Ventas por Categoría
            var serieCat = chartCategorias.Series["Categorias"];
            serieCat.Points.Clear();

            var datosCat = EstadisticasSimuladas.ObtenerVentasPorCategoria();
            Color[] paletaAlba = new Color[]
            {
                Color.FromArgb(42, 8, 12),    // Borgoña
                Color.FromArgb(197, 160, 89), // Oro / Dorado
                Color.FromArgb(119, 27, 34),  // Vino
                Color.FromArgb(141, 91, 76),  // Bronce / Canela
                Color.FromArgb(230, 194, 128),// Champán
                Color.FromArgb(160, 133, 125) // Platino / Ceniza
            };

            int colorIdx = 0;
            decimal totalGeneralCat = datosCat.Values.Sum();
            if (totalGeneralCat == 0) totalGeneralCat = 1;

            foreach (var kvp in datosCat)
            {
                int ptIndex = serieCat.Points.AddXY(kvp.Key, (double)kvp.Value);
                serieCat.Points[ptIndex].Color = paletaAlba[colorIdx % paletaAlba.Length];
                double pct = (double)(kvp.Value / totalGeneralCat) * 100.0;
                serieCat.Points[ptIndex].LegendText = $"{kvp.Key} ({pct:F1}%)";
                colorIdx++;
            }

            // --- 3. ACTIVIDAD RECIENTE Y PRODUCTOS CRÍTICOS ---
            // Últimas Ventas
            DGUltimasVentas.Rows.Clear();
            var ultimasVentas = EstadisticasSimuladas.ObtenerUltimasVentas(5);
            foreach (var v in ultimasVentas)
            {
                DGUltimasVentas.Rows.Add(
                    "#" + v.NroVenta,
                    v.Cliente,
                    v.Fecha.ToString("dd/MM HH:mm"),
                    v.Total.ToString("C0")
                );
            }

            // Productos Críticos
            DGProductosCriticos.Rows.Clear();
            var productosCriticos = EstadisticasSimuladas.ObtenerProductosCriticos();
            foreach (var p in productosCriticos)
            {
                int rowIdx = DGProductosCriticos.Rows.Add(
                    p.Codigo,
                    p.Nombre,
                    p.StockActual,
                    p.StockMinimo
                );

                if (p.StockActual <= p.StockMinimo)
                {
                    DGProductosCriticos.Rows[rowIdx].Cells["colStock"].Style.ForeColor = Color.FromArgb(179, 38, 30);
                    DGProductosCriticos.Rows[rowIdx].Cells["colStock"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
            }
        }

        private void AjustarLayoutResponsive()
        {
            int anchoTotal = this.ClientSize.Width - 40;
            if (anchoTotal < 800) anchoTotal = 800;

            // Bloque 1: KPIs
            int anchoCardKpi = (anchoTotal - 40) / 3;
            cardVentasDia.Width = anchoCardKpi;
            cardRecaudacionMes.Left = cardVentasDia.Right + 20;
            cardRecaudacionMes.Width = anchoCardKpi;
            cardAlertasStock.Left = cardRecaudacionMes.Right + 20;
            cardAlertasStock.Width = anchoCardKpi;

            // Bloque 2: Gráficos
            int anchoGraficos = (anchoTotal - 20) / 2;
            cardChartEvolucion.Width = anchoGraficos;
            cardChartCategorias.Left = cardChartEvolucion.Right + 20;
            cardChartCategorias.Width = anchoGraficos;

            // Bloque 3: Inferior (Grilla ventas 38%, Críticos 38%, Acciones 24%)
            int espacioInferior = anchoTotal - 40;
            int anchoGrillas = (int)(espacioInferior * 0.38);
            int anchoAcciones = espacioInferior - (anchoGrillas * 2);

            cardUltimasVentas.Width = anchoGrillas;
            cardProductosCriticos.Left = cardUltimasVentas.Right + 20;
            cardProductosCriticos.Width = anchoGrillas;
            cardAcciones.Left = cardProductosCriticos.Right + 20;
            cardAcciones.Width = anchoAcciones;
        }

        private void FormDashboardGerente_Resize(object sender, EventArgs e)
        {
            AjustarLayoutResponsive();
        }

        private void BRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatosDashboard();
            MessageBox.Show("Métricas del Dashboard actualizadas con éxito.", "Dashboard ALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BNuevaVenta_Click(object sender, EventArgs e)
        {
            using (FormRegistroVentas formVenta = new FormRegistroVentas(nombreUsuarioLogueado))
            {
                if (formVenta.ShowDialog() == DialogResult.OK)
                {
                    CargarDatosDashboard();
                }
            }
        }

        private void BIngresoStock_Click(object sender, EventArgs e)
        {
            using (FormAjusteStock formAjuste = new FormAjusteStock(nombreUsuarioLogueado))
            {
                formAjuste.ShowDialog();
                CargarDatosDashboard();
            }
        }

        private void BDevoluciones_Click(object sender, EventArgs e)
        {
            using (Devoluciones.FormRegistrarDevolucion formDev = new Devoluciones.FormRegistrarDevolucion())
            {
                if (formDev.ShowDialog() == DialogResult.OK)
                {
                    CargarDatosDashboard();
                }
            }
        }

        private void BVerInformes_Click(object sender, EventArgs e)
        {
            FormInformesEstadisticos formInfo = new FormInformesEstadisticos();
            if (this.MdiParent != null)
            {
                formInfo.MdiParent = this.MdiParent;
                formInfo.WindowState = FormWindowState.Maximized;
                formInfo.Show();
            }
            else
            {
                formInfo.ShowDialog();
            }
        }
    }
}
