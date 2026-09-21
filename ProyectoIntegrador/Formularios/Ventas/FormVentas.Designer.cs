namespace ProyectoIntegrador.Formularios.Ventas
{
    partial class FormVentas
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
            this.BRegistrarVenta = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgVentas = new System.Windows.Forms.DataGridView();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleOrden = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(25, 20);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(265, 31);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Gestión de Ventas";
            // 
            // BRegistrarVenta
            // 
            this.BRegistrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.BRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegistrarVenta.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.BRegistrarVenta.Location = new System.Drawing.Point(615, 20);
            this.BRegistrarVenta.Name = "BRegistrarVenta";
            this.BRegistrarVenta.Size = new System.Drawing.Size(165, 36);
            this.BRegistrarVenta.TabIndex = 1;
            this.BRegistrarVenta.Text = "+ Registrar Venta";
            this.BRegistrarVenta.UseVisualStyleBackColor = false;
            this.BRegistrarVenta.Click += new System.EventHandler(this.BRegistrarVenta_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Controls.Add(this.dgVentas);
            this.panelGrid.Location = new System.Drawing.Point(25, 75);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(755, 430);
            this.panelGrid.TabIndex = 2;
            // 
            // dgVentas
            // 
            this.dgVentas.AllowUserToAddRows = false;
            this.dgVentas.AllowUserToDeleteRows = false;
            this.dgVentas.AllowUserToResizeRows = false;
            this.dgVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompra,
            this.fechaCompa,
            this.cliente,
            this.Total,
            this.DetalleOrden});
            this.dgVentas.Location = new System.Drawing.Point(12, 12);
            this.dgVentas.Name = "dgVentas";
            this.dgVentas.ReadOnly = true;
            this.dgVentas.RowHeadersVisible = false;
            this.dgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVentas.Size = new System.Drawing.Size(731, 406);
            this.dgVentas.TabIndex = 0;
            // 
            // idCompra
            // 
            this.idCompra.FillWeight = 20F;
            this.idCompra.HeaderText = "Nro.";
            this.idCompra.Name = "idCompra";
            this.idCompra.ReadOnly = true;
            // 
            // fechaCompa
            // 
            this.fechaCompa.FillWeight = 30F;
            this.fechaCompa.HeaderText = "Fecha";
            this.fechaCompa.Name = "fechaCompa";
            this.fechaCompa.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.FillWeight = 50F;
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 40F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // DetalleOrden
            // 
            this.DetalleOrden.FillWeight = 30F;
            this.DetalleOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetalleOrden.HeaderText = "Detalle";
            this.DetalleOrden.Name = "DetalleOrden";
            this.DetalleOrden.ReadOnly = true;
            this.DetalleOrden.Text = "Ver...";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(806, 527);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.BRegistrarVenta);
            this.Controls.Add(this.LTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormVentas";
            this.Text = "Gestión de Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load_1);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button BRegistrarVenta;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn DetalleOrden;
    }
}