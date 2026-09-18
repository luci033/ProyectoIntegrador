namespace ProyectoIntegrador.Formularios.Principal
{
    partial class FormPrincipalLogistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalLogistica));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BAjusteStock = new System.Windows.Forms.Button();
            this.BCompras = new System.Windows.Forms.Button();
            this.BProductos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BAjusteStock);
            this.panel1.Controls.Add(this.BCompras);
            this.panel1.Controls.Add(this.BProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 664);
            this.panel1.TabIndex = 3;
            // 
            // BAjusteStock
            // 
            this.BAjusteStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BAjusteStock.BackgroundImage")));
            this.BAjusteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAjusteStock.ForeColor = System.Drawing.Color.Transparent;
            this.BAjusteStock.Location = new System.Drawing.Point(30, 288);
            this.BAjusteStock.Name = "BAjusteStock";
            this.BAjusteStock.Size = new System.Drawing.Size(100, 100);
            this.BAjusteStock.TabIndex = 3;
            this.BAjusteStock.UseVisualStyleBackColor = true;
            this.BAjusteStock.Click += new System.EventHandler(this.BAjusteStock_Click);
            // 
            // BCompras
            // 
            this.BCompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BCompras.BackgroundImage")));
            this.BCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCompras.ForeColor = System.Drawing.Color.Transparent;
            this.BCompras.Location = new System.Drawing.Point(30, 156);
            this.BCompras.Name = "BCompras";
            this.BCompras.Size = new System.Drawing.Size(100, 100);
            this.BCompras.TabIndex = 2;
            this.BCompras.UseVisualStyleBackColor = true;
            this.BCompras.Click += new System.EventHandler(this.BCompras_Click);
            // 
            // BProductos
            // 
            this.BProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BProductos.BackgroundImage")));
            this.BProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProductos.ForeColor = System.Drawing.Color.Transparent;
            this.BProductos.Location = new System.Drawing.Point(30, 28);
            this.BProductos.Name = "BProductos";
            this.BProductos.Size = new System.Drawing.Size(100, 100);
            this.BProductos.TabIndex = 1;
            this.BProductos.UseVisualStyleBackColor = false;
            this.BProductos.Click += new System.EventHandler(this.BProductos_Click);
            // 
            // FormPrincipalLogistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 664);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipalLogistica";
            this.Text = "Joyería ALBA - Logística";
            this.Load += new System.EventHandler(this.FormPrincipalLogistica_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BAjusteStock;
        private System.Windows.Forms.Button BCompras;
        private System.Windows.Forms.Button BProductos;
    }
}