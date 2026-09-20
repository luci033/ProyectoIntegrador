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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.BCancelar.Location = new System.Drawing.Point(480, 245);
            this.BCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(119, 42);
            this.BCancelar.TabIndex = 9;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BCobrar
            // 
            this.BCobrar.Location = new System.Drawing.Point(629, 245);
            this.BCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.BCobrar.Name = "BCobrar";
            this.BCobrar.Size = new System.Drawing.Size(119, 42);
            this.BCobrar.TabIndex = 10;
            this.BCobrar.Text = "Cobrar";
            this.BCobrar.UseVisualStyleBackColor = true;
            this.BCobrar.Click += new System.EventHandler(this.BCobrar_Click);
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(762, 258);
            this.LTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(46, 17);
            this.LTotal.TabIndex = 11;
            this.LTotal.Text = "TOTAL:";
            // 
            // TBTotal
            // 
            this.TBTotal.Location = new System.Drawing.Point(816, 255);
            this.TBTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(116, 25);
            this.TBTotal.TabIndex = 6;
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
            this.dataGridProducto.AllowUserToResizeColumns = false;
            this.dataGridProducto.AllowUserToResizeRows = false;
            this.dataGridProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colProducto,
            this.colPrecioUnitario,
            this.colCantidad,
            this.colEliminar,
            this.colSubTotal});
            this.dataGridProducto.Location = new System.Drawing.Point(4, 4);
            this.dataGridProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridProducto.MultiSelect = false;
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridProducto.RowHeadersVisible = false;
            this.dataGridProducto.Size = new System.Drawing.Size(941, 233);
            this.dataGridProducto.TabIndex = 7;
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
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.FillWeight = 30F;
            this.colPrecioUnitario.HeaderText = "Precio Unit.";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 30F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colEliminar
            // 
            this.colEliminar.FillWeight = 30F;
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Text = "Eliminar";
            // 
            // colSubTotal
            // 
            this.colSubTotal.FillWeight = 50F;
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridProducto);
            this.panel1.Controls.Add(this.BCobrar);
            this.panel1.Controls.Add(this.BCancelar);
            this.panel1.Controls.Add(this.LTotal);
            this.panel1.Controls.Add(this.TBTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 306);
            this.panel1.TabIndex = 14;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Location = new System.Drawing.Point(29, 42);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(97, 17);
            this.LTitulo.TabIndex = 15;
            this.LTitulo.Text = "Registrar Venta";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BBuscarCliente);
            this.panel3.Controls.Add(this.TBCondicionIVA);
            this.panel3.Controls.Add(this.TBCliente);
            this.panel3.Controls.Add(this.LCliente);
            this.panel3.Controls.Add(this.LCondicionIVA);
            this.panel3.Location = new System.Drawing.Point(32, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(852, 61);
            this.panel3.TabIndex = 17;
            // 
            // BBuscarCliente
            // 
            this.BBuscarCliente.Location = new System.Drawing.Point(707, 9);
            this.BBuscarCliente.Name = "BBuscarCliente";
            this.BBuscarCliente.Size = new System.Drawing.Size(111, 37);
            this.BBuscarCliente.TabIndex = 18;
            this.BBuscarCliente.Text = "Buscar Cliente";
            this.BBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // TBCondicionIVA
            // 
            this.TBCondicionIVA.Location = new System.Drawing.Point(507, 16);
            this.TBCondicionIVA.Name = "TBCondicionIVA";
            this.TBCondicionIVA.ReadOnly = true;
            this.TBCondicionIVA.Size = new System.Drawing.Size(131, 25);
            this.TBCondicionIVA.TabIndex = 23;
            // 
            // TBCliente
            // 
            this.TBCliente.Location = new System.Drawing.Point(147, 16);
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.ReadOnly = true;
            this.TBCliente.Size = new System.Drawing.Size(131, 25);
            this.TBCliente.TabIndex = 22;
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Location = new System.Drawing.Point(97, 19);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(50, 17);
            this.LCliente.TabIndex = 12;
            this.LCliente.Text = "Cliente:";
            // 
            // LCondicionIVA
            // 
            this.LCondicionIVA.AutoSize = true;
            this.LCondicionIVA.Location = new System.Drawing.Point(406, 19);
            this.LCondicionIVA.Name = "LCondicionIVA";
            this.LCondicionIVA.Size = new System.Drawing.Size(95, 17);
            this.LCondicionIVA.TabIndex = 13;
            this.LCondicionIVA.Text = "Condición IVA: ";
            // 
            // LVendedor
            // 
            this.LVendedor.AutoSize = true;
            this.LVendedor.Location = new System.Drawing.Point(73, 57);
            this.LVendedor.Name = "LVendedor";
            this.LVendedor.Size = new System.Drawing.Size(68, 17);
            this.LVendedor.TabIndex = 13;
            this.LVendedor.Text = "Vendedor:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(457, 21);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(44, 17);
            this.LFecha.TabIndex = 12;
            this.LFecha.Text = "Fecha:";
            // 
            // TBVendedor
            // 
            this.TBVendedor.Location = new System.Drawing.Point(147, 54);
            this.TBVendedor.Name = "TBVendedor";
            this.TBVendedor.ReadOnly = true;
            this.TBVendedor.Size = new System.Drawing.Size(131, 25);
            this.TBVendedor.TabIndex = 20;
            // 
            // TBFecha
            // 
            this.TBFecha.Location = new System.Drawing.Point(507, 18);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(131, 25);
            this.TBFecha.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.LNroComprobante);
            this.panel2.Controls.Add(this.TBFecha);
            this.panel2.Controls.Add(this.TBVendedor);
            this.panel2.Controls.Add(this.LFecha);
            this.panel2.Controls.Add(this.LVendedor);
            this.panel2.Location = new System.Drawing.Point(32, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 101);
            this.panel2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(131, 25);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LNroComprobante
            // 
            this.LNroComprobante.AutoSize = true;
            this.LNroComprobante.Location = new System.Drawing.Point(15, 21);
            this.LNroComprobante.Name = "LNroComprobante";
            this.LNroComprobante.Size = new System.Drawing.Size(126, 17);
            this.LNroComprobante.TabIndex = 22;
            this.LNroComprobante.Text = "Nro. Comprobante: ";
            this.LNroComprobante.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BAgregarProducto
            // 
            this.BAgregarProducto.Location = new System.Drawing.Point(32, 314);
            this.BAgregarProducto.Name = "BAgregarProducto";
            this.BAgregarProducto.Size = new System.Drawing.Size(159, 39);
            this.BAgregarProducto.TabIndex = 24;
            this.BAgregarProducto.Text = "Agregar Producto";
            this.BAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // FormRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 705);
            this.Controls.Add(this.BAgregarProducto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistroVentas";
            this.Text = "Registro de venta";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LNroComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
    }
}