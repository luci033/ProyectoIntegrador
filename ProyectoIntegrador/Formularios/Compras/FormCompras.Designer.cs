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
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.LBuscar = new System.Windows.Forms.Label();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.DGCompras = new System.Windows.Forms.DataGridView();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRecepcion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleOrden = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BAgregarOrden = new System.Windows.Forms.Button();
            this.panelFiltro.SuspendLayout();
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
            // panelFiltro
            // 
            this.panelFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltro.Controls.Add(this.BLimpiar);
            this.panelFiltro.Controls.Add(this.cmbEstado);
            this.panelFiltro.Controls.Add(this.LEstado);
            this.panelFiltro.Controls.Add(this.TBBuscar);
            this.panelFiltro.Controls.Add(this.cmbBuscar);
            this.panelFiltro.Controls.Add(this.LBuscar);
            this.panelFiltro.Location = new System.Drawing.Point(24, 80);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(752, 52);
            this.panelFiltro.TabIndex = 11;
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LBuscar.Location = new System.Drawing.Point(12, 16);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(77, 17);
            this.LBuscar.TabIndex = 0;
            this.LBuscar.Text = "Buscar por:";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(94, 13);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(130, 25);
            this.cmbBuscar.TabIndex = 1;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBBuscar.Location = new System.Drawing.Point(232, 13);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(185, 25);
            this.TBBuscar.TabIndex = 2;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LEstado.Location = new System.Drawing.Point(432, 16);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(52, 17);
            this.LEstado.TabIndex = 3;
            this.LEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(490, 13);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(155, 25);
            this.cmbEstado.TabIndex = 4;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // BLimpiar
            // 
            this.BLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BLimpiar.Location = new System.Drawing.Point(654, 11);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(86, 29);
            this.BLimpiar.TabIndex = 5;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = true;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
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
            this.DGCompras.Location = new System.Drawing.Point(24, 144);
            this.DGCompras.Name = "DGCompras";
            this.DGCompras.ReadOnly = true;
            this.DGCompras.RowHeadersVisible = false;
            this.DGCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCompras.Size = new System.Drawing.Size(752, 276);
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
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.BAgregarOrden);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.DGCompras);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button BLimpiar;
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