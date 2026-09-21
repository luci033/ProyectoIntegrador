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
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BBuscarVenta);
            this.panel1.Controls.Add(this.LFecha);
            this.panel1.Controls.Add(this.LCliente);
            this.panel1.Controls.Add(this.TBFecha);
            this.panel1.Controls.Add(this.TBCliente);
            this.panel1.Controls.Add(this.LNroVenta);
            this.panel1.Controls.Add(this.TBNroVenta);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 100);
            this.panel1.TabIndex = 0;
            // 
            // BBuscarVenta
            // 
            this.BBuscarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BBuscarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BBuscarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscarVenta.FlatAppearance.BorderSize = 0;
            this.BBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarVenta.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarVenta.ForeColor = System.Drawing.Color.White;
            this.BBuscarVenta.Location = new System.Drawing.Point(680, 30);
            this.BBuscarVenta.Name = "BBuscarVenta";
            this.BBuscarVenta.Size = new System.Drawing.Size(155, 38);
            this.BBuscarVenta.TabIndex = 6;
            this.BBuscarVenta.Text = "Buscar Venta";
            this.BBuscarVenta.UseVisualStyleBackColor = false;
            this.BBuscarVenta.Click += new System.EventHandler(this.BBuscarVenta_Click);
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.Transparent;
            this.LFecha.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LFecha.Location = new System.Drawing.Point(500, 22);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(47, 17);
            this.LFecha.TabIndex = 4;
            this.LFecha.Text = "Fecha:";
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.BackColor = System.Drawing.Color.Transparent;
            this.LCliente.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCliente.Location = new System.Drawing.Point(220, 22);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(55, 17);
            this.LCliente.TabIndex = 2;
            this.LCliente.Text = "Cliente:";
            // 
            // TBFecha
            // 
            this.TBFecha.BackColor = System.Drawing.Color.White;
            this.TBFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFecha.ForeColor = System.Drawing.Color.Black;
            this.TBFecha.Location = new System.Drawing.Point(500, 44);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(140, 25);
            this.TBFecha.TabIndex = 5;
            // 
            // TBCliente
            // 
            this.TBCliente.BackColor = System.Drawing.Color.White;
            this.TBCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCliente.ForeColor = System.Drawing.Color.Black;
            this.TBCliente.Location = new System.Drawing.Point(220, 44);
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.ReadOnly = true;
            this.TBCliente.Size = new System.Drawing.Size(250, 25);
            this.TBCliente.TabIndex = 3;
            // 
            // LNroVenta
            // 
            this.LNroVenta.AutoSize = true;
            this.LNroVenta.BackColor = System.Drawing.Color.Transparent;
            this.LNroVenta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNroVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LNroVenta.Location = new System.Drawing.Point(25, 22);
            this.LNroVenta.Name = "LNroVenta";
            this.LNroVenta.Size = new System.Drawing.Size(78, 17);
            this.LNroVenta.TabIndex = 0;
            this.LNroVenta.Text = "Nro. Venta:";
            // 
            // TBNroVenta
            // 
            this.TBNroVenta.BackColor = System.Drawing.Color.White;
            this.TBNroVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNroVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNroVenta.ForeColor = System.Drawing.Color.Black;
            this.TBNroVenta.Location = new System.Drawing.Point(25, 44);
            this.TBNroVenta.Name = "TBNroVenta";
            this.TBNroVenta.Size = new System.Drawing.Size(160, 25);
            this.TBNroVenta.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.DGDetalleVenta);
            this.panel2.Location = new System.Drawing.Point(20, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 370);
            this.panel2.TabIndex = 1;
            // 
            // DGDetalleVenta
            // 
            this.DGDetalleVenta.AllowUserToAddRows = false;
            this.DGDetalleVenta.AllowUserToDeleteRows = false;
            this.DGDetalleVenta.AllowUserToOrderColumns = true;
            this.DGDetalleVenta.AllowUserToResizeColumns = false;
            this.DGDetalleVenta.AllowUserToResizeRows = false;
            this.DGDetalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGDetalleVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.DGDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.colCodigo,
            this.colNombre,
            this.colPrecioUnitario,
            this.colCantComprada,
            this.colCantDevolucion,
            this.colMotivo});
            this.DGDetalleVenta.Location = new System.Drawing.Point(20, 20);
            this.DGDetalleVenta.Name = "DGDetalleVenta";
            this.DGDetalleVenta.RowHeadersVisible = false;
            this.DGDetalleVenta.Size = new System.Drawing.Size(820, 330);
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
            this.colNombre.HeaderText = "Producto";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.FillWeight = 25F;
            this.colPrecioUnitario.HeaderText = "Precio Unit.";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            // 
            // colCantComprada
            // 
            this.colCantComprada.FillWeight = 20F;
            this.colCantComprada.HeaderText = "Comprada";
            this.colCantComprada.Name = "colCantComprada";
            this.colCantComprada.ReadOnly = true;
            // 
            // colCantDevolucion
            // 
            this.colCantDevolucion.FillWeight = 25F;
            this.colCantDevolucion.HeaderText = "A Devolver";
            this.colCantDevolucion.Name = "colCantDevolucion";
            // 
            // colMotivo
            // 
            this.colMotivo.FillWeight = 40F;
            this.colMotivo.HeaderText = "Motivo";
            this.colMotivo.Items.AddRange(new object[] {
            "Falla de Fábrica",
            "Cambio de Modelo",
            "Talle Incorrecto",
            "Insatisfacción"});
            this.colMotivo.Name = "colMotivo";
            // 
            // BRegistrarDevolucion
            // 
            this.BRegistrarDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BRegistrarDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BRegistrarDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            this.BRegistrarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegistrarDevolucion.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarDevolucion.ForeColor = System.Drawing.Color.White;
            this.BRegistrarDevolucion.Location = new System.Drawing.Point(475, 520);
            this.BRegistrarDevolucion.Name = "BRegistrarDevolucion";
            this.BRegistrarDevolucion.Size = new System.Drawing.Size(210, 42);
            this.BRegistrarDevolucion.TabIndex = 2;
            this.BRegistrarDevolucion.Text = "Registrar Devolución";
            this.BRegistrarDevolucion.UseVisualStyleBackColor = false;
            this.BRegistrarDevolucion.Click += new System.EventHandler(this.BRegistrarDevolucion_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(208)))), ((int)(((byte)(201)))));
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.FlatAppearance.BorderSize = 0;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BCancelar.Location = new System.Drawing.Point(700, 520);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(180, 42);
            this.BCancelar.TabIndex = 3;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // FormRegistrarDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BRegistrarDevolucion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegistrarDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Devolución - Joyería ALBA";
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