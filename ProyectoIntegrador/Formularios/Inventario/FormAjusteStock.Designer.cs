namespace ProyectoIntegrador.Formularios.Inventario
{
    partial class FormAjusteStock
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
            this.TBCodigoProducto = new System.Windows.Forms.TextBox();
            this.LCodigoProducto = new System.Windows.Forms.Label();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.BConfirmar = new System.Windows.Forms.Button();
            this.LUsuarioActivo = new System.Windows.Forms.Label();
            this.TBUsuarioActivo = new System.Windows.Forms.TextBox();
            this.TBNombreProducto = new System.Windows.Forms.TextBox();
            this.TBStockActual = new System.Windows.Forms.TextBox();
            this.LStockProducto = new System.Windows.Forms.Label();
            this.LTipoAjuste = new System.Windows.Forms.Label();
            this.CBTipoAjuste = new System.Windows.Forms.ComboBox();
            this.LCantidadAjustar = new System.Windows.Forms.Label();
            this.TBCantidadAjustar = new System.Windows.Forms.TextBox();
            this.TBObservaciones = new System.Windows.Forms.TextBox();
            this.LObservaciones = new System.Windows.Forms.Label();
            this.BCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBUsuarioActivo);
            this.panel1.Controls.Add(this.LUsuarioActivo);
            this.panel1.Controls.Add(this.TBCodigoProducto);
            this.panel1.Controls.Add(this.LCodigoProducto);
            this.panel1.Controls.Add(this.BBuscarProducto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 130);
            this.panel1.TabIndex = 0;
            // 
            // TBCodigoProducto
            // 
            this.TBCodigoProducto.Location = new System.Drawing.Point(129, 75);
            this.TBCodigoProducto.Name = "TBCodigoProducto";
            this.TBCodigoProducto.Size = new System.Drawing.Size(136, 20);
            this.TBCodigoProducto.TabIndex = 3;
            // 
            // LCodigoProducto
            // 
            this.LCodigoProducto.AutoSize = true;
            this.LCodigoProducto.Location = new System.Drawing.Point(34, 78);
            this.LCodigoProducto.Name = "LCodigoProducto";
            this.LCodigoProducto.Size = new System.Drawing.Size(89, 13);
            this.LCodigoProducto.TabIndex = 1;
            this.LCodigoProducto.Text = "Código Producto:";
            this.LCodigoProducto.Click += new System.EventHandler(this.LCodigoProducto_Click);
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProducto.Location = new System.Drawing.Point(509, 37);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(172, 54);
            this.BBuscarProducto.TabIndex = 0;
            this.BBuscarProducto.Text = "Buscar Producto";
            this.BBuscarProducto.UseVisualStyleBackColor = true;
            this.BBuscarProducto.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LObservaciones);
            this.panel2.Controls.Add(this.TBObservaciones);
            this.panel2.Controls.Add(this.TBCantidadAjustar);
            this.panel2.Controls.Add(this.LCantidadAjustar);
            this.panel2.Controls.Add(this.CBTipoAjuste);
            this.panel2.Controls.Add(this.LTipoAjuste);
            this.panel2.Controls.Add(this.TBStockActual);
            this.panel2.Controls.Add(this.LStockProducto);
            this.panel2.Controls.Add(this.TBNombreProducto);
            this.panel2.Controls.Add(this.LNombreProducto);
            this.panel2.Location = new System.Drawing.Point(12, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 255);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Location = new System.Drawing.Point(34, 19);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(110, 13);
            this.LNombreProducto.TabIndex = 1;
            this.LNombreProducto.Text = "Nombre del Producto:";
            // 
            // BConfirmar
            // 
            this.BConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConfirmar.Location = new System.Drawing.Point(635, 409);
            this.BConfirmar.Name = "BConfirmar";
            this.BConfirmar.Size = new System.Drawing.Size(153, 29);
            this.BConfirmar.TabIndex = 0;
            this.BConfirmar.Text = "Confirmar";
            this.BConfirmar.UseVisualStyleBackColor = true;
            this.BConfirmar.Click += new System.EventHandler(this.BConfirmar_Click);
            // 
            // LUsuarioActivo
            // 
            this.LUsuarioActivo.AutoSize = true;
            this.LUsuarioActivo.Location = new System.Drawing.Point(34, 35);
            this.LUsuarioActivo.Name = "LUsuarioActivo";
            this.LUsuarioActivo.Size = new System.Drawing.Size(79, 13);
            this.LUsuarioActivo.TabIndex = 8;
            this.LUsuarioActivo.Text = "Usuario Activo:";
            // 
            // TBUsuarioActivo
            // 
            this.TBUsuarioActivo.Location = new System.Drawing.Point(129, 32);
            this.TBUsuarioActivo.Name = "TBUsuarioActivo";
            this.TBUsuarioActivo.ReadOnly = true;
            this.TBUsuarioActivo.Size = new System.Drawing.Size(136, 20);
            this.TBUsuarioActivo.TabIndex = 9;
            // 
            // TBNombreProducto
            // 
            this.TBNombreProducto.Location = new System.Drawing.Point(147, 16);
            this.TBNombreProducto.Name = "TBNombreProducto";
            this.TBNombreProducto.ReadOnly = true;
            this.TBNombreProducto.Size = new System.Drawing.Size(136, 20);
            this.TBNombreProducto.TabIndex = 10;
            // 
            // TBStockActual
            // 
            this.TBStockActual.Location = new System.Drawing.Point(568, 16);
            this.TBStockActual.Name = "TBStockActual";
            this.TBStockActual.ReadOnly = true;
            this.TBStockActual.Size = new System.Drawing.Size(72, 20);
            this.TBStockActual.TabIndex = 12;
            // 
            // LStockProducto
            // 
            this.LStockProducto.AutoSize = true;
            this.LStockProducto.Location = new System.Drawing.Point(481, 19);
            this.LStockProducto.Name = "LStockProducto";
            this.LStockProducto.Size = new System.Drawing.Size(71, 13);
            this.LStockProducto.TabIndex = 11;
            this.LStockProducto.Text = "Stock Actual:";
            // 
            // LTipoAjuste
            // 
            this.LTipoAjuste.AutoSize = true;
            this.LTipoAjuste.Location = new System.Drawing.Point(34, 63);
            this.LTipoAjuste.Name = "LTipoAjuste";
            this.LTipoAjuste.Size = new System.Drawing.Size(78, 13);
            this.LTipoAjuste.TabIndex = 13;
            this.LTipoAjuste.Text = "Tipo de Ajuste:";
            // 
            // CBTipoAjuste
            // 
            this.CBTipoAjuste.FormattingEnabled = true;
            this.CBTipoAjuste.Items.AddRange(new object[] {
            "Egreso",
            "Ingreso"});
            this.CBTipoAjuste.Location = new System.Drawing.Point(147, 60);
            this.CBTipoAjuste.Name = "CBTipoAjuste";
            this.CBTipoAjuste.Size = new System.Drawing.Size(136, 21);
            this.CBTipoAjuste.TabIndex = 15;
            // 
            // LCantidadAjustar
            // 
            this.LCantidadAjustar.AutoSize = true;
            this.LCantidadAjustar.Location = new System.Drawing.Point(34, 105);
            this.LCantidadAjustar.Name = "LCantidadAjustar";
            this.LCantidadAjustar.Size = new System.Drawing.Size(96, 13);
            this.LCantidadAjustar.TabIndex = 17;
            this.LCantidadAjustar.Text = "Cantidad a Ajustar:";
            // 
            // TBCantidadAjustar
            // 
            this.TBCantidadAjustar.Location = new System.Drawing.Point(147, 102);
            this.TBCantidadAjustar.Name = "TBCantidadAjustar";
            this.TBCantidadAjustar.Size = new System.Drawing.Size(72, 20);
            this.TBCantidadAjustar.TabIndex = 10;
            // 
            // TBObservaciones
            // 
            this.TBObservaciones.Location = new System.Drawing.Point(568, 60);
            this.TBObservaciones.Multiline = true;
            this.TBObservaciones.Name = "TBObservaciones";
            this.TBObservaciones.Size = new System.Drawing.Size(136, 51);
            this.TBObservaciones.TabIndex = 18;
            // 
            // LObservaciones
            // 
            this.LObservaciones.AutoSize = true;
            this.LObservaciones.Location = new System.Drawing.Point(481, 63);
            this.LObservaciones.Name = "LObservaciones";
            this.LObservaciones.Size = new System.Drawing.Size(81, 13);
            this.LObservaciones.TabIndex = 19;
            this.LObservaciones.Text = "Observaciones:";
            // 
            // BCancelar
            // 
            this.BCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Location = new System.Drawing.Point(476, 409);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(153, 29);
            this.BCancelar.TabIndex = 4;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // FormAjusteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BConfirmar);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormAjusteStock";
            this.Text = "Ajuste de Stock";
            this.Load += new System.EventHandler(this.FormAjusteStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBCodigoProducto;
        private System.Windows.Forms.Label LCodigoProducto;
        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.Button BConfirmar;
        private System.Windows.Forms.TextBox TBUsuarioActivo;
        private System.Windows.Forms.Label LUsuarioActivo;
        private System.Windows.Forms.Label LTipoAjuste;
        private System.Windows.Forms.TextBox TBStockActual;
        private System.Windows.Forms.Label LStockProducto;
        private System.Windows.Forms.TextBox TBNombreProducto;
        private System.Windows.Forms.TextBox TBObservaciones;
        private System.Windows.Forms.TextBox TBCantidadAjustar;
        private System.Windows.Forms.Label LCantidadAjustar;
        private System.Windows.Forms.ComboBox CBTipoAjuste;
        private System.Windows.Forms.Label LObservaciones;
        private System.Windows.Forms.Button BCancelar;
    }
}