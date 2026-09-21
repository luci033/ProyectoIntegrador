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
            this.panelCard = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.LCLienteCobro = new System.Windows.Forms.Label();
            this.TBClienteCobro = new System.Windows.Forms.TextBox();
            this.LTotalCobro = new System.Windows.Forms.Label();
            this.TBTotalCobro = new System.Windows.Forms.TextBox();
            this.LMetodoPago = new System.Windows.Forms.Label();
            this.RBEfectivo = new System.Windows.Forms.RadioButton();
            this.RBTarjeta = new System.Windows.Forms.RadioButton();
            this.RBOtro = new System.Windows.Forms.RadioButton();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BVolver = new System.Windows.Forms.Button();
            this.BFinalizarVenta = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LSubtitulo);
            this.panelCard.Controls.Add(this.LCLienteCobro);
            this.panelCard.Controls.Add(this.TBClienteCobro);
            this.panelCard.Controls.Add(this.LTotalCobro);
            this.panelCard.Controls.Add(this.TBTotalCobro);
            this.panelCard.Controls.Add(this.LMetodoPago);
            this.panelCard.Controls.Add(this.RBEfectivo);
            this.panelCard.Controls.Add(this.RBTarjeta);
            this.panelCard.Controls.Add(this.RBOtro);
            this.panelCard.Controls.Add(this.BCancelar);
            this.panelCard.Controls.Add(this.BVolver);
            this.panelCard.Controls.Add(this.BFinalizarVenta);
            this.panelCard.Location = new System.Drawing.Point(20, 16);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(420, 370);
            this.panelCard.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(20, 18);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(256, 24);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Confirmación de Cobro";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.LSubtitulo.Location = new System.Drawing.Point(22, 44);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(262, 15);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Revise el importe y seleccione el medio de pago.";
            // 
            // LCLienteCobro
            // 
            this.LCLienteCobro.AutoSize = true;
            this.LCLienteCobro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCLienteCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LCLienteCobro.Location = new System.Drawing.Point(22, 75);
            this.LCLienteCobro.Name = "LCLienteCobro";
            this.LCLienteCobro.Size = new System.Drawing.Size(49, 15);
            this.LCLienteCobro.TabIndex = 2;
            this.LCLienteCobro.Text = "Cliente:";
            // 
            // TBClienteCobro
            // 
            this.TBClienteCobro.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.TBClienteCobro.Location = new System.Drawing.Point(22, 95);
            this.TBClienteCobro.Name = "TBClienteCobro";
            this.TBClienteCobro.ReadOnly = true;
            this.TBClienteCobro.Size = new System.Drawing.Size(376, 24);
            this.TBClienteCobro.TabIndex = 3;
            // 
            // LTotalCobro
            // 
            this.LTotalCobro.AutoSize = true;
            this.LTotalCobro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTotalCobro.Location = new System.Drawing.Point(22, 132);
            this.LTotalCobro.Name = "LTotalCobro";
            this.LTotalCobro.Size = new System.Drawing.Size(89, 15);
            this.LTotalCobro.TabIndex = 4;
            this.LTotalCobro.Text = "Total a Cobrar:";
            // 
            // TBTotalCobro
            // 
            this.TBTotalCobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.TBTotalCobro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotalCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.TBTotalCobro.Location = new System.Drawing.Point(22, 152);
            this.TBTotalCobro.Name = "TBTotalCobro";
            this.TBTotalCobro.ReadOnly = true;
            this.TBTotalCobro.Size = new System.Drawing.Size(376, 27);
            this.TBTotalCobro.TabIndex = 5;
            // 
            // LMetodoPago
            // 
            this.LMetodoPago.AutoSize = true;
            this.LMetodoPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMetodoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LMetodoPago.Location = new System.Drawing.Point(22, 195);
            this.LMetodoPago.Name = "LMetodoPago";
            this.LMetodoPago.Size = new System.Drawing.Size(100, 15);
            this.LMetodoPago.TabIndex = 6;
            this.LMetodoPago.Text = "Método de Pago:";
            // 
            // RBEfectivo
            // 
            this.RBEfectivo.AutoSize = true;
            this.RBEfectivo.Checked = true;
            this.RBEfectivo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.RBEfectivo.Location = new System.Drawing.Point(25, 222);
            this.RBEfectivo.Name = "RBEfectivo";
            this.RBEfectivo.Size = new System.Drawing.Size(71, 21);
            this.RBEfectivo.TabIndex = 7;
            this.RBEfectivo.TabStop = true;
            this.RBEfectivo.Text = "Efectivo";
            this.RBEfectivo.UseVisualStyleBackColor = true;
            // 
            // RBTarjeta
            // 
            this.RBTarjeta.AutoSize = true;
            this.RBTarjeta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.RBTarjeta.Location = new System.Drawing.Point(145, 222);
            this.RBTarjeta.Name = "RBTarjeta";
            this.RBTarjeta.Size = new System.Drawing.Size(65, 21);
            this.RBTarjeta.TabIndex = 8;
            this.RBTarjeta.Text = "Tarjeta";
            this.RBTarjeta.UseVisualStyleBackColor = true;
            // 
            // RBOtro
            // 
            this.RBOtro.AutoSize = true;
            this.RBOtro.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.RBOtro.Location = new System.Drawing.Point(255, 222);
            this.RBOtro.Name = "RBOtro";
            this.RBOtro.Size = new System.Drawing.Size(53, 21);
            this.RBOtro.TabIndex = 9;
            this.RBOtro.Text = "Otro";
            this.RBOtro.UseVisualStyleBackColor = true;
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(208)))), ((int)(((byte)(201)))));
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.BCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BCancelar.Location = new System.Drawing.Point(22, 310);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(85, 34);
            this.BCancelar.TabIndex = 10;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BVolver
            // 
            this.BVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(208)))), ((int)(((byte)(201)))));
            this.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVolver.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.BVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BVolver.Location = new System.Drawing.Point(115, 310);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(85, 34);
            this.BVolver.TabIndex = 11;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = false;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // BFinalizarVenta
            // 
            this.BFinalizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BFinalizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFinalizarVenta.Font = new System.Drawing.Font("Georgia", 9.5F, System.Drawing.FontStyle.Bold);
            this.BFinalizarVenta.ForeColor = System.Drawing.Color.White;
            this.BFinalizarVenta.Location = new System.Drawing.Point(210, 310);
            this.BFinalizarVenta.Name = "BFinalizarVenta";
            this.BFinalizarVenta.Size = new System.Drawing.Size(188, 34);
            this.BFinalizarVenta.TabIndex = 12;
            this.BFinalizarVenta.Text = "Finalizar Cobro";
            this.BFinalizarVenta.UseVisualStyleBackColor = false;
            this.BFinalizarVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(460, 405);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cobro de Venta";
            this.Load += new System.EventHandler(this.FromCobro_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
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