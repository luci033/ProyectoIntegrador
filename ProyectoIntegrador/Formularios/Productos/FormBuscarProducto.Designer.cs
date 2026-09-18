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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGProductos = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCancelar = new System.Windows.Forms.Button();
            this.LSeleccionarProducto = new System.Windows.Forms.Label();
            this.LBuscarProducto = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.CBGenero = new System.Windows.Forms.ComboBox();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LGenero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToAddRows = false;
            this.DGProductos.AllowUserToDeleteRows = false;
            this.DGProductos.AllowUserToResizeColumns = false;
            this.DGProductos.AllowUserToResizeRows = false;
            this.DGProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colCodigo,
            this.colNombre,
            this.colCostoCompra,
            this.colCategoria,
            this.colGenero});
            this.DGProductos.Location = new System.Drawing.Point(12, 214);
            this.DGProductos.Name = "DGProductos";
            this.DGProductos.RowHeadersVisible = false;
            this.DGProductos.Size = new System.Drawing.Size(776, 179);
            this.DGProductos.TabIndex = 0;
            this.DGProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProductos_CellDoubleClick);
            this.DGProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DD);
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
            // colCostoCompra
            // 
            dataGridViewCellStyle6.Format = "C2";
            this.colCostoCompra.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCostoCompra.FillWeight = 60F;
            this.colCostoCompra.HeaderText = "Costo de Compra";
            this.colCostoCompra.Name = "colCostoCompra";
            this.colCostoCompra.ReadOnly = true;
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
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BCancelar.FlatAppearance.BorderSize = 0;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BCancelar.ForeColor = System.Drawing.Color.White;
            this.BCancelar.Location = new System.Drawing.Point(697, 399);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(91, 39);
            this.BCancelar.TabIndex = 1;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // LSeleccionarProducto
            // 
            this.LSeleccionarProducto.AutoSize = true;
            this.LSeleccionarProducto.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSeleccionarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(105)))), ((int)(((byte)(100)))));
            this.LSeleccionarProducto.Location = new System.Drawing.Point(12, 25);
            this.LSeleccionarProducto.Name = "LSeleccionarProducto";
            this.LSeleccionarProducto.Size = new System.Drawing.Size(477, 50);
            this.LSeleccionarProducto.TabIndex = 2;
            this.LSeleccionarProducto.Text = "SELECCIONAR PRODUCTO";
            // 
            // LBuscarProducto
            // 
            this.LBuscarProducto.AutoSize = true;
            this.LBuscarProducto.Location = new System.Drawing.Point(50, 191);
            this.LBuscarProducto.Name = "LBuscarProducto";
            this.LBuscarProducto.Size = new System.Drawing.Size(47, 13);
            this.LBuscarProducto.TabIndex = 3;
            this.LBuscarProducto.Text = "Nombre:";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(103, 188);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(160, 20);
            this.TBBuscar.TabIndex = 4;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // CBCategoria
            // 
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(398, 188);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(121, 21);
            this.CBCategoria.TabIndex = 5;
            this.CBCategoria.SelectedIndexChanged += new System.EventHandler(this.CBCategoria_SelectedIndexChanged);
            // 
            // CBGenero
            // 
            this.CBGenero.FormattingEnabled = true;
            this.CBGenero.Location = new System.Drawing.Point(611, 188);
            this.CBGenero.Name = "CBGenero";
            this.CBGenero.Size = new System.Drawing.Size(121, 21);
            this.CBGenero.TabIndex = 6;
            this.CBGenero.SelectedIndexChanged += new System.EventHandler(this.CBGenero_SelectedIndexChanged);
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Location = new System.Drawing.Point(338, 191);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(57, 13);
            this.LCategoria.TabIndex = 7;
            this.LCategoria.Text = "Categoría:";
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Location = new System.Drawing.Point(563, 191);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(45, 13);
            this.LGenero.TabIndex = 8;
            this.LGenero.Text = "Genero:";
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LGenero);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.CBGenero);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.TBBuscar);
            this.Controls.Add(this.LBuscarProducto);
            this.Controls.Add(this.LSeleccionarProducto);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.DGProductos);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormBuscarProducto";
            this.Text = "Buscar Productos";
            this.Load += new System.EventHandler(this.FormBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label LSeleccionarProducto;
        private System.Windows.Forms.Label LBuscarProducto;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.ComboBox CBGenero;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label LGenero;
    }
}