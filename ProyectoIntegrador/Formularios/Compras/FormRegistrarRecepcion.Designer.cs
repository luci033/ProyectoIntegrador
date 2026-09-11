namespace ProyectoIntegrador.Formularios.Compras
{
    partial class FormRegistrarRecepcion
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
            this.LRegistrarRecepcion = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.TBFechaRecepcion = new System.Windows.Forms.TextBox();
            this.TBObservacion = new System.Windows.Forms.TextBox();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LRegistrarRecepcion
            // 
            this.LRegistrarRecepcion.AutoSize = true;
            this.LRegistrarRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarRecepcion.Location = new System.Drawing.Point(175, 68);
            this.LRegistrarRecepcion.Name = "LRegistrarRecepcion";
            this.LRegistrarRecepcion.Size = new System.Drawing.Size(479, 55);
            this.LRegistrarRecepcion.TabIndex = 0;
            this.LRegistrarRecepcion.Text = "Registrar Recepción";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(63, 73);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(40, 13);
            this.LFecha.TabIndex = 1;
            this.LFecha.Text = "Fecha:";
            // 
            // TBFechaRecepcion
            // 
            this.TBFechaRecepcion.Location = new System.Drawing.Point(109, 70);
            this.TBFechaRecepcion.Name = "TBFechaRecepcion";
            this.TBFechaRecepcion.ReadOnly = true;
            this.TBFechaRecepcion.Size = new System.Drawing.Size(102, 20);
            this.TBFechaRecepcion.TabIndex = 2;
            // 
            // TBObservacion
            // 
            this.TBObservacion.Location = new System.Drawing.Point(402, 70);
            this.TBObservacion.Multiline = true;
            this.TBObservacion.Name = "TBObservacion";
            this.TBObservacion.Size = new System.Drawing.Size(214, 80);
            this.TBObservacion.TabIndex = 3;
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Location = new System.Drawing.Point(330, 70);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LDescripcion.TabIndex = 4;
            this.LDescripcion.Text = "Descripción:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBFechaRecepcion);
            this.panel1.Controls.Add(this.LFecha);
            this.panel1.Controls.Add(this.LDescripcion);
            this.panel1.Controls.Add(this.TBObservacion);
            this.panel1.Location = new System.Drawing.Point(67, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 220);
            this.panel1.TabIndex = 5;
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(592, 391);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(150, 33);
            this.BAceptar.TabIndex = 7;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(436, 391);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(150, 33);
            this.BCancelar.TabIndex = 8;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // FormRegistrarRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LRegistrarRecepcion);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormRegistrarRecepcion";
            this.Text = "RegistrarRecepcion";
            this.Load += new System.EventHandler(this.FormRegistrarRecepcion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LRegistrarRecepcion;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.TextBox TBFechaRecepcion;
        private System.Windows.Forms.TextBox TBObservacion;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCancelar;
    }
}