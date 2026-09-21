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
            this.LSubtitulo = new System.Windows.Forms.Label();
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
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LSubtitulo);
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
            this.panelCard.Location = new System.Drawing.Point(40, 20);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(760, 530);
            this.panelCard.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(40, 22);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(680, 36);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Nuevo Proveedor";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.LSubtitulo.Location = new System.Drawing.Point(40, 62);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(680, 20);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Complete los datos comerciales y de contacto del proveedor.";
            this.LSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LRazonSocial.Location = new System.Drawing.Point(55, 96);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(98, 19);
            this.LRazonSocial.TabIndex = 2;
            this.LRazonSocial.Text = "Razón Social:";
            // 
            // TBRazonSocial
            // 
            this.TBRazonSocial.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRazonSocial.Location = new System.Drawing.Point(55, 120);
            this.TBRazonSocial.Name = "TBRazonSocial";
            this.TBRazonSocial.Size = new System.Drawing.Size(650, 26);
            this.TBRazonSocial.TabIndex = 3;
            this.TBRazonSocial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LCUIT
            // 
            this.LCUIT.AutoSize = true;
            this.LCUIT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCUIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LCUIT.Location = new System.Drawing.Point(55, 164);
            this.LCUIT.Name = "LCUIT";
            this.LCUIT.Size = new System.Drawing.Size(46, 19);
            this.LCUIT.TabIndex = 4;
            this.LCUIT.Text = "CUIT:";
            // 
            // TBCUIT
            // 
            this.TBCUIT.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCUIT.Location = new System.Drawing.Point(55, 188);
            this.TBCUIT.Name = "TBCUIT";
            this.TBCUIT.Size = new System.Drawing.Size(650, 26);
            this.TBCUIT.TabIndex = 5;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LTelefono.Location = new System.Drawing.Point(55, 232);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(71, 19);
            this.LTelefono.TabIndex = 6;
            this.LTelefono.Text = "Teléfono:";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelefono.Location = new System.Drawing.Point(55, 256);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(650, 26);
            this.TBTelefono.TabIndex = 7;
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LCorreo.Location = new System.Drawing.Point(55, 300);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(136, 19);
            this.LCorreo.TabIndex = 8;
            this.LCorreo.Text = "Correo Electrónico:";
            // 
            // TBCorreo
            // 
            this.TBCorreo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreo.Location = new System.Drawing.Point(55, 324);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(650, 26);
            this.TBCorreo.TabIndex = 9;
            // 
            // BGuardar
            // 
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.Location = new System.Drawing.Point(55, 430);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(310, 46);
            this.BGuardar.TabIndex = 10;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Location = new System.Drawing.Point(395, 430);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(310, 46);
            this.BCancelar.TabIndex = 11;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(840, 600);
            this.Controls.Add(this.panelCard);
            this.MinimumSize = new System.Drawing.Size(840, 600);
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
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Label LRazonSocial;
        private System.Windows.Forms.TextBox TBRazonSocial;
        private System.Windows.Forms.Label LCUIT;
        private System.Windows.Forms.TextBox TBCUIT;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}