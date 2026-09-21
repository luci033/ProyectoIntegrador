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
            this.panelCard = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LNroOrden = new System.Windows.Forms.Label();
            this.TBNroOrden = new System.Windows.Forms.TextBox();
            this.LProveedor = new System.Windows.Forms.Label();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.LFechaEmision = new System.Windows.Forms.Label();
            this.TBFechaEmision = new System.Windows.Forms.TextBox();
            this.LFechaRecepcion = new System.Windows.Forms.Label();
            this.TBFechaRecepcion = new System.Windows.Forms.TextBox();
            this.LObservacion = new System.Windows.Forms.Label();
            this.TBObservacion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGDetalleOrden = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTotalGeneral = new System.Windows.Forms.Label();
            this.TBTotalGeneral = new System.Windows.Forms.TextBox();
            this.BCerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panelCard.Controls.Add(this.BCerrar);
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
            this.LTitulo.Location = new System.Drawing.Point(25, 20);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(395, 31);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Detalle de Orden de Compra";
            this.LTitulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.LSubtitulo.Location = new System.Drawing.Point(25, 55);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(534, 17);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Consulta integral de productos pedidos, cantidades recibidas, costos unitarios y totales.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.LNroOrden);
            this.panel1.Controls.Add(this.TBNroOrden);
            this.panel1.Controls.Add(this.LProveedor);
            this.panel1.Controls.Add(this.TBProveedor);
            this.panel1.Controls.Add(this.LFechaEmision);
            this.panel1.Controls.Add(this.TBFechaEmision);
            this.panel1.Controls.Add(this.LFechaRecepcion);
            this.panel1.Controls.Add(this.TBFechaRecepcion);
            this.panel1.Controls.Add(this.LObservacion);
            this.panel1.Controls.Add(this.TBObservacion);
            this.panel1.Location = new System.Drawing.Point(25, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 130);
            this.panel1.TabIndex = 2;
            // 
            // LNroOrden
            // 
            this.LNroOrden.AutoSize = true;
            this.LNroOrden.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNroOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LNroOrden.Location = new System.Drawing.Point(20, 15);
            this.LNroOrden.Name = "LNroOrden";
            this.LNroOrden.Size = new System.Drawing.Size(73, 15);
            this.LNroOrden.TabIndex = 0;
            this.LNroOrden.Text = "Nro. Orden:";
            this.LNroOrden.Click += new System.EventHandler(this.label6_Click);
            // 
            // TBNroOrden
            // 
            this.TBNroOrden.BackColor = System.Drawing.Color.White;
            this.TBNroOrden.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBNroOrden.Location = new System.Drawing.Point(20, 35);
            this.TBNroOrden.Name = "TBNroOrden";
            this.TBNroOrden.ReadOnly = true;
            this.TBNroOrden.Size = new System.Drawing.Size(100, 24);
            this.TBNroOrden.TabIndex = 1;
            // 
            // LProveedor
            // 
            this.LProveedor.AutoSize = true;
            this.LProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LProveedor.Location = new System.Drawing.Point(140, 15);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(69, 15);
            this.LProveedor.TabIndex = 2;
            this.LProveedor.Text = "Proveedor:";
            // 
            // TBProveedor
            // 
            this.TBProveedor.BackColor = System.Drawing.Color.White;
            this.TBProveedor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBProveedor.Location = new System.Drawing.Point(140, 35);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.ReadOnly = true;
            this.TBProveedor.Size = new System.Drawing.Size(320, 24);
            this.TBProveedor.TabIndex = 3;
            // 
            // LFechaEmision
            // 
            this.LFechaEmision.AutoSize = true;
            this.LFechaEmision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaEmision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LFechaEmision.Location = new System.Drawing.Point(480, 15);
            this.LFechaEmision.Name = "LFechaEmision";
            this.LFechaEmision.Size = new System.Drawing.Size(89, 15);
            this.LFechaEmision.TabIndex = 4;
            this.LFechaEmision.Text = "Fecha Emisión:";
            // 
            // TBFechaEmision
            // 
            this.TBFechaEmision.BackColor = System.Drawing.Color.White;
            this.TBFechaEmision.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBFechaEmision.Location = new System.Drawing.Point(480, 35);
            this.TBFechaEmision.Name = "TBFechaEmision";
            this.TBFechaEmision.ReadOnly = true;
            this.TBFechaEmision.Size = new System.Drawing.Size(200, 24);
            this.TBFechaEmision.TabIndex = 5;
            // 
            // LFechaRecepcion
            // 
            this.LFechaRecepcion.AutoSize = true;
            this.LFechaRecepcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaRecepcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LFechaRecepcion.Location = new System.Drawing.Point(700, 15);
            this.LFechaRecepcion.Name = "LFechaRecepcion";
            this.LFechaRecepcion.Size = new System.Drawing.Size(107, 15);
            this.LFechaRecepcion.TabIndex = 6;
            this.LFechaRecepcion.Text = "Fecha Recepción:";
            // 
            // TBFechaRecepcion
            // 
            this.TBFechaRecepcion.BackColor = System.Drawing.Color.White;
            this.TBFechaRecepcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBFechaRecepcion.Location = new System.Drawing.Point(700, 35);
            this.TBFechaRecepcion.Name = "TBFechaRecepcion";
            this.TBFechaRecepcion.ReadOnly = true;
            this.TBFechaRecepcion.Size = new System.Drawing.Size(210, 24);
            this.TBFechaRecepcion.TabIndex = 7;
            // 
            // LObservacion
            // 
            this.LObservacion.AutoSize = true;
            this.LObservacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LObservacion.Location = new System.Drawing.Point(20, 68);
            this.LObservacion.Name = "LObservacion";
            this.LObservacion.Size = new System.Drawing.Size(79, 15);
            this.LObservacion.TabIndex = 8;
            this.LObservacion.Text = "Observación:";
            this.LObservacion.Click += new System.EventHandler(this.label5_Click);
            // 
            // TBObservacion
            // 
            this.TBObservacion.BackColor = System.Drawing.Color.White;
            this.TBObservacion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBObservacion.Location = new System.Drawing.Point(20, 88);
            this.TBObservacion.Name = "TBObservacion";
            this.TBObservacion.ReadOnly = true;
            this.TBObservacion.Size = new System.Drawing.Size(890, 24);
            this.TBObservacion.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.TBTotalGeneral);
            this.panel2.Controls.Add(this.DGDetalleOrden);
            this.panel2.Controls.Add(this.LTotalGeneral);
            this.panel2.Location = new System.Drawing.Point(25, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 365);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DGDetalleOrden
            // 
            this.DGDetalleOrden.AllowUserToAddRows = false;
            this.DGDetalleOrden.AllowUserToDeleteRows = false;
            this.DGDetalleOrden.AllowUserToResizeColumns = false;
            this.DGDetalleOrden.AllowUserToResizeRows = false;
            this.DGDetalleOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.DGDetalleOrden.Location = new System.Drawing.Point(15, 15);
            this.DGDetalleOrden.Name = "DGDetalleOrden";
            this.DGDetalleOrden.RowHeadersVisible = false;
            this.DGDetalleOrden.Size = new System.Drawing.Size(900, 295);
            this.DGDetalleOrden.TabIndex = 0;
            this.DGDetalleOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetalleOrden_CellContentClick);
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
            this.nombre.FillWeight = 110F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.FillWeight = 65F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colGenero
            // 
            this.colGenero.FillWeight = 55F;
            this.colGenero.HeaderText = "Género";
            this.colGenero.Name = "colGenero";
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 45F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // colCantidadRecibida
            // 
            this.colCantidadRecibida.FillWeight = 50F;
            this.colCantidadRecibida.HeaderText = "Cant. Recibida";
            this.colCantidadRecibida.Name = "colCantidadRecibida";
            // 
            // CostoUnitario
            // 
            dataGridViewCellStyle1.Format = "C2";
            this.CostoUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.CostoUnitario.FillWeight = 55F;
            this.CostoUnitario.HeaderText = "Costo Unit.";
            this.CostoUnitario.Name = "CostoUnitario";
            this.CostoUnitario.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle2.Format = "C2";
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.Subtotal.FillWeight = 60F;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // LTotalGeneral
            // 
            this.LTotalGeneral.AutoSize = true;
            this.LTotalGeneral.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LTotalGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTotalGeneral.Location = new System.Drawing.Point(580, 326);
            this.LTotalGeneral.Name = "LTotalGeneral";
            this.LTotalGeneral.Size = new System.Drawing.Size(107, 20);
            this.LTotalGeneral.TabIndex = 1;
            this.LTotalGeneral.Text = "Total General:";
            this.LTotalGeneral.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBTotalGeneral
            // 
            this.TBTotalGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.TBTotalGeneral.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.TBTotalGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.TBTotalGeneral.Location = new System.Drawing.Point(695, 321);
            this.TBTotalGeneral.Name = "TBTotalGeneral";
            this.TBTotalGeneral.ReadOnly = true;
            this.TBTotalGeneral.Size = new System.Drawing.Size(220, 31);
            this.TBTotalGeneral.TabIndex = 2;
            this.TBTotalGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BCerrar
            // 
            this.BCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BCerrar.Location = new System.Drawing.Point(755, 610);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(200, 44);
            this.BCerrar.TabIndex = 4;
            this.BCerrar.Text = "Cerrar";
            this.BCerrar.UseVisualStyleBackColor = true;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 5;
            this.panel3.Visible = false;
            // 
            // FormVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 720);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "FormVerDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Orden de Compra";
            this.Load += new System.EventHandler(this.FormVerDetalle_Load);
            this.Resize += new System.EventHandler(this.FormVerDetalle_Resize);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LSubtitulo;
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