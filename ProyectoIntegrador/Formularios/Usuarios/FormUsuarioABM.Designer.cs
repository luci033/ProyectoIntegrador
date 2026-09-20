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
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LConstraseña = new System.Windows.Forms.Label();
            this.LRepetirContraseña = new System.Windows.Forms.Label();
            this.LDNI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.TBContraseñaRepetir = new System.Windows.Forms.TextBox();
            this.L = new System.Windows.Forms.Label();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.BCrearUsuario = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.BBuscarArchivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LNombre.Location = new System.Drawing.Point(57, 75);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(57, 104);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Apellido";
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(57, 162);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(43, 13);
            this.LUsuario.TabIndex = 6;
            this.LUsuario.Text = "Usuario";
            this.LUsuario.Click += new System.EventHandler(this.LCorreo_Click);
            // 
            // LConstraseña
            // 
            this.LConstraseña.AutoSize = true;
            this.LConstraseña.Location = new System.Drawing.Point(57, 191);
            this.LConstraseña.Name = "LConstraseña";
            this.LConstraseña.Size = new System.Drawing.Size(61, 13);
            this.LConstraseña.TabIndex = 8;
            this.LConstraseña.Text = "Contraseña";
            // 
            // LRepetirContraseña
            // 
            this.LRepetirContraseña.AutoSize = true;
            this.LRepetirContraseña.Location = new System.Drawing.Point(57, 219);
            this.LRepetirContraseña.Name = "LRepetirContraseña";
            this.LRepetirContraseña.Size = new System.Drawing.Size(98, 13);
            this.LRepetirContraseña.TabIndex = 10;
            this.LRepetirContraseña.Text = "Repetir Contraseña";
            // 
            // LDNI
            // 
            this.LDNI.AutoSize = true;
            this.LDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LDNI.Location = new System.Drawing.Point(57, 135);
            this.LDNI.Name = "LDNI";
            this.LDNI.Size = new System.Drawing.Size(26, 13);
            this.LDNI.TabIndex = 4;
            this.LDNI.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccionar foto de perfil";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(201, 72);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(121, 20);
            this.TBNombre.TabIndex = 1;
            this.TBNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TBNombre_Validating);
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(201, 132);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(121, 20);
            this.TBDni.TabIndex = 5;
            this.TBDni.Validating += new System.ComponentModel.CancelEventHandler(this.TBDni_Validating);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(201, 101);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(121, 20);
            this.TBApellido.TabIndex = 3;
            this.TBApellido.Validating += new System.ComponentModel.CancelEventHandler(this.TBApellido_Validating);
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(201, 159);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(121, 20);
            this.TBUsuario.TabIndex = 7;
            this.TBUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TBUsuario_Validating);
            // 
            // TBContraseña
            // 
            this.TBContraseña.Location = new System.Drawing.Point(201, 188);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(121, 20);
            this.TBContraseña.TabIndex = 9;
            this.TBContraseña.UseSystemPasswordChar = true;
            this.TBContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.TBContraseña_Validating);
            // 
            // TBContraseñaRepetir
            // 
            this.TBContraseñaRepetir.Location = new System.Drawing.Point(201, 216);
            this.TBContraseñaRepetir.Name = "TBContraseñaRepetir";
            this.TBContraseñaRepetir.Size = new System.Drawing.Size(121, 20);
            this.TBContraseñaRepetir.TabIndex = 11;
            this.TBContraseñaRepetir.UseSystemPasswordChar = true;
            this.TBContraseñaRepetir.Validating += new System.ComponentModel.CancelEventHandler(this.TBContraseñaRepetir_Validating);
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(57, 276);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(131, 13);
            this.L.TabIndex = 14;
            this.L.Text = "Seleccionar rol del usuario";
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.InitialImage")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(359, 63);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(210, 200);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuario.TabIndex = 14;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // BCrearUsuario
            // 
            this.BCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCrearUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.BCrearUsuario.Location = new System.Drawing.Point(106, 343);
            this.BCrearUsuario.Name = "BCrearUsuario";
            this.BCrearUsuario.Size = new System.Drawing.Size(136, 34);
            this.BCrearUsuario.TabIndex = 16;
            this.BCrearUsuario.Text = "Crear Usuario";
            this.BCrearUsuario.UseVisualStyleBackColor = false;
            this.BCrearUsuario.Click += new System.EventHandler(this.BCrearUsuario_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.Color.White;
            this.BCancelar.Location = new System.Drawing.Point(359, 343);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(136, 34);
            this.BCancelar.TabIndex = 17;
            this.BCancelar.Text = "Cancelar y Salir";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Logistica"});
            this.CBRol.Location = new System.Drawing.Point(201, 273);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(121, 21);
            this.CBRol.TabIndex = 15;
            // 
            // BBuscarArchivo
            // 
            this.BBuscarArchivo.Location = new System.Drawing.Point(201, 244);
            this.BBuscarArchivo.Name = "BBuscarArchivo";
            this.BBuscarArchivo.Size = new System.Drawing.Size(121, 23);
            this.BBuscarArchivo.TabIndex = 13;
            this.BBuscarArchivo.Text = "Buscar Archivo";
            this.BBuscarArchivo.UseVisualStyleBackColor = true;
            this.BBuscarArchivo.Click += new System.EventHandler(this.BBuscarArchivo_Click);
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
            this.ClientSize = new System.Drawing.Size(642, 421);
            this.Controls.Add(this.BBuscarArchivo);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BCrearUsuario);
            this.Controls.Add(this.pictureBoxUsuario);
            this.Controls.Add(this.L);
            this.Controls.Add(this.TBContraseñaRepetir);
            this.Controls.Add(this.TBContraseña);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LDNI);
            this.Controls.Add(this.LRepetirContraseña);
            this.Controls.Add(this.LConstraseña);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Name = "FormUsuarioABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Usuarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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

