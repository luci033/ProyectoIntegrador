namespace ProyectoIntegrador.Formularios.Ventas
{
    partial class FormRegistroVentas
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
            this.components = new System.ComponentModel.Container();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BCobrar = new System.Windows.Forms.Button();
            this.LTotal = new System.Windows.Forms.Label();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BBuscarCliente = new System.Windows.Forms.Button();
            this.TBCondicionIVA = new System.Windows.Forms.TextBox();
            this.TBCliente = new System.Windows.Forms.TextBox();
            this.LCliente = new System.Windows.Forms.Label();
            this.LCondicionIVA = new System.Windows.Forms.Label();
            this.LVendedor = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.TBVendedor = new System.Windows.Forms.TextBox();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBNroVenta = new System.Windows.Forms.TextBox();
            this.LNroComprobante = new System.Windows.Forms.Label();
            this.BAgregarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCancelar
            // 
            this.BCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(208)))), ((int)(((byte)(201)))));
            this.BCancelar.FlatAppearance.BorderSize = 0;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BCancelar.Location = new System.Drawing.Point(470, 332);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(110, 36);
            this.BCancelar.TabIndex = 2;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BCobrar
            // 
            this.BCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BCobrar.FlatAppearance.BorderSize = 0;
            this.BCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCobrar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCobrar.ForeColor = System.Drawing.Color.White;
            this.BCobrar.Location = new System.Drawing.Point(595, 332);
            this.BCobrar.Name = "BCobrar";
            this.BCobrar.Size = new System.Drawing.Size(130, 36);
            this.BCobrar.TabIndex = 3;
            this.BCobrar.Text = "Cobrar";
            this.BCobrar.UseVisualStyleBackColor = false;
            this.BCobrar.Click += new System.EventHandler(this.BCobrar_Click);
            // 
            // LTotal
            // 
            this.LTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTotal.Location = new System.Drawing.Point(740, 340);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(54, 19);
            this.LTotal.TabIndex = 4;
            this.LTotal.Text = "TOTAL:";
            // 
            // TBTotal
            // 
            this.TBTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.TBTotal.Location = new System.Drawing.Point(800, 336);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(83, 27);
            this.TBTotal.TabIndex = 5;
            this.TBTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.AllowUserToAddRows = false;
            this.dataGridProducto.AllowUserToDeleteRows = false;
            this.dataGridProducto.AllowUserToOrderColumns = true;
            this.dataGridProducto.AllowUserToResizeRows = false;
            this.dataGridProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducto.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colProducto,
            this.colCategoria,
            this.colGenero,
            this.colPrecioUnitario,
            this.colCantidad,
            this.colEliminar,
            this.colSubTotal});
            this.dataGridProducto.Location = new System.Drawing.Point(12, 12);
            this.dataGridProducto.MultiSelect = false;
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridProducto.RowHeadersVisible = false;
            this.dataGridProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducto.Size = new System.Drawing.Size(871, 305);
            this.dataGridProducto.TabIndex = 1;
            this.dataGridProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProducto_CellContentClick);
            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 20F;
            this.colCodigo.HeaderText = "Cod.";
            this.colCodigo.Name = "colCodigo";
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 50F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colCategoria
            // 
            this.colCategoria.FillWeight = 40F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            // 
            // colGenero
            // 
            this.colGenero.FillWeight = 40F;
            this.colGenero.HeaderText = "Género";
            this.colGenero.Name = "colGenero";
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.FillWeight = 30F;
            this.colPrecioUnitario.HeaderText = "Precio Unit.";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 25F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colEliminar
            // 
            this.colEliminar.FillWeight = 25F;
            this.colEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Text = "Eliminar";
            this.colEliminar.UseColumnTextForButtonValue = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.FillWeight = 35F;
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridProducto);
            this.panel1.Controls.Add(this.BCobrar);
            this.panel1.Controls.Add(this.BCancelar);
            this.panel1.Controls.Add(this.LTotal);
            this.panel1.Controls.Add(this.TBTotal);
            this.panel1.Location = new System.Drawing.Point(25, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 380);
            this.panel1.TabIndex = 4;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(25, 20);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(221, 31);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Registar Venta";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.BBuscarCliente);
            this.panel3.Controls.Add(this.TBCondicionIVA);
            this.panel3.Controls.Add(this.TBCliente);
            this.panel3.Controls.Add(this.LCliente);
            this.panel3.Controls.Add(this.LCondicionIVA);
            this.panel3.Location = new System.Drawing.Point(25, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 55);
            this.panel3.TabIndex = 2;
            // 
            // BBuscarCliente
            // 
            this.BBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BBuscarCliente.FlatAppearance.BorderSize = 0;
            this.BBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarCliente.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.BBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.BBuscarCliente.Location = new System.Drawing.Point(620, 11);
            this.BBuscarCliente.Name = "BBuscarCliente";
            this.BBuscarCliente.Size = new System.Drawing.Size(130, 32);
            this.BBuscarCliente.TabIndex = 4;
            this.BBuscarCliente.Text = "Buscar Cliente";
            this.BBuscarCliente.UseVisualStyleBackColor = false;
            this.BBuscarCliente.Click += new System.EventHandler(this.BBuscarCliente_Click);
            // 
            // TBCondicionIVA
            // 
            this.TBCondicionIVA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBCondicionIVA.Location = new System.Drawing.Point(400, 15);
            this.TBCondicionIVA.Name = "TBCondicionIVA";
            this.TBCondicionIVA.ReadOnly = true;
            this.TBCondicionIVA.Size = new System.Drawing.Size(180, 24);
            this.TBCondicionIVA.TabIndex = 3;
            // 
            // TBCliente
            // 
            this.TBCliente.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBCliente.Location = new System.Drawing.Point(75, 15);
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.ReadOnly = true;
            this.TBCliente.Size = new System.Drawing.Size(200, 24);
            this.TBCliente.TabIndex = 1;
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCliente.Location = new System.Drawing.Point(18, 18);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(49, 15);
            this.LCliente.TabIndex = 0;
            this.LCliente.Text = "Cliente:";
            // 
            // LCondicionIVA
            // 
            this.LCondicionIVA.AutoSize = true;
            this.LCondicionIVA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LCondicionIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCondicionIVA.Location = new System.Drawing.Point(295, 18);
            this.LCondicionIVA.Name = "LCondicionIVA";
            this.LCondicionIVA.Size = new System.Drawing.Size(86, 15);
            this.LCondicionIVA.TabIndex = 2;
            this.LCondicionIVA.Text = "Condición IVA:";
            // 
            // LVendedor
            // 
            this.LVendedor.AutoSize = true;
            this.LVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LVendedor.Location = new System.Drawing.Point(295, 20);
            this.LVendedor.Name = "LVendedor";
            this.LVendedor.Size = new System.Drawing.Size(64, 15);
            this.LVendedor.TabIndex = 2;
            this.LVendedor.Text = "Vendedor:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LFecha.Location = new System.Drawing.Point(550, 20);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(42, 15);
            this.LFecha.TabIndex = 4;
            this.LFecha.Text = "Fecha:";
            // 
            // TBVendedor
            // 
            this.TBVendedor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBVendedor.Location = new System.Drawing.Point(365, 17);
            this.TBVendedor.Name = "TBVendedor";
            this.TBVendedor.ReadOnly = true;
            this.TBVendedor.Size = new System.Drawing.Size(160, 24);
            this.TBVendedor.TabIndex = 3;
            // 
            // TBFecha
            // 
            this.TBFecha.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBFecha.Location = new System.Drawing.Point(600, 17);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(120, 24);
            this.TBFecha.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TBNroVenta);
            this.panel2.Controls.Add(this.LNroComprobante);
            this.panel2.Controls.Add(this.TBFecha);
            this.panel2.Controls.Add(this.TBVendedor);
            this.panel2.Controls.Add(this.LFecha);
            this.panel2.Controls.Add(this.LVendedor);
            this.panel2.Location = new System.Drawing.Point(25, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 60);
            this.panel2.TabIndex = 1;
            // 
            // TBNroVenta
            // 
            this.TBNroVenta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBNroVenta.Location = new System.Drawing.Point(145, 17);
            this.TBNroVenta.Name = "TBNroVenta";
            this.TBNroVenta.ReadOnly = true;
            this.TBNroVenta.Size = new System.Drawing.Size(130, 24);
            this.TBNroVenta.TabIndex = 1;
            this.TBNroVenta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LNroComprobante
            // 
            this.LNroComprobante.AutoSize = true;
            this.LNroComprobante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LNroComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LNroComprobante.Location = new System.Drawing.Point(18, 20);
            this.LNroComprobante.Name = "LNroComprobante";
            this.LNroComprobante.Size = new System.Drawing.Size(113, 15);
            this.LNroComprobante.TabIndex = 0;
            this.LNroComprobante.Text = "Nro. Comprobante:";
            this.LNroComprobante.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BAgregarProducto
            // 
            this.BAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BAgregarProducto.FlatAppearance.BorderSize = 0;
            this.BAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarProducto.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.BAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.BAgregarProducto.Location = new System.Drawing.Point(25, 210);
            this.BAgregarProducto.Name = "BAgregarProducto";
            this.BAgregarProducto.Size = new System.Drawing.Size(160, 34);
            this.BAgregarProducto.TabIndex = 3;
            this.BAgregarProducto.Text = "+ Agregar Joya";
            this.BAgregarProducto.UseVisualStyleBackColor = false;
            this.BAgregarProducto.Click += new System.EventHandler(this.BAgregarProducto_Click_1);
            // 
            // FormRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(945, 655);
            this.Controls.Add(this.BAgregarProducto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormRegistroVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Venta";
            this.Load += new System.EventHandler(this.FormRegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BCobrar;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.TextBox TBTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.DataGridView dataGridProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TBCondicionIVA;
        private System.Windows.Forms.TextBox TBCliente;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.Label LCondicionIVA;
        private System.Windows.Forms.Button BAgregarProducto;
        private System.Windows.Forms.Button BBuscarCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.TextBox TBVendedor;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LVendedor;
        private System.Windows.Forms.TextBox TBNroVenta;
        private System.Windows.Forms.Label LNroComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}