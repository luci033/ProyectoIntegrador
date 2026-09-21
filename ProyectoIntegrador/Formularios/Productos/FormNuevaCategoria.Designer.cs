namespace ProyectoIntegrador.Formularios.Productos
{
    partial class FormNuevaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevaCategoria));
            this.panelCard = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LNuevaCaterogoria = new System.Windows.Forms.Label();
            this.TNuevaCategoria = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LNuevaCaterogoria);
            this.panelCard.Controls.Add(this.TNuevaCategoria);
            this.panelCard.Controls.Add(this.BGuardar);
            this.panelCard.Controls.Add(this.BCancelar);
            this.panelCard.Controls.Add(this.pictureBox1);
            this.panelCard.Location = new System.Drawing.Point(130, 40);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(540, 320);
            this.panelCard.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(20, 25);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(500, 38);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Agregar Nueva Categoría";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LTitulo.Click += new System.EventHandler(this.LCategorias_Click);
            // 
            // LNuevaCaterogoria
            // 
            this.LNuevaCaterogoria.AutoSize = true;
            this.LNuevaCaterogoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNuevaCaterogoria.Location = new System.Drawing.Point(50, 85);
            this.LNuevaCaterogoria.Name = "LNuevaCaterogoria";
            this.LNuevaCaterogoria.Size = new System.Drawing.Size(167, 19);
            this.LNuevaCaterogoria.TabIndex = 1;
            this.LNuevaCaterogoria.Text = "Nombre de la categoría:";
            // 
            // TNuevaCategoria
            // 
            this.TNuevaCategoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNuevaCategoria.Location = new System.Drawing.Point(50, 115);
            this.TNuevaCategoria.Name = "TNuevaCategoria";
            this.TNuevaCategoria.Size = new System.Drawing.Size(440, 27);
            this.TNuevaCategoria.TabIndex = 2;
            this.TNuevaCategoria.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.TNuevaCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.TCategoria_Validating);
            // 
            // BGuardar
            // 
            this.BGuardar.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.Location = new System.Drawing.Point(50, 185);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(210, 44);
            this.BGuardar.TabIndex = 3;
            this.BGuardar.Text = "Guardar Categoría";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.CausesValidation = false;
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Location = new System.Drawing.Point(280, 185);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(210, 44);
            this.BCancelar.TabIndex = 4;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNuevaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCard);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormNuevaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Categoría";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNuevaCategoria_Load);
            this.Resize += new System.EventHandler(this.FormNuevaCategoria_Resize);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TNuevaCategoria;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LNuevaCaterogoria;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}