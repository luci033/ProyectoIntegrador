namespace ProyectoIntegrador.Formularios.Productos
{
    partial class FormBuscarProducto
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
            this.DGProductos = new System.Windows.Forms.DataGridView();
            this.BCancelar = new System.Windows.Forms.Button();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LBuscarProducto = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.CBGenero = new System.Windows.Forms.ComboBox();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LGenero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToAddRows = false;
            this.DGProductos.AllowUserToDeleteRows = false;
            this.DGProductos.AllowUserToResizeColumns = false;
            this.DGProductos.AllowUserToResizeRows = false;
            this.DGProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colCodigo,
            this.colNombre,
            this.colCategoria,
            this.colGenero,
            this.colStockActual,
            this.colPrecioVenta,
            this.colPrecioCompra});
            this.DGProductos.Location = new System.Drawing.Point(0, 0);
            this.DGProductos.Name = "DGProductos";
            this.DGProductos.RowHeadersVisible = false;
            this.DGProductos.Size = new System.Drawing.Size(752, 236);
            this.DGProductos.TabIndex = 0;
            this.DGProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProductos_CellDoubleClick);
            // 
            // BCancelar
            // 
            this.BCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.BCancelar.Location = new System.Drawing.Point(602, 246);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(150, 38);
            this.BCancelar.TabIndex = 1;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(24, 25);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(368, 38);
            this.LTitulo.TabIndex = 2;
            this.LTitulo.Text = "Seleccionar Producto";
            // 
            // LBuscarProducto
            // 
            this.LBuscarProducto.AutoSize = true;
            this.LBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LBuscarProducto.Location = new System.Drawing.Point(10, 14);
            this.LBuscarProducto.Name = "LBuscarProducto";
            this.LBuscarProducto.Size = new System.Drawing.Size(53, 17);
            this.LBuscarProducto.TabIndex = 3;
            this.LBuscarProducto.Text = "Buscar:";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBBuscar.Location = new System.Drawing.Point(68, 10);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(195, 25);
            this.TBBuscar.TabIndex = 4;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // CBCategoria
            // 
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(355, 11);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(135, 21);
            this.CBCategoria.TabIndex = 5;
            this.CBCategoria.SelectedIndexChanged += new System.EventHandler(this.CBCategoria_SelectedIndexChanged);
            // 
            // CBGenero
            // 
            this.CBGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGenero.FormattingEnabled = true;
            this.CBGenero.Location = new System.Drawing.Point(575, 11);
            this.CBGenero.Name = "CBGenero";
            this.CBGenero.Size = new System.Drawing.Size(135, 21);
            this.CBGenero.TabIndex = 6;
            this.CBGenero.SelectedIndexChanged += new System.EventHandler(this.CBGenero_SelectedIndexChanged);
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LCategoria.Location = new System.Drawing.Point(280, 14);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(71, 17);
            this.LCategoria.TabIndex = 7;
            this.LCategoria.Text = "Categoría:";
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LGenero.Location = new System.Drawing.Point(510, 14);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(56, 17);
            this.LGenero.TabIndex = 8;
            this.LGenero.Text = "Género:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BCancelar);
            this.panel1.Controls.Add(this.DGProductos);
            this.panel1.Location = new System.Drawing.Point(24, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 290);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.CBGenero);
            this.panel2.Controls.Add(this.LBuscarProducto);
            this.panel2.Controls.Add(this.LGenero);
            this.panel2.Controls.Add(this.TBBuscar);
            this.panel2.Controls.Add(this.LCategoria);
            this.panel2.Controls.Add(this.CBCategoria);
            this.panel2.Location = new System.Drawing.Point(24, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 48);
            this.panel2.TabIndex = 10;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "Id Producto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = false;
            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 40F;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.FillWeight = 60F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colGenero
            // 
            this.colGenero.FillWeight = 30F;
            this.colGenero.HeaderText = "Género";
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            // 
            // colStockActual
            // 
            this.colStockActual.HeaderText = "Stock Actual";
            this.colStockActual.Name = "colStockActual";
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.FillWeight = 40F;
            this.colPrecioVenta.HeaderText = "Precio Venta";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.Visible = false;
            // 
            // colPrecioCompra
            // 
            this.colPrecioCompra.HeaderText = "Precio Compra";
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.Visible = false;
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LTitulo);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "FormBuscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LBuscarProducto;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.ComboBox CBGenero;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label LGenero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
    }
}