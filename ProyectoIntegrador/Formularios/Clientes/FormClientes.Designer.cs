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
            this.dataGridHistorialClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistorial = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorialClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BNuevoCliente
            // 
            this.BNuevoCliente.Location = new System.Drawing.Point(483, 60);
            this.BNuevoCliente.Name = "BNuevoCliente";
            this.BNuevoCliente.Size = new System.Drawing.Size(121, 51);
            this.BNuevoCliente.TabIndex = 1;
            this.BNuevoCliente.Text = "Nuevo Cliente";
            this.BNuevoCliente.UseVisualStyleBackColor = true;
            this.BNuevoCliente.Click += new System.EventHandler(this.BNuevoCliente_Click);
            // 
            // dataGridHistorialClientes
            // 
            this.dataGridHistorialClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridHistorialClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistorialClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorialClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.colNro,
            this.colNombre,
            this.colApellido,
            this.colDni,
            this.colCorreo,
            this.colHistorial,
            this.colModificar});
            this.dataGridHistorialClientes.Location = new System.Drawing.Point(2, 217);
            this.dataGridHistorialClientes.Name = "dataGridHistorialClientes";
            this.dataGridHistorialClientes.RowHeadersVisible = false;
            this.dataGridHistorialClientes.Size = new System.Drawing.Size(748, 154);
            this.dataGridHistorialClientes.TabIndex = 2;
            this.dataGridHistorialClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHistorialClientes_CellContentClick);
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
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(751, 383);
            this.Controls.Add(this.dataGridHistorialClientes);
            this.Controls.Add(this.BNuevoCliente);
            this.Name = "FormClientes";
            this.Text = "Gestión de Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorialClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BNuevoCliente;
        private System.Windows.Forms.DataGridView dataGridHistorialClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewButtonColumn colHistorial;
        private System.Windows.Forms.DataGridViewButtonColumn colModificar;
    }
}