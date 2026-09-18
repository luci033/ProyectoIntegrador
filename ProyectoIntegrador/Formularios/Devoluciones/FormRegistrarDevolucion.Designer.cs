namespace ProyectoIntegrador.Formularios.Devoluciones
{
    partial class FormRegistrarDevolucion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BBuscarVenta = new System.Windows.Forms.Button();
            this.LFecha = new System.Windows.Forms.Label();
            this.LCliente = new System.Windows.Forms.Label();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.TBCliente = new System.Windows.Forms.TextBox();
            this.LNroVenta = new System.Windows.Forms.Label();
            this.TBNroVenta = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGDetalleVenta = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantComprada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotivo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BRegistrarDevolucion = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BBuscarVenta);
            this.panel1.Controls.Add(this.LFecha);
            this.panel1.Controls.Add(this.LCliente);
            this.panel1.Controls.Add(this.TBFecha);
            this.panel1.Controls.Add(this.TBCliente);
            this.panel1.Controls.Add(this.LNroVenta);
            this.panel1.Controls.Add(this.TBNroVenta);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 165);
            this.panel1.TabIndex = 0;
            // 
            // BBuscarVenta
            // 
            this.BBuscarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarVenta.Location = new System.Drawing.Point(467, 62);
            this.BBuscarVenta.Name = "BBuscarVenta";
            this.BBuscarVenta.Size = new System.Drawing.Size(210, 36);
            this.BBuscarVenta.TabIndex = 7;
            this.BBuscarVenta.Text = "Buscar Venta";
            this.BBuscarVenta.UseVisualStyleBackColor = true;
            this.BBuscarVenta.Click += new System.EventHandler(this.BBuscarVenta_Click);
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(40, 120);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(40, 13);
            this.LFecha.TabIndex = 6;
            this.LFecha.Text = "Fecha:";
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Location = new System.Drawing.Point(38, 77);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(42, 13);
            this.LCliente.TabIndex = 5;
            this.LCliente.Text = "Cliente:";
            // 
            // TBFecha
            // 
            this.TBFecha.Location = new System.Drawing.Point(102, 117);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(105, 20);
            this.TBFecha.TabIndex = 4;
            // 
            // TBCliente
            // 
            this.TBCliente.Location = new System.Drawing.Point(102, 74);
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.ReadOnly = true;
            this.TBCliente.Size = new System.Drawing.Size(188, 20);
            this.TBCliente.TabIndex = 3;
            // 
            // LNroVenta
            // 
            this.LNroVenta.AutoSize = true;
            this.LNroVenta.Location = new System.Drawing.Point(38, 33);
            this.LNroVenta.Name = "LNroVenta";
            this.LNroVenta.Size = new System.Drawing.Size(61, 13);
            this.LNroVenta.TabIndex = 1;
            this.LNroVenta.Text = "Nro. Venta:";
            // 
            // TBNroVenta
            // 
            this.TBNroVenta.Location = new System.Drawing.Point(102, 30);
            this.TBNroVenta.Name = "TBNroVenta";
            this.TBNroVenta.Size = new System.Drawing.Size(105, 20);
            this.TBNroVenta.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGDetalleVenta);
            this.panel2.Location = new System.Drawing.Point(12, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 221);
            this.panel2.TabIndex = 1;
            // 
            // DGDetalleVenta
            // 
            this.DGDetalleVenta.AllowUserToAddRows = false;
            this.DGDetalleVenta.AllowUserToDeleteRows = false;
            this.DGDetalleVenta.AllowUserToOrderColumns = true;
            this.DGDetalleVenta.AllowUserToResizeColumns = false;
            this.DGDetalleVenta.AllowUserToResizeRows = false;
            this.DGDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.colCodigo,
            this.colNombre,
            this.colPrecioUnitario,
            this.colCantComprada,
            this.colCantDevolucion,
            this.colMotivo});
            this.DGDetalleVenta.Location = new System.Drawing.Point(3, 14);
            this.DGDetalleVenta.Name = "DGDetalleVenta";
            this.DGDetalleVenta.RowHeadersVisible = false;
            this.DGDetalleVenta.Size = new System.Drawing.Size(770, 163);
            this.DGDetalleVenta.TabIndex = 0;
            this.DGDetalleVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetalleVenta_CellContentClick);
            this.DGDetalleVenta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetalleVenta_CellValueChanged);
            this.DGDetalleVenta.CurrentCellDirtyStateChanged += new System.EventHandler(this.DGDetalleVenta_CurrentCellDirtyStateChanged);
            // 
            // idDetalle
            // 
            this.idDetalle.HeaderText = "Detalle";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 20F;
            this.colCodigo.HeaderText = "Cód.";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 60F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.HeaderText = "Precio Unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            this.colPrecioUnitario.Visible = false;
            // 
            // colCantComprada
            // 
            this.colCantComprada.FillWeight = 30F;
            this.colCantComprada.HeaderText = "Cantidad Comprada";
            this.colCantComprada.Name = "colCantComprada";
            this.colCantComprada.ReadOnly = true;
            // 
            // colCantDevolucion
            // 
            this.colCantDevolucion.FillWeight = 30F;
            this.colCantDevolucion.HeaderText = "Cantidad a Devolver";
            this.colCantDevolucion.Name = "colCantDevolucion";
            // 
            // colMotivo
            // 
            this.colMotivo.FillWeight = 30F;
            this.colMotivo.HeaderText = "Motivo";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BRegistrarDevolucion
            // 
            this.BRegistrarDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarDevolucion.Location = new System.Drawing.Point(592, 410);
            this.BRegistrarDevolucion.Name = "BRegistrarDevolucion";
            this.BRegistrarDevolucion.Size = new System.Drawing.Size(196, 36);
            this.BRegistrarDevolucion.TabIndex = 9;
            this.BRegistrarDevolucion.Text = "Registrar Devolución";
            this.BRegistrarDevolucion.UseVisualStyleBackColor = true;
            this.BRegistrarDevolucion.Click += new System.EventHandler(this.BRegistrarDevolucion_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Location = new System.Drawing.Point(390, 410);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(196, 36);
            this.BCancelar.TabIndex = 10;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // FormRegistrarDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BRegistrarDevolucion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegistrarDevolucion";
            this.Text = "Registrar Devolución";
            this.Load += new System.EventHandler(this.FormRegistrarDevolucion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LNroVenta;
        private System.Windows.Forms.TextBox TBNroVenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGDetalleVenta;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.TextBox TBCliente;
        private System.Windows.Forms.Button BBuscarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantComprada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantDevolucion;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMotivo;
        private System.Windows.Forms.Button BRegistrarDevolucion;
        private System.Windows.Forms.Button BCancelar;
    }
}