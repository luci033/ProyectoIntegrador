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
            this.panelCard = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LNroOrden = new System.Windows.Forms.Label();
            this.TBNroOrden = new System.Windows.Forms.TextBox();
            this.LProveedor = new System.Windows.Forms.Label();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.LFechaOrden = new System.Windows.Forms.Label();
            this.TBFechaOrden = new System.Windows.Forms.TextBox();
            this.LFechaRecepcion = new System.Windows.Forms.Label();
            this.TBFechaRecepcion = new System.Windows.Forms.TextBox();
            this.LObservacion = new System.Windows.Forms.Label();
            this.TBObservacion = new System.Windows.Forms.TextBox();
            this.DGDetalleRecepcion = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadPedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadRecibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BAceptar = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleRecepcion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LSubtitulo);
            this.panelCard.Controls.Add(this.panel1);
            this.panelCard.Controls.Add(this.DGDetalleRecepcion);
            this.panelCard.Controls.Add(this.BCancelar);
            this.panelCard.Controls.Add(this.BAceptar);
            this.panelCard.Location = new System.Drawing.Point(30, 20);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(960, 640);
            this.panelCard.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(25, 20);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(288, 31);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Registrar Recepción";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.LSubtitulo.Location = new System.Drawing.Point(25, 55);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(465, 17);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Verifique las cantidades recibidas de cada producto y consigne observaciones pertinentes.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
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
            this.panel1.Location = new System.Drawing.Point(25, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 130);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // 
            // TBNroOrden
            // 
            this.TBNroOrden.BackColor = System.Drawing.Color.White;
            this.TBNroOrden.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBNroOrden.Location = new System.Drawing.Point(20, 35);
            this.TBNroOrden.Name = "TBNroOrden";
            this.TBNroOrden.ReadOnly = true;
            this.TBNroOrden.Size = new System.Drawing.Size(110, 24);
            this.TBNroOrden.TabIndex = 1;
            this.TBNroOrden.TextChanged += new System.EventHandler(this.TBNroOrden_TextChanged);
            // 
            // LProveedor
            // 
            this.LProveedor.AutoSize = true;
            this.LProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LProveedor.Location = new System.Drawing.Point(150, 15);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(69, 15);
            this.LProveedor.TabIndex = 2;
            this.LProveedor.Text = "Proveedor:";
            // 
            // TBProveedor
            // 
            this.TBProveedor.BackColor = System.Drawing.Color.White;
            this.TBProveedor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBProveedor.Location = new System.Drawing.Point(150, 35);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.ReadOnly = true;
            this.TBProveedor.Size = new System.Drawing.Size(320, 24);
            this.TBProveedor.TabIndex = 3;
            this.TBProveedor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LFechaOrden
            // 
            this.LFechaOrden.AutoSize = true;
            this.LFechaOrden.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LFechaOrden.Location = new System.Drawing.Point(490, 15);
            this.LFechaOrden.Name = "LFechaOrden";
            this.LFechaOrden.Size = new System.Drawing.Size(81, 15);
            this.LFechaOrden.TabIndex = 4;
            this.LFechaOrden.Text = "Fecha Orden:";
            // 
            // TBFechaOrden
            // 
            this.TBFechaOrden.BackColor = System.Drawing.Color.White;
            this.TBFechaOrden.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBFechaOrden.Location = new System.Drawing.Point(490, 35);
            this.TBFechaOrden.Name = "TBFechaOrden";
            this.TBFechaOrden.ReadOnly = true;
            this.TBFechaOrden.Size = new System.Drawing.Size(180, 24);
            this.TBFechaOrden.TabIndex = 5;
            this.TBFechaOrden.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LFechaRecepcion
            // 
            this.LFechaRecepcion.AutoSize = true;
            this.LFechaRecepcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaRecepcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LFechaRecepcion.Location = new System.Drawing.Point(690, 15);
            this.LFechaRecepcion.Name = "LFechaRecepcion";
            this.LFechaRecepcion.Size = new System.Drawing.Size(107, 15);
            this.LFechaRecepcion.TabIndex = 6;
            this.LFechaRecepcion.Text = "Fecha Recepción:";
            this.LFechaRecepcion.Click += new System.EventHandler(this.LFecha_Click);
            // 
            // TBFechaRecepcion
            // 
            this.TBFechaRecepcion.BackColor = System.Drawing.Color.White;
            this.TBFechaRecepcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBFechaRecepcion.Location = new System.Drawing.Point(690, 35);
            this.TBFechaRecepcion.Name = "TBFechaRecepcion";
            this.TBFechaRecepcion.ReadOnly = true;
            this.TBFechaRecepcion.Size = new System.Drawing.Size(195, 24);
            this.TBFechaRecepcion.TabIndex = 7;
            this.TBFechaRecepcion.TextChanged += new System.EventHandler(this.TBFechaRecepcion_TextChanged);
            // 
            // LObservacion
            // 
            this.LObservacion.AutoSize = true;
            this.LObservacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LObservacion.Location = new System.Drawing.Point(20, 68);
            this.LObservacion.Name = "LObservacion";
            this.LObservacion.Size = new System.Drawing.Size(155, 15);
            this.LObservacion.TabIndex = 8;
            this.LObservacion.Text = "Observaciones de Entrega:";
            // 
            // TBObservacion
            // 
            this.TBObservacion.BackColor = System.Drawing.Color.White;
            this.TBObservacion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBObservacion.Location = new System.Drawing.Point(20, 88);
            this.TBObservacion.Name = "TBObservacion";
            this.TBObservacion.Size = new System.Drawing.Size(865, 24);
            this.TBObservacion.TabIndex = 9;
            this.TBObservacion.TextChanged += new System.EventHandler(this.TBObservacion_TextChanged);
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
            this.DGDetalleRecepcion.Location = new System.Drawing.Point(25, 230);
            this.DGDetalleRecepcion.Name = "DGDetalleRecepcion";
            this.DGDetalleRecepcion.RowHeadersVisible = false;
            this.DGDetalleRecepcion.Size = new System.Drawing.Size(910, 335);
            this.DGDetalleRecepcion.TabIndex = 3;
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
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 120F;
            this.colNombre.HeaderText = "Producto";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colCantidadPedida
            // 
            this.colCantidadPedida.FillWeight = 55F;
            this.colCantidadPedida.HeaderText = "Cant. Pedida";
            this.colCantidadPedida.Name = "colCantidadPedida";
            // 
            // colCantidadRecibida
            // 
            this.colCantidadRecibida.FillWeight = 55F;
            this.colCantidadRecibida.HeaderText = "Cant. Recibida";
            this.colCantidadRecibida.Name = "colCantidadRecibida";
            // 
            // BCancelar
            // 
            this.BCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BCancelar.Location = new System.Drawing.Point(545, 580);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(180, 44);
            this.BCancelar.TabIndex = 4;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BAceptar
            // 
            this.BAceptar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BAceptar.Location = new System.Drawing.Point(745, 580);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(190, 44);
            this.BAceptar.TabIndex = 5;
            this.BAceptar.Text = "Confirmar Recepción";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // FormRegistrarRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 690);
            this.Controls.Add(this.panelCard);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormRegistrarRecepcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Recepción";
            this.Load += new System.EventHandler(this.FormRegistrarRecepcion_Load);
            this.Resize += new System.EventHandler(this.FormRegistrarRecepcion_Resize);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleRecepcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
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