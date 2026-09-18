namespace ProyectoIntegrador.Formularios.Productos
{
    partial class FormCategorias
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
            this.DGCategoria = new System.Windows.Forms.DataGridView();
            this.BAgregarCategoria = new System.Windows.Forms.Button();
            this.LCategorias = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CategoriaDesactivar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCategoria
            // 
            this.DGCategoria.AllowDrop = true;
            this.DGCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Número,
            this.CategoriaNombre,
            this.CategoriaModificar,
            this.CategoriaDesactivar});
            this.DGCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGCategoria.EnableHeadersVisualStyles = false;
            this.DGCategoria.Location = new System.Drawing.Point(0, 212);
            this.DGCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGCategoria.Name = "DGCategoria";
            this.DGCategoria.ReadOnly = true;
            this.DGCategoria.RowHeadersVisible = false;
            this.DGCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCategoria.Size = new System.Drawing.Size(807, 291);
            this.DGCategoria.TabIndex = 0;
            this.DGCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCategoria_CellContentClick);
            // 
            // BAgregarCategoria
            // 
            this.BAgregarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAgregarCategoria.Location = new System.Drawing.Point(550, 120);
            this.BAgregarCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BAgregarCategoria.Name = "BAgregarCategoria";
            this.BAgregarCategoria.Size = new System.Drawing.Size(204, 51);
            this.BAgregarCategoria.TabIndex = 1;
            this.BAgregarCategoria.Text = "Agregar Categoría";
            this.BAgregarCategoria.UseVisualStyleBackColor = true;
            this.BAgregarCategoria.Click += new System.EventHandler(this.BAgregarCategoria_Click);
            // 
            // LCategorias
            // 
            this.LCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LCategorias.AutoSize = true;
            this.LCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategorias.Location = new System.Drawing.Point(14, 55);
            this.LCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCategorias.Name = "LCategorias";
            this.LCategorias.Size = new System.Drawing.Size(411, 42);
            this.LCategorias.TabIndex = 2;
            this.LCategorias.Text = "Gestión de Categorías";
            this.LCategorias.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clasificación de Joyas";
            // 
            // Número
            // 
            this.Número.FillWeight = 10F;
            this.Número.HeaderText = "Nro.";
            this.Número.Name = "Número";
            this.Número.ReadOnly = true;
            // 
            // CategoriaNombre
            // 
            this.CategoriaNombre.FillWeight = 30F;
            this.CategoriaNombre.HeaderText = "Nombre Categoría";
            this.CategoriaNombre.Name = "CategoriaNombre";
            this.CategoriaNombre.ReadOnly = true;
            // 
            // CategoriaModificar
            // 
            this.CategoriaModificar.FillWeight = 20F;
            this.CategoriaModificar.HeaderText = "Modificar";
            this.CategoriaModificar.Name = "CategoriaModificar";
            this.CategoriaModificar.ReadOnly = true;
            this.CategoriaModificar.Text = "Editar";
            this.CategoriaModificar.UseColumnTextForButtonValue = true;
            // 
            // CategoriaDesactivar
            // 
            this.CategoriaDesactivar.FillWeight = 15F;
            this.CategoriaDesactivar.HeaderText = "Desactivar";
            this.CategoriaDesactivar.Name = "CategoriaDesactivar";
            this.CategoriaDesactivar.ReadOnly = true;
            this.CategoriaDesactivar.Text = "Eliminar";
            this.CategoriaDesactivar.UseColumnTextForButtonValue = true;
            // 
            // FormCategorias
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(807, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LCategorias);
            this.Controls.Add(this.BAgregarCategoria);
            this.Controls.Add(this.DGCategoria);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormCategorias";
            this.Text = "Categorías";
            this.Load += new System.EventHandler(this.FCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCategoria;
        private System.Windows.Forms.Button BAgregarCategoria;
        private System.Windows.Forms.Label LCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaNombre;
        private System.Windows.Forms.DataGridViewButtonColumn CategoriaModificar;
        private System.Windows.Forms.DataGridViewButtonColumn CategoriaDesactivar;
    }
}