namespace ProyectoIntegrador.Formularios.Proveedores
{
    partial class FormProveedorABM
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
            this.LTitulo = new System.Windows.Forms.Label();
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.TBRazonSocial = new System.Windows.Forms.TextBox();
            this.LCUIT = new System.Windows.Forms.Label();
            this.TBCUIT = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LRazonSocial);
            this.panelCard.Controls.Add(this.TBRazonSocial);
            this.panelCard.Controls.Add(this.LCUIT);
            this.panelCard.Controls.Add(this.TBCUIT);
            this.panelCard.Controls.Add(this.LTelefono);
            this.panelCard.Controls.Add(this.TBTelefono);
            this.panelCard.Controls.Add(this.LCorreo);
            this.panelCard.Controls.Add(this.TBCorreo);
            this.panelCard.Controls.Add(this.BGuardar);
            this.panelCard.Controls.Add(this.BCancelar);
            this.panelCard.Location = new System.Drawing.Point(90, 20);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(620, 440);
            this.panelCard.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(30, 20);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(560, 40);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Nuevo Proveedor";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRazonSocial.Location = new System.Drawing.Point(50, 80);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(89, 17);
            this.LRazonSocial.TabIndex = 1;
            this.LRazonSocial.Text = "Razón Social:";
            // 
            // TBRazonSocial
            // 
            this.TBRazonSocial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRazonSocial.Location = new System.Drawing.Point(50, 102);
            this.TBRazonSocial.Name = "TBRazonSocial";
            this.TBRazonSocial.Size = new System.Drawing.Size(520, 25);
            this.TBRazonSocial.TabIndex = 2;
            this.TBRazonSocial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LCUIT
            // 
            this.LCUIT.AutoSize = true;
            this.LCUIT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCUIT.Location = new System.Drawing.Point(50, 140);
            this.LCUIT.Name = "LCUIT";
            this.LCUIT.Size = new System.Drawing.Size(42, 17);
            this.LCUIT.TabIndex = 3;
            this.LCUIT.Text = "CUIT:";
            // 
            // TBCUIT
            // 
            this.TBCUIT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCUIT.Location = new System.Drawing.Point(50, 162);
            this.TBCUIT.Name = "TBCUIT";
            this.TBCUIT.Size = new System.Drawing.Size(520, 25);
            this.TBCUIT.TabIndex = 4;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(50, 200);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(66, 17);
            this.LTelefono.TabIndex = 5;
            this.LTelefono.Text = "Teléfono:";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelefono.Location = new System.Drawing.Point(50, 222);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(520, 25);
            this.TBTelefono.TabIndex = 6;
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.Location = new System.Drawing.Point(50, 260);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(125, 17);
            this.LCorreo.TabIndex = 7;
            this.LCorreo.Text = "Correo Electrónico:";
            // 
            // TBCorreo
            // 
            this.TBCorreo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreo.Location = new System.Drawing.Point(50, 282);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(520, 25);
            this.TBCorreo.TabIndex = 8;
            // 
            // BGuardar
            // 
            this.BGuardar.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.Location = new System.Drawing.Point(50, 345);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(245, 45);
            this.BGuardar.TabIndex = 9;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Location = new System.Drawing.Point(325, 345);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(245, 45);
            this.BCancelar.TabIndex = 10;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormProveedorABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.panelCard);
            this.MinimumSize = new System.Drawing.Size(680, 520);
            this.Name = "FormProveedorABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Proveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProveedorABM_Load);
            this.Resize += new System.EventHandler(this.FormProveedorABM_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LRazonSocial;
        private System.Windows.Forms.Label LCUIT;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox TBRazonSocial;
        private System.Windows.Forms.TextBox TBCUIT;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}