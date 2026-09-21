namespace ProyectoIntegrador.Formularios.Clientes
{
    partial class FormClientesABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientesABM));
            this.panelCard = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.LCondicionIVA = new System.Windows.Forms.Label();
            this.cmbCondicionIVA = new System.Windows.Forms.ComboBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BRegistrarCliente = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCard.SuspendLayout();
            this.panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LSubtitulo);
            this.panelCard.Controls.Add(this.LNombre);
            this.panelCard.Controls.Add(this.TBNombre);
            this.panelCard.Controls.Add(this.LApellido);
            this.panelCard.Controls.Add(this.TBApellido);
            this.panelCard.Controls.Add(this.LDni);
            this.panelCard.Controls.Add(this.TBDni);
            this.panelCard.Controls.Add(this.LCondicionIVA);
            this.panelCard.Controls.Add(this.cmbCondicionIVA);
            this.panelCard.Controls.Add(this.LTelefono);
            this.panelCard.Controls.Add(this.TBTelefono);
            this.panelCard.Controls.Add(this.LCorreo);
            this.panelCard.Controls.Add(this.TBCorreo);
            this.panelCard.Controls.Add(this.panelAvatar);
            this.panelCard.Controls.Add(this.BCancelar);
            this.panelCard.Controls.Add(this.BRegistrarCliente);
            this.panelCard.Location = new System.Drawing.Point(30, 20);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(920, 620);
            this.panelCard.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(30, 25);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(248, 31);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Registrar Cliente";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.LSubtitulo.Location = new System.Drawing.Point(30, 62);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(434, 17);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Complete la información personal, tributaria y de contacto del cliente.";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LNombre.Location = new System.Drawing.Point(30, 105);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(56, 15);
            this.LNombre.TabIndex = 2;
            this.LNombre.Text = "Nombre:";
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBNombre.Location = new System.Drawing.Point(30, 127);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(265, 25);
            this.TBNombre.TabIndex = 3;
            this.TBNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TBNombre_Validating);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LApellido.Location = new System.Drawing.Point(325, 105);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(55, 15);
            this.LApellido.TabIndex = 4;
            this.LApellido.Text = "Apellido:";
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBApellido.Location = new System.Drawing.Point(325, 127);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(265, 25);
            this.TBApellido.TabIndex = 5;
            this.TBApellido.Validating += new System.ComponentModel.CancelEventHandler(this.TBApellido_Validating);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LDni.Location = new System.Drawing.Point(30, 175);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(65, 15);
            this.LDni.TabIndex = 6;
            this.LDni.Text = "DNI / CUIT:";
            // 
            // TBDni
            // 
            this.TBDni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBDni.Location = new System.Drawing.Point(30, 197);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(265, 25);
            this.TBDni.TabIndex = 7;
            this.TBDni.Validating += new System.ComponentModel.CancelEventHandler(this.TBDni_Validating);
            // 
            // LCondicionIVA
            // 
            this.LCondicionIVA.AutoSize = true;
            this.LCondicionIVA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCondicionIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCondicionIVA.Location = new System.Drawing.Point(325, 175);
            this.LCondicionIVA.Name = "LCondicionIVA";
            this.LCondicionIVA.Size = new System.Drawing.Size(89, 15);
            this.LCondicionIVA.TabIndex = 8;
            this.LCondicionIVA.Text = "Condición IVA:";
            this.LCondicionIVA.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbCondicionIVA
            // 
            this.cmbCondicionIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionIVA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbCondicionIVA.FormattingEnabled = true;
            this.cmbCondicionIVA.Items.AddRange(new object[] {
            "Responsable Inscripto",
            "Monotributista",
            "Exento",
            "Consumidor Final"});
            this.cmbCondicionIVA.Location = new System.Drawing.Point(325, 197);
            this.cmbCondicionIVA.Name = "cmbCondicionIVA";
            this.cmbCondicionIVA.Size = new System.Drawing.Size(265, 25);
            this.cmbCondicionIVA.TabIndex = 9;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTelefono.Location = new System.Drawing.Point(30, 245);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(126, 15);
            this.LTelefono.TabIndex = 10;
            this.LTelefono.Text = "Teléfono de Contacto:";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBTelefono.Location = new System.Drawing.Point(30, 267);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(265, 25);
            this.TBTelefono.TabIndex = 11;
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCorreo.Location = new System.Drawing.Point(325, 245);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(113, 15);
            this.LCorreo.TabIndex = 12;
            this.LCorreo.Text = "Correo Electrónico:";
            // 
            // TBCorreo
            // 
            this.TBCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBCorreo.Location = new System.Drawing.Point(325, 267);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(265, 25);
            this.TBCorreo.TabIndex = 13;
            this.TBCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.TBCorreo_Validating);
            // 
            // panelAvatar
            // 
            this.panelAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panelAvatar.Controls.Add(this.pictureBox1);
            this.panelAvatar.Location = new System.Drawing.Point(625, 105);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(260, 260);
            this.panelAvatar.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BCancelar
            // 
            this.BCancelar.CausesValidation = false;
            this.BCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BCancelar.Location = new System.Drawing.Point(490, 545);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(180, 44);
            this.BCancelar.TabIndex = 15;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BRegistrarCliente
            // 
            this.BRegistrarCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BRegistrarCliente.Location = new System.Drawing.Point(690, 545);
            this.BRegistrarCliente.Name = "BRegistrarCliente";
            this.BRegistrarCliente.Size = new System.Drawing.Size(200, 44);
            this.BRegistrarCliente.TabIndex = 16;
            this.BRegistrarCliente.Text = "Registrar Cliente";
            this.BRegistrarCliente.UseVisualStyleBackColor = true;
            this.BRegistrarCliente.Click += new System.EventHandler(this.BRegistrarCliente_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormClientesABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.panelCard);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "FormClientesABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormClientesABM_Load);
            this.Resize += new System.EventHandler(this.FormClientesABM_Resize);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LCondicionIVA;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BRegistrarCliente;
        private System.Windows.Forms.ComboBox cmbCondicionIVA;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LTitulo;
    }
}