namespace ProyectoIntegrador.Formularios.Clientes
{
    partial class DetalleClientes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LNombre = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.LCondicionIVA = new System.Windows.Forms.Label();
            this.cmbCondicionIVA = new System.Windows.Forms.ComboBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LDesde = new System.Windows.Forms.Label();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.LHasta = new System.Windows.Forms.Label();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
            this.LMedioPago = new System.Windows.Forms.Label();
            this.cmbDMedioPago = new System.Windows.Forms.ComboBox();
            this.BFiltrar = new System.Windows.Forms.Button();
            this.dataGridDetalleCliente = new System.Windows.Forms.DataGridView();
            this.colNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BPDF = new System.Windows.Forms.Button();
            this.BCerrar = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalleCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LSubtitulo);
            this.panelCard.Controls.Add(this.panel2);
            this.panelCard.Controls.Add(this.panel1);
            this.panelCard.Controls.Add(this.dataGridDetalleCliente);
            this.panelCard.Controls.Add(this.BPDF);
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
            this.LTitulo.Size = new System.Drawing.Size(462, 31);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Historial de Compras del Cliente";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.LSubtitulo.Location = new System.Drawing.Point(25, 55);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(466, 17);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Consulte las ventas efectuadas, medios de pago y montos totales facturados.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.LNombre);
            this.panel2.Controls.Add(this.TBNombre);
            this.panel2.Controls.Add(this.LDni);
            this.panel2.Controls.Add(this.TBDni);
            this.panel2.Controls.Add(this.LCondicionIVA);
            this.panel2.Controls.Add(this.cmbCondicionIVA);
            this.panel2.Controls.Add(this.LCorreo);
            this.panel2.Controls.Add(this.TBCorreo);
            this.panel2.Location = new System.Drawing.Point(25, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 75);
            this.panel2.TabIndex = 2;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LNombre.Location = new System.Drawing.Point(20, 14);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(113, 15);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre y Apellido:";
            // 
            // TBNombre
            // 
            this.TBNombre.BackColor = System.Drawing.Color.White;
            this.TBNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBNombre.Location = new System.Drawing.Point(20, 35);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.ReadOnly = true;
            this.TBNombre.Size = new System.Drawing.Size(240, 24);
            this.TBNombre.TabIndex = 1;
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LDni.Location = new System.Drawing.Point(280, 14);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(65, 15);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI / CUIT:";
            // 
            // TBDni
            // 
            this.TBDni.BackColor = System.Drawing.Color.White;
            this.TBDni.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBDni.Location = new System.Drawing.Point(280, 35);
            this.TBDni.Name = "TBDni";
            this.TBDni.ReadOnly = true;
            this.TBDni.Size = new System.Drawing.Size(140, 24);
            this.TBDni.TabIndex = 3;
            // 
            // LCondicionIVA
            // 
            this.LCondicionIVA.AutoSize = true;
            this.LCondicionIVA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCondicionIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCondicionIVA.Location = new System.Drawing.Point(440, 14);
            this.LCondicionIVA.Name = "LCondicionIVA";
            this.LCondicionIVA.Size = new System.Drawing.Size(89, 15);
            this.LCondicionIVA.TabIndex = 4;
            this.LCondicionIVA.Text = "Condición IVA:";
            // 
            // cmbCondicionIVA
            // 
            this.cmbCondicionIVA.BackColor = System.Drawing.Color.White;
            this.cmbCondicionIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionIVA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbCondicionIVA.FormattingEnabled = true;
            this.cmbCondicionIVA.Location = new System.Drawing.Point(440, 35);
            this.cmbCondicionIVA.Name = "cmbCondicionIVA";
            this.cmbCondicionIVA.Size = new System.Drawing.Size(180, 24);
            this.cmbCondicionIVA.TabIndex = 5;
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCorreo.Location = new System.Drawing.Point(640, 14);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(113, 15);
            this.LCorreo.TabIndex = 6;
            this.LCorreo.Text = "Correo Electrónico:";
            // 
            // TBCorreo
            // 
            this.TBCorreo.BackColor = System.Drawing.Color.White;
            this.TBCorreo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBCorreo.Location = new System.Drawing.Point(640, 35);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.ReadOnly = true;
            this.TBCorreo.Size = new System.Drawing.Size(270, 24);
            this.TBCorreo.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.LDesde);
            this.panel1.Controls.Add(this.DTPDesde);
            this.panel1.Controls.Add(this.LHasta);
            this.panel1.Controls.Add(this.DTPHasta);
            this.panel1.Controls.Add(this.LMedioPago);
            this.panel1.Controls.Add(this.cmbDMedioPago);
            this.panel1.Controls.Add(this.BFiltrar);
            this.panel1.Location = new System.Drawing.Point(25, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 60);
            this.panel1.TabIndex = 3;
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LDesde.Location = new System.Drawing.Point(20, 22);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(45, 15);
            this.LDesde.TabIndex = 0;
            this.LDesde.Text = "Desde:";
            // 
            // DTPDesde
            // 
            this.DTPDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.DTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDesde.Location = new System.Drawing.Point(75, 18);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(130, 24);
            this.DTPDesde.TabIndex = 1;
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LHasta.Location = new System.Drawing.Point(225, 22);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(42, 15);
            this.LHasta.TabIndex = 2;
            this.LHasta.Text = "Hasta:";
            // 
            // DTPHasta
            // 
            this.DTPHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.DTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPHasta.Location = new System.Drawing.Point(275, 18);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(130, 24);
            this.DTPHasta.TabIndex = 3;
            // 
            // LMedioPago
            // 
            this.LMedioPago.AutoSize = true;
            this.LMedioPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMedioPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LMedioPago.Location = new System.Drawing.Point(435, 22);
            this.LMedioPago.Name = "LMedioPago";
            this.LMedioPago.Size = new System.Drawing.Size(95, 15);
            this.LMedioPago.TabIndex = 4;
            this.LMedioPago.Text = "Medio de Pago:";
            // 
            // cmbDMedioPago
            // 
            this.cmbDMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDMedioPago.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbDMedioPago.FormattingEnabled = true;
            this.cmbDMedioPago.Location = new System.Drawing.Point(540, 18);
            this.cmbDMedioPago.Name = "cmbDMedioPago";
            this.cmbDMedioPago.Size = new System.Drawing.Size(180, 24);
            this.cmbDMedioPago.TabIndex = 5;
            // 
            // BFiltrar
            // 
            this.BFiltrar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.BFiltrar.Location = new System.Drawing.Point(745, 13);
            this.BFiltrar.Name = "BFiltrar";
            this.BFiltrar.Size = new System.Drawing.Size(165, 34);
            this.BFiltrar.TabIndex = 6;
            this.BFiltrar.Text = "Filtrar";
            this.BFiltrar.UseVisualStyleBackColor = true;
            this.BFiltrar.Click += new System.EventHandler(this.BFiltrar_Click);
            // 
            // dataGridDetalleCliente
            // 
            this.dataGridDetalleCliente.AllowUserToAddRows = false;
            this.dataGridDetalleCliente.AllowUserToDeleteRows = false;
            this.dataGridDetalleCliente.AllowUserToResizeColumns = false;
            this.dataGridDetalleCliente.AllowUserToResizeRows = false;
            this.dataGridDetalleCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetalleCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalleCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroVenta,
            this.colFecha,
            this.colMedioPago,
            this.colTotal,
            this.colDetalle});
            this.dataGridDetalleCliente.Location = new System.Drawing.Point(25, 240);
            this.dataGridDetalleCliente.Name = "dataGridDetalleCliente";
            this.dataGridDetalleCliente.RowHeadersVisible = false;
            this.dataGridDetalleCliente.Size = new System.Drawing.Size(930, 350);
            this.dataGridDetalleCliente.TabIndex = 4;
            this.dataGridDetalleCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colNroVenta
            // 
            this.colNroVenta.FillWeight = 20F;
            this.colNroVenta.HeaderText = "Nro. Venta";
            this.colNroVenta.Name = "colNroVenta";
            this.colNroVenta.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 25F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colMedioPago
            // 
            this.colMedioPago.FillWeight = 30F;
            this.colMedioPago.HeaderText = "Medio de Pago";
            this.colMedioPago.Name = "colMedioPago";
            this.colMedioPago.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.FillWeight = 25F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colDetalle
            // 
            this.colDetalle.FillWeight = 20F;
            this.colDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.Text = "Ver...";
            // 
            // BPDF
            // 
            this.BPDF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BPDF.Location = new System.Drawing.Point(545, 605);
            this.BPDF.Name = "BPDF";
            this.BPDF.Size = new System.Drawing.Size(180, 44);
            this.BPDF.TabIndex = 5;
            this.BPDF.Text = "Exportar PDF";
            this.BPDF.UseVisualStyleBackColor = true;
            // 
            // BCerrar
            // 
            this.BCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BCerrar.Location = new System.Drawing.Point(745, 605);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(210, 44);
            this.BCerrar.TabIndex = 6;
            this.BCerrar.Text = "Cerrar";
            this.BCerrar.UseVisualStyleBackColor = true;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // DetalleClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 720);
            this.Controls.Add(this.panelCard);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "DetalleClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Compras del Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DetalleClientes_Load);
            this.Resize += new System.EventHandler(this.DetalleClientes_Resize);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalleCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.ComboBox cmbCondicionIVA;
        private System.Windows.Forms.Label LCondicionIVA;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DTPHasta;
        private System.Windows.Forms.ComboBox cmbDMedioPago;
        private System.Windows.Forms.Button BFiltrar;
        private System.Windows.Forms.Label LMedioPago;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.DataGridView dataGridDetalleCliente;
        private System.Windows.Forms.Button BPDF;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colDetalle;
        private System.Windows.Forms.DateTimePicker DTPDesde;
    }
}