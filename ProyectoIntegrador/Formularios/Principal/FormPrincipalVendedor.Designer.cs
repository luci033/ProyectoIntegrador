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
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.LTituloAlba = new System.Windows.Forms.Label();
            this.LSubtituloVendedor = new System.Windows.Forms.Label();
            this.panelSeparador = new System.Windows.Forms.Panel();
            this.LSeccion = new System.Windows.Forms.Label();
            this.BProductos = new System.Windows.Forms.Button();
            this.BVentas = new System.Windows.Forms.Button();
            this.BDevoluciones = new System.Windows.Forms.Button();
            this.BClientes = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.BCerrarSesion = new System.Windows.Forms.Button();
            this.LFooter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.panel1.Controls.Add(this.PBLogo);
            this.panel1.Controls.Add(this.LTituloAlba);
            this.panel1.Controls.Add(this.LSubtituloVendedor);
            this.panel1.Controls.Add(this.panelSeparador);
            this.panel1.Controls.Add(this.LSeccion);
            this.panel1.Controls.Add(this.BProductos);
            this.panel1.Controls.Add(this.BVentas);
            this.panel1.Controls.Add(this.BDevoluciones);
            this.panel1.Controls.Add(this.BClientes);
            this.panel1.Controls.Add(this.panelFooter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 680);
            this.panel1.TabIndex = 3;
            // 
            // PBLogo
            // 
            this.PBLogo.BackColor = System.Drawing.Color.Transparent;
            this.PBLogo.Image = global::ProyectoIntegrador.Properties.Resources.diamante; // Asegúrate de tener este recurso o coméntalo si no existe
            this.PBLogo.Location = new System.Drawing.Point(98, 16);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(44, 44);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 0;
            this.PBLogo.TabStop = false;
            // 
            // LTituloAlba
            // 
            this.LTituloAlba.BackColor = System.Drawing.Color.Transparent;
            this.LTituloAlba.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAlba.ForeColor = System.Drawing.Color.White;
            this.LTituloAlba.Location = new System.Drawing.Point(15, 64);
            this.LTituloAlba.Name = "LTituloAlba";
            this.LTituloAlba.Size = new System.Drawing.Size(210, 24);
            this.LTituloAlba.TabIndex = 1;
            this.LTituloAlba.Text = "Joyería ALBA";
            this.LTituloAlba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSubtituloVendedor
            // 
            this.LSubtituloVendedor.BackColor = System.Drawing.Color.Transparent;
            this.LSubtituloVendedor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtituloVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(204)))), ((int)(((byte)(194)))));
            this.LSubtituloVendedor.Location = new System.Drawing.Point(15, 90);
            this.LSubtituloVendedor.Name = "LSubtituloVendedor";
            this.LSubtituloVendedor.Size = new System.Drawing.Size(210, 18);
            this.LSubtituloVendedor.TabIndex = 2;
            this.LSubtituloVendedor.Text = "MÓDULO VENDEDOR";
            this.LSubtituloVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSeparador
            // 
            this.panelSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panelSeparador.Location = new System.Drawing.Point(25, 114);
            this.panelSeparador.Name = "panelSeparador";
            this.panelSeparador.Size = new System.Drawing.Size(190, 1);
            this.panelSeparador.TabIndex = 3;
            // 
            // LSeccion
            // 
            this.LSeccion.BackColor = System.Drawing.Color.Transparent;
            this.LSeccion.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.LSeccion.Location = new System.Drawing.Point(25, 122);
            this.LSeccion.Name = "LSeccion";
            this.LSeccion.Size = new System.Drawing.Size(190, 16);
            this.LSeccion.TabIndex = 4;
            this.LSeccion.Text = "MÓDULOS DE GESTIÓN";
            this.LSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BProductos
            // 
            this.BProductos.BackColor = System.Drawing.Color.Transparent;
            this.BProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BProductos.BackgroundImage")));
            this.BProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BProductos.FlatAppearance.BorderSize = 0;
            this.BProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProductos.ForeColor = System.Drawing.Color.Transparent;
            this.BProductos.Location = new System.Drawing.Point(62, 134);
            this.BProductos.Name = "BProductos";
            this.BProductos.Size = new System.Drawing.Size(116, 116);
            this.BProductos.TabIndex = 1;
            this.BProductos.UseVisualStyleBackColor = false;
            this.BProductos.Click += new System.EventHandler(this.BProductos_Click);
            // 
            // BVentas
            // 
            this.BVentas.BackColor = System.Drawing.Color.Transparent;
            this.BVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BVentas.BackgroundImage")));
            this.BVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVentas.FlatAppearance.BorderSize = 0;
            this.BVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVentas.ForeColor = System.Drawing.Color.Transparent;
            this.BVentas.Location = new System.Drawing.Point(62, 260);
            this.BVentas.Name = "BVentas";
            this.BVentas.Size = new System.Drawing.Size(116, 116);
            this.BVentas.TabIndex = 2;
            this.BVentas.UseVisualStyleBackColor = false;
            this.BVentas.Click += new System.EventHandler(this.BVentas_Click);
            // 
            // BDevoluciones
            // 
            this.BDevoluciones.BackColor = System.Drawing.Color.Transparent;
            this.BDevoluciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BDevoluciones.BackgroundImage")));
            this.BDevoluciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BDevoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDevoluciones.FlatAppearance.BorderSize = 0;
            this.BDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDevoluciones.ForeColor = System.Drawing.Color.Transparent;
            this.BDevoluciones.Location = new System.Drawing.Point(62, 386);
            this.BDevoluciones.Name = "BDevoluciones";
            this.BDevoluciones.Size = new System.Drawing.Size(116, 116);
            this.BDevoluciones.TabIndex = 3;
            this.BDevoluciones.UseVisualStyleBackColor = false;
            this.BDevoluciones.Click += new System.EventHandler(this.BDevoluciones_Click);
            // 
            // BClientes
            // 
            this.BClientes.BackColor = System.Drawing.Color.Transparent;
            this.BClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BClientes.BackgroundImage")));
            this.BClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BClientes.FlatAppearance.BorderSize = 0;
            this.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClientes.ForeColor = System.Drawing.Color.Transparent;
            this.BClientes.Location = new System.Drawing.Point(62, 512);
            this.BClientes.Name = "BClientes";
            this.BClientes.Size = new System.Drawing.Size(116, 116);
            this.BClientes.TabIndex = 4;
            this.BClientes.UseVisualStyleBackColor = false;
            this.BClientes.Click += new System.EventHandler(this.BClientes_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(9)))));
            this.panelFooter.Controls.Add(this.BCerrarSesion);
            this.panelFooter.Controls.Add(this.LFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 592);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(240, 88);
            this.panelFooter.TabIndex = 5;
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.BCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.BCerrarSesion.Location = new System.Drawing.Point(15, 10);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(210, 38);
            this.BCerrarSesion.TabIndex = 1;
            this.BCerrarSesion.Text = "🚪  Cerrar Sesión";
            this.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BCerrarSesion.UseVisualStyleBackColor = false;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click);
            // 
            // LFooter
            // 
            this.LFooter.BackColor = System.Drawing.Color.Transparent;
            this.LFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(180)))), ((int)(((byte)(165)))));
            this.LFooter.Location = new System.Drawing.Point(0, 52);
            this.LFooter.Name = "LFooter";
            this.LFooter.Size = new System.Drawing.Size(240, 30);
            this.LFooter.TabIndex = 0;
            this.LFooter.Text = "Sesión activa: Vendedor";
            this.LFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipalVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipalVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joyería ALBA - Vendedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipalVendedor_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipalVendedor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label LTituloAlba;
        private System.Windows.Forms.Label LSubtituloVendedor;
        private System.Windows.Forms.Panel panelSeparador;
        private System.Windows.Forms.Label LSeccion;
        private System.Windows.Forms.Button BProductos;
        private System.Windows.Forms.Button BVentas;
        private System.Windows.Forms.Button BDevoluciones;
        private System.Windows.Forms.Button BClientes;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button BCerrarSesion;
        private System.Windows.Forms.Label LFooter;
    }
}