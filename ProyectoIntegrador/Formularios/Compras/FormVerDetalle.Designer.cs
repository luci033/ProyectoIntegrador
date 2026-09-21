namespace ProyectoIntegrador.Formularios.Compras
{
    partial class FormVerDetalle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.LProveedor = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TBObservacion = new System.Windows.Forms.TextBox();
            this.TBFechaRecepcion = new System.Windows.Forms.TextBox();
            this.TBFechaEmision = new System.Windows.Forms.TextBox();
            this.LObservacion = new System.Windows.Forms.Label();
            this.LFechaRecepcion = new System.Windows.Forms.Label();
            this.LFechaEmision = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LNroOrden = new System.Windows.Forms.Label();
            this.BCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBTotalGeneral = new System.Windows.Forms.TextBox();
            this.DGDetalleOrden = new System.Windows.Forms.DataGridView();
            this.LTotalGeneral = new System.Windows.Forms.Label();
            this.TBNroOrden = new System.Windows.Forms.TextBox();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBProveedor);
            this.panel1.Controls.Add(this.LProveedor);
            this.panel1.Location = new System.Drawing.Point(17, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 78);
            this.panel1.TabIndex = 0;
            // 
            // TBProveedor
            // 
            this.TBProveedor.Location = new System.Drawing.Point(126, 35);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.ReadOnly = true;
            this.TBProveedor.Size = new System.Drawing.Size(239, 20);
            this.TBProveedor.TabIndex = 1;
            // 
            // LProveedor
            // 
            this.LProveedor.AutoSize = true;
            this.LProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LProveedor.Location = new System.Drawing.Point(25, 33);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(95, 20);
            this.LProveedor.TabIndex = 0;
            this.LProveedor.Text = "Proveedor:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TBObservacion);
            this.panel3.Controls.Add(this.TBFechaRecepcion);
            this.panel3.Controls.Add(this.TBFechaEmision);
            this.panel3.Controls.Add(this.LObservacion);
            this.panel3.Controls.Add(this.LFechaRecepcion);
            this.panel3.Controls.Add(this.LFechaEmision);
            this.panel3.Location = new System.Drawing.Point(17, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 89);
            this.panel3.TabIndex = 2;
            // 
            // TBObservacion
            // 
            this.TBObservacion.Location = new System.Drawing.Point(145, 49);
            this.TBObservacion.Name = "TBObservacion";
            this.TBObservacion.ReadOnly = true;
            this.TBObservacion.Size = new System.Drawing.Size(517, 20);
            this.TBObservacion.TabIndex = 5;
            // 
            // TBFechaRecepcion
            // 
            this.TBFechaRecepcion.Location = new System.Drawing.Point(539, 11);
            this.TBFechaRecepcion.Name = "TBFechaRecepcion";
            this.TBFechaRecepcion.ReadOnly = true;
            this.TBFechaRecepcion.Size = new System.Drawing.Size(123, 20);
            this.TBFechaRecepcion.TabIndex = 4;
            // 
            // TBFechaEmision
            // 
            this.TBFechaEmision.Location = new System.Drawing.Point(164, 11);
            this.TBFechaEmision.Name = "TBFechaEmision";
            this.TBFechaEmision.ReadOnly = true;
            this.TBFechaEmision.Size = new System.Drawing.Size(123, 20);
            this.TBFechaEmision.TabIndex = 2;
            // 
            // LObservacion
            // 
            this.LObservacion.AutoSize = true;
            this.LObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LObservacion.Location = new System.Drawing.Point(26, 49);
            this.LObservacion.Name = "LObservacion";
            this.LObservacion.Size = new System.Drawing.Size(113, 20);
            this.LObservacion.TabIndex = 3;
            this.LObservacion.Text = "Observación:";
            this.LObservacion.Click += new System.EventHandler(this.label5_Click);
            // 
            // LFechaRecepcion
            // 
            this.LFechaRecepcion.AutoSize = true;
            this.LFechaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LFechaRecepcion.Location = new System.Drawing.Point(379, 11);
            this.LFechaRecepcion.Name = "LFechaRecepcion";
            this.LFechaRecepcion.Size = new System.Drawing.Size(154, 20);
            this.LFechaRecepcion.TabIndex = 2;
            this.LFechaRecepcion.Text = "Fecha Recepción:";
            // 
            // LFechaEmision
            // 
            this.LFechaEmision.AutoSize = true;
            this.LFechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LFechaEmision.Location = new System.Drawing.Point(26, 11);
            this.LFechaEmision.Name = "LFechaEmision";
            this.LFechaEmision.Size = new System.Drawing.Size(132, 20);
            this.LFechaEmision.TabIndex = 1;
            this.LFechaEmision.Text = "Fecha Emisión:";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(12, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(157, 25);
            this.LTitulo.TabIndex = 1;
            this.LTitulo.Text = "Detalle Orden";
            this.LTitulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // LNroOrden
            // 
            this.LNroOrden.AutoSize = true;
            this.LNroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNroOrden.Location = new System.Drawing.Point(12, 50);
            this.LNroOrden.Name = "LNroOrden";
            this.LNroOrden.Size = new System.Drawing.Size(96, 20);
            this.LNroOrden.TabIndex = 3;
            this.LNroOrden.Text = "Nro Orden:";
            this.LNroOrden.Click += new System.EventHandler(this.label6_Click);
            // 
            // BCerrar
            // 
            this.BCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BCerrar.Location = new System.Drawing.Point(665, 515);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(124, 33);
            this.BCerrar.TabIndex = 4;
            this.BCerrar.Text = "Cerrar";
            this.BCerrar.UseVisualStyleBackColor = true;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TBTotalGeneral);
            this.panel2.Controls.Add(this.DGDetalleOrden);
            this.panel2.Controls.Add(this.LTotalGeneral);
            this.panel2.Location = new System.Drawing.Point(17, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 222);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TBTotalGeneral
            // 
            this.TBTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotalGeneral.Location = new System.Drawing.Point(583, 188);
            this.TBTotalGeneral.Multiline = true;
            this.TBTotalGeneral.Name = "TBTotalGeneral";
            this.TBTotalGeneral.ReadOnly = true;
            this.TBTotalGeneral.Size = new System.Drawing.Size(185, 31);
            this.TBTotalGeneral.TabIndex = 14;
            this.TBTotalGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.colCantidadRecibida,
            this.CostoUnitario,
            this.Subtotal});
            this.DGDetalleOrden.GridColor = System.Drawing.Color.Silver;
            this.DGDetalleOrden.Location = new System.Drawing.Point(0, 3);
            this.DGDetalleOrden.MaximumSize = new System.Drawing.Size(768, 183);
            this.DGDetalleOrden.MinimumSize = new System.Drawing.Size(768, 183);
            this.DGDetalleOrden.Name = "DGDetalleOrden";
            this.DGDetalleOrden.RowHeadersVisible = false;
            this.DGDetalleOrden.Size = new System.Drawing.Size(768, 183);
            this.DGDetalleOrden.TabIndex = 9;
            this.DGDetalleOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetalleOrden_CellContentClick);
            // 
            // LTotalGeneral
            // 
            this.LTotalGeneral.AutoSize = true;
            this.LTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LTotalGeneral.Location = new System.Drawing.Point(454, 193);
            this.LTotalGeneral.Name = "LTotalGeneral";
            this.LTotalGeneral.Size = new System.Drawing.Size(123, 20);
            this.LTotalGeneral.TabIndex = 6;
            this.LTotalGeneral.Text = "Total General:";
            this.LTotalGeneral.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBNroOrden
            // 
            this.TBNroOrden.Location = new System.Drawing.Point(114, 50);
            this.TBNroOrden.Name = "TBNroOrden";
            this.TBNroOrden.ReadOnly = true;
            this.TBNroOrden.Size = new System.Drawing.Size(88, 20);
            this.TBNroOrden.TabIndex = 2;
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
            this.cantidad.ReadOnly = true;
            // 
            // colCantidadRecibida
            // 
            this.colCantidadRecibida.FillWeight = 34.85054F;
            this.colCantidadRecibida.HeaderText = "Cantidad Recibida";
            this.colCantidadRecibida.Name = "colCantidadRecibida";
            // 
            // CostoUnitario
            // 
            dataGridViewCellStyle1.Format = "C2";
            this.CostoUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.CostoUnitario.FillWeight = 55F;
            this.CostoUnitario.HeaderText = "Costo Unitario";
            this.CostoUnitario.Name = "CostoUnitario";
            this.CostoUnitario.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle2.Format = "C2";
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.Subtotal.FillWeight = 58.08423F;
            this.Subtotal.HeaderText = "Subtotal ";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // FormVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.TBNroOrden);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BCerrar);
            this.Controls.Add(this.LNroOrden);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(816, 588);
            this.MinimumSize = new System.Drawing.Size(816, 588);
            this.Name = "FormVerDetalle";
            this.Text = "Detalle Orden";
            this.Load += new System.EventHandler(this.FormVerDetalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LObservacion;
        private System.Windows.Forms.Label LFechaRecepcion;
        private System.Windows.Forms.Label LFechaEmision;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LNroOrden;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.TextBox TBProveedor;
        private System.Windows.Forms.TextBox TBObservacion;
        private System.Windows.Forms.TextBox TBFechaRecepcion;
        private System.Windows.Forms.TextBox TBFechaEmision;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LTotalGeneral;
        private System.Windows.Forms.DataGridView DGDetalleOrden;
        private System.Windows.Forms.TextBox TBTotalGeneral;
        private System.Windows.Forms.TextBox TBNroOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadRecibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}