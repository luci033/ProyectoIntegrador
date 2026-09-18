namespace ProyectoIntegrador.Formularios.Ventas
{
    partial class FormCobro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RBOtro = new System.Windows.Forms.RadioButton();
            this.TBTotalCobro = new System.Windows.Forms.TextBox();
            this.RBTarjeta = new System.Windows.Forms.RadioButton();
            this.LMetodoPago = new System.Windows.Forms.Label();
            this.RBEfectivo = new System.Windows.Forms.RadioButton();
            this.LTotalCobro = new System.Windows.Forms.Label();
            this.TBClienteCobro = new System.Windows.Forms.TextBox();
            this.LCLienteCobro = new System.Windows.Forms.Label();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BVolver = new System.Windows.Forms.Button();
            this.BFinalizarVenta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBOtro);
            this.panel1.Controls.Add(this.TBTotalCobro);
            this.panel1.Controls.Add(this.RBTarjeta);
            this.panel1.Controls.Add(this.LMetodoPago);
            this.panel1.Controls.Add(this.RBEfectivo);
            this.panel1.Controls.Add(this.LTotalCobro);
            this.panel1.Controls.Add(this.TBClienteCobro);
            this.panel1.Controls.Add(this.LCLienteCobro);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 187);
            this.panel1.TabIndex = 9;
            // 
            // RBOtro
            // 
            this.RBOtro.AutoSize = true;
            this.RBOtro.Location = new System.Drawing.Point(124, 137);
            this.RBOtro.Name = "RBOtro";
            this.RBOtro.Size = new System.Drawing.Size(45, 17);
            this.RBOtro.TabIndex = 15;
            this.RBOtro.TabStop = true;
            this.RBOtro.Text = "Otro";
            this.RBOtro.UseVisualStyleBackColor = true;
            // 
            // TBTotalCobro
            // 
            this.TBTotalCobro.Location = new System.Drawing.Point(124, 55);
            this.TBTotalCobro.Name = "TBTotalCobro";
            this.TBTotalCobro.Size = new System.Drawing.Size(100, 20);
            this.TBTotalCobro.TabIndex = 4;
            // 
            // RBTarjeta
            // 
            this.RBTarjeta.AutoSize = true;
            this.RBTarjeta.Location = new System.Drawing.Point(124, 114);
            this.RBTarjeta.Name = "RBTarjeta";
            this.RBTarjeta.Size = new System.Drawing.Size(58, 17);
            this.RBTarjeta.TabIndex = 14;
            this.RBTarjeta.TabStop = true;
            this.RBTarjeta.Text = "Tarjeta";
            this.RBTarjeta.UseVisualStyleBackColor = true;
            // 
            // LMetodoPago
            // 
            this.LMetodoPago.AutoSize = true;
            this.LMetodoPago.Location = new System.Drawing.Point(23, 91);
            this.LMetodoPago.Name = "LMetodoPago";
            this.LMetodoPago.Size = new System.Drawing.Size(86, 13);
            this.LMetodoPago.TabIndex = 3;
            this.LMetodoPago.Text = "Método de Pago";
            // 
            // RBEfectivo
            // 
            this.RBEfectivo.AutoSize = true;
            this.RBEfectivo.Location = new System.Drawing.Point(124, 91);
            this.RBEfectivo.Name = "RBEfectivo";
            this.RBEfectivo.Size = new System.Drawing.Size(64, 17);
            this.RBEfectivo.TabIndex = 13;
            this.RBEfectivo.TabStop = true;
            this.RBEfectivo.Text = "Efectivo";
            this.RBEfectivo.UseVisualStyleBackColor = true;
            // 
            // LTotalCobro
            // 
            this.LTotalCobro.AutoSize = true;
            this.LTotalCobro.Location = new System.Drawing.Point(23, 55);
            this.LTotalCobro.Name = "LTotalCobro";
            this.LTotalCobro.Size = new System.Drawing.Size(31, 13);
            this.LTotalCobro.TabIndex = 2;
            this.LTotalCobro.Text = "Total";
            // 
            // TBClienteCobro
            // 
            this.TBClienteCobro.Location = new System.Drawing.Point(124, 21);
            this.TBClienteCobro.Name = "TBClienteCobro";
            this.TBClienteCobro.Size = new System.Drawing.Size(100, 20);
            this.TBClienteCobro.TabIndex = 1;
            // 
            // LCLienteCobro
            // 
            this.LCLienteCobro.AutoSize = true;
            this.LCLienteCobro.Location = new System.Drawing.Point(23, 24);
            this.LCLienteCobro.Name = "LCLienteCobro";
            this.LCLienteCobro.Size = new System.Drawing.Size(39, 13);
            this.LCLienteCobro.TabIndex = 0;
            this.LCLienteCobro.Text = "Cliente";
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(30, 249);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(60, 32);
            this.BCancelar.TabIndex = 10;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BVolver
            // 
            this.BVolver.Location = new System.Drawing.Point(174, 249);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(60, 32);
            this.BVolver.TabIndex = 11;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // BFinalizarVenta
            // 
            this.BFinalizarVenta.Location = new System.Drawing.Point(249, 249);
            this.BFinalizarVenta.Name = "BFinalizarVenta";
            this.BFinalizarVenta.Size = new System.Drawing.Size(109, 32);
            this.BFinalizarVenta.TabIndex = 12;
            this.BFinalizarVenta.Text = "Finalizar Compra";
            this.BFinalizarVenta.UseVisualStyleBackColor = true;
            this.BFinalizarVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 328);
            this.Controls.Add(this.BFinalizarVenta);
            this.Controls.Add(this.BVolver);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.panel1);
            this.Name = "FormCobro";
            this.Text = "Cobro";
            this.Load += new System.EventHandler(this.FromCobro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBTotalCobro;
        private System.Windows.Forms.Label LMetodoPago;
        private System.Windows.Forms.Label LTotalCobro;
        private System.Windows.Forms.TextBox TBClienteCobro;
        private System.Windows.Forms.Label LCLienteCobro;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.Button BFinalizarVenta;
        private System.Windows.Forms.RadioButton RBEfectivo;
        private System.Windows.Forms.RadioButton RBOtro;
        private System.Windows.Forms.RadioButton RBTarjeta;
    }
}