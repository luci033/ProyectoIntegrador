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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductoABM));
            this.panelCard = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.LCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.LGenero = new System.Windows.Forms.Label();
            this.combGenero = new System.Windows.Forms.ComboBox();
            this.LProveedor = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.LStockI = new System.Windows.Forms.Label();
            this.textStockInicial = new System.Windows.Forms.TextBox();
            this.LStockM = new System.Windows.Forms.Label();
            this.textStockMinimo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BCrearProducto = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LNombre);
            this.panelCard.Controls.Add(this.textNombre);
            this.panelCard.Controls.Add(this.LCategoria);
            this.panelCard.Controls.Add(this.cmbCategoria);
            this.panelCard.Controls.Add(this.LGenero);
            this.panelCard.Controls.Add(this.combGenero);
            this.panelCard.Controls.Add(this.LProveedor);
            this.panelCard.Controls.Add(this.cmbProveedor);
            this.panelCard.Controls.Add(this.LDescripcion);
            this.panelCard.Controls.Add(this.textDescripcion);
            this.panelCard.Controls.Add(this.label1);
            this.panelCard.Controls.Add(this.textPrecio);
            this.panelCard.Controls.Add(this.LStockI);
            this.panelCard.Controls.Add(this.textStockInicial);
            this.panelCard.Controls.Add(this.LStockM);
            this.panelCard.Controls.Add(this.textStockMinimo);
            this.panelCard.Controls.Add(this.pictureBox1);
            this.panelCard.Controls.Add(this.BCrearProducto);
            this.panelCard.Controls.Add(this.BCancelar);
            this.panelCard.Location = new System.Drawing.Point(25, 12);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(760, 520);
            this.panelCard.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(20, 18);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(720, 36);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Registrar Producto";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LNombre.Location = new System.Drawing.Point(40, 68);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(62, 17);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre:";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textNombre.Location = new System.Drawing.Point(40, 89);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(320, 25);
            this.textNombre.TabIndex = 2;
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LCategoria.Location = new System.Drawing.Point(40, 122);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(71, 17);
            this.LCategoria.TabIndex = 3;
            this.LCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(40, 143);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(320, 24);
            this.cmbCategoria.TabIndex = 4;
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LGenero.Location = new System.Drawing.Point(40, 176);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(56, 17);
            this.LGenero.TabIndex = 5;
            this.LGenero.Text = "Género:";
            // 
            // combGenero
            // 
            this.combGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combGenero.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.combGenero.FormattingEnabled = true;
            this.combGenero.Location = new System.Drawing.Point(40, 197);
            this.combGenero.Name = "combGenero";
            this.combGenero.Size = new System.Drawing.Size(320, 24);
            this.combGenero.TabIndex = 6;
            // 
            // LProveedor
            // 
            this.LProveedor.AutoSize = true;
            this.LProveedor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LProveedor.Location = new System.Drawing.Point(40, 230);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(75, 17);
            this.LProveedor.TabIndex = 7;
            this.LProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(40, 251);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(320, 24);
            this.cmbProveedor.TabIndex = 8;
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LDescripcion.Location = new System.Drawing.Point(40, 284);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(84, 17);
            this.LDescripcion.TabIndex = 9;
            this.LDescripcion.Text = "Descripción:";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textDescripcion.Location = new System.Drawing.Point(40, 305);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(320, 115);
            this.textDescripcion.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(400, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Precio Unitario:";
            // 
            // textPrecio
            // 
            this.textPrecio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textPrecio.Location = new System.Drawing.Point(400, 89);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.ReadOnly = true;
            this.textPrecio.Size = new System.Drawing.Size(320, 25);
            this.textPrecio.TabIndex = 12;
            this.textPrecio.TextChanged += new System.EventHandler(this.textPrecio_TextChanged);
            // 
            // LStockI
            // 
            this.LStockI.AutoSize = true;
            this.LStockI.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LStockI.Location = new System.Drawing.Point(400, 122);
            this.LStockI.Name = "LStockI";
            this.LStockI.Size = new System.Drawing.Size(89, 17);
            this.LStockI.TabIndex = 13;
            this.LStockI.Text = "Stock Actual:";
            // 
            // textStockInicial
            // 
            this.textStockInicial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textStockInicial.Location = new System.Drawing.Point(400, 143);
            this.textStockInicial.Name = "textStockInicial";
            this.textStockInicial.ReadOnly = true;
            this.textStockInicial.Size = new System.Drawing.Size(320, 25);
            this.textStockInicial.TabIndex = 14;
            // 
            // LStockM
            // 
            this.LStockM.AutoSize = true;
            this.LStockM.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.LStockM.Location = new System.Drawing.Point(400, 176);
            this.LStockM.Name = "LStockM";
            this.LStockM.Size = new System.Drawing.Size(98, 17);
            this.LStockM.TabIndex = 15;
            this.LStockM.Text = "Stock Mínimo:";
            // 
            // textStockMinimo
            // 
            this.textStockMinimo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textStockMinimo.Location = new System.Drawing.Point(400, 197);
            this.textStockMinimo.Name = "textStockMinimo";
            this.textStockMinimo.Size = new System.Drawing.Size(320, 25);
            this.textStockMinimo.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BCrearProducto
            // 
            this.BCrearProducto.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold);
            this.BCrearProducto.Location = new System.Drawing.Point(140, 445);
            this.BCrearProducto.Name = "BCrearProducto";
            this.BCrearProducto.Size = new System.Drawing.Size(220, 44);
            this.BCrearProducto.TabIndex = 18;
            this.BCrearProducto.Text = "Crear Producto";
            this.BCrearProducto.UseVisualStyleBackColor = true;
            this.BCrearProducto.Click += new System.EventHandler(this.BCrearProducto_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.CausesValidation = false;
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold);
            this.BCancelar.Location = new System.Drawing.Point(400, 445);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(220, 44);
            this.BCancelar.TabIndex = 19;
            this.BCancelar.Text = "Cancelar y Salir";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormProductoABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 550);
            this.Controls.Add(this.panelCard);
            this.MinimumSize = new System.Drawing.Size(820, 560);
            this.Name = "FormProductoABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.FormProductoABM_Resize);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
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