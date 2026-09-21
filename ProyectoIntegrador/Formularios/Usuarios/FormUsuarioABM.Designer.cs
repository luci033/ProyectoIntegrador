namespace ProyectoIntegrador
{
    partial class FormUsuarioABM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarioABM));
            this.panelCard = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.LDNI = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.L = new System.Windows.Forms.Label();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.LConstraseña = new System.Windows.Forms.Label();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.LRepetirContraseña = new System.Windows.Forms.Label();
            this.TBContraseñaRepetir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.BBuscarArchivo = new System.Windows.Forms.Button();
            this.BCrearUsuario = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LSubtitulo);
            this.panelCard.Controls.Add(this.LNombre);
            this.panelCard.Controls.Add(this.TBNombre);
            this.panelCard.Controls.Add(this.LApellido);
            this.panelCard.Controls.Add(this.TBApellido);
            this.panelCard.Controls.Add(this.LDNI);
            this.panelCard.Controls.Add(this.TBDni);
            this.panelCard.Controls.Add(this.L);
            this.panelCard.Controls.Add(this.CBRol);
            this.panelCard.Controls.Add(this.LUsuario);
            this.panelCard.Controls.Add(this.TBUsuario);
            this.panelCard.Controls.Add(this.LConstraseña);
            this.panelCard.Controls.Add(this.TBContraseña);
            this.panelCard.Controls.Add(this.LRepetirContraseña);
            this.panelCard.Controls.Add(this.TBContraseñaRepetir);
            this.panelCard.Controls.Add(this.label1);
            this.panelCard.Controls.Add(this.pictureBoxUsuario);
            this.panelCard.Controls.Add(this.BBuscarArchivo);
            this.panelCard.Controls.Add(this.BCrearUsuario);
            this.panelCard.Controls.Add(this.BCancelar);
            this.panelCard.Location = new System.Drawing.Point(24, 20);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(640, 420);
            this.panelCard.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(25, 20);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(221, 25);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Gestión de Usuario";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.LSubtitulo.Location = new System.Drawing.Point(26, 48);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(325, 15);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Complete los datos personales y credenciales de acceso del usuario.";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LNombre.Location = new System.Drawing.Point(26, 80);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(50, 13);
            this.LNombre.TabIndex = 2;
            this.LNombre.Text = "Nombre";
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBNombre.Location = new System.Drawing.Point(26, 98);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(160, 24);
            this.TBNombre.TabIndex = 3;
            this.TBNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TBNombre_Validating);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LApellido.Location = new System.Drawing.Point(198, 80);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(52, 13);
            this.LApellido.TabIndex = 4;
            this.LApellido.Text = "Apellido";
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBApellido.Location = new System.Drawing.Point(198, 98);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(160, 24);
            this.TBApellido.TabIndex = 5;
            this.TBApellido.Validating += new System.ComponentModel.CancelEventHandler(this.TBApellido_Validating);
            // 
            // LDNI
            // 
            this.LDNI.AutoSize = true;
            this.LDNI.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LDNI.Location = new System.Drawing.Point(26, 135);
            this.LDNI.Name = "LDNI";
            this.LDNI.Size = new System.Drawing.Size(27, 13);
            this.LDNI.TabIndex = 6;
            this.LDNI.Text = "DNI";
            // 
            // TBDni
            // 
            this.TBDni.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBDni.Location = new System.Drawing.Point(26, 153);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(160, 24);
            this.TBDni.TabIndex = 7;
            this.TBDni.Validating += new System.ComponentModel.CancelEventHandler(this.TBDni_Validating);
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.L.Location = new System.Drawing.Point(198, 135);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(89, 13);
            this.L.TabIndex = 8;
            this.L.Text = "Rol del Usuario";
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Logistica"});
            this.CBRol.Location = new System.Drawing.Point(198, 153);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(160, 25);
            this.CBRol.TabIndex = 9;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LUsuario.Location = new System.Drawing.Point(26, 192);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(110, 13);
            this.LUsuario.TabIndex = 10;
            this.LUsuario.Text = "Nombre de Usuario";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBUsuario.Location = new System.Drawing.Point(26, 210);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(332, 24);
            this.TBUsuario.TabIndex = 11;
            this.TBUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TBUsuario_Validating);
            // 
            // LConstraseña
            // 
            this.LConstraseña.AutoSize = true;
            this.LConstraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConstraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LConstraseña.Location = new System.Drawing.Point(26, 248);
            this.LConstraseña.Name = "LConstraseña";
            this.LConstraseña.Size = new System.Drawing.Size(66, 13);
            this.LConstraseña.TabIndex = 12;
            this.LConstraseña.Text = "Contraseña";
            // 
            // TBContraseña
            // 
            this.TBContraseña.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBContraseña.Location = new System.Drawing.Point(26, 266);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(160, 24);
            this.TBContraseña.TabIndex = 13;
            this.TBContraseña.UseSystemPasswordChar = true;
            this.TBContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.TBContraseña_Validating);
            // 
            // LRepetirContraseña
            // 
            this.LRepetirContraseña.AutoSize = true;
            this.LRepetirContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRepetirContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LRepetirContraseña.Location = new System.Drawing.Point(198, 248);
            this.LRepetirContraseña.Name = "LRepetirContraseña";
            this.LRepetirContraseña.Size = new System.Drawing.Size(107, 13);
            this.LRepetirContraseña.TabIndex = 14;
            this.LRepetirContraseña.Text = "Repetir Contraseña";
            // 
            // TBContraseñaRepetir
            // 
            this.TBContraseñaRepetir.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBContraseñaRepetir.Location = new System.Drawing.Point(198, 266);
            this.TBContraseñaRepetir.Name = "TBContraseñaRepetir";
            this.TBContraseñaRepetir.Size = new System.Drawing.Size(160, 24);
            this.TBContraseñaRepetir.TabIndex = 15;
            this.TBContraseñaRepetir.UseSystemPasswordChar = true;
            this.TBContraseñaRepetir.Validating += new System.ComponentModel.CancelEventHandler(this.TBContraseñaRepetir_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(400, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Foto de Perfil";
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.pictureBoxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.InitialImage")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(400, 98);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(210, 150);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuario.TabIndex = 17;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // BBuscarArchivo
            // 
            this.BBuscarArchivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarArchivo.Location = new System.Drawing.Point(400, 258);
            this.BBuscarArchivo.Name = "BBuscarArchivo";
            this.BBuscarArchivo.Size = new System.Drawing.Size(210, 32);
            this.BBuscarArchivo.TabIndex = 18;
            this.BBuscarArchivo.Text = "Buscar Archivo...";
            this.BBuscarArchivo.UseVisualStyleBackColor = true;
            this.BBuscarArchivo.Click += new System.EventHandler(this.BBuscarArchivo_Click);
            // 
            // BCrearUsuario
            // 
            this.BCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCrearUsuario.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.BCrearUsuario.Location = new System.Drawing.Point(340, 355);
            this.BCrearUsuario.Name = "BCrearUsuario";
            this.BCrearUsuario.Size = new System.Drawing.Size(145, 38);
            this.BCrearUsuario.TabIndex = 19;
            this.BCrearUsuario.Text = "Guardar Usuario";
            this.BCrearUsuario.UseVisualStyleBackColor = false;
            this.BCrearUsuario.Click += new System.EventHandler(this.BCrearUsuario_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(208)))), ((int)(((byte)(201)))));
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BCancelar.Location = new System.Drawing.Point(495, 355);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(115, 38);
            this.BCancelar.TabIndex = 20;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormUsuarioABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(688, 460);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuarioABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LConstraseña;
        private System.Windows.Forms.Label LRepetirContraseña;
        private System.Windows.Forms.Label LDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBContraseña;
        private System.Windows.Forms.TextBox TBContraseñaRepetir;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Button BCrearUsuario;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Button BBuscarArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
