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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductoABM));
            this.LNombre = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.LGenero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LStockI = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.LStockM = new System.Windows.Forms.Label();
            this.textStockInicial = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textStockMinimo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.BCrearProducto = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.combGenero = new System.Windows.Forms.ComboBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LProveedor = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(72, 103);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(47, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Location = new System.Drawing.Point(72, 142);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(57, 13);
            this.LCategoria.TabIndex = 1;
            this.LCategoria.Text = "Categoría:";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Location = new System.Drawing.Point(72, 358);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LDescripcion.TabIndex = 3;
            this.LDescripcion.Text = "Descripción:";
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Location = new System.Drawing.Point(72, 182);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(45, 13);
            this.LGenero.TabIndex = 4;
            this.LGenero.Text = "Género:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Precio Unitario:";
            // 
            // LStockI
            // 
            this.LStockI.AutoSize = true;
            this.LStockI.Location = new System.Drawing.Point(72, 282);
            this.LStockI.Name = "LStockI";
            this.LStockI.Size = new System.Drawing.Size(71, 13);
            this.LStockI.TabIndex = 6;
            this.LStockI.Text = "Stock Actual:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(180, 100);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(125, 20);
            this.textNombre.TabIndex = 0;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(180, 355);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(123, 55);
            this.textDescripcion.TabIndex = 7;
            // 
            // LStockM
            // 
            this.LStockM.AutoSize = true;
            this.LStockM.Location = new System.Drawing.Point(72, 320);
            this.LStockM.Name = "LStockM";
            this.LStockM.Size = new System.Drawing.Size(76, 13);
            this.LStockM.TabIndex = 11;
            this.LStockM.Text = "Stock Mínimo:";
            // 
            // textStockInicial
            // 
            this.textStockInicial.Location = new System.Drawing.Point(180, 279);
            this.textStockInicial.Name = "textStockInicial";
            this.textStockInicial.ReadOnly = true;
            this.textStockInicial.Size = new System.Drawing.Size(125, 20);
            this.textStockInicial.TabIndex = 5;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(180, 243);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.ReadOnly = true;
            this.textPrecio.Size = new System.Drawing.Size(125, 20);
            this.textPrecio.TabIndex = 4;
            this.textPrecio.TextChanged += new System.EventHandler(this.textPrecio_TextChanged);
            // 
            // textStockMinimo
            // 
            this.textStockMinimo.Location = new System.Drawing.Point(180, 317);
            this.textStockMinimo.Name = "textStockMinimo";
            this.textStockMinimo.Size = new System.Drawing.Size(125, 20);
            this.textStockMinimo.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(180, 139);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(125, 21);
            this.cmbCategoria.TabIndex = 1;
            // 
            // BCrearProducto
            // 
            this.BCrearProducto.Location = new System.Drawing.Point(173, 441);
            this.BCrearProducto.Name = "BCrearProducto";
            this.BCrearProducto.Size = new System.Drawing.Size(130, 23);
            this.BCrearProducto.TabIndex = 8;
            this.BCrearProducto.Text = "Crear Producto";
            this.BCrearProducto.UseVisualStyleBackColor = true;
            this.BCrearProducto.Click += new System.EventHandler(this.BCrearProducto_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.CausesValidation = false;
            this.BCancelar.Location = new System.Drawing.Point(492, 441);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(130, 23);
            this.BCancelar.TabIndex = 9;
            this.BCancelar.Text = "Cancelar y Salir";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // combGenero
            // 
            this.combGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combGenero.FormattingEnabled = true;
            this.combGenero.Location = new System.Drawing.Point(180, 179);
            this.combGenero.Name = "combGenero";
            this.combGenero.Size = new System.Drawing.Size(125, 21);
            this.combGenero.TabIndex = 2;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Location = new System.Drawing.Point(72, 41);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(95, 13);
            this.LTitulo.TabIndex = 23;
            this.LTitulo.Text = "Registrar Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(492, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // LProveedor
            // 
            this.LProveedor.AutoSize = true;
            this.LProveedor.Location = new System.Drawing.Point(72, 216);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(59, 13);
            this.LProveedor.TabIndex = 25;
            this.LProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(180, 213);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(125, 21);
            this.cmbProveedor.TabIndex = 3;
            // 
            // FormProductoABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 508);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.LProveedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.combGenero);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BCrearProducto);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.textStockMinimo);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textStockInicial);
            this.Controls.Add(this.LStockM);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.LStockI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LGenero);
            this.Controls.Add(this.LDescripcion);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.LNombre);
            this.Name = "FormProductoABM";
            this.Text = "Registrar Producto";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.Label LGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LStockI;
        private System.Windows.Forms.TextBox textDescripcion;
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
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
    }
}