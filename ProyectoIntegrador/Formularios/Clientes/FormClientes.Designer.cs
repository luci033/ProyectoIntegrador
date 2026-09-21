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
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDniCUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicionIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistorial = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LCondiciónIVA = new System.Windows.Forms.Label();
            this.LBucar = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.CBCondiciónIVA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BNuevoCliente
            // 
            this.BNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNuevoCliente.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevoCliente.Location = new System.Drawing.Point(592, 24);
            this.BNuevoCliente.Name = "BNuevoCliente";
            this.BNuevoCliente.Size = new System.Drawing.Size(200, 44);
            this.BNuevoCliente.TabIndex = 1;
            this.BNuevoCliente.Text = "+ Nuevo Cliente";
            this.BNuevoCliente.UseVisualStyleBackColor = true;
            this.BNuevoCliente.Click += new System.EventHandler(this.BNuevoCliente_Click);
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.AllowUserToDeleteRows = false;
            this.DGClientes.AllowUserToResizeColumns = false;
            this.DGClientes.AllowUserToResizeRows = false;
            this.DGClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.colNro,
            this.colNombre,
            this.colApellido,
            this.colDniCUIT,
            this.colTelefono,
            this.colCorreo,
            this.colCondicionIVA,
            this.colHistorial,
            this.colModificar});
            this.DGClientes.BackgroundColor = System.Drawing.Color.White;
            this.DGClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGClientes.Location = new System.Drawing.Point(12, 12);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.ReadOnly = true;
            this.DGClientes.RowHeadersVisible = false;
            this.DGClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientes.Size = new System.Drawing.Size(744, 376);
            this.DGClientes.TabIndex = 2;
            this.DGClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHistorialClientes_CellContentClick);
            this.DGClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGClientes_CellDoubleClick);
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
            this.colNro.FillWeight = 25F;
            this.colNro.HeaderText = "Nro";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 70F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.FillWeight = 70F;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colDniCUIT
            // 
            this.colDniCUIT.FillWeight = 55F;
            this.colDniCUIT.HeaderText = "DNI/CUIT";
            this.colDniCUIT.Name = "colDniCUIT";
            this.colDniCUIT.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.FillWeight = 55F;
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colCorreo
            // 
            this.colCorreo.FillWeight = 90F;
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            // 
            // colCondicionIVA
            // 
            this.colCondicionIVA.FillWeight = 70F;
            this.colCondicionIVA.HeaderText = "Condición IVA";
            this.colCondicionIVA.Name = "colCondicionIVA";
            this.colCondicionIVA.ReadOnly = true;
            // 
            // colHistorial
            // 
            this.colHistorial.FillWeight = 40F;
            this.colHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colHistorial.HeaderText = "Historial";
            this.colHistorial.Name = "colHistorial";
            this.colHistorial.ReadOnly = true;
            this.colHistorial.Text = "Ver...";
            // 
            // colModificar
            // 
            this.colModificar.FillWeight = 45F;
            this.colModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colModificar.HeaderText = "Modificar";
            this.colModificar.Name = "colModificar";
            this.colModificar.ReadOnly = true;
            this.colModificar.Text = "Modificar";
            // 
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(24, 25);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(330, 38);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Gestión de Clientes";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DGClientes);
            this.panel1.Location = new System.Drawing.Point(24, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 400);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LCondiciónIVA);
            this.panel2.Controls.Add(this.LBucar);
            this.panel2.Controls.Add(this.TBBuscar);
            this.panel2.Controls.Add(this.CBCondiciónIVA);
            this.panel2.Location = new System.Drawing.Point(24, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 48);
            this.panel2.TabIndex = 4;
            // 
            // LCondiciónIVA
            // 
            this.LCondiciónIVA.AutoSize = true;
            this.LCondiciónIVA.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LCondiciónIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCondiciónIVA.Location = new System.Drawing.Point(320, 14);
            this.LCondiciónIVA.Name = "LCondiciónIVA";
            this.LCondiciónIVA.Size = new System.Drawing.Size(100, 17);
            this.LCondiciónIVA.TabIndex = 6;
            this.LCondiciónIVA.Text = "Condición IVA:";
            // 
            // LBucar
            // 
            this.LBucar.AutoSize = true;
            this.LBucar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LBucar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LBucar.Location = new System.Drawing.Point(15, 14);
            this.LBucar.Name = "LBucar";
            this.LBucar.Size = new System.Drawing.Size(53, 17);
            this.LBucar.TabIndex = 4;
            this.LBucar.Text = "Buscar:";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBBuscar.Location = new System.Drawing.Point(74, 11);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(220, 25);
            this.TBBuscar.TabIndex = 2;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBuscar_TextChanged);
            // 
            // CBCondiciónIVA
            // 
            this.CBCondiciónIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCondiciónIVA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.CBCondiciónIVA.FormattingEnabled = true;
            this.CBCondiciónIVA.Location = new System.Drawing.Point(428, 11);
            this.CBCondiciónIVA.Name = "CBCondiciónIVA";
            this.CBCondiciónIVA.Size = new System.Drawing.Size(180, 25);
            this.CBCondiciónIVA.TabIndex = 1;
            this.CBCondiciónIVA.SelectedIndexChanged += new System.EventHandler(this.CBCondiciónIVA_SelectedIndexChanged);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(816, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.BNuevoCliente);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colDniCUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicionIVA;
        private System.Windows.Forms.DataGridViewButtonColumn colHistorial;
        private System.Windows.Forms.DataGridViewButtonColumn colModificar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LCondiciónIVA;
        private System.Windows.Forms.Label LBucar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.ComboBox CBCondiciónIVA;
    }
}