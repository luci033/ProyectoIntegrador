namespace ProyectoIntegrador.Formularios.Ventas
{
    partial class FDetalleVenta
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
            this.LTotal = new System.Windows.Forms.Label();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.LInfoVenta = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.dataGridDetalle = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LJoyeria = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TBNroVenta = new System.Windows.Forms.TextBox();
            this.LFechaEmision = new System.Windows.Forms.Label();
            this.LNroVenta = new System.Windows.Forms.Label();
            this.LComrprobanteVenta = new System.Windows.Forms.Label();
            this.LALBA = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBTeléfono = new System.Windows.Forms.TextBox();
            this.TBCUITDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TBCondicionIVA = new System.Windows.Forms.TextBox();
            this.TBRazonSocial = new System.Windows.Forms.TextBox();
            this.LCondicionVenta = new System.Windows.Forms.Label();
            this.LCondicionIVA = new System.Windows.Forms.Label();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.LTotal);
            this.panelCard.Controls.Add(this.TBTotal);
            this.panelCard.Controls.Add(this.LInfoVenta);
            this.panelCard.Controls.Add(this.LSubtitulo);
            this.panelCard.Controls.Add(this.dataGridDetalle);
            this.panelCard.Controls.Add(this.BCerrar);
            this.panelCard.Location = new System.Drawing.Point(22, 266);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(753, 404);
            this.panelCard.TabIndex = 0;
            // 
            // LTotal
            // 
            this.LTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTotal.Location = new System.Drawing.Point(563, 326);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(54, 19);
            this.LTotal.TabIndex = 6;
            this.LTotal.Text = "TOTAL:";
            // 
            // TBTotal
            // 
            this.TBTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.TBTotal.Location = new System.Drawing.Point(623, 321);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(110, 27);
            this.TBTotal.TabIndex = 7;
            this.TBTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LInfoVenta
            // 
            this.LInfoVenta.AutoSize = true;
            this.LInfoVenta.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfoVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LInfoVenta.Location = new System.Drawing.Point(20, 18);
            this.LInfoVenta.Name = "LInfoVenta";
            this.LInfoVenta.Size = new System.Drawing.Size(265, 24);
            this.LInfoVenta.TabIndex = 0;
            this.LInfoVenta.Text = "Detalle del Comprobante";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.LSubtitulo.Location = new System.Drawing.Point(22, 46);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(178, 15);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Desglose de artículos de la venta";
            // 
            // dataGridDetalle
            // 
            this.dataGridDetalle.AllowUserToAddRows = false;
            this.dataGridDetalle.AllowUserToDeleteRows = false;
            this.dataGridDetalle.AllowUserToResizeRows = false;
            this.dataGridDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubTotal});
            this.dataGridDetalle.Location = new System.Drawing.Point(20, 75);
            this.dataGridDetalle.Name = "dataGridDetalle";
            this.dataGridDetalle.ReadOnly = true;
            this.dataGridDetalle.RowHeadersVisible = false;
            this.dataGridDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDetalle.Size = new System.Drawing.Size(713, 236);
            this.dataGridDetalle.TabIndex = 2;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "idProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Visible = false;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 50F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 16.86741F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.FillWeight = 20.24089F;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.FillWeight = 20.24089F;
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // BCerrar
            // 
            this.BCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerrar.ForeColor = System.Drawing.Color.White;
            this.BCerrar.Location = new System.Drawing.Point(623, 360);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(110, 34);
            this.BCerrar.TabIndex = 3;
            this.BCerrar.Text = "Cerrar";
            this.BCerrar.UseVisualStyleBackColor = false;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LJoyeria);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.TBNroVenta);
            this.panel1.Controls.Add(this.LFechaEmision);
            this.panel1.Controls.Add(this.LNroVenta);
            this.panel1.Controls.Add(this.LComrprobanteVenta);
            this.panel1.Controls.Add(this.LALBA);
            this.panel1.Location = new System.Drawing.Point(22, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 110);
            this.panel1.TabIndex = 1;
            // 
            // LJoyeria
            // 
            this.LJoyeria.AutoSize = true;
            this.LJoyeria.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LJoyeria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.LJoyeria.Location = new System.Drawing.Point(26, 62);
            this.LJoyeria.Name = "LJoyeria";
            this.LJoyeria.Size = new System.Drawing.Size(152, 16);
            this.LJoyeria.TabIndex = 11;
            this.LJoyeria.Text = "JOYERÍA & ALTA GAMA";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBox5.Location = new System.Drawing.Point(544, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(185, 24);
            this.textBox5.TabIndex = 10;
            // 
            // TBNroVenta
            // 
            this.TBNroVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBNroVenta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBNroVenta.Location = new System.Drawing.Point(544, 43);
            this.TBNroVenta.Name = "TBNroVenta";
            this.TBNroVenta.ReadOnly = true;
            this.TBNroVenta.Size = new System.Drawing.Size(185, 24);
            this.TBNroVenta.TabIndex = 9;
            // 
            // LFechaEmision
            // 
            this.LFechaEmision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LFechaEmision.AutoSize = true;
            this.LFechaEmision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LFechaEmision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LFechaEmision.Location = new System.Drawing.Point(448, 76);
            this.LFechaEmision.Name = "LFechaEmision";
            this.LFechaEmision.Size = new System.Drawing.Size(87, 15);
            this.LFechaEmision.TabIndex = 3;
            this.LFechaEmision.Text = "Fecha Emisión:";
            // 
            // LNroVenta
            // 
            this.LNroVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LNroVenta.AutoSize = true;
            this.LNroVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LNroVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LNroVenta.Location = new System.Drawing.Point(448, 46);
            this.LNroVenta.Name = "LNroVenta";
            this.LNroVenta.Size = new System.Drawing.Size(69, 15);
            this.LNroVenta.TabIndex = 2;
            this.LNroVenta.Text = "Nro. Venta:";
            // 
            // LComrprobanteVenta
            // 
            this.LComrprobanteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LComrprobanteVenta.AutoSize = true;
            this.LComrprobanteVenta.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LComrprobanteVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LComrprobanteVenta.Location = new System.Drawing.Point(448, 16);
            this.LComrprobanteVenta.Name = "LComrprobanteVenta";
            this.LComrprobanteVenta.Size = new System.Drawing.Size(226, 18);
            this.LComrprobanteVenta.TabIndex = 1;
            this.LComrprobanteVenta.Text = "COMPROBANTE DE VENTA";
            // 
            // LALBA
            // 
            this.LALBA.AutoSize = true;
            this.LALBA.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LALBA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LALBA.Location = new System.Drawing.Point(24, 20);
            this.LALBA.Name = "LALBA";
            this.LALBA.Size = new System.Drawing.Size(111, 38);
            this.LALBA.TabIndex = 0;
            this.LALBA.Text = "ALBA";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTelefono.Location = new System.Drawing.Point(375, 51);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(59, 15);
            this.LTelefono.TabIndex = 14;
            this.LTelefono.Text = "Teléfono:";
            // 
            // TBTeléfono
            // 
            this.TBTeléfono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBTeléfono.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBTeléfono.Location = new System.Drawing.Point(475, 48);
            this.TBTeléfono.Name = "TBTeléfono";
            this.TBTeléfono.ReadOnly = true;
            this.TBTeléfono.Size = new System.Drawing.Size(254, 24);
            this.TBTeléfono.TabIndex = 13;
            // 
            // TBCUITDNI
            // 
            this.TBCUITDNI.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBCUITDNI.Location = new System.Drawing.Point(145, 13);
            this.TBCUITDNI.Name = "TBCUITDNI";
            this.TBCUITDNI.ReadOnly = true;
            this.TBCUITDNI.Size = new System.Drawing.Size(185, 24);
            this.TBCUITDNI.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.label7.Location = new System.Drawing.Point(18, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "CUIT / DNI:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBox3.Location = new System.Drawing.Point(145, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(185, 24);
            this.textBox3.TabIndex = 8;
            // 
            // TBCondicionIVA
            // 
            this.TBCondicionIVA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBCondicionIVA.Location = new System.Drawing.Point(145, 48);
            this.TBCondicionIVA.Name = "TBCondicionIVA";
            this.TBCondicionIVA.ReadOnly = true;
            this.TBCondicionIVA.Size = new System.Drawing.Size(185, 24);
            this.TBCondicionIVA.TabIndex = 7;
            // 
            // TBRazonSocial
            // 
            this.TBRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBRazonSocial.Location = new System.Drawing.Point(475, 13);
            this.TBRazonSocial.Name = "TBRazonSocial";
            this.TBRazonSocial.ReadOnly = true;
            this.TBRazonSocial.Size = new System.Drawing.Size(254, 24);
            this.TBRazonSocial.TabIndex = 4;
            // 
            // LCondicionVenta
            // 
            this.LCondicionVenta.AutoSize = true;
            this.LCondicionVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LCondicionVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCondicionVenta.Location = new System.Drawing.Point(18, 86);
            this.LCondicionVenta.Name = "LCondicionVenta";
            this.LCondicionVenta.Size = new System.Drawing.Size(116, 15);
            this.LCondicionVenta.TabIndex = 6;
            this.LCondicionVenta.Text = "Condición de Venta:";
            // 
            // LCondicionIVA
            // 
            this.LCondicionIVA.AutoSize = true;
            this.LCondicionIVA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LCondicionIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCondicionIVA.Location = new System.Drawing.Point(18, 51);
            this.LCondicionIVA.Name = "LCondicionIVA";
            this.LCondicionIVA.Size = new System.Drawing.Size(86, 15);
            this.LCondicionIVA.TabIndex = 5;
            this.LCondicionIVA.Text = "Condición IVA:";
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LRazonSocial.Location = new System.Drawing.Point(375, 16);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(79, 15);
            this.LRazonSocial.TabIndex = 4;
            this.LRazonSocial.Text = "Razón Social:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LTelefono);
            this.panel2.Controls.Add(this.TBCUITDNI);
            this.panel2.Controls.Add(this.TBTeléfono);
            this.panel2.Controls.Add(this.LRazonSocial);
            this.panel2.Controls.Add(this.LCondicionIVA);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.LCondicionVenta);
            this.panel2.Controls.Add(this.TBRazonSocial);
            this.panel2.Controls.Add(this.TBCondicionIVA);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Location = new System.Drawing.Point(22, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 122);
            this.panel2.TabIndex = 2;
            // 
            // FDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(797, 696);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de Venta";
            this.Load += new System.EventHandler(this.FDetalleVenta_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LInfoVenta;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.DataGridView dataGridDetalle;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.TextBox TBCUITDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox TBNroVenta;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TBCondicionIVA;
        private System.Windows.Forms.TextBox TBRazonSocial;
        private System.Windows.Forms.Label LCondicionVenta;
        private System.Windows.Forms.Label LCondicionIVA;
        private System.Windows.Forms.Label LRazonSocial;
        private System.Windows.Forms.Label LFechaEmision;
        private System.Windows.Forms.Label LNroVenta;
        private System.Windows.Forms.Label LComrprobanteVenta;
        private System.Windows.Forms.Label LALBA;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox TBTeléfono;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LJoyeria;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.TextBox TBTotal;
    }
}