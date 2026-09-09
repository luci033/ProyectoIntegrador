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
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.DataGridHistorialVenta = new System.Windows.Forms.DataGridView();
            this.IDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorialVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Location = new System.Drawing.Point(32, 172);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(40, 13);
            this.LBuscar.TabIndex = 0;
            this.LBuscar.Text = "Buscar";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(96, 169);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(100, 20);
            this.TBBuscar.TabIndex = 1;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // DataGridHistorialVenta
            // 
            this.DataGridHistorialVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridHistorialVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridHistorialVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVenta,
            this.Fecha,
            this.total,
            this.detalle});
            this.DataGridHistorialVenta.Location = new System.Drawing.Point(2, 252);
            this.DataGridHistorialVenta.Name = "DataGridHistorialVenta";
            this.DataGridHistorialVenta.Size = new System.Drawing.Size(460, 110);
            this.DataGridHistorialVenta.TabIndex = 2;
            this.DataGridHistorialVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHistorialVenta_CellContentClick);
            // 
            // IDVenta
            // 
            this.IDVenta.HeaderText = "ID venta";
            this.IDVenta.Name = "IDVenta";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // detalle
            // 
            this.detalle.HeaderText = "";
            this.detalle.Name = "detalle";
            this.detalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detalle.Text = "Detalle";
            this.detalle.UseColumnTextForButtonValue = true;
            // 
            // FHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.DataGridHistorialVenta);
            this.Controls.Add(this.TBBuscar);
            this.Controls.Add(this.LBuscar);
            this.Name = "FHistorialVentas";
            this.Text = "FormHistorialVentas";
            this.Load += new System.EventHandler(this.FHistorialVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorialVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.DataGridView DataGridHistorialVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn detalle;
    }
}