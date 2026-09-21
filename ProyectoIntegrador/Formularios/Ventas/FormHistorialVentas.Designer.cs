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
            this.LBuscar = new System.Windows.Forms.Label();
            this.DataGridHistorialVenta = new System.Windows.Forms.DataGridView();
            this.IDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LHistorialVenta = new System.Windows.Forms.Label();
            this.LFechaDesde = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.DTPFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DTPFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.LFechaHasta = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.TBTotalFiltrado = new System.Windows.Forms.TextBox();
            this.LTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorialVenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // LHistorialVenta
            // 
            this.LHistorialVenta.AutoSize = true;
            this.LHistorialVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LHistorialVenta.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHistorialVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LHistorialVenta.Location = new System.Drawing.Point(25, 20);
            this.LHistorialVenta.Name = "LHistorialVenta";
            this.LHistorialVenta.Size = new System.Drawing.Size(359, 31);
            this.LHistorialVenta.TabIndex = 0;
            this.LHistorialVenta.Text = "HISTORIAL DE VENTAS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LFechaDesde);
            this.panel1.Controls.Add(this.DTPFechaDesde);
            this.panel1.Controls.Add(this.LFechaHasta);
            this.panel1.Controls.Add(this.DTPFechaHasta);
            this.panel1.Controls.Add(this.LBuscar);
            this.panel1.Controls.Add(this.cmbBuscar);
            this.panel1.Controls.Add(this.TBBuscar);
            this.panel1.Controls.Add(this.BBuscar);
            this.panel1.Controls.Add(this.BLimpiar);
            this.panel1.Location = new System.Drawing.Point(25, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 88);
            this.panel1.TabIndex = 1;
            // 
            // LFechaDesde
            // 
            this.LFechaDesde.AutoSize = true;
            this.LFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LFechaDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LFechaDesde.Location = new System.Drawing.Point(18, 16);
            this.LFechaDesde.Name = "LFechaDesde";
            this.LFechaDesde.Size = new System.Drawing.Size(46, 15);
            this.LFechaDesde.TabIndex = 0;
            this.LFechaDesde.Text = "Desde:";
            // 
            // DTPFechaDesde
            // 
            this.DTPFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaDesde.Location = new System.Drawing.Point(70, 12);
            this.DTPFechaDesde.Name = "DTPFechaDesde";
            this.DTPFechaDesde.Size = new System.Drawing.Size(115, 23);
            this.DTPFechaDesde.TabIndex = 1;
            // 
            // LFechaHasta
            // 
            this.LFechaHasta.AutoSize = true;
            this.LFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LFechaHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LFechaHasta.Location = new System.Drawing.Point(210, 16);
            this.LFechaHasta.Name = "LFechaHasta";
            this.LFechaHasta.Size = new System.Drawing.Size(41, 15);
            this.LFechaHasta.TabIndex = 2;
            this.LFechaHasta.Text = "Hasta:";
            // 
            // DTPFechaHasta
            // 
            this.DTPFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaHasta.Location = new System.Drawing.Point(257, 12);
            this.DTPFechaHasta.Name = "DTPFechaHasta";
            this.DTPFechaHasta.Size = new System.Drawing.Size(115, 23);
            this.DTPFechaHasta.TabIndex = 3;
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LBuscar.Location = new System.Drawing.Point(18, 52);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(70, 15);
            this.LBuscar.TabIndex = 4;
            this.LBuscar.Text = "Buscar por:";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(94, 48);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(125, 23);
            this.cmbBuscar.TabIndex = 5;
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBBuscar.Location = new System.Drawing.Point(228, 47);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(160, 24);
            this.TBBuscar.TabIndex = 6;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BBuscar.FlatAppearance.BorderSize = 0;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Location = new System.Drawing.Point(405, 45);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(95, 28);
            this.BBuscar.TabIndex = 7;
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
            this.BLimpiar.Location = new System.Drawing.Point(510, 45);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(90, 28);
            this.BLimpiar.TabIndex = 8;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Controls.Add(this.DataGridHistorialVenta);
            this.panelGrid.Location = new System.Drawing.Point(25, 160);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(840, 360);
            this.panelGrid.TabIndex = 2;
            // 
            // DataGridHistorialVenta
            // 
            this.DataGridHistorialVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridHistorialVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridHistorialVenta.BackgroundColor = System.Drawing.Color.White;
            this.DataGridHistorialVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridHistorialVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridHistorialVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVenta,
            this.colAccion,
            this.colNroVenta,
            this.colVendedor,
            this.Fecha,
            this.total});
            this.DataGridHistorialVenta.Location = new System.Drawing.Point(12, 12);
            this.DataGridHistorialVenta.Name = "DataGridHistorialVenta";
            this.DataGridHistorialVenta.ReadOnly = true;
            this.DataGridHistorialVenta.RowHeadersVisible = false;
            this.DataGridHistorialVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridHistorialVenta.Size = new System.Drawing.Size(816, 336);
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
            this.colAccion.Text = "Detalle";
            this.colAccion.UseColumnTextForButtonValue = true;
            // 
            // colNroVenta
            // 
            this.colNroVenta.FillWeight = 50F;
            this.colNroVenta.HeaderText = "Nro. Venta";
            this.colNroVenta.Name = "colNroVenta";
            this.colNroVenta.ReadOnly = true;
            // 
            // colVendedor
            // 
            this.colVendedor.FillWeight = 80F;
            this.colVendedor.HeaderText = "Vendedor";
            this.colVendedor.Name = "colVendedor";
            this.colVendedor.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 70F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // total
            // 
            this.total.FillWeight = 60F;
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
            this.LTotal.Location = new System.Drawing.Point(595, 535);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(127, 19);
            this.LTotal.TabIndex = 3;
            this.LTotal.Text = "TOTAL FILTRADO:";
            // 
            // TBTotalFiltrado
            // 
            this.TBTotalFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBTotalFiltrado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TBTotalFiltrado.Location = new System.Drawing.Point(728, 532);
            this.TBTotalFiltrado.Name = "TBTotalFiltrado";
            this.TBTotalFiltrado.ReadOnly = true;
            this.TBTotalFiltrado.Size = new System.Drawing.Size(137, 25);
            this.TBTotalFiltrado.TabIndex = 4;
            this.TBTotalFiltrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(890, 575);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.TBTotalFiltrado);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LHistorialVenta);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FHistorialVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Ventas";
            this.Load += new System.EventHandler(this.FHistorialVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorialVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.DataGridView DataGridHistorialVenta;
        private System.Windows.Forms.Label LHistorialVenta;
        private System.Windows.Forms.Label LFechaDesde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Label LFechaHasta;
        private System.Windows.Forms.DateTimePicker DTPFechaHasta;
        private System.Windows.Forms.DateTimePicker DTPFechaDesde;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVenta;
        private System.Windows.Forms.DataGridViewButtonColumn colAccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.TextBox TBTotalFiltrado;
        private System.Windows.Forms.Label LTotal;
    }
}