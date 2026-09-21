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
            this.panelCard = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.BRegistrarVenta = new System.Windows.Forms.Button();
            this.BHistorialVenta = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LSubtitulo);
            this.panelCard.Controls.Add(this.BRegistrarVenta);
            this.panelCard.Controls.Add(this.BHistorialVenta);
            this.panelCard.Location = new System.Drawing.Point(130, 45);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(540, 360);
            this.panelCard.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(0, 24);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(540, 30);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Módulo de Ventas";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.LSubtitulo.Location = new System.Drawing.Point(0, 56);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(540, 22);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Seleccione la operación que desea realizar";
            this.LSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BRegistrarVenta
            // 
            this.BRegistrarVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BRegistrarVenta.BackgroundImage")));
            this.BRegistrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.BRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegistrarVenta.ForeColor = System.Drawing.Color.Transparent;
            this.BRegistrarVenta.Location = new System.Drawing.Point(55, 105);
            this.BRegistrarVenta.Name = "BRegistrarVenta";
            this.BRegistrarVenta.Size = new System.Drawing.Size(190, 190);
            this.BRegistrarVenta.TabIndex = 2;
            this.BRegistrarVenta.UseVisualStyleBackColor = true;
            this.BRegistrarVenta.Click += new System.EventHandler(this.BRegistrarVenta_Click);
            // 
            // BHistorialVenta
            // 
            this.BHistorialVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BHistorialVenta.BackgroundImage")));
            this.BHistorialVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BHistorialVenta.FlatAppearance.BorderSize = 0;
            this.BHistorialVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BHistorialVenta.ForeColor = System.Drawing.Color.Transparent;
            this.BHistorialVenta.Location = new System.Drawing.Point(295, 105);
            this.BHistorialVenta.Name = "BHistorialVenta";
            this.BHistorialVenta.Size = new System.Drawing.Size(190, 190);
            this.BHistorialVenta.TabIndex = 3;
            this.BHistorialVenta.UseVisualStyleBackColor = true;
            this.BHistorialVenta.Click += new System.EventHandler(this.BHistorialVenta_Click);
            // 
            // FormOpcionesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCard);
            this.Name = "FormOpcionesVenta";
            this.Text = "Opciones de Venta";
            this.Load += new System.EventHandler(this.FormOpcionesVenta_Load);
            this.Resize += new System.EventHandler(this.FormOpcionesVenta_Resize);
            this.panelCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Button BRegistrarVenta;
        private System.Windows.Forms.Button BHistorialVenta;
    }
}