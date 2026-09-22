namespace ProyectoIntegrador.Formularios.Gerente
{
    partial class FormInformesEstadisticos
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.LPeriodo = new System.Windows.Forms.Label();
            this.CBPeriodo = new System.Windows.Forms.ComboBox();
            this.LDesde = new System.Windows.Forms.Label();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.LHasta = new System.Windows.Forms.Label();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
            this.BGenerar = new System.Windows.Forms.Button();
            this.BExportar = new System.Windows.Forms.Button();
            this.panelKpis = new System.Windows.Forms.Panel();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.LTotalTitulo = new System.Windows.Forms.Label();
            this.LTotalValor = new System.Windows.Forms.Label();
            this.cardUnidades = new System.Windows.Forms.Panel();
            this.LUnidadesTitulo = new System.Windows.Forms.Label();
            this.LUnidadesValor = new System.Windows.Forms.Label();
            this.cardPromedio = new System.Windows.Forms.Panel();
            this.LPromedioTitulo = new System.Windows.Forms.Label();
            this.LPromedioValor = new System.Windows.Forms.Label();
            this.cardLider = new System.Windows.Forms.Panel();
            this.LLiderTitulo = new System.Windows.Forms.Label();
            this.LLiderValor = new System.Windows.Forms.Label();
            this.panelGrilla = new System.Windows.Forms.Panel();
            this.LGrillaTitulo = new System.Windows.Forms.Label();
            this.DGInforme = new System.Windows.Forms.DataGridView();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParticipacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.panelKpis.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.cardUnidades.SuspendLayout();
            this.cardPromedio.SuspendLayout();
            this.cardLider.SuspendLayout();
            this.panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.LTitulo);
            this.panelHeader.Controls.Add(this.LSubtitulo);
            this.panelHeader.Location = new System.Drawing.Point(20, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 61);
            this.panelHeader.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(0, 0);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(417, 29);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Informes Estadísticos de Gestión";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.LSubtitulo.Location = new System.Drawing.Point(3, 38);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(460, 15);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Consolidado de rendimiento comercial, ticket promedio y participación por categor" +
    "ía.";
            // 
            // panelFiltros
            // 
            this.panelFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltros.BackColor = System.Drawing.Color.White;
            this.panelFiltros.Controls.Add(this.LPeriodo);
            this.panelFiltros.Controls.Add(this.CBPeriodo);
            this.panelFiltros.Controls.Add(this.LDesde);
            this.panelFiltros.Controls.Add(this.DTPDesde);
            this.panelFiltros.Controls.Add(this.LHasta);
            this.panelFiltros.Controls.Add(this.DTPHasta);
            this.panelFiltros.Controls.Add(this.BGenerar);
            this.panelFiltros.Controls.Add(this.BExportar);
            this.panelFiltros.Location = new System.Drawing.Point(20, 72);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(1000, 68);
            this.panelFiltros.TabIndex = 1;
            // 
            // LPeriodo
            // 
            this.LPeriodo.AutoSize = true;
            this.LPeriodo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LPeriodo.Location = new System.Drawing.Point(16, 12);
            this.LPeriodo.Name = "LPeriodo";
            this.LPeriodo.Size = new System.Drawing.Size(53, 15);
            this.LPeriodo.TabIndex = 0;
            this.LPeriodo.Text = "Período:";
            // 
            // CBPeriodo
            // 
            this.CBPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPeriodo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.CBPeriodo.FormattingEnabled = true;
            this.CBPeriodo.Items.AddRange(new object[] {
            "Mes Actual",
            "Últimos 7 días",
            "Hoy",
            "Personalizado"});
            this.CBPeriodo.Location = new System.Drawing.Point(19, 30);
            this.CBPeriodo.Name = "CBPeriodo";
            this.CBPeriodo.Size = new System.Drawing.Size(140, 25);
            this.CBPeriodo.TabIndex = 1;
            this.CBPeriodo.SelectedIndexChanged += new System.EventHandler(this.CBPeriodo_SelectedIndexChanged);
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LDesde.Location = new System.Drawing.Point(180, 12);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(80, 15);
            this.LDesde.TabIndex = 2;
            this.LDesde.Text = "Fecha Desde:";
            // 
            // DTPDesde
            // 
            this.DTPDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDesde.Location = new System.Drawing.Point(183, 30);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(120, 24);
            this.DTPDesde.TabIndex = 3;
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LHasta.Location = new System.Drawing.Point(320, 12);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(76, 15);
            this.LHasta.TabIndex = 4;
            this.LHasta.Text = "Fecha Hasta:";
            // 
            // DTPHasta
            // 
            this.DTPHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPHasta.Location = new System.Drawing.Point(323, 30);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(120, 24);
            this.DTPHasta.TabIndex = 5;
            // 
            // BGenerar
            // 
            this.BGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGenerar.FlatAppearance.BorderSize = 0;
            this.BGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGenerar.Font = new System.Drawing.Font("Georgia", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerar.ForeColor = System.Drawing.Color.White;
            this.BGenerar.Location = new System.Drawing.Point(470, 24);
            this.BGenerar.Name = "BGenerar";
            this.BGenerar.Size = new System.Drawing.Size(160, 34);
            this.BGenerar.TabIndex = 6;
            this.BGenerar.Text = "📊 Generar Informe";
            this.BGenerar.UseVisualStyleBackColor = false;
            this.BGenerar.Click += new System.EventHandler(this.BGenerar_Click);
            // 
            // BExportar
            // 
            this.BExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(208)))), ((int)(((byte)(201)))));
            this.BExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExportar.FlatAppearance.BorderSize = 0;
            this.BExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExportar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BExportar.Location = new System.Drawing.Point(820, 24);
            this.BExportar.Name = "BExportar";
            this.BExportar.Size = new System.Drawing.Size(160, 34);
            this.BExportar.TabIndex = 7;
            this.BExportar.Text = "💾 Exportar Resumen";
            this.BExportar.UseVisualStyleBackColor = false;
            this.BExportar.Click += new System.EventHandler(this.BExportar_Click);
            // 
            // panelKpis
            // 
            this.panelKpis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKpis.BackColor = System.Drawing.Color.Transparent;
            this.panelKpis.Controls.Add(this.cardTotal);
            this.panelKpis.Controls.Add(this.cardUnidades);
            this.panelKpis.Controls.Add(this.cardPromedio);
            this.panelKpis.Controls.Add(this.cardLider);
            this.panelKpis.Location = new System.Drawing.Point(20, 150);
            this.panelKpis.Name = "panelKpis";
            this.panelKpis.Size = new System.Drawing.Size(1000, 85);
            this.panelKpis.TabIndex = 2;
            // 
            // cardTotal
            // 
            this.cardTotal.BackColor = System.Drawing.Color.White;
            this.cardTotal.Controls.Add(this.LTotalTitulo);
            this.cardTotal.Controls.Add(this.LTotalValor);
            this.cardTotal.Location = new System.Drawing.Point(0, 0);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(235, 80);
            this.cardTotal.TabIndex = 0;
            // 
            // LTotalTitulo
            // 
            this.LTotalTitulo.AutoSize = true;
            this.LTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LTotalTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(105)))), ((int)(((byte)(100)))));
            this.LTotalTitulo.Location = new System.Drawing.Point(14, 12);
            this.LTotalTitulo.Name = "LTotalTitulo";
            this.LTotalTitulo.Size = new System.Drawing.Size(119, 13);
            this.LTotalTitulo.TabIndex = 0;
            this.LTotalTitulo.Text = "FACTURACIÓN TOTAL";
            // 
            // LTotalValor
            // 
            this.LTotalValor.AutoSize = true;
            this.LTotalValor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.LTotalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTotalValor.Location = new System.Drawing.Point(12, 34);
            this.LTotalValor.Name = "LTotalValor";
            this.LTotalValor.Size = new System.Drawing.Size(136, 28);
            this.LTotalValor.TabIndex = 1;
            this.LTotalValor.Text = "$ 18.620.000";
            // 
            // cardUnidades
            // 
            this.cardUnidades.BackColor = System.Drawing.Color.White;
            this.cardUnidades.Controls.Add(this.LUnidadesTitulo);
            this.cardUnidades.Controls.Add(this.LUnidadesValor);
            this.cardUnidades.Location = new System.Drawing.Point(255, 0);
            this.cardUnidades.Name = "cardUnidades";
            this.cardUnidades.Size = new System.Drawing.Size(235, 80);
            this.cardUnidades.TabIndex = 1;
            // 
            // LUnidadesTitulo
            // 
            this.LUnidadesTitulo.AutoSize = true;
            this.LUnidadesTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LUnidadesTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(105)))), ((int)(((byte)(100)))));
            this.LUnidadesTitulo.Location = new System.Drawing.Point(14, 12);
            this.LUnidadesTitulo.Name = "LUnidadesTitulo";
            this.LUnidadesTitulo.Size = new System.Drawing.Size(121, 13);
            this.LUnidadesTitulo.TabIndex = 0;
            this.LUnidadesTitulo.Text = "UNIDADES VENDIDAS";
            // 
            // LUnidadesValor
            // 
            this.LUnidadesValor.AutoSize = true;
            this.LUnidadesValor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.LUnidadesValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LUnidadesValor.Location = new System.Drawing.Point(12, 34);
            this.LUnidadesValor.Name = "LUnidadesValor";
            this.LUnidadesValor.Size = new System.Drawing.Size(113, 28);
            this.LUnidadesValor.TabIndex = 1;
            this.LUnidadesValor.Text = "128 Piezas";
            // 
            // cardPromedio
            // 
            this.cardPromedio.BackColor = System.Drawing.Color.White;
            this.cardPromedio.Controls.Add(this.LPromedioTitulo);
            this.cardPromedio.Controls.Add(this.LPromedioValor);
            this.cardPromedio.Location = new System.Drawing.Point(510, 0);
            this.cardPromedio.Name = "cardPromedio";
            this.cardPromedio.Size = new System.Drawing.Size(235, 80);
            this.cardPromedio.TabIndex = 2;
            // 
            // LPromedioTitulo
            // 
            this.LPromedioTitulo.AutoSize = true;
            this.LPromedioTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LPromedioTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(105)))), ((int)(((byte)(100)))));
            this.LPromedioTitulo.Location = new System.Drawing.Point(14, 12);
            this.LPromedioTitulo.Name = "LPromedioTitulo";
            this.LPromedioTitulo.Size = new System.Drawing.Size(103, 13);
            this.LPromedioTitulo.TabIndex = 0;
            this.LPromedioTitulo.Text = "TICKET PROMEDIO";
            // 
            // LPromedioValor
            // 
            this.LPromedioValor.AutoSize = true;
            this.LPromedioValor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.LPromedioValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LPromedioValor.Location = new System.Drawing.Point(12, 34);
            this.LPromedioValor.Name = "LPromedioValor";
            this.LPromedioValor.Size = new System.Drawing.Size(107, 28);
            this.LPromedioValor.TabIndex = 1;
            this.LPromedioValor.Text = "$ 290.937";
            // 
            // cardLider
            // 
            this.cardLider.BackColor = System.Drawing.Color.White;
            this.cardLider.Controls.Add(this.LLiderTitulo);
            this.cardLider.Controls.Add(this.LLiderValor);
            this.cardLider.Location = new System.Drawing.Point(765, 0);
            this.cardLider.Name = "cardLider";
            this.cardLider.Size = new System.Drawing.Size(235, 80);
            this.cardLider.TabIndex = 3;
            // 
            // LLiderTitulo
            // 
            this.LLiderTitulo.AutoSize = true;
            this.LLiderTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LLiderTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(105)))), ((int)(((byte)(100)))));
            this.LLiderTitulo.Location = new System.Drawing.Point(14, 12);
            this.LLiderTitulo.Name = "LLiderTitulo";
            this.LLiderTitulo.Size = new System.Drawing.Size(100, 13);
            this.LLiderTitulo.TabIndex = 0;
            this.LLiderTitulo.Text = "CATEGORÍA LÍDER";
            // 
            // LLiderValor
            // 
            this.LLiderValor.AutoSize = true;
            this.LLiderValor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.LLiderValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(160)))), ((int)(((byte)(89)))));
            this.LLiderValor.Location = new System.Drawing.Point(12, 34);
            this.LLiderValor.Name = "LLiderValor";
            this.LLiderValor.Size = new System.Drawing.Size(87, 28);
            this.LLiderValor.TabIndex = 1;
            this.LLiderValor.Text = "Collares";
            // 
            // panelGrilla
            // 
            this.panelGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrilla.BackColor = System.Drawing.Color.White;
            this.panelGrilla.Controls.Add(this.LGrillaTitulo);
            this.panelGrilla.Controls.Add(this.DGInforme);
            this.panelGrilla.Location = new System.Drawing.Point(20, 245);
            this.panelGrilla.Name = "panelGrilla";
            this.panelGrilla.Size = new System.Drawing.Size(1000, 360);
            this.panelGrilla.TabIndex = 3;
            // 
            // LGrillaTitulo
            // 
            this.LGrillaTitulo.AutoSize = true;
            this.LGrillaTitulo.Font = new System.Drawing.Font("Georgia", 11.5F, System.Drawing.FontStyle.Bold);
            this.LGrillaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LGrillaTitulo.Location = new System.Drawing.Point(16, 14);
            this.LGrillaTitulo.Name = "LGrillaTitulo";
            this.LGrillaTitulo.Size = new System.Drawing.Size(332, 18);
            this.LGrillaTitulo.TabIndex = 0;
            this.LGrillaTitulo.Text = "Desglose de Rendimiento por Categoría";
            // 
            // DGInforme
            // 
            this.DGInforme.AllowUserToAddRows = false;
            this.DGInforme.AllowUserToDeleteRows = false;
            this.DGInforme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGInforme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGInforme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.DGInforme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategoria,
            this.colUnidades,
            this.colTotal,
            this.colParticipacion});
            this.DGInforme.Location = new System.Drawing.Point(16, 42);
            this.DGInforme.Name = "DGInforme";
            this.DGInforme.ReadOnly = true;
            this.DGInforme.RowHeadersVisible = false;
            this.DGInforme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGInforme.Size = new System.Drawing.Size(964, 302);
            this.DGInforme.TabIndex = 1;
            // 
            // colCategoria
            // 
            this.colCategoria.FillWeight = 40F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colUnidades
            // 
            this.colUnidades.FillWeight = 25F;
            this.colUnidades.HeaderText = "Unidades Vendidas";
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.FillWeight = 35F;
            this.colTotal.HeaderText = "Facturación Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colParticipacion
            // 
            this.colParticipacion.FillWeight = 25F;
            this.colParticipacion.HeaderText = "Participación (%)";
            this.colParticipacion.Name = "colParticipacion";
            this.colParticipacion.ReadOnly = true;
            // 
            // FormInformesEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1040, 620);
            this.Controls.Add(this.panelGrilla);
            this.Controls.Add(this.panelKpis);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormInformesEstadisticos";
            this.Text = "Informes Estadísticos - Joyería ALBA";
            this.Load += new System.EventHandler(this.FormInformesEstadisticos_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelKpis.ResumeLayout(false);
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.cardUnidades.ResumeLayout(false);
            this.cardUnidades.PerformLayout();
            this.cardPromedio.ResumeLayout(false);
            this.cardPromedio.PerformLayout();
            this.cardLider.ResumeLayout(false);
            this.cardLider.PerformLayout();
            this.panelGrilla.ResumeLayout(false);
            this.panelGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGInforme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label LPeriodo;
        private System.Windows.Forms.ComboBox CBPeriodo;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.DateTimePicker DTPDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.DateTimePicker DTPHasta;
        private System.Windows.Forms.Button BGenerar;
        private System.Windows.Forms.Button BExportar;
        private System.Windows.Forms.Panel panelKpis;
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Label LTotalTitulo;
        private System.Windows.Forms.Label LTotalValor;
        private System.Windows.Forms.Panel cardUnidades;
        private System.Windows.Forms.Label LUnidadesTitulo;
        private System.Windows.Forms.Label LUnidadesValor;
        private System.Windows.Forms.Panel cardPromedio;
        private System.Windows.Forms.Label LPromedioTitulo;
        private System.Windows.Forms.Label LPromedioValor;
        private System.Windows.Forms.Panel cardLider;
        private System.Windows.Forms.Label LLiderTitulo;
        private System.Windows.Forms.Label LLiderValor;
        private System.Windows.Forms.Panel panelGrilla;
        private System.Windows.Forms.Label LGrillaTitulo;
        private System.Windows.Forms.DataGridView DGInforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParticipacion;
    }
}
