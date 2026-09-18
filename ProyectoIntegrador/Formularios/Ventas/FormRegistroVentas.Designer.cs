namespace ProyectoIntegrador.Formularios.Ventas
{
    partial class FormRegistroVentas
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
            this.components = new System.ComponentModel.Container();
            this.LCLiente = new System.Windows.Forms.Label();
            this.TBCliente = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.BAgregarProducto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BCobrar = new System.Windows.Forms.Button();
            this.LTotal = new System.Windows.Forms.Label();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreJoya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LCLiente
            // 
            this.LCLiente.AutoSize = true;
            this.LCLiente.Location = new System.Drawing.Point(19, 43);
            this.LCLiente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCLiente.Name = "LCLiente";
            this.LCLiente.Size = new System.Drawing.Size(47, 17);
            this.LCLiente.TabIndex = 0;
            this.LCLiente.Text = "Cliente";
            this.LCLiente.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBCliente
            // 
            this.TBCliente.Location = new System.Drawing.Point(94, 33);
            this.TBCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.Size = new System.Drawing.Size(116, 25);
            this.TBCliente.TabIndex = 1;
            this.TBCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBCliente_Validating);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(19, 83);
            this.LTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(58, 17);
            this.LTelefono.TabIndex = 2;
            this.LTelefono.Text = "Teléfono";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(19, 130);
            this.LDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(30, 17);
            this.LDni.TabIndex = 3;
            this.LDni.Text = "DNI";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(94, 79);
            this.TBTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(116, 25);
            this.TBTelefono.TabIndex = 4;
            this.TBTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.TBTelefono_Validating);
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(94, 121);
            this.TBDni.Margin = new System.Windows.Forms.Padding(4);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(116, 25);
            this.TBDni.TabIndex = 5;
            this.TBDni.Validating += new System.ComponentModel.CancelEventHandler(this.TBDni_Validating);
            // 
            // BAgregarProducto
            // 
            this.BAgregarProducto.Location = new System.Drawing.Point(289, 121);
            this.BAgregarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.BAgregarProducto.Name = "BAgregarProducto";
            this.BAgregarProducto.Size = new System.Drawing.Size(155, 31);
            this.BAgregarProducto.TabIndex = 6;
            this.BAgregarProducto.Text = "Agregar Producto";
            this.BAgregarProducto.UseVisualStyleBackColor = true;
            this.BAgregarProducto.Click += new System.EventHandler(this.BAgregarProducto_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBDni);
            this.panel1.Controls.Add(this.TBTelefono);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.TBCliente);
            this.panel1.Controls.Add(this.LCLiente);
            this.panel1.Controls.Add(this.BAgregarProducto);
            this.panel1.Location = new System.Drawing.Point(396, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 162);
            this.panel1.TabIndex = 8;
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(17, 439);
            this.BCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(88, 30);
            this.BCancelar.TabIndex = 9;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BCobrar
            // 
            this.BCobrar.Location = new System.Drawing.Point(134, 439);
            this.BCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.BCobrar.Name = "BCobrar";
            this.BCobrar.Size = new System.Drawing.Size(88, 30);
            this.BCobrar.TabIndex = 10;
            this.BCobrar.Text = "Cobrar";
            this.BCobrar.UseVisualStyleBackColor = true;
            this.BCobrar.Click += new System.EventHandler(this.BCobrar_Click);
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(499, 450);
            this.LTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(43, 17);
            this.LTotal.TabIndex = 11;
            this.LTotal.Text = "TOTAL";
            // 
            // TBTotal
            // 
            this.TBTotal.Location = new System.Drawing.Point(568, 442);
            this.TBTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(116, 25);
            this.TBTotal.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Text = "Eliminar";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unit.";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // NombreJoya
            // 
            this.NombreJoya.HeaderText = "Nombre Joya";
            this.NombreJoya.Name = "NombreJoya";
            // 
            // Id
            // 
            this.Id.HeaderText = "IdVenta";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreJoya,
            this.PrecioUnitario,
            this.Cantidad,
            this.SubTotal,
            this.colEliminar});
            this.dataGridProducto.Location = new System.Drawing.Point(0, 253);
            this.dataGridProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridProducto.MultiSelect = false;
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridProducto.RowHeadersVisible = false;
            this.dataGridProducto.Size = new System.Drawing.Size(863, 155);
            this.dataGridProducto.TabIndex = 7;
            // 
            // FormRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 490);
            this.Controls.Add(this.TBTotal);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.BCobrar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridProducto);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistroVentas";
            this.Text = "Registro de venta";
            this.Load += new System.EventHandler(this.FormRegistrarVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCLiente;
        private System.Windows.Forms.TextBox TBCliente;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Button BAgregarProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BCobrar;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.TextBox TBTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.DataGridView dataGridProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreJoya;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
    }
}