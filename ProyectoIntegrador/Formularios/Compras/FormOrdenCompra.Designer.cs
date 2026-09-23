namespace ProyectoIntegrador.Formularios.Compras
{
    partial class FormOrdenCompra
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BSeleccionarProveedor = new System.Windows.Forms.Button();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.TBRazonSocial = new System.Windows.Forms.TextBox();
            this.LCUIT = new System.Windows.Forms.Label();
            this.TBCUIT = new System.Windows.Forms.TextBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBContacto = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BAgregarProducto = new System.Windows.Forms.Button();
            this.DGDetalleOrden = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTotal = new System.Windows.Forms.Label();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BGenerarOrden = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LSubtitulo);
            this.panelCard.Controls.Add(this.panel1);
            this.panelCard.Controls.Add(this.panel2);
            this.panelCard.Controls.Add(this.BCancelar);
            this.panelCard.Controls.Add(this.BGenerarOrden);
            this.panelCard.Location = new System.Drawing.Point(30, 20);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(980, 670);
            this.panelCard.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(30, 16);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(354, 31);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Nueva Orden de Compra";
            this.LTitulo.Click += new System.EventHandler(this.label4_Click);
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.LSubtitulo.Location = new System.Drawing.Point(32, 52);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(546, 17);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Seleccione el proveedor, agregue los productos del catálogo y genere la orden de " +
    "compra.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.BSeleccionarProveedor);
            this.panel1.Controls.Add(this.LRazonSocial);
            this.panel1.Controls.Add(this.TBRazonSocial);
            this.panel1.Controls.Add(this.LCUIT);
            this.panel1.Controls.Add(this.TBCUIT);
            this.panel1.Controls.Add(this.LFecha);
            this.panel1.Controls.Add(this.TBFecha);
            this.panel1.Controls.Add(this.LUsuario);
            this.panel1.Controls.Add(this.TBUsuario);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.TBContacto);
            this.panel1.Controls.Add(this.LCorreo);
            this.panel1.Controls.Add(this.TBCorreo);
            this.panel1.Location = new System.Drawing.Point(30, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 118);
            this.panel1.TabIndex = 2;
            // 
            // BSeleccionarProveedor
            // 
            this.BSeleccionarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSeleccionarProveedor.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSeleccionarProveedor.Location = new System.Drawing.Point(15, 12);
            this.BSeleccionarProveedor.Name = "BSeleccionarProveedor";
            this.BSeleccionarProveedor.Size = new System.Drawing.Size(200, 42);
            this.BSeleccionarProveedor.TabIndex = 0;
            this.BSeleccionarProveedor.Text = "🏢 Seleccionar Proveedor";
            this.BSeleccionarProveedor.UseVisualStyleBackColor = true;
            this.BSeleccionarProveedor.Click += new System.EventHandler(this.BSeleccionarProveedor_Click);
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LRazonSocial.Location = new System.Drawing.Point(235, 12);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(79, 15);
            this.LRazonSocial.TabIndex = 1;
            this.LRazonSocial.Text = "Razón Social:";
            // 
            // TBRazonSocial
            // 
            this.TBRazonSocial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRazonSocial.Location = new System.Drawing.Point(235, 30);
            this.TBRazonSocial.Name = "TBRazonSocial";
            this.TBRazonSocial.ReadOnly = true;
            this.TBRazonSocial.Size = new System.Drawing.Size(240, 25);
            this.TBRazonSocial.TabIndex = 2;
            this.TBRazonSocial.TextChanged += new System.EventHandler(this.label3_Click);
            // 
            // LCUIT
            // 
            this.LCUIT.AutoSize = true;
            this.LCUIT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCUIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LCUIT.Location = new System.Drawing.Point(495, 12);
            this.LCUIT.Name = "LCUIT";
            this.LCUIT.Size = new System.Drawing.Size(37, 15);
            this.LCUIT.TabIndex = 3;
            this.LCUIT.Text = "CUIT:";
            // 
            // TBCUIT
            // 
            this.TBCUIT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCUIT.Location = new System.Drawing.Point(495, 30);
            this.TBCUIT.Name = "TBCUIT";
            this.TBCUIT.ReadOnly = true;
            this.TBCUIT.Size = new System.Drawing.Size(170, 25);
            this.TBCUIT.TabIndex = 4;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LFecha.Location = new System.Drawing.Point(685, 12);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(42, 15);
            this.LFecha.TabIndex = 5;
            this.LFecha.Text = "Fecha:";
            // 
            // TBFecha
            // 
            this.TBFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFecha.Location = new System.Drawing.Point(685, 30);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(100, 25);
            this.TBFecha.TabIndex = 6;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LUsuario.Location = new System.Drawing.Point(805, 12);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(52, 15);
            this.LUsuario.TabIndex = 7;
            this.LUsuario.Text = "Usuario:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuario.Location = new System.Drawing.Point(805, 30);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.ReadOnly = true;
            this.TBUsuario.Size = new System.Drawing.Size(100, 25);
            this.TBUsuario.TabIndex = 8;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LTelefono.Location = new System.Drawing.Point(235, 62);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(59, 15);
            this.LTelefono.TabIndex = 9;
            this.LTelefono.Text = "Teléfono:";
            this.LTelefono.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // TBContacto
            // 
            this.TBContacto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContacto.Location = new System.Drawing.Point(235, 80);
            this.TBContacto.Name = "TBContacto";
            this.TBContacto.ReadOnly = true;
            this.TBContacto.Size = new System.Drawing.Size(240, 25);
            this.TBContacto.TabIndex = 10;
            this.TBContacto.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LCorreo.Location = new System.Drawing.Point(495, 62);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(113, 15);
            this.LCorreo.TabIndex = 11;
            this.LCorreo.Text = "Correo Electrónico:";
            // 
            // TBCorreo
            // 
            this.TBCorreo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreo.Location = new System.Drawing.Point(495, 80);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.ReadOnly = true;
            this.TBCorreo.Size = new System.Drawing.Size(410, 25);
            this.TBCorreo.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.BAgregarProducto);
            this.panel2.Controls.Add(this.DGDetalleOrden);
            this.panel2.Controls.Add(this.LTotal);
            this.panel2.Controls.Add(this.TBTotal);
            this.panel2.Location = new System.Drawing.Point(30, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 390);
            this.panel2.TabIndex = 3;
            // 
            // BAgregarProducto
            // 
            this.BAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregarProducto.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarProducto.Location = new System.Drawing.Point(15, 12);
            this.BAgregarProducto.Name = "BAgregarProducto";
            this.BAgregarProducto.Size = new System.Drawing.Size(200, 40);
            this.BAgregarProducto.TabIndex = 0;
            this.BAgregarProducto.Text = "🔍 Agregar Producto";
            this.BAgregarProducto.UseVisualStyleBackColor = true;
            this.BAgregarProducto.Click += new System.EventHandler(this.BAgregarProducto_Click);
            // 
            // DGDetalleOrden
            // 
            this.DGDetalleOrden.AllowUserToAddRows = false;
            this.DGDetalleOrden.AllowUserToDeleteRows = false;
            this.DGDetalleOrden.AllowUserToResizeColumns = false;
            this.DGDetalleOrden.AllowUserToResizeRows = false;
            this.DGDetalleOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGDetalleOrden.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.DGDetalleOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalleOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colCodigo,
            this.nombre,
            this.colCategoria,
            this.colGenero,
            this.cantidad,
            this.CostoUnitario,
            this.Subtotal});
            this.DGDetalleOrden.GridColor = System.Drawing.Color.Silver;
            this.DGDetalleOrden.Location = new System.Drawing.Point(15, 60);
            this.DGDetalleOrden.Name = "DGDetalleOrden";
            this.DGDetalleOrden.RowHeadersVisible = false;
            this.DGDetalleOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGDetalleOrden.Size = new System.Drawing.Size(890, 270);
            this.DGDetalleOrden.TabIndex = 1;
            this.DGDetalleOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetalleOrden_CellContentClick);
            this.DGDetalleOrden.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGDetalleOrden_CellValidating);
            this.DGDetalleOrden.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetalleOrden_CellValueChanged);
            this.DGDetalleOrden.CurrentCellDirtyStateChanged += new System.EventHandler(this.DGDetalleOrden_CurrentCellDirtyStateChanged);
            this.DGDetalleOrden.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGDetalleOrden_DataError);
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "Id Producto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = false;
            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 25F;
            this.colCodigo.HeaderText = "Cod.";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 70F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.FillWeight = 50F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colGenero
            // 
            this.colGenero.FillWeight = 45F;
            this.colGenero.HeaderText = "Género";
            this.colGenero.Name = "colGenero";
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 35F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // CostoUnitario
            // 
            dataGridViewCellStyle1.Format = "C2";
            this.CostoUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.CostoUnitario.FillWeight = 50F;
            this.CostoUnitario.HeaderText = "Costo Unitario";
            this.CostoUnitario.Name = "CostoUnitario";
            // 
            // Subtotal
            // 
            dataGridViewCellStyle2.Format = "C2";
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.Subtotal.FillWeight = 50F;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTotal.Location = new System.Drawing.Point(620, 345);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(95, 20);
            this.LTotal.TabIndex = 2;
            this.LTotal.Text = "Total Orden:";
            this.LTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // TBTotal
            // 
            this.TBTotal.BackColor = System.Drawing.Color.White;
            this.TBTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.TBTotal.Location = new System.Drawing.Point(725, 340);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(180, 32);
            this.TBTotal.TabIndex = 3;
            this.TBTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BCancelar
            // 
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Location = new System.Drawing.Point(530, 610);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(190, 44);
            this.BCancelar.TabIndex = 4;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BGenerarOrden
            // 
            this.BGenerarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGenerarOrden.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarOrden.Location = new System.Drawing.Point(735, 610);
            this.BGenerarOrden.Name = "BGenerarOrden";
            this.BGenerarOrden.Size = new System.Drawing.Size(215, 44);
            this.BGenerarOrden.TabIndex = 5;
            this.BGenerarOrden.Text = "Generar Orden";
            this.BGenerarOrden.UseVisualStyleBackColor = true;
            this.BGenerarOrden.Click += new System.EventHandler(this.BGenerarOrden_Click);
            // 
            // FormOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1040, 710);
            this.Controls.Add(this.panelCard);
            this.MinimumSize = new System.Drawing.Size(1040, 710);
            this.Name = "FormOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Orden de Compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOrdenCompra_Load);
            this.Resize += new System.EventHandler(this.FormOrdenCompra_Resize);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleOrden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Button BSeleccionarProveedor;
        private System.Windows.Forms.Label LCUIT;
        private System.Windows.Forms.Label LRazonSocial;
        private System.Windows.Forms.TextBox TBRazonSocial;
        private System.Windows.Forms.TextBox TBCUIT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGDetalleOrden;
        private System.Windows.Forms.Button BAgregarProducto;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Button BGenerarOrden;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.TextBox TBContacto;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox TBTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Label LUsuario;
    }
}