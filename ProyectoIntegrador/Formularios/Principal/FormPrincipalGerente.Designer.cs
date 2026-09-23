namespace ProyectoIntegrador.Formularios.Principal
{
    partial class FormPrincipalGerente
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelContenedorBotones = new System.Windows.Forms.Panel();
            this.BDashboard = new System.Windows.Forms.Button();
            this.BInformes = new System.Windows.Forms.Button();
            this.BAjusteStock = new System.Windows.Forms.Button();
            this.BHistorialVentas = new System.Windows.Forms.Button();
            this.BCerrarSesion = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.LFooter = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.LTituloAlba = new System.Windows.Forms.Label();
            this.LSubtituloGerente = new System.Windows.Forms.Label();
            this.panelSeparador = new System.Windows.Forms.Panel();
            this.LSeccion = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelContenedorBotones.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
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
            this.panelContenedorBotones.Controls.Add(this.BDashboard);
            this.panelContenedorBotones.Controls.Add(this.BInformes);
            this.panelContenedorBotones.Controls.Add(this.BAjusteStock);
            this.panelContenedorBotones.Controls.Add(this.BHistorialVentas);
            this.panelContenedorBotones.Controls.Add(this.BCerrarSesion);
            this.panelContenedorBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorBotones.Location = new System.Drawing.Point(0, 144);
            this.panelContenedorBotones.Name = "panelContenedorBotones";
            this.panelContenedorBotones.Size = new System.Drawing.Size(250, 532);
            this.panelContenedorBotones.TabIndex = 2;
            // 
            // BDashboard
            // 
            this.BDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.BDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDashboard.FlatAppearance.BorderSize = 0;
            this.BDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDashboard.ForeColor = System.Drawing.Color.White;
            this.BDashboard.Location = new System.Drawing.Point(18, 16);
            this.BDashboard.Name = "BDashboard";
            this.BDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BDashboard.Size = new System.Drawing.Size(214, 46);
            this.BDashboard.TabIndex = 0;
            this.BDashboard.Text = "📊  Dashboard General";
            this.BDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDashboard.UseVisualStyleBackColor = false;
            this.BDashboard.Click += new System.EventHandler(this.BDashboard_Click);
            // 
            // BInformes
            // 
            this.BInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BInformes.FlatAppearance.BorderSize = 0;
            this.BInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInformes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.BInformes.Location = new System.Drawing.Point(18, 72);
            this.BInformes.Name = "BInformes";
            this.BInformes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BInformes.Size = new System.Drawing.Size(214, 46);
            this.BInformes.TabIndex = 1;
            this.BInformes.Text = "📈  Informes Estadísticos";
            this.BInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BInformes.UseVisualStyleBackColor = false;
            this.BInformes.Click += new System.EventHandler(this.BInformes_Click);
            // 
            // BAjusteStock
            // 
            this.BAjusteStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BAjusteStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAjusteStock.FlatAppearance.BorderSize = 0;
            this.BAjusteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAjusteStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAjusteStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.BAjusteStock.Location = new System.Drawing.Point(18, 128);
            this.BAjusteStock.Name = "BAjusteStock";
            this.BAjusteStock.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BAjusteStock.Size = new System.Drawing.Size(214, 46);
            this.BAjusteStock.TabIndex = 2;
            this.BAjusteStock.Text = "📦  Ajuste de Stock";
            this.BAjusteStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAjusteStock.UseVisualStyleBackColor = false;
            this.BAjusteStock.Click += new System.EventHandler(this.BAjusteStock_Click);
            // 
            // BHistorialVentas
            // 
            this.BHistorialVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BHistorialVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BHistorialVentas.FlatAppearance.BorderSize = 0;
            this.BHistorialVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BHistorialVentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BHistorialVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.BHistorialVentas.Location = new System.Drawing.Point(18, 184);
            this.BHistorialVentas.Name = "BHistorialVentas";
            this.BHistorialVentas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BHistorialVentas.Size = new System.Drawing.Size(214, 46);
            this.BHistorialVentas.TabIndex = 3;
            this.BHistorialVentas.Text = "💳  Historial de Ventas";
            this.BHistorialVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BHistorialVentas.UseVisualStyleBackColor = false;
            this.BHistorialVentas.Click += new System.EventHandler(this.BVentas_Click);
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.BCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.BCerrarSesion.Location = new System.Drawing.Point(18, 260);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(214, 40);
            this.BCerrarSesion.TabIndex = 4;
            this.BCerrarSesion.Text = "🚪  Cerrar Sesión";
            this.BCerrarSesion.UseVisualStyleBackColor = false;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click);
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
            this.LFooter.Text = "Sesión activa: Gerente | Nivel Ejecutivo";
            this.LFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LFooter.Click += new System.EventHandler(this.LFooter_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.PBLogo);
            this.panelHeader.Controls.Add(this.LTituloAlba);
            this.panelHeader.Controls.Add(this.LSubtituloGerente);
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
            // LSubtituloGerente
            // 
            this.LSubtituloGerente.BackColor = System.Drawing.Color.Transparent;
            this.LSubtituloGerente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtituloGerente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(204)))), ((int)(((byte)(194)))));
            this.LSubtituloGerente.Location = new System.Drawing.Point(15, 88);
            this.LSubtituloGerente.Name = "LSubtituloGerente";
            this.LSubtituloGerente.Size = new System.Drawing.Size(220, 18);
            this.LSubtituloGerente.TabIndex = 2;
            this.LSubtituloGerente.Text = "PANEL GERENTE";
            this.LSubtituloGerente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.LSeccion.Text = "GESTIÓN Y ANÁLISIS";
            this.LSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPrincipalGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1180, 720);
            this.Controls.Add(this.panelSidebar);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipalGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joyería ALBA - Panel Gerente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipalGerente_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipalGerente_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelContenedorBotones.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label LTituloAlba;
        private System.Windows.Forms.Label LSubtituloGerente;
        private System.Windows.Forms.Panel panelSeparador;
        private System.Windows.Forms.Label LSeccion;
        private System.Windows.Forms.Panel panelContenedorBotones;
        private System.Windows.Forms.Button BDashboard;
        private System.Windows.Forms.Button BInformes;
        private System.Windows.Forms.Button BAjusteStock;
        private System.Windows.Forms.Button BHistorialVentas;
        private System.Windows.Forms.Button BCerrarSesion;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label LFooter;
    }
}
