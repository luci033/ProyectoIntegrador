namespace ProyectoIntegrador.Formularios.Gerente
{
    partial class FormDashboardGerente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTopHeader = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.BRefrescar = new System.Windows.Forms.Button();
            this.panelKpis = new System.Windows.Forms.Panel();
            this.cardVentasDia = new System.Windows.Forms.Panel();
            this.LTituloVentasDia = new System.Windows.Forms.Label();
            this.LVentasDiaMonto = new System.Windows.Forms.Label();
            this.LVentasDiaOps = new System.Windows.Forms.Label();
            this.cardRecaudacionMes = new System.Windows.Forms.Panel();
            this.LTituloRecaudacion = new System.Windows.Forms.Label();
            this.LRecaudacionMesMonto = new System.Windows.Forms.Label();
            this.LRecaudacionMesOps = new System.Windows.Forms.Label();
            this.cardAlertasStock = new System.Windows.Forms.Panel();
            this.LTituloAlertas = new System.Windows.Forms.Label();
            this.LAlertasStockCant = new System.Windows.Forms.Label();
            this.LAlertasStockSub = new System.Windows.Forms.Label();
            this.panelGraficos = new System.Windows.Forms.Panel();
            this.cardChartEvolucion = new System.Windows.Forms.Panel();
            this.LTituloChartEvolucion = new System.Windows.Forms.Label();
            this.chartEvolucion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cardChartCategorias = new System.Windows.Forms.Panel();
            this.LTituloChartCategorias = new System.Windows.Forms.Label();
            this.chartCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.cardUltimasVentas = new System.Windows.Forms.Panel();
            this.LTituloUltimasVentas = new System.Windows.Forms.Label();
            this.DGUltimasVentas = new System.Windows.Forms.DataGridView();
            this.cardProductosCriticos = new System.Windows.Forms.Panel();
            this.LTituloProductosCriticos = new System.Windows.Forms.Label();
            this.DGProductosCriticos = new System.Windows.Forms.DataGridView();
            this.cardAcciones = new System.Windows.Forms.Panel();
            this.LTituloAcciones = new System.Windows.Forms.Label();
            this.BNuevaVenta = new System.Windows.Forms.Button();
            this.BIngresoStock = new System.Windows.Forms.Button();
            this.BDevoluciones = new System.Windows.Forms.Button();
            this.BVerInformes = new System.Windows.Forms.Button();
            this.panelTopHeader.SuspendLayout();
            this.panelKpis.SuspendLayout();
            this.cardVentasDia.SuspendLayout();
            this.cardRecaudacionMes.SuspendLayout();
            this.cardAlertasStock.SuspendLayout();
            this.panelGraficos.SuspendLayout();
            this.cardChartEvolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolucion)).BeginInit();
            this.cardChartCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorias)).BeginInit();
            this.panelInferior.SuspendLayout();
            this.cardUltimasVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUltimasVentas)).BeginInit();
            this.cardProductosCriticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductosCriticos)).BeginInit();
            this.cardAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopHeader
            // 
            this.panelTopHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelTopHeader.Controls.Add(this.LTitulo);
            this.panelTopHeader.Controls.Add(this.LSubtitulo);
            this.panelTopHeader.Controls.Add(this.BRefrescar);
            this.panelTopHeader.Location = new System.Drawing.Point(20, 2);
            this.panelTopHeader.Name = "panelTopHeader";
            this.panelTopHeader.Size = new System.Drawing.Size(1100, 62);
            this.panelTopHeader.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(0, 4);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(346, 29);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Dashboard Ejecutivo ALBA";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.LSubtitulo.Location = new System.Drawing.Point(2, 40);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(413, 15);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Monitoreo en tiempo real de operaciones, facturación e inventario de joyería.";
            // 
            // BRefrescar
            // 
            this.BRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRefrescar.FlatAppearance.BorderSize = 0;
            this.BRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRefrescar.Font = new System.Drawing.Font("Georgia", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRefrescar.ForeColor = System.Drawing.Color.White;
            this.BRefrescar.Location = new System.Drawing.Point(920, 8);
            this.BRefrescar.Name = "BRefrescar";
            this.BRefrescar.Size = new System.Drawing.Size(180, 36);
            this.BRefrescar.TabIndex = 2;
            this.BRefrescar.Text = "↻ Actualizar Métricas";
            this.BRefrescar.UseVisualStyleBackColor = false;
            this.BRefrescar.Click += new System.EventHandler(this.BRefrescar_Click);
            // 
            // panelKpis
            // 
            this.panelKpis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKpis.BackColor = System.Drawing.Color.Transparent;
            this.panelKpis.Controls.Add(this.cardVentasDia);
            this.panelKpis.Controls.Add(this.cardRecaudacionMes);
            this.panelKpis.Controls.Add(this.cardAlertasStock);
            this.panelKpis.Location = new System.Drawing.Point(20, 70);
            this.panelKpis.Name = "panelKpis";
            this.panelKpis.Size = new System.Drawing.Size(1100, 100);
            this.panelKpis.TabIndex = 1;
            // 
            // cardVentasDia
            // 
            this.cardVentasDia.BackColor = System.Drawing.Color.White;
            this.cardVentasDia.Controls.Add(this.LTituloVentasDia);
            this.cardVentasDia.Controls.Add(this.LVentasDiaMonto);
            this.cardVentasDia.Controls.Add(this.LVentasDiaOps);
            this.cardVentasDia.Location = new System.Drawing.Point(0, 0);
            this.cardVentasDia.Name = "cardVentasDia";
            this.cardVentasDia.Size = new System.Drawing.Size(350, 95);
            this.cardVentasDia.TabIndex = 0;
            // 
            // LTituloVentasDia
            // 
            this.LTituloVentasDia.AutoSize = true;
            this.LTituloVentasDia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloVentasDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(105)))), ((int)(((byte)(100)))));
            this.LTituloVentasDia.Location = new System.Drawing.Point(16, 12);
            this.LTituloVentasDia.Name = "LTituloVentasDia";
            this.LTituloVentasDia.Size = new System.Drawing.Size(93, 13);
            this.LTituloVentasDia.TabIndex = 0;
            this.LTituloVentasDia.Text = "VENTAS DEL DÍA";
            // 
            // LVentasDiaMonto
            // 
            this.LVentasDiaMonto.AutoSize = true;
            this.LVentasDiaMonto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVentasDiaMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LVentasDiaMonto.Location = new System.Drawing.Point(14, 30);
            this.LVentasDiaMonto.Name = "LVentasDiaMonto";
            this.LVentasDiaMonto.Size = new System.Drawing.Size(147, 32);
            this.LVentasDiaMonto.TabIndex = 1;
            this.LVentasDiaMonto.Text = "$ 1.159.965";
            // 
            // LVentasDiaOps
            // 
            this.LVentasDiaOps.AutoSize = true;
            this.LVentasDiaOps.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVentasDiaOps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.LVentasDiaOps.Location = new System.Drawing.Point(16, 68);
            this.LVentasDiaOps.Name = "LVentasDiaOps";
            this.LVentasDiaOps.Size = new System.Drawing.Size(103, 15);
            this.LVentasDiaOps.TabIndex = 2;
            this.LVentasDiaOps.Text = "5 operaciones hoy";
            // 
            // cardRecaudacionMes
            // 
            this.cardRecaudacionMes.BackColor = System.Drawing.Color.White;
            this.cardRecaudacionMes.Controls.Add(this.LTituloRecaudacion);
            this.cardRecaudacionMes.Controls.Add(this.LRecaudacionMesMonto);
            this.cardRecaudacionMes.Controls.Add(this.LRecaudacionMesOps);
            this.cardRecaudacionMes.Location = new System.Drawing.Point(375, 0);
            this.cardRecaudacionMes.Name = "cardRecaudacionMes";
            this.cardRecaudacionMes.Size = new System.Drawing.Size(350, 95);
            this.cardRecaudacionMes.TabIndex = 1;
            // 
            // LTituloRecaudacion
            // 
            this.LTituloRecaudacion.AutoSize = true;
            this.LTituloRecaudacion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloRecaudacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(105)))), ((int)(((byte)(100)))));
            this.LTituloRecaudacion.Location = new System.Drawing.Point(16, 12);
            this.LTituloRecaudacion.Name = "LTituloRecaudacion";
            this.LTituloRecaudacion.Size = new System.Drawing.Size(143, 13);
            this.LTituloRecaudacion.TabIndex = 0;
            this.LTituloRecaudacion.Text = "RECAUDACIÓN MENSUAL";
            // 
            // LRecaudacionMesMonto
            // 
            this.LRecaudacionMesMonto.AutoSize = true;
            this.LRecaudacionMesMonto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecaudacionMesMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LRecaudacionMesMonto.Location = new System.Drawing.Point(14, 30);
            this.LRecaudacionMesMonto.Name = "LRecaudacionMesMonto";
            this.LRecaudacionMesMonto.Size = new System.Drawing.Size(161, 32);
            this.LRecaudacionMesMonto.TabIndex = 1;
            this.LRecaudacionMesMonto.Text = "$ 18.620.000";
            // 
            // LRecaudacionMesOps
            // 
            this.LRecaudacionMesOps.AutoSize = true;
            this.LRecaudacionMesOps.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecaudacionMesOps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(72)))));
            this.LRecaudacionMesOps.Location = new System.Drawing.Point(16, 68);
            this.LRecaudacionMesOps.Name = "LRecaudacionMesOps";
            this.LRecaudacionMesOps.Size = new System.Drawing.Size(140, 15);
            this.LRecaudacionMesOps.TabIndex = 2;
            this.LRecaudacionMesOps.Text = "Total acumulado del mes";
            // 
            // cardAlertasStock
            // 
            this.cardAlertasStock.BackColor = System.Drawing.Color.White;
            this.cardAlertasStock.Controls.Add(this.LTituloAlertas);
            this.cardAlertasStock.Controls.Add(this.LAlertasStockCant);
            this.cardAlertasStock.Controls.Add(this.LAlertasStockSub);
            this.cardAlertasStock.Location = new System.Drawing.Point(750, 0);
            this.cardAlertasStock.Name = "cardAlertasStock";
            this.cardAlertasStock.Size = new System.Drawing.Size(350, 95);
            this.cardAlertasStock.TabIndex = 2;
            // 
            // LTituloAlertas
            // 
            this.LTituloAlertas.AutoSize = true;
            this.LTituloAlertas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAlertas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(105)))), ((int)(((byte)(100)))));
            this.LTituloAlertas.Location = new System.Drawing.Point(16, 12);
            this.LTituloAlertas.Name = "LTituloAlertas";
            this.LTituloAlertas.Size = new System.Drawing.Size(107, 13);
            this.LTituloAlertas.TabIndex = 0;
            this.LTituloAlertas.Text = "ALERTAS DE STOCK";
            // 
            // LAlertasStockCant
            // 
            this.LAlertasStockCant.AutoSize = true;
            this.LAlertasStockCant.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAlertasStockCant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(38)))), ((int)(((byte)(30)))));
            this.LAlertasStockCant.Location = new System.Drawing.Point(14, 30);
            this.LAlertasStockCant.Name = "LAlertasStockCant";
            this.LAlertasStockCant.Size = new System.Drawing.Size(152, 32);
            this.LAlertasStockCant.TabIndex = 1;
            this.LAlertasStockCant.Text = "3 Productos";
            // 
            // LAlertasStockSub
            // 
            this.LAlertasStockSub.AutoSize = true;
            this.LAlertasStockSub.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAlertasStockSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(38)))), ((int)(((byte)(30)))));
            this.LAlertasStockSub.Location = new System.Drawing.Point(16, 68);
            this.LAlertasStockSub.Name = "LAlertasStockSub";
            this.LAlertasStockSub.Size = new System.Drawing.Size(147, 15);
            this.LAlertasStockSub.TabIndex = 2;
            this.LAlertasStockSub.Text = "En o bajo su stock mínimo";
            // 
            // panelGraficos
            // 
            this.panelGraficos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraficos.BackColor = System.Drawing.Color.Transparent;
            this.panelGraficos.Controls.Add(this.cardChartEvolucion);
            this.panelGraficos.Controls.Add(this.cardChartCategorias);
            this.panelGraficos.Location = new System.Drawing.Point(20, 175);
            this.panelGraficos.Name = "panelGraficos";
            this.panelGraficos.Size = new System.Drawing.Size(1100, 260);
            this.panelGraficos.TabIndex = 2;
            // 
            // cardChartEvolucion
            // 
            this.cardChartEvolucion.BackColor = System.Drawing.Color.White;
            this.cardChartEvolucion.Controls.Add(this.LTituloChartEvolucion);
            this.cardChartEvolucion.Controls.Add(this.chartEvolucion);
            this.cardChartEvolucion.Location = new System.Drawing.Point(0, 0);
            this.cardChartEvolucion.Name = "cardChartEvolucion";
            this.cardChartEvolucion.Size = new System.Drawing.Size(585, 255);
            this.cardChartEvolucion.TabIndex = 0;
            // 
            // LTituloChartEvolucion
            // 
            this.LTituloChartEvolucion.AutoSize = true;
            this.LTituloChartEvolucion.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloChartEvolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTituloChartEvolucion.Location = new System.Drawing.Point(16, 12);
            this.LTituloChartEvolucion.Name = "LTituloChartEvolucion";
            this.LTituloChartEvolucion.Size = new System.Drawing.Size(334, 18);
            this.LTituloChartEvolucion.TabIndex = 0;
            this.LTituloChartEvolucion.Text = "Evolución de Recaudación (Últimos 7 días)";
            // 
            // chartEvolucion
            // 
            this.chartEvolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartAreaEvolucion";
            this.chartEvolucion.ChartAreas.Add(chartArea1);
            this.chartEvolucion.Location = new System.Drawing.Point(10, 38);
            this.chartEvolucion.Name = "chartEvolucion";
            series1.ChartArea = "ChartAreaEvolucion";
            series1.Name = "Recaudacion";
            this.chartEvolucion.Series.Add(series1);
            this.chartEvolucion.Size = new System.Drawing.Size(565, 205);
            this.chartEvolucion.TabIndex = 1;
            // 
            // cardChartCategorias
            // 
            this.cardChartCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardChartCategorias.BackColor = System.Drawing.Color.White;
            this.cardChartCategorias.Controls.Add(this.LTituloChartCategorias);
            this.cardChartCategorias.Controls.Add(this.chartCategorias);
            this.cardChartCategorias.Location = new System.Drawing.Point(600, 0);
            this.cardChartCategorias.Name = "cardChartCategorias";
            this.cardChartCategorias.Size = new System.Drawing.Size(500, 255);
            this.cardChartCategorias.TabIndex = 1;
            // 
            // LTituloChartCategorias
            // 
            this.LTituloChartCategorias.AutoSize = true;
            this.LTituloChartCategorias.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloChartCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTituloChartCategorias.Location = new System.Drawing.Point(16, 12);
            this.LTituloChartCategorias.Name = "LTituloChartCategorias";
            this.LTituloChartCategorias.Size = new System.Drawing.Size(253, 18);
            this.LTituloChartCategorias.TabIndex = 0;
            this.LTituloChartCategorias.Text = "Ventas por Categoría (% Ventas)";
            // 
            // chartCategorias
            // 
            this.chartCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartAreaCategorias";
            this.chartCategorias.ChartAreas.Add(chartArea2);
            legend1.Name = "LegendCategorias";
            this.chartCategorias.Legends.Add(legend1);
            this.chartCategorias.Location = new System.Drawing.Point(10, 38);
            this.chartCategorias.Name = "chartCategorias";
            series2.ChartArea = "ChartAreaCategorias";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "LegendCategorias";
            series2.Name = "Categorias";
            this.chartCategorias.Series.Add(series2);
            this.chartCategorias.Size = new System.Drawing.Size(480, 205);
            this.chartCategorias.TabIndex = 1;
            // 
            // panelInferior
            // 
            this.panelInferior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInferior.BackColor = System.Drawing.Color.Transparent;
            this.panelInferior.Controls.Add(this.cardUltimasVentas);
            this.panelInferior.Controls.Add(this.cardProductosCriticos);
            this.panelInferior.Controls.Add(this.cardAcciones);
            this.panelInferior.Location = new System.Drawing.Point(20, 440);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1100, 245);
            this.panelInferior.TabIndex = 3;
            // 
            // cardUltimasVentas
            // 
            this.cardUltimasVentas.BackColor = System.Drawing.Color.White;
            this.cardUltimasVentas.Controls.Add(this.LTituloUltimasVentas);
            this.cardUltimasVentas.Controls.Add(this.DGUltimasVentas);
            this.cardUltimasVentas.Location = new System.Drawing.Point(0, 0);
            this.cardUltimasVentas.Name = "cardUltimasVentas";
            this.cardUltimasVentas.Size = new System.Drawing.Size(430, 240);
            this.cardUltimasVentas.TabIndex = 0;
            // 
            // LTituloUltimasVentas
            // 
            this.LTituloUltimasVentas.AutoSize = true;
            this.LTituloUltimasVentas.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloUltimasVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTituloUltimasVentas.Location = new System.Drawing.Point(14, 12);
            this.LTituloUltimasVentas.Name = "LTituloUltimasVentas";
            this.LTituloUltimasVentas.Size = new System.Drawing.Size(188, 17);
            this.LTituloUltimasVentas.TabIndex = 0;
            this.LTituloUltimasVentas.Text = "Últimas Ventas Emitidas";
            // 
            // DGUltimasVentas
            // 
            this.DGUltimasVentas.AllowUserToAddRows = false;
            this.DGUltimasVentas.AllowUserToDeleteRows = false;
            this.DGUltimasVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGUltimasVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGUltimasVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.DGUltimasVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGUltimasVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUltimasVentas.Location = new System.Drawing.Point(14, 38);
            this.DGUltimasVentas.Name = "DGUltimasVentas";
            this.DGUltimasVentas.ReadOnly = true;
            this.DGUltimasVentas.RowHeadersVisible = false;
            this.DGUltimasVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGUltimasVentas.Size = new System.Drawing.Size(402, 190);
            this.DGUltimasVentas.TabIndex = 1;
            // 
            // cardProductosCriticos
            // 
            this.cardProductosCriticos.BackColor = System.Drawing.Color.White;
            this.cardProductosCriticos.Controls.Add(this.LTituloProductosCriticos);
            this.cardProductosCriticos.Controls.Add(this.DGProductosCriticos);
            this.cardProductosCriticos.Location = new System.Drawing.Point(445, 0);
            this.cardProductosCriticos.Name = "cardProductosCriticos";
            this.cardProductosCriticos.Size = new System.Drawing.Size(410, 240);
            this.cardProductosCriticos.TabIndex = 1;
            // 
            // LTituloProductosCriticos
            // 
            this.LTituloProductosCriticos.AutoSize = true;
            this.LTituloProductosCriticos.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloProductosCriticos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(38)))), ((int)(((byte)(30)))));
            this.LTituloProductosCriticos.Location = new System.Drawing.Point(14, 12);
            this.LTituloProductosCriticos.Name = "LTituloProductosCriticos";
            this.LTituloProductosCriticos.Size = new System.Drawing.Size(302, 17);
            this.LTituloProductosCriticos.TabIndex = 0;
            this.LTituloProductosCriticos.Text = "Productos Críticos (Reposición Urgente)";
            // 
            // DGProductosCriticos
            // 
            this.DGProductosCriticos.AllowUserToAddRows = false;
            this.DGProductosCriticos.AllowUserToDeleteRows = false;
            this.DGProductosCriticos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGProductosCriticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGProductosCriticos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.DGProductosCriticos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGProductosCriticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductosCriticos.Location = new System.Drawing.Point(14, 38);
            this.DGProductosCriticos.Name = "DGProductosCriticos";
            this.DGProductosCriticos.ReadOnly = true;
            this.DGProductosCriticos.RowHeadersVisible = false;
            this.DGProductosCriticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProductosCriticos.Size = new System.Drawing.Size(382, 190);
            this.DGProductosCriticos.TabIndex = 1;
            // 
            // cardAcciones
            // 
            this.cardAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardAcciones.BackColor = System.Drawing.Color.White;
            this.cardAcciones.Controls.Add(this.LTituloAcciones);
            this.cardAcciones.Controls.Add(this.BNuevaVenta);
            this.cardAcciones.Controls.Add(this.BIngresoStock);
            this.cardAcciones.Controls.Add(this.BDevoluciones);
            this.cardAcciones.Controls.Add(this.BVerInformes);
            this.cardAcciones.Location = new System.Drawing.Point(870, 0);
            this.cardAcciones.Name = "cardAcciones";
            this.cardAcciones.Size = new System.Drawing.Size(230, 240);
            this.cardAcciones.TabIndex = 2;
            // 
            // LTituloAcciones
            // 
            this.LTituloAcciones.AutoSize = true;
            this.LTituloAcciones.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAcciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTituloAcciones.Location = new System.Drawing.Point(14, 12);
            this.LTituloAcciones.Name = "LTituloAcciones";
            this.LTituloAcciones.Size = new System.Drawing.Size(135, 17);
            this.LTituloAcciones.TabIndex = 0;
            this.LTituloAcciones.Text = "Acciones Rápidas";
            // 
            // BNuevaVenta
            // 
            this.BNuevaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BNuevaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BNuevaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNuevaVenta.FlatAppearance.BorderSize = 0;
            this.BNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevaVenta.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevaVenta.ForeColor = System.Drawing.Color.White;
            this.BNuevaVenta.Location = new System.Drawing.Point(14, 38);
            this.BNuevaVenta.Name = "BNuevaVenta";
            this.BNuevaVenta.Size = new System.Drawing.Size(202, 38);
            this.BNuevaVenta.TabIndex = 1;
            this.BNuevaVenta.Text = "+ Nueva Venta";
            this.BNuevaVenta.UseVisualStyleBackColor = false;
            this.BNuevaVenta.Click += new System.EventHandler(this.BNuevaVenta_Click);
            // 
            // BIngresoStock
            // 
            this.BIngresoStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BIngresoStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BIngresoStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BIngresoStock.FlatAppearance.BorderSize = 0;
            this.BIngresoStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIngresoStock.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIngresoStock.ForeColor = System.Drawing.Color.White;
            this.BIngresoStock.Location = new System.Drawing.Point(14, 82);
            this.BIngresoStock.Name = "BIngresoStock";
            this.BIngresoStock.Size = new System.Drawing.Size(202, 38);
            this.BIngresoStock.TabIndex = 2;
            this.BIngresoStock.Text = "⚖ Ajuste de Stock";
            this.BIngresoStock.UseVisualStyleBackColor = false;
            this.BIngresoStock.Click += new System.EventHandler(this.BIngresoStock_Click);
            // 
            // BDevoluciones
            // 
            this.BDevoluciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BDevoluciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BDevoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDevoluciones.FlatAppearance.BorderSize = 0;
            this.BDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDevoluciones.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDevoluciones.ForeColor = System.Drawing.Color.White;
            this.BDevoluciones.Location = new System.Drawing.Point(14, 170);
            this.BDevoluciones.Name = "BDevoluciones";
            this.BDevoluciones.Size = new System.Drawing.Size(202, 38);
            this.BDevoluciones.TabIndex = 3;
            this.BDevoluciones.Text = "🔄 Devoluciones";
            this.BDevoluciones.UseVisualStyleBackColor = false;
            this.BDevoluciones.Visible = false;
            this.BDevoluciones.Click += new System.EventHandler(this.BDevoluciones_Click);
            // 
            // BVerInformes
            // 
            this.BVerInformes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BVerInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(208)))), ((int)(((byte)(201)))));
            this.BVerInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVerInformes.FlatAppearance.BorderSize = 0;
            this.BVerInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVerInformes.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVerInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BVerInformes.Location = new System.Drawing.Point(14, 126);
            this.BVerInformes.Name = "BVerInformes";
            this.BVerInformes.Size = new System.Drawing.Size(202, 38);
            this.BVerInformes.TabIndex = 4;
            this.BVerInformes.Text = "📊 Ver Informes";
            this.BVerInformes.UseVisualStyleBackColor = false;
            this.BVerInformes.Click += new System.EventHandler(this.BVerInformes_Click);
            // 
            // FormDashboardGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1140, 710);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelGraficos);
            this.Controls.Add(this.panelKpis);
            this.Controls.Add(this.panelTopHeader);
            this.Name = "FormDashboardGerente";
            this.Text = "Dashboard Ejecutivo - Joyería ALBA";
            this.Load += new System.EventHandler(this.FormDashboardGerente_Load);
            this.Resize += new System.EventHandler(this.FormDashboardGerente_Resize);
            this.panelTopHeader.ResumeLayout(false);
            this.panelTopHeader.PerformLayout();
            this.panelKpis.ResumeLayout(false);
            this.cardVentasDia.ResumeLayout(false);
            this.cardVentasDia.PerformLayout();
            this.cardRecaudacionMes.ResumeLayout(false);
            this.cardRecaudacionMes.PerformLayout();
            this.cardAlertasStock.ResumeLayout(false);
            this.cardAlertasStock.PerformLayout();
            this.panelGraficos.ResumeLayout(false);
            this.cardChartEvolucion.ResumeLayout(false);
            this.cardChartEvolucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolucion)).EndInit();
            this.cardChartCategorias.ResumeLayout(false);
            this.cardChartCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorias)).EndInit();
            this.panelInferior.ResumeLayout(false);
            this.cardUltimasVentas.ResumeLayout(false);
            this.cardUltimasVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUltimasVentas)).EndInit();
            this.cardProductosCriticos.ResumeLayout(false);
            this.cardProductosCriticos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductosCriticos)).EndInit();
            this.cardAcciones.ResumeLayout(false);
            this.cardAcciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopHeader;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Button BRefrescar;
        private System.Windows.Forms.Panel panelKpis;
        private System.Windows.Forms.Panel cardVentasDia;
        private System.Windows.Forms.Label LTituloVentasDia;
        private System.Windows.Forms.Label LVentasDiaMonto;
        private System.Windows.Forms.Label LVentasDiaOps;
        private System.Windows.Forms.Panel cardRecaudacionMes;
        private System.Windows.Forms.Label LTituloRecaudacion;
        private System.Windows.Forms.Label LRecaudacionMesMonto;
        private System.Windows.Forms.Label LRecaudacionMesOps;
        private System.Windows.Forms.Panel cardAlertasStock;
        private System.Windows.Forms.Label LTituloAlertas;
        private System.Windows.Forms.Label LAlertasStockCant;
        private System.Windows.Forms.Label LAlertasStockSub;
        private System.Windows.Forms.Panel panelGraficos;
        private System.Windows.Forms.Panel cardChartEvolucion;
        private System.Windows.Forms.Label LTituloChartEvolucion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEvolucion;
        private System.Windows.Forms.Panel cardChartCategorias;
        private System.Windows.Forms.Label LTituloChartCategorias;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategorias;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel cardUltimasVentas;
        private System.Windows.Forms.Label LTituloUltimasVentas;
        private System.Windows.Forms.DataGridView DGUltimasVentas;
        private System.Windows.Forms.Panel cardProductosCriticos;
        private System.Windows.Forms.Label LTituloProductosCriticos;
        private System.Windows.Forms.DataGridView DGProductosCriticos;
        private System.Windows.Forms.Panel cardAcciones;
        private System.Windows.Forms.Label LTituloAcciones;
        private System.Windows.Forms.Button BNuevaVenta;
        private System.Windows.Forms.Button BIngresoStock;
        private System.Windows.Forms.Button BDevoluciones;
        private System.Windows.Forms.Button BVerInformes;
    }
}
