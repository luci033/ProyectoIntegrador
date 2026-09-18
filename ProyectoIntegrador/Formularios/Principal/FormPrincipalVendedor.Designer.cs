namespace ProyectoIntegrador.Formularios.Principal
{
    partial class FormPrincipalVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalVendedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BClientes = new System.Windows.Forms.Button();
            this.BDevoluciones = new System.Windows.Forms.Button();
            this.BVentas = new System.Windows.Forms.Button();
            this.BProductos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BClientes);
            this.panel1.Controls.Add(this.BDevoluciones);
            this.panel1.Controls.Add(this.BVentas);
            this.panel1.Controls.Add(this.BProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 634);
            this.panel1.TabIndex = 3;
            // 
            // BClientes
            // 
            this.BClientes.BackColor = System.Drawing.Color.Transparent;
            this.BClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BClientes.BackgroundImage")));
            this.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClientes.ForeColor = System.Drawing.Color.Transparent;
            this.BClientes.Location = new System.Drawing.Point(42, 530);
            this.BClientes.Name = "BClientes";
            this.BClientes.Size = new System.Drawing.Size(100, 100);
            this.BClientes.TabIndex = 3;
            this.BClientes.UseVisualStyleBackColor = false;
            this.BClientes.Click += new System.EventHandler(this.BClientes_Click);
            // 
            // BDevoluciones
            // 
            this.BDevoluciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BDevoluciones.BackgroundImage")));
            this.BDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDevoluciones.ForeColor = System.Drawing.Color.Transparent;
            this.BDevoluciones.Location = new System.Drawing.Point(42, 362);
            this.BDevoluciones.Name = "BDevoluciones";
            this.BDevoluciones.Size = new System.Drawing.Size(100, 100);
            this.BDevoluciones.TabIndex = 2;
            this.BDevoluciones.UseVisualStyleBackColor = true;
            this.BDevoluciones.Click += new System.EventHandler(this.BDevoluciones_Click);
            // 
            // BVentas
            // 
            this.BVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BVentas.BackgroundImage")));
            this.BVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVentas.ForeColor = System.Drawing.Color.Transparent;
            this.BVentas.Location = new System.Drawing.Point(42, 192);
            this.BVentas.Name = "BVentas";
            this.BVentas.Size = new System.Drawing.Size(100, 100);
            this.BVentas.TabIndex = 1;
            this.BVentas.UseVisualStyleBackColor = true;
            this.BVentas.Click += new System.EventHandler(this.BVentas_Click);
            // 
            // BProductos
            // 
            this.BProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BProductos.BackgroundImage")));
            this.BProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProductos.ForeColor = System.Drawing.Color.Transparent;
            this.BProductos.Location = new System.Drawing.Point(42, 22);
            this.BProductos.Name = "BProductos";
            this.BProductos.Size = new System.Drawing.Size(100, 100);
            this.BProductos.TabIndex = 0;
            this.BProductos.UseVisualStyleBackColor = true;
            this.BProductos.Click += new System.EventHandler(this.BProductos_Click);
            // 
            // FormPrincipalVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipalVendedor";
            this.Text = "FormPrincipalVendedor";
            this.Load += new System.EventHandler(this.s);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BClientes;
        private System.Windows.Forms.Button BDevoluciones;
        private System.Windows.Forms.Button BVentas;
        private System.Windows.Forms.Button BProductos;
    }
}