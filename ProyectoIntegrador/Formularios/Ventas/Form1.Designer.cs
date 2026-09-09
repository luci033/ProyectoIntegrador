namespace ProyectoIntegrador.Formularios.Ventas
{
    partial class FinalizarCompra
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
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.LMetodoPago = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.TBCliente = new System.Windows.Forms.TextBox();
            this.LCLiente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBTelefono);
            this.panel1.Controls.Add(this.LMetodoPago);
            this.panel1.Controls.Add(this.LTotal);
            this.panel1.Controls.Add(this.TBCliente);
            this.panel1.Controls.Add(this.LCLiente);
            this.panel1.Location = new System.Drawing.Point(52, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 128);
            this.panel1.TabIndex = 9;
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(87, 52);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(100, 20);
            this.TBTelefono.TabIndex = 4;
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
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(23, 55);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(31, 13);
            this.LTotal.TabIndex = 2;
            this.LTotal.Text = "Total";
            this.LTotal.Click += new System.EventHandler(this.LTelefono_Click);
            // 
            // TBCliente
            // 
            this.TBCliente.Location = new System.Drawing.Point(87, 17);
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.Size = new System.Drawing.Size(100, 20);
            this.TBCliente.TabIndex = 1;
            // 
            // LCLiente
            // 
            this.LCLiente.AutoSize = true;
            this.LCLiente.Location = new System.Drawing.Point(23, 24);
            this.LCLiente.Name = "LCLiente";
            this.LCLiente.Size = new System.Drawing.Size(39, 13);
            this.LCLiente.TabIndex = 0;
            this.LCLiente.Text = "Cliente";
            // 
            // FinalizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FinalizarCompra";
            this.Text = "Finaliza Compra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label LMetodoPago;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.TextBox TBCliente;
        private System.Windows.Forms.Label LCLiente;
    }
}