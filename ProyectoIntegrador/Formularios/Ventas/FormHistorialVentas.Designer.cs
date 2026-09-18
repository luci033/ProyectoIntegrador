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
            this.TBTotalFiltrado = new System.Windows.Forms.TextBox();
            this.LTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorialVenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Location = new System.Drawing.Point(24, 68);
            this.LBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(74, 17);
            this.LBuscar.TabIndex = 0;
            this.LBuscar.Text = "Buscar por:";
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
            this.DataGridHistorialVenta.Location = new System.Drawing.Point(2, 245);
            this.DataGridHistorialVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataGridHistorialVenta.Name = "DataGridHistorialVenta";
            this.DataGridHistorialVenta.ReadOnly = true;
            this.DataGridHistorialVenta.RowHeadersVisible = false;
            this.DataGridHistorialVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridHistorialVenta.Size = new System.Drawing.Size(828, 154);
            this.DataGridHistorialVenta.TabIndex = 2;
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
            this.colAccion.HeaderText = "Acción";
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAccion.Text = "Detalle";
            // 
            // colNroVenta
            // 
            this.colNroVenta.HeaderText = "Nro. Venta";
            this.colNroVenta.Name = "colNroVenta";
            this.colNroVenta.ReadOnly = true;
            // 
            // colVendedor
            // 
            this.colVendedor.HeaderText = "Vendedor";
            this.colVendedor.Name = "colVendedor";
            this.colVendedor.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total Venta";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // LHistorialVenta
            // 
            this.LHistorialVenta.AutoSize = true;
            this.LHistorialVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LHistorialVenta.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHistorialVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LHistorialVenta.Location = new System.Drawing.Point(13, 23);
            this.LHistorialVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LHistorialVenta.Name = "LHistorialVenta";
            this.LHistorialVenta.Size = new System.Drawing.Size(293, 40);
            this.LHistorialVenta.TabIndex = 3;
            this.LHistorialVenta.Text = "HISTORIAL DE VENTA";
            // 
            // LFechaDesde
            // 
            this.LFechaDesde.AutoSize = true;
            this.LFechaDesde.Location = new System.Drawing.Point(19, 25);
            this.LFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaDesde.Name = "LFechaDesde";
            this.LFechaDesde.Size = new System.Drawing.Size(85, 17);
            this.LFechaDesde.TabIndex = 4;
            this.LFechaDesde.Text = "Fecha Desde:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBBuscar);
            this.panel1.Controls.Add(this.BLimpiar);
            this.panel1.Controls.Add(this.BBuscar);
            this.panel1.Controls.Add(this.DTPFechaHasta);
            this.panel1.Controls.Add(this.DTPFechaDesde);
            this.panel1.Controls.Add(this.cmbBuscar);
            this.panel1.Controls.Add(this.LFechaHasta);
            this.panel1.Controls.Add(this.LBuscar);
            this.panel1.Controls.Add(this.LFechaDesde);
            this.panel1.Location = new System.Drawing.Point(41, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 112);
            this.panel1.TabIndex = 5;
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(238, 65);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(116, 25);
            this.TBBuscar.TabIndex = 14;
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BLimpiar.FlatAppearance.BorderSize = 0;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.ForeColor = System.Drawing.Color.White;
            this.BLimpiar.Location = new System.Drawing.Point(589, 68);
            this.BLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(88, 31);
            this.BLimpiar.TabIndex = 13;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BBuscar.CausesValidation = false;
            this.BBuscar.FlatAppearance.BorderSize = 0;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Location = new System.Drawing.Point(493, 68);
            this.BBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(88, 31);
            this.BBuscar.TabIndex = 12;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // DTPFechaHasta
            // 
            this.DTPFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaHasta.Location = new System.Drawing.Point(393, 25);
            this.DTPFechaHasta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DTPFechaHasta.Name = "DTPFechaHasta";
            this.DTPFechaHasta.Size = new System.Drawing.Size(119, 25);
            this.DTPFechaHasta.TabIndex = 11;
            // 
            // DTPFechaDesde
            // 
            this.DTPFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaDesde.Location = new System.Drawing.Point(112, 20);
            this.DTPFechaDesde.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DTPFechaDesde.Name = "DTPFechaDesde";
            this.DTPFechaDesde.Size = new System.Drawing.Size(119, 25);
            this.DTPFechaDesde.TabIndex = 10;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.Color.White;
            this.cmbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(112, 65);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(119, 25);
            this.cmbBuscar.TabIndex = 8;
            // 
            // LFechaHasta
            // 
            this.LFechaHasta.AutoSize = true;
            this.LFechaHasta.Location = new System.Drawing.Point(303, 25);
            this.LFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaHasta.Name = "LFechaHasta";
            this.LFechaHasta.Size = new System.Drawing.Size(81, 17);
            this.LFechaHasta.TabIndex = 6;
            this.LFechaHasta.Text = "Fecha Hasta:";
            // 
            // TBTotalFiltrado
            // 
            this.TBTotalFiltrado.Location = new System.Drawing.Point(658, 432);
            this.TBTotalFiltrado.Margin = new System.Windows.Forms.Padding(4);
            this.TBTotalFiltrado.Name = "TBTotalFiltrado";
            this.TBTotalFiltrado.ReadOnly = true;
            this.TBTotalFiltrado.Size = new System.Drawing.Size(116, 25);
            this.TBTotalFiltrado.TabIndex = 7;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(543, 435);
            this.LTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(107, 17);
            this.LTotal.TabIndex = 12;
            this.LTotal.Text = " TOTAL FILTRADO";
            // 
            // FHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 469);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.TBTotalFiltrado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LHistorialVenta);
            this.Controls.Add(this.DataGridHistorialVenta);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FHistorialVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHistorialVentas";
            this.Load += new System.EventHandler(this.FHistorialVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorialVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.DataGridView DataGridHistorialVenta;
        private System.Windows.Forms.Label LHistorialVenta;
        private System.Windows.Forms.Label LFechaDesde;
        private System.Windows.Forms.Panel panel1;
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