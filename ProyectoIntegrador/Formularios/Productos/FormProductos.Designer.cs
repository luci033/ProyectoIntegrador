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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BModificar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.combCategoriaForm = new System.Windows.Forms.ComboBox();
            this.dataGridCatalogoProd = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BNuevo = new System.Windows.Forms.Button();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LCatalogoProductos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBBuscarProd = new System.Windows.Forms.TextBox();
            this.LBuscarProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalogoProd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BModificar
            // 
            this.BModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.BModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(178)))));
            this.BModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BModificar.Location = new System.Drawing.Point(445, 15);
            this.BModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(126, 30);
            this.BModificar.TabIndex = 0;
            this.BModificar.Text = "Modificar";
            this.BModificar.UseVisualStyleBackColor = false;
            this.BModificar.Click += new System.EventHandler(this.BModificar_Click);
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
            // combCategoriaForm
            // 
            this.combCategoriaForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCategoriaForm.FormattingEnabled = true;
            this.combCategoriaForm.Location = new System.Drawing.Point(137, 87);
            this.combCategoriaForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combCategoriaForm.Name = "combCategoriaForm";
            this.combCategoriaForm.Size = new System.Drawing.Size(116, 23);
            this.combCategoriaForm.TabIndex = 5;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCatalogoProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridCatalogoProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCatalogoProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.CStock});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCatalogoProd.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridCatalogoProd.EnableHeadersVisualStyles = false;
            this.dataGridCatalogoProd.Location = new System.Drawing.Point(2, 336);
            this.dataGridCatalogoProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridCatalogoProd.Name = "dataGridCatalogoProd";
            this.dataGridCatalogoProd.ReadOnly = true;
            this.dataGridCatalogoProd.RowHeadersVisible = false;
            this.dataGridCatalogoProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCatalogoProd.Size = new System.Drawing.Size(706, 109);
            this.dataGridCatalogoProd.TabIndex = 8;
            this.dataGridCatalogoProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Column7
            // 
            this.Column7.HeaderText = "Imagen";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
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
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BEliminar.FlatAppearance.BorderSize = 0;
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BEliminar.ForeColor = System.Drawing.Color.White;
            this.BEliminar.Location = new System.Drawing.Point(445, 67);
            this.BEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(126, 30);
            this.BEliminar.TabIndex = 9;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = false;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BNuevo
            // 
            this.BNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevo.ForeColor = System.Drawing.Color.White;
            this.BNuevo.Location = new System.Drawing.Point(445, 122);
            this.BNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(126, 30);
            this.BNuevo.TabIndex = 10;
            this.BNuevo.Text = "Nuevo Producto";
            this.BNuevo.UseVisualStyleBackColor = false;
            this.BNuevo.Click += new System.EventHandler(this.BNuevo_Click);
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(80)))));
            this.LCategoria.Location = new System.Drawing.Point(21, 87);
            this.LCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(68, 19);
            this.LCategoria.TabIndex = 14;
            this.LCategoria.Text = "Categoria";
            // 
            // LCatalogoProductos
            // 
            this.LCatalogoProductos.AutoSize = true;
            this.LCatalogoProductos.Font = new System.Drawing.Font("Georgia", 16F);
            this.LCatalogoProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCatalogoProductos.Location = new System.Drawing.Point(14, 53);
            this.LCatalogoProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCatalogoProductos.Name = "LCatalogoProductos";
            this.LCatalogoProductos.Size = new System.Drawing.Size(481, 27);
            this.LCatalogoProductos.TabIndex = 15;
            this.LCatalogoProductos.Text = "Colección Joyería ALBA - Catálogo de Productos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BEliminar);
            this.panel1.Controls.Add(this.BModificar);
            this.panel1.Controls.Add(this.BNuevo);
            this.panel1.Controls.Add(this.TBBuscarProd);
            this.panel1.Controls.Add(this.LBuscarProd);
            this.panel1.Controls.Add(this.LCategoria);
            this.panel1.Controls.Add(this.combCategoriaForm);
            this.panel1.Location = new System.Drawing.Point(15, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 155);
            this.panel1.TabIndex = 16;
            // 
            // TBBuscarProd
            // 
            this.TBBuscarProd.Location = new System.Drawing.Point(137, 14);
            this.TBBuscarProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBBuscarProd.Name = "TBBuscarProd";
            this.TBBuscarProd.Size = new System.Drawing.Size(116, 23);
            this.TBBuscarProd.TabIndex = 15;
            // 
            // LBuscarProd
            // 
            this.LBuscarProd.AutoSize = true;
            this.LBuscarProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LBuscarProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(80)))));
            this.LBuscarProd.Location = new System.Drawing.Point(20, 14);
            this.LBuscarProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBuscarProd.Name = "LBuscarProd";
            this.LBuscarProd.Size = new System.Drawing.Size(109, 19);
            this.LBuscarProd.TabIndex = 0;
            this.LBuscarProd.Text = "Buscar Producto";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(708, 457);
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.ComboBox combCategoriaForm;
        private System.Windows.Forms.DataGridView dataGridCatalogoProd;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label LCatalogoProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBBuscarProd;
        private System.Windows.Forms.Label LBuscarProd;
    }
}