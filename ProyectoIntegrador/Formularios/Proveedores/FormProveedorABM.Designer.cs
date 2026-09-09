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
            this.LRazonSocial = new System.Windows.Forms.Label();
            this.LCUIT = new System.Windows.Forms.Label();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TBRazonSocial = new System.Windows.Forms.TextBox();
            this.TBCUIT = new System.Windows.Forms.TextBox();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.LNuevoProveedor = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LRazonSocial
            // 
            this.LRazonSocial.AutoSize = true;
            this.LRazonSocial.Location = new System.Drawing.Point(55, 67);
            this.LRazonSocial.Name = "LRazonSocial";
            this.LRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.LRazonSocial.TabIndex = 0;
            this.LRazonSocial.Text = "Razón Social:";
            // 
            // LCUIT
            // 
            this.LCUIT.AutoSize = true;
            this.LCUIT.Location = new System.Drawing.Point(55, 104);
            this.LCUIT.Name = "LCUIT";
            this.LCUIT.Size = new System.Drawing.Size(35, 13);
            this.LCUIT.TabIndex = 1;
            this.LCUIT.Text = "CUIT:";
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Location = new System.Drawing.Point(55, 178);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(97, 13);
            this.LCorreo.TabIndex = 3;
            this.LCorreo.Text = "Correo Electrónico:";
            // 
            // TBRazonSocial
            // 
            this.TBRazonSocial.Location = new System.Drawing.Point(158, 64);
            this.TBRazonSocial.Name = "TBRazonSocial";
            this.TBRazonSocial.Size = new System.Drawing.Size(183, 20);
            this.TBRazonSocial.TabIndex = 4;
            this.TBRazonSocial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBCUIT
            // 
            this.TBCUIT.Location = new System.Drawing.Point(158, 101);
            this.TBCUIT.Name = "TBCUIT";
            this.TBCUIT.Size = new System.Drawing.Size(183, 20);
            this.TBCUIT.TabIndex = 5;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(158, 175);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(183, 20);
            this.TBCorreo.TabIndex = 7;
            // 
            // BGuardar
            // 
            this.BGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.Location = new System.Drawing.Point(113, 310);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(197, 60);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Location = new System.Drawing.Point(419, 310);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(197, 60);
            this.BCancelar.TabIndex = 9;
            this.BCancelar.Text = "Cancelar ";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // LNuevoProveedor
            // 
            this.LNuevoProveedor.AutoSize = true;
            this.LNuevoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNuevoProveedor.Location = new System.Drawing.Point(412, 118);
            this.LNuevoProveedor.Name = "LNuevoProveedor";
            this.LNuevoProveedor.Size = new System.Drawing.Size(301, 39);
            this.LNuevoProveedor.TabIndex = 10;
            this.LNuevoProveedor.Text = "Nuevo Proveedor";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(158, 136);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(183, 20);
            this.TBTelefono.TabIndex = 11;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(55, 139);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(52, 13);
            this.LTelefono.TabIndex = 12;
            this.LTelefono.Text = "Teléfono:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormProveedorABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.LNuevoProveedor);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.TBCorreo);
            this.Controls.Add(this.TBCUIT);
            this.Controls.Add(this.TBRazonSocial);
            this.Controls.Add(this.LCorreo);
            this.Controls.Add(this.LCUIT);
            this.Controls.Add(this.LRazonSocial);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormProveedorABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Proveedor";
            this.Load += new System.EventHandler(this.FormProveedorABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LRazonSocial;
        private System.Windows.Forms.Label LCUIT;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox TBRazonSocial;
        private System.Windows.Forms.TextBox TBCUIT;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label LNuevoProveedor;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}