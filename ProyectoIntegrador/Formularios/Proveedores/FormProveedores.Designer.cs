namespace ProyectoIntegrador.Formularios.Proveedores
{
    partial class FormProveedores
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
            this.LProveedores = new System.Windows.Forms.Label();
            this.BAgregarProveedor = new System.Windows.Forms.Button();
            this.DGProveedores = new System.Windows.Forms.DataGridView();
            this.ProveedoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProveedorDesactivar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // LProveedores
            // 
            this.LProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LProveedores.AutoSize = true;
            this.LProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProveedores.Location = new System.Drawing.Point(12, 59);
            this.LProveedores.Name = "LProveedores";
            this.LProveedores.Size = new System.Drawing.Size(444, 42);
            this.LProveedores.TabIndex = 6;
            this.LProveedores.Text = "Gestión de Proveedores";
            this.LProveedores.Click += new System.EventHandler(this.LProveedores_Click);
            // 
            // BAgregarProveedor
            // 
            this.BAgregarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAgregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarProveedor.Location = new System.Drawing.Point(525, 30);
            this.BAgregarProveedor.Name = "BAgregarProveedor";
            this.BAgregarProveedor.Size = new System.Drawing.Size(215, 91);
            this.BAgregarProveedor.TabIndex = 5;
            this.BAgregarProveedor.Text = "Agregar Proveedor";
            this.BAgregarProveedor.UseVisualStyleBackColor = true;
            this.BAgregarProveedor.Click += new System.EventHandler(this.BAgregarProveedor_Click);
            // 
            // DGProveedores
            // 
            this.DGProveedores.AllowUserToAddRows = false;
            this.DGProveedores.AllowUserToDeleteRows = false;
            this.DGProveedores.AllowUserToResizeColumns = false;
            this.DGProveedores.AllowUserToResizeRows = false;
            this.DGProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProveedoNombre,
            this.CUIT,
            this.telefono,
            this.correo,
            this.ProveedorModificar,
            this.ProveedorDesactivar});
            this.DGProveedores.Location = new System.Drawing.Point(12, 169);
            this.DGProveedores.Name = "DGProveedores";
            this.DGProveedores.ReadOnly = true;
            this.DGProveedores.RowHeadersVisible = false;
            this.DGProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProveedores.Size = new System.Drawing.Size(776, 252);
            this.DGProveedores.TabIndex = 4;
            this.DGProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProveedores_CellContentClick);
            // 
            // ProveedoNombre
            // 
            this.ProveedoNombre.FillWeight = 60F;
            this.ProveedoNombre.HeaderText = "Razón Social";
            this.ProveedoNombre.Name = "ProveedoNombre";
            this.ProveedoNombre.ReadOnly = true;
            // 
            // CUIT
            // 
            this.CUIT.FillWeight = 40F;
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.FillWeight = 40F;
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.FillWeight = 45F;
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // ProveedorModificar
            // 
            this.ProveedorModificar.FillWeight = 20F;
            this.ProveedorModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProveedorModificar.HeaderText = "Modificar";
            this.ProveedorModificar.Name = "ProveedorModificar";
            this.ProveedorModificar.ReadOnly = true;
            this.ProveedorModificar.Text = "Editar";
            // 
            // ProveedorDesactivar
            // 
            this.ProveedorDesactivar.FillWeight = 20F;
            this.ProveedorDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProveedorDesactivar.HeaderText = "Desactivar";
            this.ProveedorDesactivar.Name = "ProveedorDesactivar";
            this.ProveedorDesactivar.ReadOnly = true;
            this.ProveedorDesactivar.Text = "Desactivar";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LProveedores);
            this.Controls.Add(this.BAgregarProveedor);
            this.Controls.Add(this.DGProveedores);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.DGProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LProveedores;
        private System.Windows.Forms.Button BAgregarProveedor;
        private System.Windows.Forms.DataGridView DGProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewButtonColumn ProveedorModificar;
        private System.Windows.Forms.DataGridViewButtonColumn ProveedorDesactivar;
    }
}