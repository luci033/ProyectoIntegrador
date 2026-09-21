namespace ProyectoIntegrador.Formularios.Clientes
{
    partial class FormBuscarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.CBCondiciónIVA = new System.Windows.Forms.ComboBox();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LCondiciónIVA = new System.Windows.Forms.Label();
            this.LBucar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGClientes);
            this.panel1.Location = new System.Drawing.Point(5, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 154);
            this.panel1.TabIndex = 1;
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
            this.DGClientes.Location = new System.Drawing.Point(28, 25);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.ReadOnly = true;
            this.DGClientes.RowHeadersVisible = false;
            this.DGClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientes.Size = new System.Drawing.Size(696, 113);
            this.DGClientes.TabIndex = 3;
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
            this.colHistorial.Visible = false;
            // 
            // colModificar
            // 
            this.colModificar.FillWeight = 45F;
            this.colModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colModificar.HeaderText = "Modificar";
            this.colModificar.Name = "colModificar";
            this.colModificar.ReadOnly = true;
            this.colModificar.Text = "Modificar";
            this.colModificar.Visible = false;
            // 
            // CBCondiciónIVA
            // 
            this.CBCondiciónIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCondiciónIVA.FormattingEnabled = true;
            this.CBCondiciónIVA.Location = new System.Drawing.Point(554, 10);
            this.CBCondiciónIVA.Name = "CBCondiciónIVA";
            this.CBCondiciónIVA.Size = new System.Drawing.Size(121, 21);
            this.CBCondiciónIVA.TabIndex = 1;
            this.CBCondiciónIVA.SelectedIndexChanged += new System.EventHandler(this.CBCondiciónIVA_SelectedIndexChanged);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(71, 7);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(100, 20);
            this.TBBuscar.TabIndex = 2;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBuscar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LCondiciónIVA);
            this.panel2.Controls.Add(this.LBucar);
            this.panel2.Controls.Add(this.TBBuscar);
            this.panel2.Controls.Add(this.CBCondiciónIVA);
            this.panel2.Location = new System.Drawing.Point(33, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 44);
            this.panel2.TabIndex = 2;
            // 
            // LCondiciónIVA
            // 
            this.LCondiciónIVA.AutoSize = true;
            this.LCondiciónIVA.Location = new System.Drawing.Point(471, 14);
            this.LCondiciónIVA.Name = "LCondiciónIVA";
            this.LCondiciónIVA.Size = new System.Drawing.Size(77, 13);
            this.LCondiciónIVA.TabIndex = 6;
            this.LCondiciónIVA.Text = "Condición IVA:";
            // 
            // LBucar
            // 
            this.LBucar.AutoSize = true;
            this.LBucar.Location = new System.Drawing.Point(18, 10);
            this.LBucar.Name = "LBucar";
            this.LBucar.Size = new System.Drawing.Size(43, 13);
            this.LBucar.TabIndex = 4;
            this.LBucar.Text = "Buscar:";
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormBuscarCliente";
            this.Text = "FormBuscarCliente";
            this.Load += new System.EventHandler(this.FormBuscarCliente_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBCondiciónIVA;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBucar;
        private System.Windows.Forms.Label LCondiciónIVA;
        private System.Windows.Forms.DataGridView DGClientes;
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
    }
}