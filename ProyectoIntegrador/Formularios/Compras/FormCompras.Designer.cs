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
            this.BAgregarOrden = new System.Windows.Forms.Button();
            this.DGCompras = new System.Windows.Forms.DataGridView();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRecepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleOrden = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // LCompras
            // 
            this.LCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LCompras.AutoSize = true;
            this.LCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCompras.Location = new System.Drawing.Point(12, 59);
            this.LCompras.Name = "LCompras";
            this.LCompras.Size = new System.Drawing.Size(378, 42);
            this.LCompras.TabIndex = 9;
            this.LCompras.Text = "Gestión de Compras";
            this.LCompras.Click += new System.EventHandler(this.LProveedores_Click);
            // 
            // BAgregarOrden
            // 
            this.BAgregarOrden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAgregarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarOrden.Location = new System.Drawing.Point(525, 30);
            this.BAgregarOrden.Name = "BAgregarOrden";
            this.BAgregarOrden.Size = new System.Drawing.Size(215, 91);
            this.BAgregarOrden.TabIndex = 8;
            this.BAgregarOrden.Text = "Agregar Orden";
            this.BAgregarOrden.UseVisualStyleBackColor = true;
            this.BAgregarOrden.Click += new System.EventHandler(this.BAgregarOrden_Click);
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
            this.fechaRecepcion.FillWeight = 30F;
            this.fechaRecepcion.HeaderText = "Fecha Recepción";
            this.fechaRecepcion.Name = "fechaRecepcion";
            this.fechaRecepcion.ReadOnly = true;
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
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LCompras);
            this.Controls.Add(this.BAgregarOrden);
            this.Controls.Add(this.DGCompras);
            this.Name = "FormCompras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.DGCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCompras;
        private System.Windows.Forms.Button BAgregarOrden;
        private System.Windows.Forms.DataGridView DGCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompa;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn DetalleOrden;
    }
}