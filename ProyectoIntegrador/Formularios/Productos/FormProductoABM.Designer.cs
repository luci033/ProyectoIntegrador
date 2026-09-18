namespace ProyectoIntegrador
{
    partial class FormProductoABM
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
            this.LNombre = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LCodigo = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.LGenero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LStockI = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.LStockM = new System.Windows.Forms.Label();
            this.textStockInicial = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textStockMinimo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.BCrearProducto = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.combGenero = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(62, 55);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Location = new System.Drawing.Point(62, 91);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(52, 13);
            this.LCategoria.TabIndex = 1;
            this.LCategoria.Text = "Categoria";
            // 
            // LCodigo
            // 
            this.LCodigo.AutoSize = true;
            this.LCodigo.Location = new System.Drawing.Point(66, 126);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(40, 13);
            this.LCodigo.TabIndex = 2;
            this.LCodigo.Text = "Código";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Location = new System.Drawing.Point(64, 334);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LDescripcion.TabIndex = 3;
            this.LDescripcion.Text = "Descripción";
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Location = new System.Drawing.Point(62, 155);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(42, 13);
            this.LGenero.TabIndex = 4;
            this.LGenero.Text = "Género";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Precio Unitario";
            // 
            // LStockI
            // 
            this.LStockI.AutoSize = true;
            this.LStockI.Location = new System.Drawing.Point(62, 223);
            this.LStockI.Name = "LStockI";
            this.LStockI.Size = new System.Drawing.Size(64, 13);
            this.LStockI.TabIndex = 6;
            this.LStockI.Text = "Stock inicial";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(170, 52);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(125, 20);
            this.textNombre.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 334);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 55);
            this.textBox2.TabIndex = 8;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(170, 119);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(125, 20);
            this.textCodigo.TabIndex = 9;
            // 
            // LStockM
            // 
            this.LStockM.AutoSize = true;
            this.LStockM.Location = new System.Drawing.Point(62, 260);
            this.LStockM.Name = "LStockM";
            this.LStockM.Size = new System.Drawing.Size(70, 13);
            this.LStockM.TabIndex = 11;
            this.LStockM.Text = "Stock minimo";
            // 
            // textStockInicial
            // 
            this.textStockInicial.Location = new System.Drawing.Point(170, 220);
            this.textStockInicial.Name = "textStockInicial";
            this.textStockInicial.Size = new System.Drawing.Size(125, 20);
            this.textStockInicial.TabIndex = 12;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(170, 187);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(125, 20);
            this.textPrecio.TabIndex = 14;
            // 
            // textStockMinimo
            // 
            this.textStockMinimo.Location = new System.Drawing.Point(170, 257);
            this.textStockMinimo.Name = "textStockMinimo";
            this.textStockMinimo.Size = new System.Drawing.Size(125, 20);
            this.textStockMinimo.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(170, 83);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(125, 21);
            this.cmbCategoria.TabIndex = 18;
            // 
            // BCrearProducto
            // 
            this.BCrearProducto.Location = new System.Drawing.Point(67, 415);
            this.BCrearProducto.Name = "BCrearProducto";
            this.BCrearProducto.Size = new System.Drawing.Size(130, 23);
            this.BCrearProducto.TabIndex = 20;
            this.BCrearProducto.Text = "Crear Producto";
            this.BCrearProducto.UseVisualStyleBackColor = true;
            this.BCrearProducto.Click += new System.EventHandler(this.BCrearProducto_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.CausesValidation = false;
            this.BCancelar.Location = new System.Drawing.Point(456, 415);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(130, 23);
            this.BCancelar.TabIndex = 21;
            this.BCancelar.Text = "Cancelar y Salir";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // combGenero
            // 
            this.combGenero.FormattingEnabled = true;
            this.combGenero.Location = new System.Drawing.Point(170, 152);
            this.combGenero.Name = "combGenero";
            this.combGenero.Size = new System.Drawing.Size(125, 21);
            this.combGenero.TabIndex = 22;
            // 
            // FormProductoABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 459);
            this.Controls.Add(this.combGenero);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BCrearProducto);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.textStockMinimo);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textStockInicial);
            this.Controls.Add(this.LStockM);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.LStockI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LGenero);
            this.Controls.Add(this.LDescripcion);
            this.Controls.Add(this.LCodigo);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.LNombre);
            this.Name = "FormProductoABM";
            this.Text = "Producto ABM";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.Label LGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LStockI;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label LStockM;
        private System.Windows.Forms.TextBox textStockMinimo;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textStockInicial;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button BCrearProducto;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.ComboBox combGenero;
    }
}