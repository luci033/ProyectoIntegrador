using CapaNegocio;
using ProyectoIntegrador.Formularios.Devoluciones;
using ProyectoIntegrador.Formularios.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoIntegrador.Formularios.Gerente
{
    public partial class FormDashboardGerente : Form
    {
        private string nombreUsuarioLogueado;
        private CN_Venta objNegocioVenta = new CN_Venta();
        private CN_Producto objNegocioProducto = new CN_Producto();
        private bool inicializandoCombos = false;

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
            EstiloUI.AplicarEstiloCard(cardChartSecundario, 12);

            // Estilos de Cards inferiores
            EstiloUI.AplicarEstiloCard(cardUltimasVentas, 12);
            EstiloUI.AplicarEstiloCard(cardProductosCriticos, 12);
            EstiloUI.AplicarEstiloCard(cardAcciones, 12);

            // Grillas compactas
            EstiloUI.AplicarEstiloGrilla(DGUltimasVentas);
            EstiloUI.AplicarEstiloGrilla(DGProductosCriticos);

            // Botones de acciones de consulta
            EstiloUI.AplicarEstiloBoton(BVerInformes);
            EstiloUI.AplicarEstiloBoton(BDevoluciones);
            EstiloUI.AplicarEstiloBoton(BVerHistorial);

            ConfigurarGrillas();
            ConfigurarGraficos();

            inicializandoCombos = true;
            CBFiltroPeriodo.Items.Clear();
            CBFiltroPeriodo.Items.Add("Por Semana (Últimos 7 días)");
            CBFiltroPeriodo.Items.Add("Por Mes (Semanas del Mes Actual)");
            CBFiltroPeriodo.Items.Add("Por Año (Meses del Año Actual)");
            CBFiltroPeriodo.SelectedIndex = 0;

            CBFiltroChartSecundario.Width = 230;
            CBFiltroChartSecundario.Items.Clear();
            CBFiltroChartSecundario.Items.Add("Comparar Meses (Actual vs Anterior)");
            CBFiltroChartSecundario.Items.Add("Comparar Años Mes a Mes");
            CBFiltroChartSecundario.Items.Add("Comparar Totales Anuales");
            CBFiltroChartSecundario.SelectedIndex = 1; // Por defecto compara Año Actual vs Año Anterior mes a mes
            inicializandoCombos = false;

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

            // 3. Gráfico Secundario Comparativo (Barras / Columnas)
            chartSecundario.BackColor = Color.White;
            var areaSec = chartSecundario.ChartAreas["ChartAreaSecundario"];
            areaSec.BackColor = Color.White;
            areaSec.AxisX.MajorGrid.LineColor = Color.FromArgb(240, 235, 230);
            areaSec.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 235, 230);
            areaSec.AxisX.LabelStyle.Font = new Font("Segoe UI", 8.5f);
            areaSec.AxisY.LabelStyle.Font = new Font("Segoe UI", 8.5f);
            areaSec.AxisY.LabelStyle.Format = "${0:N0}";

            if (chartSecundario.Legends.Count == 0)
            {
                Legend legSec = new Legend("LegendSecundario");
                legSec.Docking = Docking.Top;
                legSec.Alignment = StringAlignment.Far;
                legSec.Font = new Font("Segoe UI", 8.5f);
                legSec.BackColor = Color.Transparent;
                chartSecundario.Legends.Add(legSec);
            }
        }

        public void CargarDatosDashboard()
        {
            // --- 1. TARJETAS DE INDICADORES (KPIs) Y GRILLAS INFERIORES ---
            DateTime hoy = DateTime.Today;
            DateTime mesAnterior = hoy.AddMonths(-1);
            decimal montoDia = 0;
            int opsDia = 0;
            decimal montoMes = 0;
            int opsMes = 0;
            decimal montoMesAnterior = 0;

            DGUltimasVentas.Rows.Clear();
            DataTable tablaVentas = objNegocioVenta.ListarVentas();

            foreach (DataRow row in tablaVentas.Rows)
            {
                DateTime fecha = Convert.ToDateTime(row["FechaComprobante"]);
                decimal total = Convert.ToDecimal(row["Total"]);

                // Ventas de hoy
                if (fecha.Date == hoy)
                {
                    montoDia += total;
                    opsDia++;
                }

                // Ventas del mes actual
                if (fecha.Month == hoy.Month && fecha.Year == hoy.Year)
                {
                    montoMes += total;
                    opsMes++;
                }

                // Ventas del mes anterior (para comparar)
                if (fecha.Month == mesAnterior.Month && fecha.Year == mesAnterior.Year)
                {
                    montoMesAnterior += total;
                }

                // Cargamos solo las primeras 5 en la grilla de Últimas Ventas
                if (DGUltimasVentas.Rows.Count < 5)
                {
                    int nroVenta = Convert.ToInt32(row["IdComprobante"]);
                    string cliente = row["Cliente"].ToString();
                    DGUltimasVentas.Rows.Add("#" + nroVenta.ToString("D5"), cliente, fecha.ToString("dd/MM HH:mm"), total.ToString("C0"));
                }
            }

            LVentasDiaMonto.Text = montoDia.ToString("C0");
            LVentasDiaOps.Text = $"{opsDia} operaciones registradas hoy";

            LRecaudacionMesMonto.Text = montoMes.ToString("C0");
            LRecaudacionMesOps.Text = $"{opsMes} ventas | Mes ant.: {montoMesAnterior.ToString("C0")}";

            // Productos Críticos y Alerta de Stock
            int cantAlertas = 0;
            DGProductosCriticos.Rows.Clear();
            DataTable tablaProductos = objNegocioProducto.Listar();

            var filasCriticas = new List<DataRow>();
            if (tablaProductos != null)
            {
                foreach (DataRow row in tablaProductos.Rows)
                {
                    bool activo = row["Estado"] != DBNull.Value && Convert.ToBoolean(row["Estado"]);
                    int stockActual = row["StockActual"] != DBNull.Value ? Convert.ToInt32(row["StockActual"]) : 0;
                    int stockMinimo = row["StockMinimo"] != DBNull.Value ? Convert.ToInt32(row["StockMinimo"]) : 0;

                    if (activo && stockActual <= stockMinimo)
                    {
                        filasCriticas.Add(row);
                    }
                }
            }

            foreach (DataRow row in filasCriticas.OrderBy(r => r["StockActual"] != DBNull.Value ? Convert.ToInt32(r["StockActual"]) : 0))
            {
                int stockActual = row["StockActual"] != DBNull.Value ? Convert.ToInt32(row["StockActual"]) : 0;
                int stockMinimo = row["StockMinimo"] != DBNull.Value ? Convert.ToInt32(row["StockMinimo"]) : 0;

                cantAlertas++;
                int rowIdx = DGProductosCriticos.Rows.Add(
                    row["IdProducto"].ToString(),
                    row["NombreProducto"].ToString(),
                    stockActual,
                    stockMinimo
                );

                DGProductosCriticos.Rows[rowIdx].Cells["colStock"].Style.ForeColor = Color.FromArgb(179, 38, 30);
                DGProductosCriticos.Rows[rowIdx].Cells["colStock"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            }

            LAlertasStockCant.Text = $"{cantAlertas} Joyas";
            LAlertasStockSub.Text = cantAlertas > 0 ? "Requieren reposición urgente" : "Stock en niveles óptimos";

            // --- 2. GRÁFICOS ESTADÍSTICOS ---
            // A. Evolución de Recaudación según el filtro seleccionado
            string filtro = CBFiltroPeriodo.SelectedItem != null ? CBFiltroPeriodo.SelectedItem.ToString() : "Por Semana (Últimos 7 días)";
            var serieEvo = chartEvolucion.Series["Recaudacion"];
            serieEvo.Points.Clear();
            chartEvolucion.ChartAreas["ChartAreaEvolucion"].AxisX.Interval = 1;

            if (filtro == "Por Semana (Últimos 7 días)")
            {
                LTituloChartEvolucion.Text = "Evolución de Recaudación (Últimos 7 días)";

                for (int i = 6; i >= 0; i--)
                {
                    DateTime dia = hoy.AddDays(-i);
                    decimal totalDia = 0;

                    foreach (DataRow row in tablaVentas.Rows)
                    {
                        DateTime fecha = Convert.ToDateTime(row["FechaComprobante"]);
                        if (fecha.Date == dia.Date)
                        {
                            totalDia += Convert.ToDecimal(row["Total"]);
                        }
                    }
                    serieEvo.Points.AddXY(dia.ToString("dd/MM"), (double)totalDia);
                }
            }
            else if (filtro == "Por Mes (Semanas del Mes Actual)")
            {
                LTituloChartEvolucion.Text = "Evolución del Mes por Semanas";

                for (int semana = 1; semana <= 4; semana++)
                {
                    decimal totalSemana = 0;

                    foreach (DataRow row in tablaVentas.Rows)
                    {
                        DateTime fecha = Convert.ToDateTime(row["FechaComprobante"]);
                        if (fecha.Month == hoy.Month && fecha.Year == hoy.Year)
                        {
                            int nroSemana = ((fecha.Day - 1) / 7) + 1;
                            if (nroSemana > 4) nroSemana = 4;

                            if (nroSemana == semana)
                            {
                                totalSemana += Convert.ToDecimal(row["Total"]);
                            }
                        }
                    }
                    serieEvo.Points.AddXY("Sem. " + semana, (double)totalSemana);
                }
            }
            else if (filtro == "Por Año (Meses del Año Actual)")
            {
                LTituloChartEvolucion.Text = "Evolución Mensual de Recaudación (" + hoy.Year + ")";
                string[] nombresMeses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

                for (int mes = 1; mes <= 12; mes++)
                {
                    decimal totalMes = 0;

                    foreach (DataRow row in tablaVentas.Rows)
                    {
                        DateTime fecha = Convert.ToDateTime(row["FechaComprobante"]);
                        if (fecha.Year == hoy.Year && fecha.Month == mes)
                        {
                            totalMes += Convert.ToDecimal(row["Total"]);
                        }
                    }
                    serieEvo.Points.AddXY(nombresMeses[mes - 1], (double)totalMes);
                }
            }

            // B. Ventas por Categoría (Desde la Base de Datos)
            var serieCat = chartCategorias.Series["Categorias"];
            serieCat.Points.Clear();

            DataTable tablaCat = objNegocioVenta.ListarVentasPorCategoria();

            Color[] paletaAlba = new Color[]
            {
                Color.FromArgb(42, 8, 12),    // Borgoña
                Color.FromArgb(197, 160, 89), // Oro / Dorado
                Color.FromArgb(119, 27, 34),  // Vino
                Color.FromArgb(141, 91, 76),  // Bronce / Canela
                Color.FromArgb(230, 194, 128),// Champán
                Color.FromArgb(160, 133, 125) // Platino / Ceniza
            };

            decimal totalGeneralCat = 0;
            foreach (DataRow row in tablaCat.Rows)
            {
                totalGeneralCat += Convert.ToDecimal(row["TotalRecaudado"]);
            }
            if (totalGeneralCat == 0) totalGeneralCat = 1;

            int colorIdx = 0;
            foreach (DataRow row in tablaCat.Rows)
            {
                string nombreCat = row["Categoria"].ToString();
                decimal montoCat = Convert.ToDecimal(row["TotalRecaudado"]);

                int ptIndex = serieCat.Points.AddXY(nombreCat, (double)montoCat);
                serieCat.Points[ptIndex].Color = paletaAlba[colorIdx % paletaAlba.Length];
                double pct = (double)(montoCat / totalGeneralCat) * 100.0;
                serieCat.Points[ptIndex].LegendText = $"{nombreCat} ({pct:F1}%)";
                colorIdx++;
            }

            // C. Gráfico Secundario Comparativo (Barras)
            CargarGraficoSecundario(tablaVentas, hoy);
        }

        private void CargarGraficoSecundario(DataTable tablaVentas, DateTime hoy)
        {
            if (tablaVentas == null)
            {
                tablaVentas = objNegocioVenta.ListarVentas();
            }

            string filtroSec = CBFiltroChartSecundario.SelectedItem != null
                ? CBFiltroChartSecundario.SelectedItem.ToString()
                : "Comparar Años Mes a Mes";

            chartSecundario.Series.Clear();
            chartSecundario.ChartAreas["ChartAreaSecundario"].AxisX.Interval = 1;

            if (filtroSec == "Comparar Meses (Actual vs Anterior)")
            {
                DateTime mesAnt = hoy.AddMonths(-1);
                LTituloChartSecundario.Text = "Comparación por Semanas: Mes Anterior vs Mes Actual";

                Series serieAnterior = new Series("Mes Anterior (" + mesAnt.ToString("MM/yyyy") + ")");
                serieAnterior.ChartType = SeriesChartType.Column;
                serieAnterior.Color = Color.FromArgb(197, 160, 89); // Dorado ALBA

                Series serieActual = new Series("Mes Actual (" + hoy.ToString("MM/yyyy") + ")");
                serieActual.ChartType = SeriesChartType.Column;
                serieActual.Color = EstiloUI.ColorBorgoña; // Borgoña ALBA

                for (int semana = 1; semana <= 4; semana++)
                {
                    decimal totalSemAnt = 0;
                    decimal totalSemAct = 0;

                    foreach (DataRow row in tablaVentas.Rows)
                    {
                        DateTime fecha = Convert.ToDateTime(row["FechaComprobante"]);
                        int nroSemana = ((fecha.Day - 1) / 7) + 1;
                        if (nroSemana > 4) nroSemana = 4;

                        if (nroSemana == semana)
                        {
                            if (fecha.Month == mesAnt.Month && fecha.Year == mesAnt.Year)
                            {
                                totalSemAnt += Convert.ToDecimal(row["Total"]);
                            }
                            else if (fecha.Month == hoy.Month && fecha.Year == hoy.Year)
                            {
                                totalSemAct += Convert.ToDecimal(row["Total"]);
                            }
                        }
                    }

                    serieAnterior.Points.AddXY("Semana " + semana, (double)totalSemAnt);
                    serieActual.Points.AddXY("Semana " + semana, (double)totalSemAct);
                }

                chartSecundario.Series.Add(serieAnterior);
                chartSecundario.Series.Add(serieActual);
            }
            else if (filtroSec == "Comparar Años Mes a Mes")
            {
                int anioAnt = hoy.Year - 1;
                int anioAct = hoy.Year;
                LTituloChartSecundario.Text = "Comparación Mensual de Recaudación (" + anioAnt + " vs " + anioAct + ")";
                string[] nombresMeses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

                Series serieAnioAnt = new Series("Año " + anioAnt);
                serieAnioAnt.ChartType = SeriesChartType.Column;
                serieAnioAnt.Color = Color.FromArgb(197, 160, 89); // Dorado ALBA

                Series serieAnioAct = new Series("Año " + anioAct);
                serieAnioAct.ChartType = SeriesChartType.Column;
                serieAnioAct.Color = EstiloUI.ColorBorgoña; // Borgoña ALBA

                for (int mes = 1; mes <= 12; mes++)
                {
                    decimal totalMesAnt = 0;
                    decimal totalMesAct = 0;

                    foreach (DataRow row in tablaVentas.Rows)
                    {
                        DateTime fecha = Convert.ToDateTime(row["FechaComprobante"]);
                        if (fecha.Month == mes)
                        {
                            if (fecha.Year == anioAnt)
                            {
                                totalMesAnt += Convert.ToDecimal(row["Total"]);
                            }
                            else if (fecha.Year == anioAct)
                            {
                                totalMesAct += Convert.ToDecimal(row["Total"]);
                            }
                        }
                    }

                    serieAnioAnt.Points.AddXY(nombresMeses[mes - 1], (double)totalMesAnt);
                    serieAnioAct.Points.AddXY(nombresMeses[mes - 1], (double)totalMesAct);
                }

                chartSecundario.Series.Add(serieAnioAnt);
                chartSecundario.Series.Add(serieAnioAct);
            }
            else if (filtroSec == "Comparar Totales Anuales")
            {
                LTituloChartSecundario.Text = "Comparación de Recaudación Total por Año";

                Series serieAnual = new Series("Recaudación Anual");
                serieAnual.ChartType = SeriesChartType.Column;
                serieAnual.Color = EstiloUI.ColorBorgoña;

                for (int anio = hoy.Year - 2; anio <= hoy.Year; anio++)
                {
                    decimal totalAnio = 0;

                    foreach (DataRow row in tablaVentas.Rows)
                    {
                        DateTime fecha = Convert.ToDateTime(row["FechaComprobante"]);
                        if (fecha.Year == anio)
                        {
                            totalAnio += Convert.ToDecimal(row["Total"]);
                        }
                    }

                    serieAnual.Points.AddXY(anio.ToString(), (double)totalAnio);
                }

                chartSecundario.Series.Add(serieAnual);
            }
        }

        private void CBFiltroPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicializandoCombos) return;
            CargarDatosDashboard();
        }

        private void CBFiltroChartSecundario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicializandoCombos) return;
            CargarGraficoSecundario(null, DateTime.Today);
        }

        private void AjustarLayoutResponsive()
        {
            int anchoTotal = this.ClientSize.Width - 40;
            if (anchoTotal < 800) anchoTotal = 800;

            // Ajustar el ancho de todos los paneles contenedores al mismo anchoTotal
            panelTopHeader.Width = anchoTotal;
            panelKpis.Width = anchoTotal;
            panelGraficos.Width = anchoTotal;
            panelGraficoSecundario.Width = anchoTotal;
            panelInferior.Width = anchoTotal;

            // Reubicar controles de la cabecera a la derecha
            BRefrescar.Left = panelTopHeader.Width - BRefrescar.Width;
            CBFiltroPeriodo.Left = BRefrescar.Left - CBFiltroPeriodo.Width - 12;
            LFiltroPeriodo.Left = CBFiltroPeriodo.Left - LFiltroPeriodo.Width - 6;

            // Bloque 1: KPIs
            int anchoCardKpi = (anchoTotal - 40) / 3;
            cardVentasDia.Width = anchoCardKpi;
            cardRecaudacionMes.Left = cardVentasDia.Right + 20;
            cardRecaudacionMes.Width = anchoCardKpi;
            cardAlertasStock.Left = cardRecaudacionMes.Right + 20;
            cardAlertasStock.Width = anchoCardKpi;

            // Bloque 2: Gráficos Superiores
            int anchoGraficos = (anchoTotal - 20) / 2;
            cardChartEvolucion.Width = anchoGraficos;
            cardChartCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cardChartCategorias.Left = cardChartEvolucion.Right + 20;
            cardChartCategorias.Width = anchoGraficos;

            // Bloque 2.5: Gráfico Secundario (Ancho Completo)
            panelGraficoSecundario.Top = panelGraficos.Bottom + 12;
            cardChartSecundario.Width = anchoTotal;
            CBFiltroChartSecundario.Left = cardChartSecundario.Width - CBFiltroChartSecundario.Width - 16;
            LFiltroChartSecundario.Left = CBFiltroChartSecundario.Left - LFiltroChartSecundario.Width - 8;

            // Bloque 3: Inferior (Grilla ventas 38%, Críticos 38%, Acciones 24%)
            panelInferior.Top = panelGraficoSecundario.Bottom + 12;
            int espacioInferior = anchoTotal - 40;
            int anchoGrillas = (int)(espacioInferior * 0.38);
            int anchoAcciones = espacioInferior - (anchoGrillas * 2);

            cardUltimasVentas.Width = anchoGrillas;
            cardProductosCriticos.Left = cardUltimasVentas.Right + 20;
            cardProductosCriticos.Width = anchoGrillas;
            cardAcciones.Anchor = AnchorStyles.Top | AnchorStyles.Left;
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

        private void BVerHistorial_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null)
            {
                Form formAbierto = this.MdiParent.MdiChildren.FirstOrDefault(x => x is FHistorialVentas);
                if (formAbierto != null)
                {
                    formAbierto.BringToFront();
                    return;
                }

                FHistorialVentas formHistorial = new FHistorialVentas();
                formHistorial.MdiParent = this.MdiParent;
                formHistorial.WindowState = FormWindowState.Maximized;
                formHistorial.Show();
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
