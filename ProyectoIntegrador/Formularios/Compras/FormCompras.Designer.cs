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
            this.LTitulo = new System.Windows.Forms.Label();
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
            // LTitulo
            // 
            this.LTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(24, 25);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(360, 38);
            this.LTitulo.TabIndex = 9;
            this.LTitulo.Text = "Gestión de Compras";
            this.LTitulo.Click += new System.EventHandler(this.LProveedores_Click);
            // 
            // DGCompras
            // 
            this.DGCompras.AllowUserToAddRows = false;
            this.DGCompras.AllowUserToDeleteRows = false;
            this.DGCompras.AllowUserToResizeColumns = false;
            this.DGCompras.AllowUserToResizeRows = false;
            this.DGCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.DGCompras.Location = new System.Drawing.Point(24, 85);
            this.DGCompras.Name = "DGCompras";
            this.DGCompras.ReadOnly = true;
            this.DGCompras.RowHeadersVisible = false;
            this.DGCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCompras.Size = new System.Drawing.Size(752, 335);
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
            this.BAgregarOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BAgregarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregarOrden.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarOrden.Location = new System.Drawing.Point(576, 24);
            this.BAgregarOrden.Name = "BAgregarOrden";
            this.BAgregarOrden.Size = new System.Drawing.Size(200, 44);
            this.BAgregarOrden.TabIndex = 10;
            this.BAgregarOrden.Text = "+ Nueva Orden";
            this.BAgregarOrden.UseVisualStyleBackColor = true;
            this.BAgregarOrden.Click += new System.EventHandler(this.BAgregarOrden_Click);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BAgregarOrden);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.DGCompras);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
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