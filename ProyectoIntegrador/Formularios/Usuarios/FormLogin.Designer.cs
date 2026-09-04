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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBJoya = new System.Windows.Forms.PictureBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.BVerContrasena = new System.Windows.Forms.Button();
            this.LJoyeriaALBA = new System.Windows.Forms.Label();
            this.TBContrasena = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBJoya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PBJoya);
            this.panel1.Controls.Add(this.BLogin);
            this.panel1.Controls.Add(this.TBUsuario);
            this.panel1.Controls.Add(this.BVerContrasena);
            this.panel1.Controls.Add(this.LJoyeriaALBA);
            this.panel1.Controls.Add(this.TBContrasena);
            this.panel1.Location = new System.Drawing.Point(229, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 363);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PBJoya
            // 
            this.PBJoya.Image = global::ProyectoIntegrador.Properties.Resources.diamante;
            this.PBJoya.Location = new System.Drawing.Point(78, 62);
            this.PBJoya.Name = "PBJoya";
            this.PBJoya.Size = new System.Drawing.Size(132, 132);
            this.PBJoya.TabIndex = 10;
            this.PBJoya.TabStop = false;
            this.PBJoya.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(69, 311);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(120, 23);
            this.BLogin.TabIndex = 13;
            this.BLogin.Text = "Iniciar Sesión";
            this.BLogin.UseVisualStyleBackColor = true;
            // 
            // TBUsuario
            // 
            this.TBUsuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TBUsuario.Location = new System.Drawing.Point(57, 227);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(153, 20);
            this.TBUsuario.TabIndex = 8;
            this.TBUsuario.Text = "Usuario";
            this.TBUsuario.TextChanged += new System.EventHandler(this.TBUsuario_TextChanged);
            this.TBUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TBUsuario_Validating);
            // 
            // BVerContrasena
            // 
            this.BVerContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVerContrasena.ForeColor = System.Drawing.Color.Transparent;
            this.BVerContrasena.Image = global::ProyectoIntegrador.Properties.Resources.ojo;
            this.BVerContrasena.Location = new System.Drawing.Point(207, 266);
            this.BVerContrasena.Name = "BVerContrasena";
            this.BVerContrasena.Size = new System.Drawing.Size(34, 20);
            this.BVerContrasena.TabIndex = 11;
            this.BVerContrasena.Text = "👁";
            this.BVerContrasena.UseVisualStyleBackColor = true;
            this.BVerContrasena.Click += new System.EventHandler(this.BVerContraena_Click_1);
            // 
            // LJoyeriaALBA
            // 
            this.LJoyeriaALBA.AutoSize = true;
            this.LJoyeriaALBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LJoyeriaALBA.Location = new System.Drawing.Point(75, 13);
            this.LJoyeriaALBA.Name = "LJoyeriaALBA";
            this.LJoyeriaALBA.Size = new System.Drawing.Size(135, 24);
            this.LJoyeriaALBA.TabIndex = 12;
            this.LJoyeriaALBA.Text = "Joyería ALBA";
            // 
            // TBContrasena
            // 
            this.TBContrasena.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TBContrasena.Location = new System.Drawing.Point(57, 266);
            this.TBContrasena.Name = "TBContrasena";
            this.TBContrasena.Size = new System.Drawing.Size(144, 20);
            this.TBContrasena.TabIndex = 9;
            this.TBContrasena.Text = "Contraseña";
            this.TBContrasena.UseSystemPasswordChar = true;
            this.TBContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.TBContrasena_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 414);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBJoya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBJoya;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Button BVerContrasena;
        private System.Windows.Forms.Label LJoyeriaALBA;
        private System.Windows.Forms.TextBox TBContrasena;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}