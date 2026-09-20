namespace ProyectoIntegrador.Formularios.Clientes
{
    partial class FormClientes
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
            this.BNuevoCliente = new System.Windows.Forms.Button();
            this.DGClientes = new System.Windows.Forms.DataGridView();
            this.LTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicionIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistorial = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BNuevoCliente
            // 
            this.BNuevoCliente.Location = new System.Drawing.Point(548, 96);
            this.BNuevoCliente.Name = "BNuevoCliente";
            this.BNuevoCliente.Size = new System.Drawing.Size(169, 45);
            this.BNuevoCliente.TabIndex = 1;
            this.BNuevoCliente.Text = "Nuevo Cliente";
            this.BNuevoCliente.UseVisualStyleBackColor = true;
            this.BNuevoCliente.Click += new System.EventHandler(this.BNuevoCliente_Click);
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.AllowUserToDeleteRows = false;
            this.DGClientes.AllowUserToOrderColumns = true;
            this.DGClientes.AllowUserToResizeColumns = false;
            this.DGClientes.AllowUserToResizeRows = false;
            this.DGClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.colNro,
            this.colNombre,
            this.colApellido,
            this.colDni,
            this.colTelefono,
            this.colCorreo,
            this.colCondicionIVA,
            this.colHistorial,
            this.colModificar});
            this.DGClientes.Location = new System.Drawing.Point(3, 3);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.RowHeadersVisible = false;
            this.DGClientes.Size = new System.Drawing.Size(810, 211);
            this.DGClientes.TabIndex = 2;
            this.DGClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHistorialClientes_CellContentClick);
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Location = new System.Drawing.Point(46, 68);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(98, 13);
            this.LTitulo.TabIndex = 3;
            this.LTitulo.Text = "Gestión de Clientes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 217);
            this.panel1.TabIndex = 4;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IDCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            // 
            // colNro
            // 
            this.colNro.FillWeight = 30F;
            this.colNro.HeaderText = "Nro";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colDni
            // 
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            this.colDni.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            // 
            // colCondicionIVA
            // 
            this.colCondicionIVA.HeaderText = "Condicion IVA";
            this.colCondicionIVA.Name = "colCondicionIVA";
            // 
            // colHistorial
            // 
            this.colHistorial.HeaderText = "Historial";
            this.colHistorial.Name = "colHistorial";
            // 
            // colModificar
            // 
            this.colModificar.HeaderText = "Modificar";
            this.colModificar.Name = "colModificar";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.BNuevoCliente);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Gestión de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BNuevoCliente;
        private System.Windows.Forms.DataGridView DGClientes;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicionIVA;
        private System.Windows.Forms.DataGridViewButtonColumn colHistorial;
        private System.Windows.Forms.DataGridViewButtonColumn colModificar;
    }
}