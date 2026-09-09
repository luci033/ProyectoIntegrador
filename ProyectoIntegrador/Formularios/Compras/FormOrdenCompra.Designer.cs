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
            this.BSeleccionarProveedor = new System.Windows.Forms.Button();
            this.LCUIT = new System.Windows.Forms.Label();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LDatosProveedor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BAgregarProducto = new System.Windows.Forms.Button();
            this.DGDetalleOrden = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTotal = new System.Windows.Forms.Label();
            this.LDetalleOrden = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.BSeleccionarProveedor.Name = "BSeleccionarProveedor";
            this.BSeleccionarProveedor.Size = new System.Drawing.Size(135, 43);
            this.BSeleccionarProveedor.TabIndex = 0;
            this.BSeleccionarProveedor.Text = "Seleccionar Proveedor";
            this.BSeleccionarProveedor.UseVisualStyleBackColor = true;
            this.BSeleccionarProveedor.Click += new System.EventHandler(this.button1_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.LFecha);
            this.panel1.Controls.Add(this.LDatosProveedor);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.LRazonSocial);
            this.panel1.Controls.Add(this.BSeleccionarProveedor);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.LCUIT);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 106);
            this.panel1.TabIndex = 6;
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
            this.panel2.Controls.Add(this.LDetalleOrden);
            this.panel2.Controls.Add(this.LTotal);
            this.panel2.Controls.Add(this.BAgregarProducto);
            this.panel2.Controls.Add(this.DGDetalleOrden);
            this.panel2.Location = new System.Drawing.Point(12, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 290);
            this.panel2.TabIndex = 7;
            // 
            // BAgregarProducto
            // 
            this.BAgregarProducto.Location = new System.Drawing.Point(37, 26);
            this.BAgregarProducto.Name = "BAgregarProducto";
            this.BAgregarProducto.Size = new System.Drawing.Size(135, 43);
            this.BAgregarProducto.TabIndex = 7;
            this.BAgregarProducto.Text = "Agregar Producto";
            this.BAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // DGDetalleOrden
            // 
            this.DGDetalleOrden.AllowUserToResizeColumns = false;
            this.DGDetalleOrden.AllowUserToResizeRows = false;
            this.DGDetalleOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalleOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.nombre,
            this.cantidad,
            this.CostoUnitario,
            this.Subtotal});
            this.DGDetalleOrden.Location = new System.Drawing.Point(3, 75);
            this.DGDetalleOrden.Name = "DGDetalleOrden";
            this.DGDetalleOrden.RowHeadersVisible = false;
            this.DGDetalleOrden.Size = new System.Drawing.Size(770, 191);
            this.DGDetalleOrden.TabIndex = 8;
            // 
            // idDetalle
            // 
            this.idDetalle.FillWeight = 20F;
            this.idDetalle.HeaderText = "Nro.";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 60F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 30F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // CostoUnitario
            // 
            this.CostoUnitario.FillWeight = 50F;
            this.CostoUnitario.HeaderText = "Costo Unitario";
            this.CostoUnitario.Name = "CostoUnitario";
            this.CostoUnitario.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.FillWeight = 50F;
            this.Subtotal.HeaderText = "Subtotal ";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.Location = new System.Drawing.Point(537, 269);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(45, 18);
            this.LTotal.TabIndex = 7;
            this.LTotal.Text = "Total:";
            this.LTotal.Click += new System.EventHandler(this.label3_Click);
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
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(516, 43);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(40, 13);
            this.LFecha.TabIndex = 7;
            this.LFecha.Text = "Fecha:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(562, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 8;
            // 
            // BGenerarOrden
            // 
            this.BGenerarOrden.Location = new System.Drawing.Point(650, 420);
            this.BGenerarOrden.Name = "BGenerarOrden";
            this.BGenerarOrden.Size = new System.Drawing.Size(135, 43);
            this.BGenerarOrden.TabIndex = 9;
            this.BGenerarOrden.Text = "Generar Orden";
            this.BGenerarOrden.UseVisualStyleBackColor = true;
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(509, 420);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(135, 43);
            this.BCancelar.TabIndex = 10;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
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
            this.Name = "FormOrdenCompra";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LDatosProveedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGDetalleOrden;
        private System.Windows.Forms.Button BAgregarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label LDetalleOrden;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Button BGenerarOrden;
        private System.Windows.Forms.Button BCancelar;
    }
}