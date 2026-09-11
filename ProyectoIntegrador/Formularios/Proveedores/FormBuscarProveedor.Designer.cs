namespace ProyectoIntegrador.Formularios.Compras
{
    partial class FormBuscarProveedor
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
            this.LSeleccionarProveedor = new System.Windows.Forms.Label();
            this.DGProveedores = new System.Windows.Forms.DataGridView();
            this.colRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // LSeleccionarProveedor
            // 
            this.LSeleccionarProveedor.AutoSize = true;
            this.LSeleccionarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSeleccionarProveedor.Location = new System.Drawing.Point(123, 72);
            this.LSeleccionarProveedor.Name = "LSeleccionarProveedor";
            this.LSeleccionarProveedor.Size = new System.Drawing.Size(532, 55);
            this.LSeleccionarProveedor.TabIndex = 0;
            this.LSeleccionarProveedor.Text = "Seleccionar Proveedor";
            this.LSeleccionarProveedor.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGProveedores
            // 
            this.DGProveedores.AllowUserToAddRows = false;
            this.DGProveedores.AllowUserToDeleteRows = false;
            this.DGProveedores.AllowUserToResizeColumns = false;
            this.DGProveedores.AllowUserToResizeRows = false;
            this.DGProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRazonSocial,
            this.colCUIT,
            this.colTelefono,
            this.colCorreo});
            this.DGProveedores.Location = new System.Drawing.Point(12, 181);
            this.DGProveedores.Name = "DGProveedores";
            this.DGProveedores.ReadOnly = true;
            this.DGProveedores.RowHeadersVisible = false;
            this.DGProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProveedores.Size = new System.Drawing.Size(776, 207);
            this.DGProveedores.TabIndex = 1;
            this.DGProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProveedores_CellContentClick);
            this.DGProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProveedores_CellDoubleClick);
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.HeaderText = "Razón Social";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.ReadOnly = true;
            // 
            // colCUIT
            // 
            this.colCUIT.FillWeight = 70F;
            this.colCUIT.HeaderText = "CUIT";
            this.colCUIT.Name = "colCUIT";
            this.colCUIT.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.FillWeight = 50F;
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(692, 406);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(96, 32);
            this.BCancelar.TabIndex = 2;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // FormBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.DGProveedores);
            this.Controls.Add(this.LSeleccionarProveedor);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormBuscarProveedor";
            this.Text = "Seleccionar Proveedor";
            this.Load += new System.EventHandler(this.FormBuscarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LSeleccionarProveedor;
        private System.Windows.Forms.DataGridView DGProveedores;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
    }
}