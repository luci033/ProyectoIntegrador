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
            this.TNuevaCategoria = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.LCategorias = new System.Windows.Forms.Label();
            this.LNuevaCaterogoria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TNuevaCategoria
            // 
            this.TNuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNuevaCategoria.Location = new System.Drawing.Point(31, 52);
            this.TNuevaCategoria.Name = "TNuevaCategoria";
            this.TNuevaCategoria.Size = new System.Drawing.Size(328, 38);
            this.TNuevaCategoria.TabIndex = 5;
            this.TNuevaCategoria.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.TNuevaCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.TCategoria_Validating);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(237, 109);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(122, 36);
            this.BGuardar.TabIndex = 6;
            this.BGuardar.Text = "Guardar Categoría";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.CausesValidation = false;
            this.BCancelar.Location = new System.Drawing.Point(145, 109);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(86, 36);
            this.BCancelar.TabIndex = 7;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // LCategorias
            // 
            this.LCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategorias.Location = new System.Drawing.Point(198, 127);
            this.LCategorias.Name = "LCategorias";
            this.LCategorias.Size = new System.Drawing.Size(376, 42);
            this.LCategorias.TabIndex = 9;
            this.LCategorias.Text = "Agregar nueva categoría";
            this.LCategorias.Click += new System.EventHandler(this.LCategorias_Click);
            // 
            // LNuevaCaterogoria
            // 
            this.LNuevaCaterogoria.AutoSize = true;
            this.LNuevaCaterogoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNuevaCaterogoria.Location = new System.Drawing.Point(26, 24);
            this.LNuevaCaterogoria.Name = "LNuevaCaterogoria";
            this.LNuevaCaterogoria.Size = new System.Drawing.Size(235, 25);
            this.LNuevaCaterogoria.TabIndex = 0;
            this.LNuevaCaterogoria.Text = "Nombre de la categoria";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BGuardar);
            this.panel1.Controls.Add(this.LNuevaCaterogoria);
            this.panel1.Controls.Add(this.TNuevaCategoria);
            this.panel1.Controls.Add(this.BCancelar);
            this.panel1.Location = new System.Drawing.Point(182, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 167);
            this.panel1.TabIndex = 10;
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LCategorias);
            this.Name = "FormNuevaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Categoría";
            this.Load += new System.EventHandler(this.FormNuevaCategoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TNuevaCategoria;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label LCategorias;
        private System.Windows.Forms.Label LNuevaCaterogoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}