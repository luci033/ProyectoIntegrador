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
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.cmbCondicionIVA = new System.Windows.Forms.ComboBox();
            this.LCondicionIVA = new System.Windows.Forms.Label();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.LMedioPago = new System.Windows.Forms.Label();
            this.BFiltrar = new System.Windows.Forms.Button();
            this.TBDesde = new System.Windows.Forms.TextBox();
            this.cmbDMedioPago = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BPDF = new System.Windows.Forms.Button();
            this.BCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(134, 18);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 20);
            this.TBNombre.TabIndex = 8;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(26, 25);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 7;
            this.LNombre.Text = "Nombre";
            this.LNombre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(359, 62);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(100, 20);
            this.TBDni.TabIndex = 10;
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(285, 65);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 9;
            this.LDni.Text = "DNI";
            this.LDni.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbCondicionIVA
            // 
            this.cmbCondicionIVA.FormattingEnabled = true;
            this.cmbCondicionIVA.Location = new System.Drawing.Point(359, 21);
            this.cmbCondicionIVA.Name = "cmbCondicionIVA";
            this.cmbCondicionIVA.Size = new System.Drawing.Size(100, 21);
            this.cmbCondicionIVA.TabIndex = 17;
            // 
            // LCondicionIVA
            // 
            this.LCondicionIVA.AutoSize = true;
            this.LCondicionIVA.Location = new System.Drawing.Point(266, 29);
            this.LCondicionIVA.Name = "LCondicionIVA";
            this.LCondicionIVA.Size = new System.Drawing.Size(74, 13);
            this.LCondicionIVA.TabIndex = 16;
            this.LCondicionIVA.Text = "Condición IVA";
            this.LCondicionIVA.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(134, 58);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(100, 20);
            this.TBCorreo.TabIndex = 19;
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Location = new System.Drawing.Point(23, 65);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(94, 13);
            this.LCorreo.TabIndex = 18;
            this.LCorreo.Text = "Correo Electrónico";
            this.LCorreo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cmbDMedioPago);
            this.panel1.Controls.Add(this.TBDesde);
            this.panel1.Controls.Add(this.BFiltrar);
            this.panel1.Controls.Add(this.LMedioPago);
            this.panel1.Controls.Add(this.LHasta);
            this.panel1.Controls.Add(this.LDesde);
            this.panel1.Location = new System.Drawing.Point(25, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 38);
            this.panel1.TabIndex = 20;
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(3, 11);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(44, 13);
            this.LDesde.TabIndex = 0;
            this.LDesde.Text = "Desde: ";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(140, 11);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(41, 13);
            this.LHasta.TabIndex = 1;
            this.LHasta.Text = "Hasta: ";
            // 
            // LMedioPago
            // 
            this.LMedioPago.AutoSize = true;
            this.LMedioPago.Location = new System.Drawing.Point(285, 11);
            this.LMedioPago.Name = "LMedioPago";
            this.LMedioPago.Size = new System.Drawing.Size(79, 13);
            this.LMedioPago.TabIndex = 21;
            this.LMedioPago.Text = "Medio de Pago";
            // 
            // BFiltrar
            // 
            this.BFiltrar.Location = new System.Drawing.Point(520, 4);
            this.BFiltrar.Name = "BFiltrar";
            this.BFiltrar.Size = new System.Drawing.Size(89, 27);
            this.BFiltrar.TabIndex = 22;
            this.BFiltrar.Text = "Filtrar";
            this.BFiltrar.UseVisualStyleBackColor = true;
            // 
            // TBDesde
            // 
            this.TBDesde.Location = new System.Drawing.Point(42, 8);
            this.TBDesde.Name = "TBDesde";
            this.TBDesde.Size = new System.Drawing.Size(83, 20);
            this.TBDesde.TabIndex = 23;
            // 
            // cmbDMedioPago
            // 
            this.cmbDMedioPago.FormattingEnabled = true;
            this.cmbDMedioPago.Location = new System.Drawing.Point(370, 8);
            this.cmbDMedioPago.Name = "cmbDMedioPago";
            this.cmbDMedioPago.Size = new System.Drawing.Size(95, 21);
            this.cmbDMedioPago.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroVenta,
            this.colFecha,
            this.colMedioPago,
            this.colTotal,
            this.colDetalle});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(772, 67);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BPDF
            // 
            this.BPDF.Location = new System.Drawing.Point(407, 350);
            this.BPDF.Name = "BPDF";
            this.BPDF.Size = new System.Drawing.Size(142, 24);
            this.BPDF.TabIndex = 22;
            this.BPDF.Text = "Exportar PDF//";
            this.BPDF.UseVisualStyleBackColor = true;
            // 
            // BCerrar
            // 
            this.BCerrar.Location = new System.Drawing.Point(580, 350);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(82, 24);
            this.BCerrar.TabIndex = 23;
            this.BCerrar.Text = "Cerrar";
            this.BCerrar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TBCorreo);
            this.panel2.Controls.Add(this.LCorreo);
            this.panel2.Controls.Add(this.cmbCondicionIVA);
            this.panel2.Controls.Add(this.LCondicionIVA);
            this.panel2.Controls.Add(this.TBDni);
            this.panel2.Controls.Add(this.LDni);
            this.panel2.Controls.Add(this.TBNombre);
            this.panel2.Controls.Add(this.LNombre);
            this.panel2.Location = new System.Drawing.Point(16, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 102);
            this.panel2.TabIndex = 24;
            // 
            // colNroVenta
            // 
            this.colNroVenta.FillWeight = 15F;
            this.colNroVenta.HeaderText = "Nro. Venta";
            this.colNroVenta.Name = "colNroVenta";
            this.colNroVenta.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 15F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colMedioPago
            // 
            this.colMedioPago.FillWeight = 15F;
            this.colMedioPago.HeaderText = "Medio de Pago";
            this.colMedioPago.Name = "colMedioPago";
            this.colMedioPago.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.FillWeight = 15F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colDetalle
            // 
            this.colDetalle.FillWeight = 15F;
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            // 
            // DetalleClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 386);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BCerrar);
            this.Controls.Add(this.BPDF);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "DetalleClientes";
            this.Text = "Detalle Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.ComboBox cmbCondicionIVA;
        private System.Windows.Forms.Label LCondicionIVA;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbDMedioPago;
        private System.Windows.Forms.TextBox TBDesde;
        private System.Windows.Forms.Button BFiltrar;
        private System.Windows.Forms.Label LMedioPago;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BPDF;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colDetalle;
    }
}