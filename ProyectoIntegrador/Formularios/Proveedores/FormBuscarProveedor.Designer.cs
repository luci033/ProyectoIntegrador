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
            this.LTitulo = new System.Windows.Forms.Label();
            this.DGProveedores = new System.Windows.Forms.DataGridView();
            this.colRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCancelar = new System.Windows.Forms.Button();
            this.TBBuscarProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(24, 25);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(387, 38);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Seleccionar Proveedor";
            this.LTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGProveedores
            // 
            this.DGProveedores.AllowUserToAddRows = false;
            this.DGProveedores.AllowUserToDeleteRows = false;
            this.DGProveedores.AllowUserToResizeColumns = false;
            this.DGProveedores.AllowUserToResizeRows = false;
            this.DGProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRazonSocial,
            this.colCUIT,
            this.colTelefono,
            this.colCorreo});
            this.DGProveedores.Location = new System.Drawing.Point(12, 126);
            this.DGProveedores.Name = "DGProveedores";
            this.DGProveedores.ReadOnly = true;
            this.DGProveedores.RowHeadersVisible = false;
            this.DGProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProveedores.Size = new System.Drawing.Size(752, 240);
            this.DGProveedores.TabIndex = 1;
            this.DGProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProveedores_CellDoubleClick);
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.FillWeight = 35F;
            this.colRazonSocial.HeaderText = "Razón Social";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.ReadOnly = true;
            // 
            // colCUIT
            // 
            this.colCUIT.FillWeight = 20F;
            this.colCUIT.HeaderText = "CUIT";
            this.colCUIT.Name = "colCUIT";
            this.colCUIT.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.FillWeight = 20F;
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colCorreo
            // 
            this.colCorreo.FillWeight = 25F;
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            // 
            // BCancelar
            // 
            this.BCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Location = new System.Drawing.Point(616, 396);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(160, 42);
            this.BCancelar.TabIndex = 2;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // TBBuscarProveedor
            // 
            this.TBBuscarProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBBuscarProveedor.Location = new System.Drawing.Point(86, 82);
            this.TBBuscarProveedor.Name = "TBBuscarProveedor";
            this.TBBuscarProveedor.Size = new System.Drawing.Size(205, 25);
            this.TBBuscarProveedor.TabIndex = 22;
            this.TBBuscarProveedor.TextChanged += new System.EventHandler(this.TBBuscarProducto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Buscar:";
            // 
            // FormBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBBuscarProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.DGProveedores);
            this.Controls.Add(this.LTitulo);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "FormBuscarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Proveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBuscarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.DataGridView DGProveedores;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.TextBox TBBuscarProveedor;
        private System.Windows.Forms.Label label1;
    }
}