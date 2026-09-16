namespace ProyectoIntegrador.Formularios.Devoluciones
{
    partial class FormDevoluciones
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
            this.DGDevoluciones = new System.Windows.Forms.DataGridView();
            this.BRegistrarDevolucion = new System.Windows.Forms.Button();
            this.LDevoluciones = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReintegro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LBuscar = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGDevoluciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGDevoluciones
            // 
            this.DGDevoluciones.AllowUserToAddRows = false;
            this.DGDevoluciones.AllowUserToDeleteRows = false;
            this.DGDevoluciones.AllowUserToOrderColumns = true;
            this.DGDevoluciones.AllowUserToResizeColumns = false;
            this.DGDevoluciones.AllowUserToResizeRows = false;
            this.DGDevoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDevoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFecha,
            this.colCliente,
            this.colReintegro,
            this.colDetalle});
            this.DGDevoluciones.Location = new System.Drawing.Point(3, 56);
            this.DGDevoluciones.Name = "DGDevoluciones";
            this.DGDevoluciones.RowHeadersVisible = false;
            this.DGDevoluciones.Size = new System.Drawing.Size(770, 172);
            this.DGDevoluciones.TabIndex = 0;
            this.DGDevoluciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDevoluciones_CellContentClick);
            // 
            // BRegistrarDevolucion
            // 
            this.BRegistrarDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarDevolucion.Location = new System.Drawing.Point(559, 46);
            this.BRegistrarDevolucion.Name = "BRegistrarDevolucion";
            this.BRegistrarDevolucion.Size = new System.Drawing.Size(156, 67);
            this.BRegistrarDevolucion.TabIndex = 1;
            this.BRegistrarDevolucion.Text = "Registrar Devolución";
            this.BRegistrarDevolucion.UseVisualStyleBackColor = true;
            this.BRegistrarDevolucion.Click += new System.EventHandler(this.BRegistrarDevolucion_Click);
            // 
            // LDevoluciones
            // 
            this.LDevoluciones.AutoSize = true;
            this.LDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDevoluciones.Location = new System.Drawing.Point(61, 60);
            this.LDevoluciones.Name = "LDevoluciones";
            this.LDevoluciones.Size = new System.Drawing.Size(203, 33);
            this.LDevoluciones.TabIndex = 2;
            this.LDevoluciones.Text = "Devoluciones";
            this.LDevoluciones.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBBuscar);
            this.panel1.Controls.Add(this.LBuscar);
            this.panel1.Controls.Add(this.DGDevoluciones);
            this.panel1.Location = new System.Drawing.Point(12, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 231);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LDevoluciones);
            this.panel2.Controls.Add(this.BRegistrarDevolucion);
            this.panel2.Location = new System.Drawing.Point(12, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 162);
            this.panel2.TabIndex = 4;
            // 
            // colId
            // 
            this.colId.HeaderText = "IdDevolucion";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 50F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colReintegro
            // 
            this.colReintegro.FillWeight = 60F;
            this.colReintegro.HeaderText = "Reintegro";
            this.colReintegro.Name = "colReintegro";
            // 
            // colDetalle
            // 
            this.colDetalle.FillWeight = 50F;
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Location = new System.Drawing.Point(37, 24);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(159, 13);
            this.LBuscar.TabIndex = 1;
            this.LBuscar.Text = "Buscar por Nro. Venta o Cliente:";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(202, 21);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(167, 20);
            this.TBBuscar.TabIndex = 2;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // FormDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDevoluciones";
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.FormDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGDevoluciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGDevoluciones;
        private System.Windows.Forms.Button BRegistrarDevolucion;
        private System.Windows.Forms.Label LDevoluciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReintegro;
        private System.Windows.Forms.DataGridViewButtonColumn colDetalle;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.TextBox TBBuscar;
    }
}