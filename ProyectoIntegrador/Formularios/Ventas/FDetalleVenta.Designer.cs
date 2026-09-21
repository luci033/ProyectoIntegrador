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
            this.panelCard = new System.Windows.Forms.Panel();
            this.LInfoVenta = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.dataGridDetalle = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCerrar = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.LInfoVenta);
            this.panelCard.Controls.Add(this.LSubtitulo);
            this.panelCard.Controls.Add(this.dataGridDetalle);
            this.panelCard.Controls.Add(this.BCerrar);
            this.panelCard.Location = new System.Drawing.Point(20, 20);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(600, 380);
            this.panelCard.TabIndex = 0;
            // 
            // LInfoVenta
            // 
            this.LInfoVenta.AutoSize = true;
            this.LInfoVenta.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfoVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LInfoVenta.Location = new System.Drawing.Point(20, 18);
            this.LInfoVenta.Name = "LInfoVenta";
            this.LInfoVenta.Size = new System.Drawing.Size(262, 24);
            this.LInfoVenta.TabIndex = 0;
            this.LInfoVenta.Text = "Detalle del Comprobante";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.LSubtitulo.Location = new System.Drawing.Point(22, 46);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(200, 15);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Desglose de artículos de la venta";
            // 
            // dataGridDetalle
            // 
            this.dataGridDetalle.AllowUserToAddRows = false;
            this.dataGridDetalle.AllowUserToDeleteRows = false;
            this.dataGridDetalle.AllowUserToResizeRows = false;
            this.dataGridDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubTotal});
            this.dataGridDetalle.Location = new System.Drawing.Point(20, 75);
            this.dataGridDetalle.Name = "dataGridDetalle";
            this.dataGridDetalle.ReadOnly = true;
            this.dataGridDetalle.RowHeadersVisible = false;
            this.dataGridDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDetalle.Size = new System.Drawing.Size(560, 240);
            this.dataGridDetalle.TabIndex = 2;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 50F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 16.86741F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.FillWeight = 20.24089F;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.FillWeight = 20.24089F;
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // BCerrar
            // 
            this.BCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerrar.ForeColor = System.Drawing.Color.White;
            this.BCerrar.Location = new System.Drawing.Point(470, 330);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(110, 34);
            this.BCerrar.TabIndex = 3;
            this.BCerrar.Text = "Cerrar";
            this.BCerrar.UseVisualStyleBackColor = false;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // FDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de Venta";
            this.Load += new System.EventHandler(this.FDetalleVenta_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LInfoVenta;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.DataGridView dataGridDetalle;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}