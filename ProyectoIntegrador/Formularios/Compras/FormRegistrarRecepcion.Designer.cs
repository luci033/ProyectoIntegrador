namespace ProyectoIntegrador.Formularios.Compras
{
    partial class FormRegistrarRecepcion
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
            this.LTitulo = new System.Windows.Forms.Label();
            this.LFechaRecepcion = new System.Windows.Forms.Label();
            this.TBFechaRecepcion = new System.Windows.Forms.TextBox();
            this.TBObservacion = new System.Windows.Forms.TextBox();
            this.LObservacion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBFechaOrden = new System.Windows.Forms.TextBox();
            this.LFechaOrden = new System.Windows.Forms.Label();
            this.TBNroOrden = new System.Windows.Forms.TextBox();
            this.LNroOrden = new System.Windows.Forms.Label();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.LProveedor = new System.Windows.Forms.Label();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.DGDetalleRecepcion = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadPedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleRecepcion)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(179, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(479, 55);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Registrar Recepción";
            // 
            // LFechaRecepcion
            // 
            this.LFechaRecepcion.AutoSize = true;
            this.LFechaRecepcion.Location = new System.Drawing.Point(262, 16);
            this.LFechaRecepcion.Name = "LFechaRecepcion";
            this.LFechaRecepcion.Size = new System.Drawing.Size(95, 13);
            this.LFechaRecepcion.TabIndex = 1;
            this.LFechaRecepcion.Text = "Fecha Recepción:";
            this.LFechaRecepcion.Click += new System.EventHandler(this.LFecha_Click);
            // 
            // TBFechaRecepcion
            // 
            this.TBFechaRecepcion.Location = new System.Drawing.Point(363, 13);
            this.TBFechaRecepcion.Name = "TBFechaRecepcion";
            this.TBFechaRecepcion.ReadOnly = true;
            this.TBFechaRecepcion.Size = new System.Drawing.Size(102, 20);
            this.TBFechaRecepcion.TabIndex = 2;
            this.TBFechaRecepcion.TextChanged += new System.EventHandler(this.TBFechaRecepcion_TextChanged);
            // 
            // TBObservacion
            // 
            this.TBObservacion.Location = new System.Drawing.Point(559, 16);
            this.TBObservacion.Multiline = true;
            this.TBObservacion.Name = "TBObservacion";
            this.TBObservacion.Size = new System.Drawing.Size(214, 80);
            this.TBObservacion.TabIndex = 3;
            this.TBObservacion.TextChanged += new System.EventHandler(this.TBObservacion_TextChanged);
            // 
            // LObservacion
            // 
            this.LObservacion.AutoSize = true;
            this.LObservacion.Location = new System.Drawing.Point(491, 16);
            this.LObservacion.Name = "LObservacion";
            this.LObservacion.Size = new System.Drawing.Size(70, 13);
            this.LObservacion.TabIndex = 4;
            this.LObservacion.Text = "Observación:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBFechaOrden);
            this.panel1.Controls.Add(this.LFechaOrden);
            this.panel1.Controls.Add(this.TBNroOrden);
            this.panel1.Controls.Add(this.LNroOrden);
            this.panel1.Controls.Add(this.TBObservacion);
            this.panel1.Controls.Add(this.TBProveedor);
            this.panel1.Controls.Add(this.LProveedor);
            this.panel1.Controls.Add(this.TBFechaRecepcion);
            this.panel1.Controls.Add(this.LFechaRecepcion);
            this.panel1.Controls.Add(this.LObservacion);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 118);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TBFechaOrden
            // 
            this.TBFechaOrden.Location = new System.Drawing.Point(97, 86);
            this.TBFechaOrden.Name = "TBFechaOrden";
            this.TBFechaOrden.ReadOnly = true;
            this.TBFechaOrden.Size = new System.Drawing.Size(102, 20);
            this.TBFechaOrden.TabIndex = 10;
            this.TBFechaOrden.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LFechaOrden
            // 
            this.LFechaOrden.AutoSize = true;
            this.LFechaOrden.Location = new System.Drawing.Point(20, 89);
            this.LFechaOrden.Name = "LFechaOrden";
            this.LFechaOrden.Size = new System.Drawing.Size(72, 13);
            this.LFechaOrden.TabIndex = 9;
            this.LFechaOrden.Text = "Fecha Orden:";
            // 
            // TBNroOrden
            // 
            this.TBNroOrden.Location = new System.Drawing.Point(97, 13);
            this.TBNroOrden.Name = "TBNroOrden";
            this.TBNroOrden.ReadOnly = true;
            this.TBNroOrden.Size = new System.Drawing.Size(102, 20);
            this.TBNroOrden.TabIndex = 8;
            this.TBNroOrden.TextChanged += new System.EventHandler(this.TBNroOrden_TextChanged);
            // 
            // LNroOrden
            // 
            this.LNroOrden.AutoSize = true;
            this.LNroOrden.Location = new System.Drawing.Point(20, 16);
            this.LNroOrden.Name = "LNroOrden";
            this.LNroOrden.Size = new System.Drawing.Size(62, 13);
            this.LNroOrden.TabIndex = 7;
            this.LNroOrden.Text = "Nro. Orden:";
            // 
            // TBProveedor
            // 
            this.TBProveedor.Location = new System.Drawing.Point(97, 51);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.ReadOnly = true;
            this.TBProveedor.Size = new System.Drawing.Size(102, 20);
            this.TBProveedor.TabIndex = 6;
            this.TBProveedor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LProveedor
            // 
            this.LProveedor.AutoSize = true;
            this.LProveedor.Location = new System.Drawing.Point(20, 54);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(59, 13);
            this.LProveedor.TabIndex = 5;
            this.LProveedor.Text = "Proveedor:";
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(638, 415);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(150, 27);
            this.BAceptar.TabIndex = 7;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(482, 415);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(150, 27);
            this.BCancelar.TabIndex = 8;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // DGDetalleRecepcion
            // 
            this.DGDetalleRecepcion.AllowUserToAddRows = false;
            this.DGDetalleRecepcion.AllowUserToDeleteRows = false;
            this.DGDetalleRecepcion.AllowUserToResizeColumns = false;
            this.DGDetalleRecepcion.AllowUserToResizeRows = false;
            this.DGDetalleRecepcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGDetalleRecepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalleRecepcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colCodigo,
            this.colNombre,
            this.colCantidadPedida,
            this.colCantidadRecibida});
            this.DGDetalleRecepcion.Location = new System.Drawing.Point(12, 191);
            this.DGDetalleRecepcion.Name = "DGDetalleRecepcion";
            this.DGDetalleRecepcion.RowHeadersVisible = false;
            this.DGDetalleRecepcion.Size = new System.Drawing.Size(776, 218);
            this.DGDetalleRecepcion.TabIndex = 9;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "Id Producto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Visible = false;
            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 40F;
            this.colCodigo.HeaderText = "Cód.";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colCantidadPedida
            // 
            this.colCantidadPedida.FillWeight = 50F;
            this.colCantidadPedida.HeaderText = "Cantidad Pedida";
            this.colCantidadPedida.Name = "colCantidadPedida";
            this.colCantidadPedida.ReadOnly = true;
            // 
            // colCantidadRecibida
            // 
            this.colCantidadRecibida.FillWeight = 50F;
            this.colCantidadRecibida.HeaderText = "Cantidad Recibida";
            this.colCantidadRecibida.Name = "colCantidadRecibida";
            // 
            // FormRegistrarRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGDetalleRecepcion);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LTitulo);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormRegistrarRecepcion";
            this.Text = "RegistrarRecepcion";
            this.Load += new System.EventHandler(this.FormRegistrarRecepcion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleRecepcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LFechaRecepcion;
        private System.Windows.Forms.TextBox TBFechaRecepcion;
        private System.Windows.Forms.TextBox TBObservacion;
        private System.Windows.Forms.Label LObservacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.TextBox TBProveedor;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.TextBox TBNroOrden;
        private System.Windows.Forms.Label LNroOrden;
        private System.Windows.Forms.TextBox TBFechaOrden;
        private System.Windows.Forms.Label LFechaOrden;
        private System.Windows.Forms.DataGridView DGDetalleRecepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadPedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadRecibida;
    }
}