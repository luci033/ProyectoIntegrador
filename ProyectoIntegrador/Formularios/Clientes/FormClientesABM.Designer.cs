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
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LCondicionIVA = new System.Windows.Forms.Label();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BRegistrarCliente = new System.Windows.Forms.Button();
            this.cmbCondicionIVA = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(48, 115);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(47, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            this.LNombre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(48, 141);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(47, 13);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            this.LApellido.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(48, 194);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(59, 13);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI/CUIT:";
            this.LDni.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(48, 220);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(52, 13);
            this.LTelefono.TabIndex = 3;
            this.LTelefono.Text = "Teléfono:";
            this.LTelefono.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LCondicionIVA
            // 
            this.LCondicionIVA.AutoSize = true;
            this.LCondicionIVA.Location = new System.Drawing.Point(48, 168);
            this.LCondicionIVA.Name = "LCondicionIVA";
            this.LCondicionIVA.Size = new System.Drawing.Size(77, 13);
            this.LCondicionIVA.TabIndex = 4;
            this.LCondicionIVA.Text = "Condición IVA:";
            this.LCondicionIVA.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LCondicionIVA.Click += new System.EventHandler(this.label5_Click);
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Location = new System.Drawing.Point(48, 246);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(97, 13);
            this.LCorreo.TabIndex = 5;
            this.LCorreo.Text = "Correo Electrónico:";
            this.LCorreo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(192, 108);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(132, 20);
            this.TBNombre.TabIndex = 6;
            this.TBNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TBNombre_Validating);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(192, 134);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(132, 20);
            this.TBApellido.TabIndex = 7;
            this.TBApellido.Validating += new System.ComponentModel.CancelEventHandler(this.TBApellido_Validating);
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(192, 187);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(132, 20);
            this.TBDni.TabIndex = 8;
            this.TBDni.Validating += new System.ComponentModel.CancelEventHandler(this.TBDni_Validating);
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(192, 213);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(132, 20);
            this.TBTelefono.TabIndex = 9;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(192, 239);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(132, 20);
            this.TBCorreo.TabIndex = 11;
            this.TBCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.TBCorreo_Validating);
            // 
            // BCancelar
            // 
            this.BCancelar.CausesValidation = false;
            this.BCancelar.Location = new System.Drawing.Point(112, 351);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(99, 42);
            this.BCancelar.TabIndex = 12;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BRegistrarCliente
            // 
            this.BRegistrarCliente.Location = new System.Drawing.Point(380, 351);
            this.BRegistrarCliente.Name = "BRegistrarCliente";
            this.BRegistrarCliente.Size = new System.Drawing.Size(97, 42);
            this.BRegistrarCliente.TabIndex = 13;
            this.BRegistrarCliente.Text = "Registrar Cliente";
            this.BRegistrarCliente.UseVisualStyleBackColor = true;
            this.BRegistrarCliente.Click += new System.EventHandler(this.BRegistrarCliente_Click);
            // 
            // cmbCondicionIVA
            // 
            this.cmbCondicionIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionIVA.FormattingEnabled = true;
            this.cmbCondicionIVA.Items.AddRange(new object[] {
            "Responsable Inscripto",
            "Monotributista",
            "Exento",
            "Consumidor Final"});
            this.cmbCondicionIVA.Location = new System.Drawing.Point(192, 160);
            this.cmbCondicionIVA.Name = "cmbCondicionIVA";
            this.cmbCondicionIVA.Size = new System.Drawing.Size(132, 21);
            this.cmbCondicionIVA.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Location = new System.Drawing.Point(48, 36);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(84, 13);
            this.LTitulo.TabIndex = 17;
            this.LTitulo.Text = "Registrar Cliente";
            // 
            // FormClientesABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 418);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbCondicionIVA);
            this.Controls.Add(this.BRegistrarCliente);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.TBCorreo);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LCorreo);
            this.Controls.Add(this.LCondicionIVA);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Name = "FormClientesABM";
            this.Text = "Registrar Cliente";
            this.Load += new System.EventHandler(this.FormClientesABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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