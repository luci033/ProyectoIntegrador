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
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.LCodigoProducto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LStockActual = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.LStockActual);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.LCodigoProducto);
            this.panel1.Controls.Add(this.BBuscarProducto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 146);
            this.panel1.TabIndex = 0;
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProducto.Location = new System.Drawing.Point(420, 61);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(148, 44);
            this.BBuscarProducto.TabIndex = 0;
            this.BBuscarProducto.Text = "Buscar Producto";
            this.BBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // LCodigoProducto
            // 
            this.LCodigoProducto.AutoSize = true;
            this.LCodigoProducto.Location = new System.Drawing.Point(34, 44);
            this.LCodigoProducto.Name = "LCodigoProducto";
            this.LCodigoProducto.Size = new System.Drawing.Size(89, 13);
            this.LCodigoProducto.TabIndex = 1;
            this.LCodigoProducto.Text = "Código Producto:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labe);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 239);
            this.panel2.TabIndex = 3;
            // 
            // labe
            // 
            this.labe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labe.Location = new System.Drawing.Point(141, 82);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(63, 21);
            this.labe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 3;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(129, 75);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.ReadOnly = true;
            this.TBNombre.Size = new System.Drawing.Size(136, 20);
            this.TBNombre.TabIndex = 5;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(34, 75);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(50, 13);
            this.LNombre.TabIndex = 4;
            this.LNombre.Text = "Nombre: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 7;
            // 
            // LStockActual
            // 
            this.LStockActual.AutoSize = true;
            this.LStockActual.Location = new System.Drawing.Point(34, 110);
            this.LStockActual.Name = "LStockActual";
            this.LStockActual.Size = new System.Drawing.Size(71, 13);
            this.LStockActual.TabIndex = 6;
            this.LStockActual.Text = "Stock Actual:";
            // 
            // FormAjusteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormAjusteStock";
            this.Text = "Ajuste de Stock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LCodigoProducto;
        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView labe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LStockActual;
    }
}