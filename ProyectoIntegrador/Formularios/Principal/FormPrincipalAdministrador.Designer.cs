namespace ProyectoIntegrador.Formularios.Principal
{
    partial class FormPrincipalAdministrador
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
            this.components = new System.ComponentModel.Container();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelContenedorBotones = new System.Windows.Forms.Panel();
            this.BUsuarios = new System.Windows.Forms.Button();
            this.BProductos = new System.Windows.Forms.Button();
            this.BVentas = new System.Windows.Forms.Button();
            this.BDevoluciones = new System.Windows.Forms.Button();
            this.BCompras = new System.Windows.Forms.Button();
            this.BProveedores = new System.Windows.Forms.Button();
            this.BClientes = new System.Windows.Forms.Button();
            this.BAjusteStock = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.LTituloAlba = new System.Windows.Forms.Label();
            this.LSubtituloAdmin = new System.Windows.Forms.Label();
            this.panelSeparador = new System.Windows.Forms.Panel();
            this.LSeccion = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.LFooter = new System.Windows.Forms.Label();
            this.menuContextProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemCatalogoProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGestionCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextVentas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemOpcionesVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGestionVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHistorialVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSidebar.SuspendLayout();
            this.panelContenedorBotones.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.menuContextProductos.SuspendLayout();
            this.menuContextVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.panelSidebar.Controls.Add(this.panelContenedorBotones);
            this.panelSidebar.Controls.Add(this.panelFooter);
            this.panelSidebar.Controls.Add(this.panelHeader);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 720);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelContenedorBotones
            // 
            this.panelContenedorBotones.AutoScroll = true;
            this.panelContenedorBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedorBotones.Controls.Add(this.BUsuarios);
            this.panelContenedorBotones.Controls.Add(this.BProductos);
            this.panelContenedorBotones.Controls.Add(this.BVentas);
            this.panelContenedorBotones.Controls.Add(this.BDevoluciones);
            this.panelContenedorBotones.Controls.Add(this.BCompras);
            this.panelContenedorBotones.Controls.Add(this.BProveedores);
            this.panelContenedorBotones.Controls.Add(this.BClientes);
            this.panelContenedorBotones.Controls.Add(this.BAjusteStock);
            this.panelContenedorBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorBotones.Location = new System.Drawing.Point(0, 144);
            this.panelContenedorBotones.Name = "panelContenedorBotones";
            this.panelContenedorBotones.Size = new System.Drawing.Size(250, 532);
            this.panelContenedorBotones.TabIndex = 2;
            // 
            // BUsuarios
            // 
            this.BUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.BUsuarios.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_usuarios;
            this.BUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUsuarios.FlatAppearance.BorderSize = 0;
            this.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUsuarios.ForeColor = System.Drawing.Color.Transparent;
            this.BUsuarios.Location = new System.Drawing.Point(56, 10);
            this.BUsuarios.Name = "BUsuarios";
            this.BUsuarios.Size = new System.Drawing.Size(120, 120);
            this.BUsuarios.TabIndex = 0;
            this.BUsuarios.UseVisualStyleBackColor = false;
            this.BUsuarios.Click += new System.EventHandler(this.BUsuarios_Click);
            // 
            // BProductos
            // 
            this.BProductos.BackColor = System.Drawing.Color.Transparent;
            this.BProductos.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_productos;
            this.BProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BProductos.ContextMenuStrip = this.menuContextProductos;
            this.BProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BProductos.FlatAppearance.BorderSize = 0;
            this.BProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProductos.ForeColor = System.Drawing.Color.Transparent;
            this.BProductos.Location = new System.Drawing.Point(56, 138);
            this.BProductos.Name = "BProductos";
            this.BProductos.Size = new System.Drawing.Size(120, 120);
            this.BProductos.TabIndex = 1;
            this.BProductos.UseVisualStyleBackColor = false;
            this.BProductos.Click += new System.EventHandler(this.BProductos_Click);
            // 
            // BVentas
            // 
            this.BVentas.BackColor = System.Drawing.Color.Transparent;
            this.BVentas.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_ventas;
            this.BVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BVentas.ContextMenuStrip = this.menuContextVentas;
            this.BVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVentas.FlatAppearance.BorderSize = 0;
            this.BVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVentas.ForeColor = System.Drawing.Color.Transparent;
            this.BVentas.Location = new System.Drawing.Point(56, 266);
            this.BVentas.Name = "BVentas";
            this.BVentas.Size = new System.Drawing.Size(120, 120);
            this.BVentas.TabIndex = 2;
            this.BVentas.UseVisualStyleBackColor = false;
            this.BVentas.Click += new System.EventHandler(this.BVentas_Click);
            // 
            // BDevoluciones
            // 
            this.BDevoluciones.BackColor = System.Drawing.Color.Transparent;
            this.BDevoluciones.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_devoluciones;
            this.BDevoluciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BDevoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDevoluciones.FlatAppearance.BorderSize = 0;
            this.BDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDevoluciones.ForeColor = System.Drawing.Color.Transparent;
            this.BDevoluciones.Location = new System.Drawing.Point(56, 394);
            this.BDevoluciones.Name = "BDevoluciones";
            this.BDevoluciones.Size = new System.Drawing.Size(120, 120);
            this.BDevoluciones.TabIndex = 3;
            this.BDevoluciones.UseVisualStyleBackColor = false;
            this.BDevoluciones.Click += new System.EventHandler(this.BDevoluciones_Click);
            // 
            // BCompras
            // 
            this.BCompras.BackColor = System.Drawing.Color.Transparent;
            this.BCompras.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_compras;
            this.BCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCompras.FlatAppearance.BorderSize = 0;
            this.BCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCompras.ForeColor = System.Drawing.Color.Transparent;
            this.BCompras.Location = new System.Drawing.Point(56, 522);
            this.BCompras.Name = "BCompras";
            this.BCompras.Size = new System.Drawing.Size(120, 120);
            this.BCompras.TabIndex = 4;
            this.BCompras.UseVisualStyleBackColor = false;
            this.BCompras.Click += new System.EventHandler(this.BCompras_Click);
            // 
            // BProveedores
            // 
            this.BProveedores.BackColor = System.Drawing.Color.Transparent;
            this.BProveedores.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_proveedores;
            this.BProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BProveedores.FlatAppearance.BorderSize = 0;
            this.BProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProveedores.ForeColor = System.Drawing.Color.Transparent;
            this.BProveedores.Location = new System.Drawing.Point(56, 650);
            this.BProveedores.Name = "BProveedores";
            this.BProveedores.Size = new System.Drawing.Size(120, 120);
            this.BProveedores.TabIndex = 5;
            this.BProveedores.UseVisualStyleBackColor = false;
            this.BProveedores.Click += new System.EventHandler(this.BProveedores_Click);
            // 
            // BClientes
            // 
            this.BClientes.BackColor = System.Drawing.Color.Transparent;
            this.BClientes.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_clientes;
            this.BClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BClientes.FlatAppearance.BorderSize = 0;
            this.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClientes.ForeColor = System.Drawing.Color.Transparent;
            this.BClientes.Location = new System.Drawing.Point(56, 778);
            this.BClientes.Name = "BClientes";
            this.BClientes.Size = new System.Drawing.Size(120, 120);
            this.BClientes.TabIndex = 6;
            this.BClientes.UseVisualStyleBackColor = false;
            this.BClientes.Click += new System.EventHandler(this.BClientes_Click);
            // 
            // BAjusteStock
            // 
            this.BAjusteStock.BackColor = System.Drawing.Color.Transparent;
            this.BAjusteStock.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.boton_ajuste_stock;
            this.BAjusteStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BAjusteStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAjusteStock.FlatAppearance.BorderSize = 0;
            this.BAjusteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAjusteStock.ForeColor = System.Drawing.Color.Transparent;
            this.BAjusteStock.Location = new System.Drawing.Point(56, 906);
            this.BAjusteStock.Name = "BAjusteStock";
            this.BAjusteStock.Size = new System.Drawing.Size(120, 120);
            this.BAjusteStock.TabIndex = 7;
            this.BAjusteStock.UseVisualStyleBackColor = false;
            this.BAjusteStock.Click += new System.EventHandler(this.BAjusteStock_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.PBLogo);
            this.panelHeader.Controls.Add(this.LTituloAlba);
            this.panelHeader.Controls.Add(this.LSubtituloAdmin);
            this.panelHeader.Controls.Add(this.panelSeparador);
            this.panelHeader.Controls.Add(this.LSeccion);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(250, 144);
            this.panelHeader.TabIndex = 0;
            // 
            // PBLogo
            // 
            this.PBLogo.BackColor = System.Drawing.Color.Transparent;
            this.PBLogo.Image = global::ProyectoIntegrador.Properties.Resources.diamante;
            this.PBLogo.Location = new System.Drawing.Point(103, 14);
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
            this.LTituloAlba.Location = new System.Drawing.Point(15, 62);
            this.LTituloAlba.Name = "LTituloAlba";
            this.LTituloAlba.Size = new System.Drawing.Size(220, 24);
            this.LTituloAlba.TabIndex = 1;
            this.LTituloAlba.Text = "Joyería ALBA";
            this.LTituloAlba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSubtituloAdmin
            // 
            this.LSubtituloAdmin.BackColor = System.Drawing.Color.Transparent;
            this.LSubtituloAdmin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtituloAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(204)))), ((int)(((byte)(194)))));
            this.LSubtituloAdmin.Location = new System.Drawing.Point(15, 88);
            this.LSubtituloAdmin.Name = "LSubtituloAdmin";
            this.LSubtituloAdmin.Size = new System.Drawing.Size(220, 18);
            this.LSubtituloAdmin.TabIndex = 2;
            this.LSubtituloAdmin.Text = "PANEL ADMINISTRADOR";
            this.LSubtituloAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSeparador
            // 
            this.panelSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panelSeparador.Location = new System.Drawing.Point(25, 112);
            this.panelSeparador.Name = "panelSeparador";
            this.panelSeparador.Size = new System.Drawing.Size(200, 1);
            this.panelSeparador.TabIndex = 3;
            // 
            // LSeccion
            // 
            this.LSeccion.BackColor = System.Drawing.Color.Transparent;
            this.LSeccion.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.LSeccion.Location = new System.Drawing.Point(25, 120);
            this.LSeccion.Name = "LSeccion";
            this.LSeccion.Size = new System.Drawing.Size(200, 16);
            this.LSeccion.TabIndex = 4;
            this.LSeccion.Text = "MÓDULOS DEL SISTEMA";
            this.LSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(6)))), ((int)(((byte)(9)))));
            this.panelFooter.Controls.Add(this.LFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 676);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(250, 44);
            this.panelFooter.TabIndex = 1;
            // 
            // LFooter
            // 
            this.LFooter.BackColor = System.Drawing.Color.Transparent;
            this.LFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(180)))), ((int)(((byte)(165)))));
            this.LFooter.Location = new System.Drawing.Point(0, 0);
            this.LFooter.Name = "LFooter";
            this.LFooter.Size = new System.Drawing.Size(250, 44);
            this.LFooter.TabIndex = 0;
            this.LFooter.Text = "Sesión activa: Administrador | Control Total";
            this.LFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuContextProductos
            // 
            this.menuContextProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCatalogoProductos,
            this.itemGestionCategorias});
            this.menuContextProductos.Name = "menuContextProductos";
            this.menuContextProductos.Size = new System.Drawing.Size(195, 48);
            // 
            // itemCatalogoProductos
            // 
            this.itemCatalogoProductos.Name = "itemCatalogoProductos";
            this.itemCatalogoProductos.Size = new System.Drawing.Size(194, 22);
            this.itemCatalogoProductos.Text = "Catálogo de Productos";
            this.itemCatalogoProductos.Click += new System.EventHandler(this.itemCatalogoProductos_Click);
            // 
            // itemGestionCategorias
            // 
            this.itemGestionCategorias.Name = "itemGestionCategorias";
            this.itemGestionCategorias.Size = new System.Drawing.Size(194, 22);
            this.itemGestionCategorias.Text = "Gestión de Categorías";
            this.itemGestionCategorias.Click += new System.EventHandler(this.itemGestionCategorias_Click);
            // 
            // menuContextVentas
            // 
            this.menuContextVentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpcionesVenta,
            this.itemGestionVentas,
            this.itemHistorialVentas});
            this.menuContextVentas.Name = "menuContextVentas";
            this.menuContextVentas.Size = new System.Drawing.Size(206, 70);
            // 
            // itemOpcionesVenta
            // 
            this.itemOpcionesVenta.Name = "itemOpcionesVenta";
            this.itemOpcionesVenta.Size = new System.Drawing.Size(205, 22);
            this.itemOpcionesVenta.Text = "Menú Opciones de Venta";
            this.itemOpcionesVenta.Click += new System.EventHandler(this.itemOpcionesVenta_Click);
            // 
            // itemGestionVentas
            // 
            this.itemGestionVentas.Name = "itemGestionVentas";
            this.itemGestionVentas.Size = new System.Drawing.Size(205, 22);
            this.itemGestionVentas.Text = "Gestión de Ventas";
            this.itemGestionVentas.Click += new System.EventHandler(this.itemGestionVentas_Click);
            // 
            // itemHistorialVentas
            // 
            this.itemHistorialVentas.Name = "itemHistorialVentas";
            this.itemHistorialVentas.Size = new System.Drawing.Size(205, 22);
            this.itemHistorialVentas.Text = "Historial de Ventas";
            this.itemHistorialVentas.Click += new System.EventHandler(this.itemHistorialVentas_Click);
            // 
            // FormPrincipalAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.panelSidebar);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipalAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joyería ALBA - Panel Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipalAdministrador_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipalAdministrador_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelContenedorBotones.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.menuContextProductos.ResumeLayout(false);
            this.menuContextVentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label LTituloAlba;
        private System.Windows.Forms.Label LSubtituloAdmin;
        private System.Windows.Forms.Panel panelSeparador;
        private System.Windows.Forms.Label LSeccion;
        private System.Windows.Forms.Panel panelContenedorBotones;
        private System.Windows.Forms.Button BUsuarios;
        private System.Windows.Forms.Button BProductos;
        private System.Windows.Forms.Button BVentas;
        private System.Windows.Forms.Button BDevoluciones;
        private System.Windows.Forms.Button BCompras;
        private System.Windows.Forms.Button BProveedores;
        private System.Windows.Forms.Button BClientes;
        private System.Windows.Forms.Button BAjusteStock;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label LFooter;
        private System.Windows.Forms.ContextMenuStrip menuContextProductos;
        private System.Windows.Forms.ToolStripMenuItem itemCatalogoProductos;
        private System.Windows.Forms.ToolStripMenuItem itemGestionCategorias;
        private System.Windows.Forms.ContextMenuStrip menuContextVentas;
        private System.Windows.Forms.ToolStripMenuItem itemOpcionesVenta;
        private System.Windows.Forms.ToolStripMenuItem itemGestionVentas;
        private System.Windows.Forms.ToolStripMenuItem itemHistorialVentas;
    }
}