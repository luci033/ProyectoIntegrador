namespace ProyectoIntegrador.Formularios.Compras
{
    partial class FormCompras
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
            this.LCompras = new System.Windows.Forms.Label();
            this.DGCompras = new System.Windows.Forms.DataGridView();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRecepcion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleOrden = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BAgregarOrden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // LCompras
            // 
            this.LCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LCompras.AutoSize = true;
            this.LCompras.Font = new System.Drawing.Font("Georgia", 16F);
            this.LCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCompras.Location = new System.Drawing.Point(35, 50);
            this.LCompras.Name = "LCompras";
            this.LCompras.Size = new System.Drawing.Size(210, 27);
            this.LCompras.TabIndex = 9;
            this.LCompras.Text = "Gestión de Compras";
            this.LCompras.Click += new System.EventHandler(this.LProveedores_Click);
            // 
            // DGCompras
            // 
            this.DGCompras.AllowUserToAddRows = false;
            this.DGCompras.AllowUserToDeleteRows = false;
            this.DGCompras.AllowUserToResizeColumns = false;
            this.DGCompras.AllowUserToResizeRows = false;
            this.DGCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompra,
            this.fechaCompa,
            this.proveedor,
            this.fechaRecepcion,
            this.Observacion,
            this.Total,
            this.DetalleOrden});
            this.DGCompras.Location = new System.Drawing.Point(12, 169);
            this.DGCompras.Name = "DGCompras";
            this.DGCompras.ReadOnly = true;
            this.DGCompras.RowHeadersVisible = false;
            this.DGCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCompras.Size = new System.Drawing.Size(776, 252);
            this.DGCompras.TabIndex = 7;
            this.DGCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProveedores_CellContentClick);
            // 
            // idCompra
            // 
            this.idCompra.FillWeight = 20F;
            this.idCompra.HeaderText = "Nro.";
            this.idCompra.Name = "idCompra";
            this.idCompra.ReadOnly = true;
            // 
            // fechaCompa
            // 
            this.fechaCompa.FillWeight = 30F;
            this.fechaCompa.HeaderText = "Fecha";
            this.fechaCompa.Name = "fechaCompa";
            this.fechaCompa.ReadOnly = true;
            // 
            // proveedor
            // 
            this.proveedor.FillWeight = 50F;
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            // 
            // fechaRecepcion
            // 
            this.fechaRecepcion.FillWeight = 40F;
            this.fechaRecepcion.HeaderText = "Fecha Recepción";
            this.fechaRecepcion.Name = "fechaRecepcion";
            this.fechaRecepcion.ReadOnly = true;
            this.fechaRecepcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fechaRecepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Observacion
            // 
            this.Observacion.FillWeight = 60F;
            this.Observacion.HeaderText = "Observación";
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 40F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // DetalleOrden
            // 
            this.DetalleOrden.FillWeight = 30F;
            this.DetalleOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetalleOrden.HeaderText = "Detalle";
            this.DetalleOrden.Name = "DetalleOrden";
            this.DetalleOrden.ReadOnly = true;
            this.DetalleOrden.Text = "Ver...";
            // 
            // BAgregarOrden
            // 
            this.BAgregarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.BAgregarOrden.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.BAgregarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarOrden.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BAgregarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BAgregarOrden.Location = new System.Drawing.Point(533, 33);
            this.BAgregarOrden.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BAgregarOrden.Name = "BAgregarOrden";
            this.BAgregarOrden.Size = new System.Drawing.Size(174, 65);
            this.BAgregarOrden.TabIndex = 10;
            this.BAgregarOrden.Text = "Agregar Orden";
            this.BAgregarOrden.UseVisualStyleBackColor = false;
            this.BAgregarOrden.Click += new System.EventHandler(this.BAgregarOrden_Click);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BAgregarOrden);
            this.Controls.Add(this.LCompras);
            this.Controls.Add(this.DGCompras);
            this.Name = "FormCompras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.DGCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCompras;
        private System.Windows.Forms.DataGridView DGCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompa;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewButtonColumn fechaRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn DetalleOrden;
        private System.Windows.Forms.Button BAgregarOrden;
    }
}