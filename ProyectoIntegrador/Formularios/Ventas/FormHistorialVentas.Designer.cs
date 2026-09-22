namespace ProyectoIntegrador.Formularios.Ventas
{
    partial class FHistorialVentas
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
            this.components = new System.ComponentModel.Container();
            this.LHistorialVenta = new System.Windows.Forms.Label();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.LValorTotal = new System.Windows.Forms.Label();
            this.LTituloCardTotal = new System.Windows.Forms.Label();
            this.cardCantidad = new System.Windows.Forms.Panel();
            this.LValorCantidad = new System.Windows.Forms.Label();
            this.LTituloCardCantidad = new System.Windows.Forms.Label();
            this.cardPromedio = new System.Windows.Forms.Panel();
            this.LValorPromedio = new System.Windows.Forms.Label();
            this.LTituloCardPromedio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LPeriodo = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.LFechaDesde = new System.Windows.Forms.Label();
            this.DTPFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.LFechaHasta = new System.Windows.Forms.Label();
            this.DTPFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.LBuscar = new System.Windows.Forms.Label();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.BBuscar = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BExportar = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.LEstadoVacio = new System.Windows.Forms.Label();
            this.DataGridHistorialVenta = new System.Windows.Forms.DataGridView();
            this.IDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTotal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBTotalFiltrado = new System.Windows.Forms.TextBox();
            this.panelCards.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.cardCantidad.SuspendLayout();
            this.cardPromedio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorialVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LHistorialVenta
            // 
            this.LHistorialVenta.AutoSize = true;
            this.LHistorialVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LHistorialVenta.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHistorialVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LHistorialVenta.Location = new System.Drawing.Point(24, 16);
            this.LHistorialVenta.Name = "LHistorialVenta";
            this.LHistorialVenta.Size = new System.Drawing.Size(249, 29);
            this.LHistorialVenta.TabIndex = 0;
            this.LHistorialVenta.Text = "Historial de Ventas";
            // 
            // panelCards
            // 
            this.panelCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Controls.Add(this.cardTotal);
            this.panelCards.Controls.Add(this.cardCantidad);
            this.panelCards.Controls.Add(this.cardPromedio);
            this.panelCards.Location = new System.Drawing.Point(24, 52);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(950, 70);
            this.panelCards.TabIndex = 1;
            // 
            // cardTotal
            // 
            this.cardTotal.BackColor = System.Drawing.Color.White;
            this.cardTotal.Controls.Add(this.LValorTotal);
            this.cardTotal.Controls.Add(this.LTituloCardTotal);
            this.cardTotal.Location = new System.Drawing.Point(0, 0);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(305, 66);
            this.cardTotal.TabIndex = 0;
            // 
            // LValorTotal
            // 
            this.LValorTotal.Font = new System.Drawing.Font("Georgia", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LValorTotal.Location = new System.Drawing.Point(12, 28);
            this.LValorTotal.Name = "LValorTotal";
            this.LValorTotal.Size = new System.Drawing.Size(280, 28);
            this.LValorTotal.TabIndex = 1;
            this.LValorTotal.Text = "$ 0,00";
            this.LValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LTituloCardTotal
            // 
            this.LTituloCardTotal.AutoSize = true;
            this.LTituloCardTotal.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloCardTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(105)))));
            this.LTituloCardTotal.Location = new System.Drawing.Point(14, 10);
            this.LTituloCardTotal.Name = "LTituloCardTotal";
            this.LTituloCardTotal.Size = new System.Drawing.Size(98, 12);
            this.LTituloCardTotal.TabIndex = 0;
            this.LTituloCardTotal.Text = "TOTAL FACTURADO";
            // 
            // cardCantidad
            // 
            this.cardCantidad.BackColor = System.Drawing.Color.White;
            this.cardCantidad.Controls.Add(this.LValorCantidad);
            this.cardCantidad.Controls.Add(this.LTituloCardCantidad);
            this.cardCantidad.Location = new System.Drawing.Point(320, 0);
            this.cardCantidad.Name = "cardCantidad";
            this.cardCantidad.Size = new System.Drawing.Size(305, 66);
            this.cardCantidad.TabIndex = 1;
            // 
            // LValorCantidad
            // 
            this.LValorCantidad.Font = new System.Drawing.Font("Georgia", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValorCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LValorCantidad.Location = new System.Drawing.Point(12, 28);
            this.LValorCantidad.Name = "LValorCantidad";
            this.LValorCantidad.Size = new System.Drawing.Size(280, 28);
            this.LValorCantidad.TabIndex = 1;
            this.LValorCantidad.Text = "0 operaciones";
            this.LValorCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LTituloCardCantidad
            // 
            this.LTituloCardCantidad.AutoSize = true;
            this.LTituloCardCantidad.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloCardCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(105)))));
            this.LTituloCardCantidad.Location = new System.Drawing.Point(14, 10);
            this.LTituloCardCantidad.Name = "LTituloCardCantidad";
            this.LTituloCardCantidad.Size = new System.Drawing.Size(112, 12);
            this.LTituloCardCantidad.TabIndex = 0;
            this.LTituloCardCantidad.Text = "CANTIDAD DE VENTAS";
            // 
            // cardPromedio
            // 
            this.cardPromedio.BackColor = System.Drawing.Color.White;
            this.cardPromedio.Controls.Add(this.LValorPromedio);
            this.cardPromedio.Controls.Add(this.LTituloCardPromedio);
            this.cardPromedio.Location = new System.Drawing.Point(640, 0);
            this.cardPromedio.Name = "cardPromedio";
            this.cardPromedio.Size = new System.Drawing.Size(305, 66);
            this.cardPromedio.TabIndex = 2;
            // 
            // LValorPromedio
            // 
            this.LValorPromedio.Font = new System.Drawing.Font("Georgia", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValorPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LValorPromedio.Location = new System.Drawing.Point(12, 28);
            this.LValorPromedio.Name = "LValorPromedio";
            this.LValorPromedio.Size = new System.Drawing.Size(280, 28);
            this.LValorPromedio.TabIndex = 1;
            this.LValorPromedio.Text = "$ 0,00";
            this.LValorPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LTituloCardPromedio
            // 
            this.LTituloCardPromedio.AutoSize = true;
            this.LTituloCardPromedio.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloCardPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(105)))));
            this.LTituloCardPromedio.Location = new System.Drawing.Point(14, 10);
            this.LTituloCardPromedio.Name = "LTituloCardPromedio";
            this.LTituloCardPromedio.Size = new System.Drawing.Size(94, 12);
            this.LTituloCardPromedio.TabIndex = 0;
            this.LTituloCardPromedio.Text = "TICKET PROMEDIO";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LPeriodo);
            this.panel1.Controls.Add(this.cmbPeriodo);
            this.panel1.Controls.Add(this.LFechaDesde);
            this.panel1.Controls.Add(this.DTPFechaDesde);
            this.panel1.Controls.Add(this.LFechaHasta);
            this.panel1.Controls.Add(this.DTPFechaHasta);
            this.panel1.Controls.Add(this.LBuscar);
            this.panel1.Controls.Add(this.cmbBuscar);
            this.panel1.Controls.Add(this.TBBuscar);
            this.panel1.Controls.Add(this.BBuscar);
            this.panel1.Controls.Add(this.BLimpiar);
            this.panel1.Controls.Add(this.BExportar);
            this.panel1.Location = new System.Drawing.Point(24, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 94);
            this.panel1.TabIndex = 2;
            // 
            // LPeriodo
            // 
            this.LPeriodo.AutoSize = true;
            this.LPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LPeriodo.Location = new System.Drawing.Point(14, 16);
            this.LPeriodo.Name = "LPeriodo";
            this.LPeriodo.Size = new System.Drawing.Size(53, 15);
            this.LPeriodo.TabIndex = 0;
            this.LPeriodo.Text = "Período:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "Mes Actual",
            "Últimos 7 días",
            "Hoy",
            "Todo el Historial",
            "Personalizado"});
            this.cmbPeriodo.Location = new System.Drawing.Point(74, 12);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(126, 23);
            this.cmbPeriodo.TabIndex = 1;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodo_SelectedIndexChanged);
            // 
            // LFechaDesde
            // 
            this.LFechaDesde.AutoSize = true;
            this.LFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LFechaDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LFechaDesde.Location = new System.Drawing.Point(220, 16);
            this.LFechaDesde.Name = "LFechaDesde";
            this.LFechaDesde.Size = new System.Drawing.Size(45, 15);
            this.LFechaDesde.TabIndex = 2;
            this.LFechaDesde.Text = "Desde:";
            // 
            // DTPFechaDesde
            // 
            this.DTPFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaDesde.Location = new System.Drawing.Point(270, 12);
            this.DTPFechaDesde.Name = "DTPFechaDesde";
            this.DTPFechaDesde.Size = new System.Drawing.Size(110, 23);
            this.DTPFechaDesde.TabIndex = 3;
            this.DTPFechaDesde.ValueChanged += new System.EventHandler(this.DTPFecha_ValueChanged);
            // 
            // LFechaHasta
            // 
            this.LFechaHasta.AutoSize = true;
            this.LFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LFechaHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LFechaHasta.Location = new System.Drawing.Point(398, 16);
            this.LFechaHasta.Name = "LFechaHasta";
            this.LFechaHasta.Size = new System.Drawing.Size(41, 15);
            this.LFechaHasta.TabIndex = 4;
            this.LFechaHasta.Text = "Hasta:";
            // 
            // DTPFechaHasta
            // 
            this.DTPFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaHasta.Location = new System.Drawing.Point(444, 12);
            this.DTPFechaHasta.Name = "DTPFechaHasta";
            this.DTPFechaHasta.Size = new System.Drawing.Size(110, 23);
            this.DTPFechaHasta.TabIndex = 5;
            this.DTPFechaHasta.ValueChanged += new System.EventHandler(this.DTPFecha_ValueChanged);
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LBuscar.Location = new System.Drawing.Point(14, 56);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(65, 15);
            this.LBuscar.TabIndex = 6;
            this.LBuscar.Text = "Filtrar por:";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(74, 52);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(126, 23);
            this.cmbBuscar.TabIndex = 7;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBBuscar.Location = new System.Drawing.Point(215, 52);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(185, 24);
            this.TBBuscar.TabIndex = 8;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BBuscar.FlatAppearance.BorderSize = 0;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Location = new System.Drawing.Point(420, 50);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(85, 28);
            this.BBuscar.TabIndex = 9;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(208)))), ((int)(((byte)(201)))));
            this.BLimpiar.FlatAppearance.BorderSize = 0;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.BLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BLimpiar.Location = new System.Drawing.Point(515, 50);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(85, 28);
            this.BLimpiar.TabIndex = 10;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BExportar
            // 
            this.BExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(208)))), ((int)(((byte)(201)))));
            this.BExportar.FlatAppearance.BorderSize = 0;
            this.BExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExportar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BExportar.Location = new System.Drawing.Point(805, 50);
            this.BExportar.Name = "BExportar";
            this.BExportar.Size = new System.Drawing.Size(125, 28);
            this.BExportar.TabIndex = 11;
            this.BExportar.Text = "📥 Exportar CSV";
            this.BExportar.UseVisualStyleBackColor = false;
            this.BExportar.Click += new System.EventHandler(this.BExportar_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Controls.Add(this.LEstadoVacio);
            this.panelGrid.Controls.Add(this.DataGridHistorialVenta);
            this.panelGrid.Location = new System.Drawing.Point(24, 234);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(10);
            this.panelGrid.Size = new System.Drawing.Size(950, 370);
            this.panelGrid.TabIndex = 3;
            // 
            // LEstadoVacio
            // 
            this.LEstadoVacio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LEstadoVacio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstadoVacio.ForeColor = System.Drawing.Color.Gray;
            this.LEstadoVacio.Location = new System.Drawing.Point(10, 10);
            this.LEstadoVacio.Name = "LEstadoVacio";
            this.LEstadoVacio.Size = new System.Drawing.Size(930, 350);
            this.LEstadoVacio.TabIndex = 1;
            this.LEstadoVacio.Text = "No se encontraron ventas para los criterios seleccionados.";
            this.LEstadoVacio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LEstadoVacio.Visible = false;
            // 
            // DataGridHistorialVenta
            // 
            this.DataGridHistorialVenta.AllowUserToAddRows = false;
            this.DataGridHistorialVenta.AllowUserToDeleteRows = false;
            this.DataGridHistorialVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridHistorialVenta.BackgroundColor = System.Drawing.Color.White;
            this.DataGridHistorialVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridHistorialVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridHistorialVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVenta,
            this.colAccion,
            this.colNroVenta,
            this.Fecha,
            this.colCliente,
            this.colVendedor,
            this.total});
            this.DataGridHistorialVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridHistorialVenta.Location = new System.Drawing.Point(10, 10);
            this.DataGridHistorialVenta.Name = "DataGridHistorialVenta";
            this.DataGridHistorialVenta.ReadOnly = true;
            this.DataGridHistorialVenta.RowHeadersVisible = false;
            this.DataGridHistorialVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridHistorialVenta.Size = new System.Drawing.Size(930, 350);
            this.DataGridHistorialVenta.TabIndex = 0;
            this.DataGridHistorialVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHistorialVenta_CellContentClick);
            // 
            // IDVenta
            // 
            this.IDVenta.HeaderText = "ID venta";
            this.IDVenta.Name = "IDVenta";
            this.IDVenta.ReadOnly = true;
            this.IDVenta.Visible = false;
            // 
            // colAccion
            // 
            this.colAccion.FillWeight = 40F;
            this.colAccion.HeaderText = "Acción";
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAccion.Text = "Ver Detalle";
            this.colAccion.UseColumnTextForButtonValue = true;
            // 
            // colNroVenta
            // 
            this.colNroVenta.FillWeight = 45F;
            this.colNroVenta.HeaderText = "Nro. Venta";
            this.colNroVenta.Name = "colNroVenta";
            this.colNroVenta.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 65F;
            this.Fecha.HeaderText = "Fecha y Hora";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.FillWeight = 85F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colVendedor
            // 
            this.colVendedor.FillWeight = 70F;
            this.colVendedor.HeaderText = "Vendedor";
            this.colVendedor.Name = "colVendedor";
            this.colVendedor.ReadOnly = true;
            // 
            // total
            // 
            this.total.FillWeight = 55F;
            this.total.HeaderText = "Total Venta";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // LTotal
            // 
            this.LTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTotal.Location = new System.Drawing.Point(6, 13);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(46, 19);
            this.LTotal.TabIndex = 4;
            this.LTotal.Text = "Total:";
            this.LTotal.Click += new System.EventHandler(this.LTotal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.TBTotalFiltrado);
            this.panel2.Controls.Add(this.LTotal);
            this.panel2.Location = new System.Drawing.Point(770, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 38);
            this.panel2.TabIndex = 6;
            // 
            // TBTotalFiltrado
            // 
            this.TBTotalFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBTotalFiltrado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TBTotalFiltrado.Location = new System.Drawing.Point(58, 10);
            this.TBTotalFiltrado.Name = "TBTotalFiltrado";
            this.TBTotalFiltrado.ReadOnly = true;
            this.TBTotalFiltrado.Size = new System.Drawing.Size(137, 25);
            this.TBTotalFiltrado.TabIndex = 5;
            this.TBTotalFiltrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBTotalFiltrado.TextChanged += new System.EventHandler(this.TBTotalFiltrado_TextChanged);
            // 
            // FHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.LHistorialVenta);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FHistorialVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Ventas - Joyería ALBA";
            this.Load += new System.EventHandler(this.FHistorialVentas_Load);
            this.Resize += new System.EventHandler(this.FHistorialVentas_Resize);
            this.panelCards.ResumeLayout(false);
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.cardCantidad.ResumeLayout(false);
            this.cardCantidad.PerformLayout();
            this.cardPromedio.ResumeLayout(false);
            this.cardPromedio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorialVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LHistorialVenta;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Label LValorTotal;
        private System.Windows.Forms.Label LTituloCardTotal;
        private System.Windows.Forms.Panel cardCantidad;
        private System.Windows.Forms.Label LValorCantidad;
        private System.Windows.Forms.Label LTituloCardCantidad;
        private System.Windows.Forms.Panel cardPromedio;
        private System.Windows.Forms.Label LValorPromedio;
        private System.Windows.Forms.Label LTituloCardPromedio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LPeriodo;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label LFechaDesde;
        private System.Windows.Forms.DateTimePicker DTPFechaDesde;
        private System.Windows.Forms.Label LFechaHasta;
        private System.Windows.Forms.DateTimePicker DTPFechaHasta;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BExportar;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView DataGridHistorialVenta;
        private System.Windows.Forms.Label LEstadoVacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVenta;
        private System.Windows.Forms.DataGridViewButtonColumn colAccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBTotalFiltrado;
    }
}