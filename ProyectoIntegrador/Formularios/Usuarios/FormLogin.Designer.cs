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
            this.panelCard = new System.Windows.Forms.Panel();
            this.PBJoya = new System.Windows.Forms.PictureBox();
            this.LJoyeriaALBA = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.LContrasena = new System.Windows.Forms.Label();
            this.TBContrasena = new System.Windows.Forms.TextBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBJoya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.PBJoya);
            this.panelCard.Controls.Add(this.LJoyeriaALBA);
            this.panelCard.Controls.Add(this.LSubtitulo);
            this.panelCard.Controls.Add(this.LUsuario);
            this.panelCard.Controls.Add(this.TBUsuario);
            this.panelCard.Controls.Add(this.LContrasena);
            this.panelCard.Controls.Add(this.TBContrasena);
            this.panelCard.Controls.Add(this.BLogin);
            this.panelCard.Location = new System.Drawing.Point(143, 85);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(460, 450);
            this.panelCard.TabIndex = 0;
            // 
            // PBJoya
            // 
            this.PBJoya.BackColor = System.Drawing.Color.Transparent;
            this.PBJoya.Image = global::ProyectoIntegrador.Properties.Resources.diamante;
            this.PBJoya.Location = new System.Drawing.Point(190, 28);
            this.PBJoya.Name = "PBJoya";
            this.PBJoya.Size = new System.Drawing.Size(80, 80);
            this.PBJoya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBJoya.TabIndex = 0;
            this.PBJoya.TabStop = false;
            // 
            // LJoyeriaALBA
            // 
            this.LJoyeriaALBA.BackColor = System.Drawing.Color.Transparent;
            this.LJoyeriaALBA.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LJoyeriaALBA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LJoyeriaALBA.Location = new System.Drawing.Point(30, 114);
            this.LJoyeriaALBA.Name = "LJoyeriaALBA";
            this.LJoyeriaALBA.Size = new System.Drawing.Size(400, 35);
            this.LJoyeriaALBA.TabIndex = 1;
            this.LJoyeriaALBA.Text = "Joyería ALBA";
            this.LJoyeriaALBA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(115)))), ((int)(((byte)(110)))));
            this.LSubtitulo.Location = new System.Drawing.Point(30, 150);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(400, 22);
            this.LSubtitulo.TabIndex = 2;
            this.LSubtitulo.Text = "Acceso al Sistema de Gestión";
            this.LSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LUsuario.Location = new System.Drawing.Point(55, 188);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(55, 17);
            this.LUsuario.TabIndex = 3;
            this.LUsuario.Text = "Usuario";
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.Color.White;
            this.TBUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBUsuario.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuario.ForeColor = System.Drawing.Color.Black;
            this.TBUsuario.Location = new System.Drawing.Point(55, 210);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(350, 26);
            this.TBUsuario.TabIndex = 4;
            this.TBUsuario.TextChanged += new System.EventHandler(this.TBUsuario_TextChanged);
            this.TBUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TBUsuario_Validating);
            // 
            // LContrasena
            // 
            this.LContrasena.AutoSize = true;
            this.LContrasena.BackColor = System.Drawing.Color.Transparent;
            this.LContrasena.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LContrasena.Location = new System.Drawing.Point(55, 252);
            this.LContrasena.Name = "LContrasena";
            this.LContrasena.Size = new System.Drawing.Size(77, 17);
            this.LContrasena.TabIndex = 5;
            this.LContrasena.Text = "Contraseña";
            // 
            // TBContrasena
            // 
            this.TBContrasena.BackColor = System.Drawing.Color.White;
            this.TBContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBContrasena.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContrasena.ForeColor = System.Drawing.Color.Black;
            this.TBContrasena.Location = new System.Drawing.Point(55, 274);
            this.TBContrasena.Name = "TBContrasena";
            this.TBContrasena.Size = new System.Drawing.Size(350, 26);
            this.TBContrasena.TabIndex = 6;
            this.TBContrasena.UseSystemPasswordChar = true;
            this.TBContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.TBContrasena_Validating);
            // 
            // BLogin
            // 
            this.BLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLogin.FlatAppearance.BorderSize = 0;
            this.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLogin.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLogin.ForeColor = System.Drawing.Color.White;
            this.BLogin.Location = new System.Drawing.Point(55, 335);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(350, 44);
            this.BLogin.TabIndex = 7;
            this.BLogin.Text = "Iniciar Sesión";
            this.BLogin.UseVisualStyleBackColor = false;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.BLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(747, 624);
            this.Controls.Add(this.panelCard);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión - Joyería ALBA";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.FormLogin_Resize);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBJoya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.PictureBox PBJoya;
        private System.Windows.Forms.Label LJoyeriaALBA;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Label LContrasena;
        private System.Windows.Forms.TextBox TBContrasena;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}