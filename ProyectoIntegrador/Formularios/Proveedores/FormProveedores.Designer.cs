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
            this.LTitulo = new System.Windows.Forms.Label();
            this.BAgregarProveedor = new System.Windows.Forms.Button();
            this.DGProveedores = new System.Windows.Forms.DataGridView();
            this.coIdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProveedorDesactivar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(24, 25);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(423, 38);
            this.LTitulo.TabIndex = 6;
            this.LTitulo.Text = "Gestión de Proveedores";
            this.LTitulo.Click += new System.EventHandler(this.LProveedores_Click);
            // 
            // BAgregarProveedor
            // 
            this.BAgregarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BAgregarProveedor.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarProveedor.Location = new System.Drawing.Point(576, 24);
            this.BAgregarProveedor.Name = "BAgregarProveedor";
            this.BAgregarProveedor.Size = new System.Drawing.Size(200, 44);
            this.BAgregarProveedor.TabIndex = 5;
            this.BAgregarProveedor.Text = "+ Agregar Proveedor";
            this.BAgregarProveedor.UseVisualStyleBackColor = true;
            this.BAgregarProveedor.Click += new System.EventHandler(this.BAgregarProveedor_Click);
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
            this.coIdProveedor,
            this.ProveedoNombre,
            this.CUIT,
            this.telefono,
            this.correo,
            this.ProveedorModificar,
            this.ProveedorDesactivar});
            this.DGProveedores.Location = new System.Drawing.Point(24, 85);
            this.DGProveedores.Name = "DGProveedores";
            this.DGProveedores.ReadOnly = true;
            this.DGProveedores.RowHeadersVisible = false;
            this.DGProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProveedores.Size = new System.Drawing.Size(752, 335);
            this.DGProveedores.TabIndex = 4;
            this.DGProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGProveedores_CellContentClick);
            // 
            // coIdProveedor
            // 
            this.coIdProveedor.HeaderText = "idProveedor";
            this.coIdProveedor.Name = "coIdProveedor";
            this.coIdProveedor.ReadOnly = true;
            this.coIdProveedor.Visible = false;
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
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.BAgregarProveedor);
            this.Controls.Add(this.DGProveedores);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button BAgregarProveedor;
        private System.Windows.Forms.DataGridView DGProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn coIdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewButtonColumn ProveedorModificar;
        private System.Windows.Forms.DataGridViewButtonColumn ProveedorDesactivar;
    }
}