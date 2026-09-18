namespace ProyectoIntegrador.Formularios.Usuarios
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.PBJoya = new System.Windows.Forms.PictureBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.LJoyeriaALBA = new System.Windows.Forms.Label();
            this.TBContrasena = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelGlass1 = new PanelGlass();
            ((System.ComponentModel.ISupportInitialize)(this.PBJoya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelGlass1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBJoya
            // 
            this.PBJoya.BackColor = System.Drawing.Color.Transparent;
            this.PBJoya.Image = global::ProyectoIntegrador.Properties.Resources.diamante;
            this.PBJoya.Location = new System.Drawing.Point(90, 80);
            this.PBJoya.Name = "PBJoya";
            this.PBJoya.Size = new System.Drawing.Size(132, 134);
            this.PBJoya.TabIndex = 10;
            this.PBJoya.TabStop = false;
            this.PBJoya.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BLogin
            // 
            this.BLogin.BackColor = System.Drawing.Color.Transparent;
            this.BLogin.Location = new System.Drawing.Point(77, 299);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(157, 30);
            this.BLogin.TabIndex = 13;
            this.BLogin.Text = "Iniciar Sesión";
            this.BLogin.UseVisualStyleBackColor = false;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.TBUsuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TBUsuario.Location = new System.Drawing.Point(61, 225);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(191, 20);
            this.TBUsuario.TabIndex = 8;
            this.TBUsuario.Text = "Usuario";
            this.TBUsuario.TextChanged += new System.EventHandler(this.TBUsuario_TextChanged);
            this.TBUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TBUsuario_Validating);
            // 
            // LJoyeriaALBA
            // 
            this.LJoyeriaALBA.AutoSize = true;
            this.LJoyeriaALBA.BackColor = System.Drawing.Color.Transparent;
            this.LJoyeriaALBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LJoyeriaALBA.Location = new System.Drawing.Point(86, 42);
            this.LJoyeriaALBA.Name = "LJoyeriaALBA";
            this.LJoyeriaALBA.Size = new System.Drawing.Size(135, 24);
            this.LJoyeriaALBA.TabIndex = 12;
            this.LJoyeriaALBA.Text = "Joyería ALBA";
            // 
            // TBContrasena
            // 
            this.TBContrasena.BackColor = System.Drawing.SystemColors.Info;
            this.TBContrasena.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TBContrasena.Location = new System.Drawing.Point(61, 264);
            this.TBContrasena.Name = "TBContrasena";
            this.TBContrasena.Size = new System.Drawing.Size(191, 20);
            this.TBContrasena.TabIndex = 9;
            this.TBContrasena.Text = "Contraseña";
            this.TBContrasena.UseSystemPasswordChar = true;
            this.TBContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.TBContrasena_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelGlass1
            // 
            this.panelGlass1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGlass1.Controls.Add(this.LJoyeriaALBA);
            this.panelGlass1.Controls.Add(this.BLogin);
            this.panelGlass1.Controls.Add(this.TBUsuario);
            this.panelGlass1.Controls.Add(this.PBJoya);
            this.panelGlass1.Controls.Add(this.TBContrasena);
            this.panelGlass1.Location = new System.Drawing.Point(165, 39);
            this.panelGlass1.Name = "panelGlass1";
            this.panelGlass1.Size = new System.Drawing.Size(321, 389);
            this.panelGlass1.TabIndex = 10;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 624);
            this.Controls.Add(this.panelGlass1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBJoya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelGlass1.ResumeLayout(false);
            this.panelGlass1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PBJoya;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Label LJoyeriaALBA;
        private System.Windows.Forms.TextBox TBContrasena;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PanelGlass panelGlass1;
    }
}