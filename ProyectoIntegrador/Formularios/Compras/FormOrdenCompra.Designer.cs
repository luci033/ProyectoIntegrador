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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BSeleccionarProveedor = new System.Windows.Forms.Button();
            this.LCUIT = new System.Windows.Forms.Label();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.TBRazonSocial = new System.Windows.Forms.TextBox();
            this.TBCUIT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TBContacto = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.LDatosProveedor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.LDetalleOrden = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
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
            this.BGenerarOrden = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // BSeleccionarProveedor
            // 
            this.BSeleccionarProveedor.Location = new System.Drawing.Point(37, 43);
            this.BSeleccionarProveedor.MaximumSize = new System.Drawing.Size(135, 43);
            this.BSeleccionarProveedor.MinimumSize = new System.Drawing.Size(135, 43);
            this.BSeleccionarProveedor.Name = "BSeleccionarProveedor";
            this.BSeleccionarProveedor.Size = new System.Drawing.Size(135, 43);
            this.BSeleccionarProveedor.TabIndex = 0;
            this.BSeleccionarProveedor.Text = "Seleccionar Proveedor";
            this.BSeleccionarProveedor.UseVisualStyleBackColor = true;
            this.BSeleccionarProveedor.Click += new System.EventHandler(this.BSeleccionarProveedor_Click);
            // 
            // LCUIT
            // 
            this.LCUIT.AutoSize = true;
            this.LCUIT.Location = new System.Drawing.Point(243, 80);
            this.LCUIT.Name = "LCUIT";
            this.LCUIT.Size = new System.Drawing.Size(35, 13);
            this.LCUIT.TabIndex = 1;
            this.LCUIT.Text = "CUIT:";
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Location = new System.Drawing.Point(243, 43);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.LRazonSocial.TabIndex = 2;
            this.LRazonSocial.Text = "Razón Social:";
            // 
            // TBRazonSocial
            // 
            this.TBRazonSocial.Location = new System.Drawing.Point(319, 40);
            this.TBRazonSocial.Name = "TBRazonSocial";
            this.TBRazonSocial.ReadOnly = true;
            this.TBRazonSocial.Size = new System.Drawing.Size(145, 20);
            this.TBRazonSocial.TabIndex = 3;
            this.TBRazonSocial.TextChanged += new System.EventHandler(this.label3_Click);
            // 
            // TBCUIT
            // 
            this.TBCUIT.Location = new System.Drawing.Point(319, 77);
            this.TBCUIT.Name = "TBCUIT";
            this.TBCUIT.ReadOnly = true;
            this.TBCUIT.Size = new System.Drawing.Size(145, 20);
            this.TBCUIT.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBCorreo);
            this.panel1.Controls.Add(this.LCorreo);
            this.panel1.Controls.Add(this.TBContacto);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.TBFecha);
            this.panel1.Controls.Add(this.LFecha);
            this.panel1.Controls.Add(this.LDatosProveedor);
            this.panel1.Controls.Add(this.TBCUIT);
            this.panel1.Controls.Add(this.LRazonSocial);
            this.panel1.Controls.Add(this.BSeleccionarProveedor);
            this.panel1.Controls.Add(this.TBRazonSocial);
            this.panel1.Controls.Add(this.LCUIT);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 106);
            this.panel1.TabIndex = 6;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(572, 77);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.ReadOnly = true;
            this.TBCorreo.Size = new System.Drawing.Size(145, 20);
            this.TBCorreo.TabIndex = 12;
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Location = new System.Drawing.Point(513, 80);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(41, 13);
            this.LCorreo.TabIndex = 11;
            this.LCorreo.Text = "Correo:";
            // 
            // TBContacto
            // 
            this.TBContacto.Location = new System.Drawing.Point(572, 40);
            this.TBContacto.Name = "TBContacto";
            this.TBContacto.ReadOnly = true;
            this.TBContacto.Size = new System.Drawing.Size(145, 20);
            this.TBContacto.TabIndex = 10;
            this.TBContacto.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(513, 43);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(52, 13);
            this.LTelefono.TabIndex = 9;
            this.LTelefono.Text = "Telefono:";
            this.LTelefono.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // TBFecha
            // 
            this.TBFecha.Location = new System.Drawing.Point(628, 6);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(145, 20);
            this.TBFecha.TabIndex = 8;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(569, 9);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(40, 13);
            this.LFecha.TabIndex = 7;
            this.LFecha.Text = "Fecha:";
            // 
            // LDatosProveedor
            // 
            this.LDatosProveedor.AutoSize = true;
            this.LDatosProveedor.Location = new System.Drawing.Point(3, 9);
            this.LDatosProveedor.Name = "LDatosProveedor";
            this.LDatosProveedor.Size = new System.Drawing.Size(87, 13);
            this.LDatosProveedor.TabIndex = 6;
            this.LDatosProveedor.Text = "Datos Proveedor";
            this.LDatosProveedor.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TBTotal);
            this.panel2.Controls.Add(this.LDetalleOrden);
            this.panel2.Controls.Add(this.LTotal);
            this.panel2.Controls.Add(this.BAgregarProducto);
            this.panel2.Controls.Add(this.DGDetalleOrden);
            this.panel2.Location = new System.Drawing.Point(12, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 301);
            this.panel2.TabIndex = 7;
            // 
            // TBTotal
            // 
            this.TBTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotal.Location = new System.Drawing.Point(588, 267);
            this.TBTotal.Multiline = true;
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(185, 31);
            this.TBTotal.TabIndex = 13;
            this.TBTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LDetalleOrden
            // 
            this.LDetalleOrden.AutoSize = true;
            this.LDetalleOrden.Location = new System.Drawing.Point(3, 10);
            this.LDetalleOrden.Name = "LDetalleOrden";
            this.LDetalleOrden.Size = new System.Drawing.Size(72, 13);
            this.LDetalleOrden.TabIndex = 7;
            this.LDetalleOrden.Text = "Detalle Orden";
            this.LDetalleOrden.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.Location = new System.Drawing.Point(537, 274);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(45, 18);
            this.LTotal.TabIndex = 7;
            this.LTotal.Text = "Total:";
            this.LTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // BAgregarProducto
            // 
            this.BAgregarProducto.Location = new System.Drawing.Point(37, 26);
            this.BAgregarProducto.Name = "BAgregarProducto";
            this.BAgregarProducto.Size = new System.Drawing.Size(135, 43);
            this.BAgregarProducto.TabIndex = 7;
            this.BAgregarProducto.Text = "Agregar Producto";
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
            this.DGDetalleOrden.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.DGDetalleOrden.Location = new System.Drawing.Point(3, 75);
            this.DGDetalleOrden.Name = "DGDetalleOrden";
            this.DGDetalleOrden.RowHeadersVisible = false;
            this.DGDetalleOrden.Size = new System.Drawing.Size(770, 191);
            this.DGDetalleOrden.TabIndex = 8;
            this.DGDetalleOrden.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetalleOrden_CellValueChanged);
            this.DGDetalleOrden.CurrentCellDirtyStateChanged += new System.EventHandler(this.DGDetalleOrden_CurrentCellDirtyStateChanged);
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "Id Producto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = false;
            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 23.23369F;
            this.colCodigo.HeaderText = "Cod.";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 69.70107F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.FillWeight = 69.70107F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colGenero
            // 
            this.colGenero.FillWeight = 56.34518F;
            this.colGenero.HeaderText = "Género";
            this.colGenero.Name = "colGenero";
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 34.85054F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // CostoUnitario
            // 
            dataGridViewCellStyle15.Format = "C2";
            this.CostoUnitario.DefaultCellStyle = dataGridViewCellStyle15;
            this.CostoUnitario.FillWeight = 55F;
            this.CostoUnitario.HeaderText = "Costo Unitario";
            this.CostoUnitario.Name = "CostoUnitario";
            this.CostoUnitario.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle16.Format = "C2";
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle16;
            this.Subtotal.FillWeight = 58.08423F;
            this.Subtotal.HeaderText = "Subtotal ";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // BGenerarOrden
            // 
            this.BGenerarOrden.Location = new System.Drawing.Point(650, 431);
            this.BGenerarOrden.Name = "BGenerarOrden";
            this.BGenerarOrden.Size = new System.Drawing.Size(135, 32);
            this.BGenerarOrden.TabIndex = 9;
            this.BGenerarOrden.Text = "Generar Orden";
            this.BGenerarOrden.UseVisualStyleBackColor = true;
            this.BGenerarOrden.Click += new System.EventHandler(this.BGenerarOrden_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(509, 431);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(135, 32);
            this.BCancelar.TabIndex = 10;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // FormOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BGenerarOrden);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(816, 516);
            this.MinimumSize = new System.Drawing.Size(816, 516);
            this.Name = "FormOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Orden de Compra";
            this.Load += new System.EventHandler(this.FormOrdenCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleOrden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BSeleccionarProveedor;
        private System.Windows.Forms.Label LCUIT;
        private System.Windows.Forms.Label LRazonSocial;
        private System.Windows.Forms.TextBox TBRazonSocial;
        private System.Windows.Forms.TextBox TBCUIT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LDatosProveedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGDetalleOrden;
        private System.Windows.Forms.Button BAgregarProducto;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label LDetalleOrden;
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
    }
}