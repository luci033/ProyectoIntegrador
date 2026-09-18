namespace ProyectoIntegrador.Formularios.Ventas
{
    partial class FormOpcionesVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcionesVenta));
            this.BRegistrarVenta = new System.Windows.Forms.Button();
            this.BHistorialVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BRegistrarVenta
            // 
            this.BRegistrarVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BRegistrarVenta.BackgroundImage")));
            this.BRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegistrarVenta.ForeColor = System.Drawing.Color.Transparent;
            this.BRegistrarVenta.Location = new System.Drawing.Point(172, 126);
            this.BRegistrarVenta.Name = "BRegistrarVenta";
            this.BRegistrarVenta.Size = new System.Drawing.Size(200, 200);
            this.BRegistrarVenta.TabIndex = 1;
            this.BRegistrarVenta.UseVisualStyleBackColor = true;
            this.BRegistrarVenta.Click += new System.EventHandler(this.BRegistrarVenta_Click);
            // 
            // BHistorialVenta
            // 
            this.BHistorialVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BHistorialVenta.BackgroundImage")));
            this.BHistorialVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BHistorialVenta.ForeColor = System.Drawing.Color.Transparent;
            this.BHistorialVenta.Location = new System.Drawing.Point(399, 126);
            this.BHistorialVenta.Name = "BHistorialVenta";
            this.BHistorialVenta.Size = new System.Drawing.Size(200, 200);
            this.BHistorialVenta.TabIndex = 2;
            this.BHistorialVenta.UseVisualStyleBackColor = true;
            this.BHistorialVenta.Click += new System.EventHandler(this.BHistorialVenta_Click);
            // 
            // FormOpcionesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BHistorialVenta);
            this.Controls.Add(this.BRegistrarVenta);
            this.Name = "FormOpcionesVenta";
            this.Text = "FormOpcionesVenta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BRegistrarVenta;
        private System.Windows.Forms.Button BHistorialVenta;
    }
}