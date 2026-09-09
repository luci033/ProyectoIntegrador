namespace ProyectoIntegrador.Formularios.Ventas
{
    partial class FDetalleVenta
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
            this.LInfoVenta = new System.Windows.Forms.Label();
            this.dataGridDetalle = new System.Windows.Forms.DataGridView();
            this.BCerrar = new System.Windows.Forms.Button();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // LInfoVenta
            // 
            this.LInfoVenta.AutoSize = true;
            this.LInfoVenta.Location = new System.Drawing.Point(35, 32);
            this.LInfoVenta.Name = "LInfoVenta";
            this.LInfoVenta.Size = new System.Drawing.Size(56, 13);
            this.LInfoVenta.TabIndex = 0;
            this.LInfoVenta.Text = "Info Venta";
            // 
            // dataGridDetalle
            // 
            this.dataGridDetalle.AllowUserToAddRows = false;
            this.dataGridDetalle.AllowUserToDeleteRows = false;
            this.dataGridDetalle.AllowUserToResizeColumns = false;
            this.dataGridDetalle.AllowUserToResizeRows = false;
            this.dataGridDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubTotal});
            this.dataGridDetalle.Location = new System.Drawing.Point(0, 115);
            this.dataGridDetalle.Name = "dataGridDetalle";
            this.dataGridDetalle.RowHeadersVisible = false;
            this.dataGridDetalle.Size = new System.Drawing.Size(573, 96);
            this.dataGridDetalle.TabIndex = 1;
            // 
            // BCerrar
            // 
            this.BCerrar.Location = new System.Drawing.Point(12, 245);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(75, 23);
            this.BCerrar.TabIndex = 2;
            this.BCerrar.Text = "Cerrar";
            this.BCerrar.UseVisualStyleBackColor = true;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 50F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 16.86741F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colPrecio
            // 
            this.colPrecio.FillWeight = 20.24089F;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            // 
            // colSubTotal
            // 
            this.colSubTotal.FillWeight = 20.24089F;
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            // 
            // FDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.BCerrar);
            this.Controls.Add(this.dataGridDetalle);
            this.Controls.Add(this.LInfoVenta);
            this.Name = "FDetalleVenta";
            this.Text = "FDetalleVenta";
            this.Load += new System.EventHandler(this.FDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LInfoVenta;
        private System.Windows.Forms.DataGridView dataGridDetalle;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}