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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmbCondicionIVA = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(28, 69);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            this.LNombre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(28, 99);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido";
            this.LApellido.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(28, 129);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            this.LDni.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(28, 155);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 3;
            this.LTelefono.Text = "Teléfono";
            this.LTelefono.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LCondicionIVA
            // 
            this.LCondicionIVA.AutoSize = true;
            this.LCondicionIVA.Location = new System.Drawing.Point(28, 183);
            this.LCondicionIVA.Name = "LCondicionIVA";
            this.LCondicionIVA.Size = new System.Drawing.Size(74, 13);
            this.LCondicionIVA.TabIndex = 4;
            this.LCondicionIVA.Text = "Condición IVA";
            this.LCondicionIVA.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LCondicionIVA.Click += new System.EventHandler(this.label5_Click);
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Location = new System.Drawing.Point(28, 212);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(94, 13);
            this.LCorreo.TabIndex = 5;
            this.LCorreo.Text = "Correo Electrónico";
            this.LCorreo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(172, 62);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 20);
            this.TBNombre.TabIndex = 6;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(172, 92);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(100, 20);
            this.TBApellido.TabIndex = 7;
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(172, 122);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(100, 20);
            this.TBDni.TabIndex = 8;
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(172, 148);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(100, 20);
            this.TBTelefono.TabIndex = 9;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(172, 205);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(100, 20);
            this.TBCorreo.TabIndex = 11;
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(21, 269);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(81, 26);
            this.BCancelar.TabIndex = 12;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BRegistrarCliente
            // 
            this.BRegistrarCliente.Location = new System.Drawing.Point(193, 269);
            this.BRegistrarCliente.Name = "BRegistrarCliente";
            this.BRegistrarCliente.Size = new System.Drawing.Size(79, 26);
            this.BRegistrarCliente.TabIndex = 13;
            this.BRegistrarCliente.Text = "Registrar Cliente";
            this.BRegistrarCliente.UseVisualStyleBackColor = true;
            this.BRegistrarCliente.Click += new System.EventHandler(this.BRegistrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmbCondicionIVA
            // 
            this.cmbCondicionIVA.FormattingEnabled = true;
            this.cmbCondicionIVA.Location = new System.Drawing.Point(172, 175);
            this.cmbCondicionIVA.Name = "cmbCondicionIVA";
            this.cmbCondicionIVA.Size = new System.Drawing.Size(100, 21);
            this.cmbCondicionIVA.TabIndex = 15;
            // 
            // FormClientesABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 312);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormClientesABM";
            this.Text = "FormClientesABM";
            this.Load += new System.EventHandler(this.FormClientesABM_Load);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cmbCondicionIVA;
    }
}