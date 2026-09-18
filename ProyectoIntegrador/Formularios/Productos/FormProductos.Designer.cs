namespace ProyectoIntegrador.Formularios.Productos
{
    partial class FormProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.dataGridCatalogoProd = new System.Windows.Forms.DataGridView();
            this.BNuevo = new System.Windows.Forms.Button();
            this.LCatalogoProductos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalogoProd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 359);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 1;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(16, 370);
            this.LNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(51, 15);
            this.LNombre.TabIndex = 2;
            this.LNombre.Text = "Nombre";
            // 
            // dataGridCatalogoProd
            // 
            this.dataGridCatalogoProd.AllowUserToAddRows = false;
            this.dataGridCatalogoProd.AllowUserToOrderColumns = true;
            this.dataGridCatalogoProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCatalogoProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCatalogoProd.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCatalogoProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCatalogoProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCatalogoProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCatalogoProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.CCodigo,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.CStock,
            this.colStockMinimo,
            this.colEliminar,
            this.colModificar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCatalogoProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCatalogoProd.EnableHeadersVisualStyles = false;
            this.dataGridCatalogoProd.Location = new System.Drawing.Point(2, 336);
            this.dataGridCatalogoProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridCatalogoProd.Name = "dataGridCatalogoProd";
            this.dataGridCatalogoProd.ReadOnly = true;
            this.dataGridCatalogoProd.RowHeadersVisible = false;
            this.dataGridCatalogoProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCatalogoProd.Size = new System.Drawing.Size(850, 109);
            this.dataGridCatalogoProd.TabIndex = 8;
            this.dataGridCatalogoProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BNuevo
            // 
            this.BNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevo.ForeColor = System.Drawing.Color.White;
            this.BNuevo.Location = new System.Drawing.Point(432, 13);
            this.BNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(126, 30);
            this.BNuevo.TabIndex = 10;
            this.BNuevo.Text = "Nuevo Producto";
            this.BNuevo.UseVisualStyleBackColor = false;
            this.BNuevo.Click += new System.EventHandler(this.BNuevo_Click);
            // 
            // LCatalogoProductos
            // 
            this.LCatalogoProductos.AutoSize = true;
            this.LCatalogoProductos.Font = new System.Drawing.Font("Georgia", 16F);
            this.LCatalogoProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCatalogoProductos.Location = new System.Drawing.Point(10, 87);
            this.LCatalogoProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCatalogoProductos.Name = "LCatalogoProductos";
            this.LCatalogoProductos.Size = new System.Drawing.Size(481, 27);
            this.LCatalogoProductos.TabIndex = 15;
            this.LCatalogoProductos.Text = "Colección Joyería ALBA - Catálogo de Productos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BBuscarProducto);
            this.panel1.Controls.Add(this.BNuevo);
            this.panel1.Location = new System.Drawing.Point(28, 247);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 55);
            this.panel1.TabIndex = 16;
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarProducto.Location = new System.Drawing.Point(18, 13);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(117, 23);
            this.BBuscarProducto.TabIndex = 15;
            this.BBuscarProducto.Text = "Buscar Producto";
            this.BBuscarProducto.UseVisualStyleBackColor = true;
            this.BBuscarProducto.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "IdProducto";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.Visible = false;
            // 
            // CCodigo
            // 
            this.CCodigo.FillWeight = 50F;
            this.CCodigo.HeaderText = "Código";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Categoría";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Género";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // CStock
            // 
            this.CStock.HeaderText = "Stock";
            this.CStock.Name = "CStock";
            this.CStock.ReadOnly = true;
            // 
            // colStockMinimo
            // 
            this.colStockMinimo.HeaderText = "Stock Mínimo";
            this.colStockMinimo.Name = "colStockMinimo";
            this.colStockMinimo.ReadOnly = true;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEliminar.Text = "Eliminar";
            this.colEliminar.UseColumnTextForButtonValue = true;
            // 
            // colModificar
            // 
            this.colModificar.HeaderText = "";
            this.colModificar.Name = "colModificar";
            this.colModificar.ReadOnly = true;
            this.colModificar.Text = "Modificar";
            this.colModificar.UseColumnTextForButtonValue = true;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(852, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LCatalogoProductos);
            this.Controls.Add(this.dataGridCatalogoProd);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalogoProd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.DataGridView dataGridCatalogoProd;
        private System.Windows.Forms.Button BNuevo;
        private System.Windows.Forms.Label LCatalogoProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMinimo;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.DataGridViewButtonColumn colModificar;
    }
}