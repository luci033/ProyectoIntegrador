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
            this.panelCard = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubtitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LSeccionBusqueda = new System.Windows.Forms.Label();
            this.TBUsuarioActivo = new System.Windows.Forms.TextBox();
            this.LUsuarioActivo = new System.Windows.Forms.Label();
            this.TBCodigoProducto = new System.Windows.Forms.TextBox();
            this.LCodigoProducto = new System.Windows.Forms.Label();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LSeccionDetalle = new System.Windows.Forms.Label();
            this.LObservaciones = new System.Windows.Forms.Label();
            this.TBObservaciones = new System.Windows.Forms.TextBox();
            this.TBCantidadAjustar = new System.Windows.Forms.TextBox();
            this.LCantidadAjustar = new System.Windows.Forms.Label();
            this.CBTipoAjuste = new System.Windows.Forms.ComboBox();
            this.LTipoAjuste = new System.Windows.Forms.Label();
            this.TBStockActual = new System.Windows.Forms.TextBox();
            this.LStockProducto = new System.Windows.Forms.Label();
            this.TBNombreProducto = new System.Windows.Forms.TextBox();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.BConfirmar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.LTitulo);
            this.panelCard.Controls.Add(this.LSubtitulo);
            this.panelCard.Controls.Add(this.panel1);
            this.panelCard.Controls.Add(this.panel2);
            this.panelCard.Controls.Add(this.BCancelar);
            this.panelCard.Controls.Add(this.BConfirmar);
            this.panelCard.Location = new System.Drawing.Point(30, 20);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(960, 640);
            this.panelCard.TabIndex = 0;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LTitulo.Location = new System.Drawing.Point(30, 20);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(434, 31);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Ajuste de Stock e Inventario";
            // 
            // LSubtitulo
            // 
            this.LSubtitulo.AutoSize = true;
            this.LSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LSubtitulo.Location = new System.Drawing.Point(32, 58);
            this.LSubtitulo.Name = "LSubtitulo";
            this.LSubtitulo.Size = new System.Drawing.Size(462, 17);
            this.LSubtitulo.TabIndex = 1;
            this.LSubtitulo.Text = "Gestione ingresos, egresos y regularizaciones de stock para los productos del catálogo.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LSeccionBusqueda);
            this.panel1.Controls.Add(this.TBUsuarioActivo);
            this.panel1.Controls.Add(this.LUsuarioActivo);
            this.panel1.Controls.Add(this.TBCodigoProducto);
            this.panel1.Controls.Add(this.LCodigoProducto);
            this.panel1.Controls.Add(this.BBuscarProducto);
            this.panel1.Location = new System.Drawing.Point(30, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 110);
            this.panel1.TabIndex = 2;
            // 
            // LSeccionBusqueda
            // 
            this.LSeccionBusqueda.AutoSize = true;
            this.LSeccionBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSeccionBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LSeccionBusqueda.Location = new System.Drawing.Point(20, 10);
            this.LSeccionBusqueda.Name = "LSeccionBusqueda";
            this.LSeccionBusqueda.Size = new System.Drawing.Size(252, 19);
            this.LSeccionBusqueda.TabIndex = 0;
            this.LSeccionBusqueda.Text = "1. Búsqueda de Producto y Operador";
            // 
            // LUsuarioActivo
            // 
            this.LUsuarioActivo.AutoSize = true;
            this.LUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuarioActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LUsuarioActivo.Location = new System.Drawing.Point(20, 40);
            this.LUsuarioActivo.Name = "LUsuarioActivo";
            this.LUsuarioActivo.Size = new System.Drawing.Size(107, 17);
            this.LUsuarioActivo.TabIndex = 1;
            this.LUsuarioActivo.Text = "Operador Activo:";
            // 
            // TBUsuarioActivo
            // 
            this.TBUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuarioActivo.Location = new System.Drawing.Point(20, 64);
            this.TBUsuarioActivo.Name = "TBUsuarioActivo";
            this.TBUsuarioActivo.ReadOnly = true;
            this.TBUsuarioActivo.Size = new System.Drawing.Size(250, 25);
            this.TBUsuarioActivo.TabIndex = 2;
            // 
            // LCodigoProducto
            // 
            this.LCodigoProducto.AutoSize = true;
            this.LCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LCodigoProducto.Location = new System.Drawing.Point(295, 40);
            this.LCodigoProducto.Name = "LCodigoProducto";
            this.LCodigoProducto.Size = new System.Drawing.Size(135, 17);
            this.LCodigoProducto.TabIndex = 3;
            this.LCodigoProducto.Text = "Código de Producto:";
            this.LCodigoProducto.Click += new System.EventHandler(this.LCodigoProducto_Click);
            // 
            // TBCodigoProducto
            // 
            this.TBCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigoProducto.Location = new System.Drawing.Point(295, 64);
            this.TBCodigoProducto.Name = "TBCodigoProducto";
            this.TBCodigoProducto.Size = new System.Drawing.Size(270, 25);
            this.TBCodigoProducto.TabIndex = 4;
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBuscarProducto.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProducto.Location = new System.Drawing.Point(590, 50);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(280, 42);
            this.BBuscarProducto.TabIndex = 5;
            this.BBuscarProducto.Text = "🔍 Buscar Producto";
            this.BBuscarProducto.UseVisualStyleBackColor = true;
            this.BBuscarProducto.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LSeccionDetalle);
            this.panel2.Controls.Add(this.LNombreProducto);
            this.panel2.Controls.Add(this.TBNombreProducto);
            this.panel2.Controls.Add(this.LTipoAjuste);
            this.panel2.Controls.Add(this.CBTipoAjuste);
            this.panel2.Controls.Add(this.LCantidadAjustar);
            this.panel2.Controls.Add(this.TBCantidadAjustar);
            this.panel2.Controls.Add(this.LStockProducto);
            this.panel2.Controls.Add(this.TBStockActual);
            this.panel2.Controls.Add(this.LObservaciones);
            this.panel2.Controls.Add(this.TBObservaciones);
            this.panel2.Location = new System.Drawing.Point(30, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 340);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LSeccionDetalle
            // 
            this.LSeccionDetalle.AutoSize = true;
            this.LSeccionDetalle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSeccionDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.LSeccionDetalle.Location = new System.Drawing.Point(20, 10);
            this.LSeccionDetalle.Name = "LSeccionDetalle";
            this.LSeccionDetalle.Size = new System.Drawing.Size(325, 19);
            this.LSeccionDetalle.TabIndex = 0;
            this.LSeccionDetalle.Text = "2. Detalle del Producto y Regularización de Stock";
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LNombreProducto.Location = new System.Drawing.Point(20, 42);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(146, 17);
            this.LNombreProducto.TabIndex = 1;
            this.LNombreProducto.Text = "Nombre del Producto:";
            // 
            // TBNombreProducto
            // 
            this.TBNombreProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProducto.Location = new System.Drawing.Point(20, 66);
            this.TBNombreProducto.Name = "TBNombreProducto";
            this.TBNombreProducto.ReadOnly = true;
            this.TBNombreProducto.Size = new System.Drawing.Size(410, 25);
            this.TBNombreProducto.TabIndex = 2;
            // 
            // LTipoAjuste
            // 
            this.LTipoAjuste.AutoSize = true;
            this.LTipoAjuste.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoAjuste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LTipoAjuste.Location = new System.Drawing.Point(20, 114);
            this.LTipoAjuste.Name = "LTipoAjuste";
            this.LTipoAjuste.Size = new System.Drawing.Size(100, 17);
            this.LTipoAjuste.TabIndex = 3;
            this.LTipoAjuste.Text = "Tipo de Ajuste:";
            // 
            // CBTipoAjuste
            // 
            this.CBTipoAjuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoAjuste.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTipoAjuste.FormattingEnabled = true;
            this.CBTipoAjuste.Location = new System.Drawing.Point(20, 138);
            this.CBTipoAjuste.Name = "CBTipoAjuste";
            this.CBTipoAjuste.Size = new System.Drawing.Size(410, 25);
            this.CBTipoAjuste.TabIndex = 4;
            // 
            // LCantidadAjustar
            // 
            this.LCantidadAjustar.AutoSize = true;
            this.LCantidadAjustar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidadAjustar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LCantidadAjustar.Location = new System.Drawing.Point(20, 186);
            this.LCantidadAjustar.Name = "LCantidadAjustar";
            this.LCantidadAjustar.Size = new System.Drawing.Size(125, 17);
            this.LCantidadAjustar.TabIndex = 5;
            this.LCantidadAjustar.Text = "Cantidad a Ajustar:";
            // 
            // TBCantidadAjustar
            // 
            this.TBCantidadAjustar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCantidadAjustar.Location = new System.Drawing.Point(20, 210);
            this.TBCantidadAjustar.Name = "TBCantidadAjustar";
            this.TBCantidadAjustar.Size = new System.Drawing.Size(410, 26);
            this.TBCantidadAjustar.TabIndex = 6;
            // 
            // LStockProducto
            // 
            this.LStockProducto.AutoSize = true;
            this.LStockProducto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStockProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LStockProducto.Location = new System.Drawing.Point(470, 42);
            this.LStockProducto.Name = "LStockProducto";
            this.LStockProducto.Size = new System.Drawing.Size(155, 17);
            this.LStockProducto.TabIndex = 7;
            this.LStockProducto.Text = "Stock Actual en Sistema:";
            // 
            // TBStockActual
            // 
            this.TBStockActual.BackColor = System.Drawing.Color.White;
            this.TBStockActual.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStockActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.TBStockActual.Location = new System.Drawing.Point(470, 66);
            this.TBStockActual.Name = "TBStockActual";
            this.TBStockActual.ReadOnly = true;
            this.TBStockActual.Size = new System.Drawing.Size(410, 32);
            this.TBStockActual.TabIndex = 8;
            this.TBStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LObservaciones
            // 
            this.LObservaciones.AutoSize = true;
            this.LObservaciones.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LObservaciones.Location = new System.Drawing.Point(470, 114);
            this.LObservaciones.Name = "LObservaciones";
            this.LObservaciones.Size = new System.Drawing.Size(294, 17);
            this.LObservaciones.TabIndex = 9;
            this.LObservaciones.Text = "Motivo / Observaciones (mínimo 5 caracteres):";
            // 
            // TBObservaciones
            // 
            this.TBObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBObservaciones.Location = new System.Drawing.Point(470, 138);
            this.TBObservaciones.Multiline = true;
            this.TBObservaciones.Name = "TBObservaciones";
            this.TBObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBObservaciones.Size = new System.Drawing.Size(410, 172);
            this.TBObservaciones.TabIndex = 10;
            // 
            // BCancelar
            // 
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Location = new System.Drawing.Point(520, 575);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(180, 44);
            this.BCancelar.TabIndex = 4;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BConfirmar
            // 
            this.BConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BConfirmar.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConfirmar.Location = new System.Drawing.Point(720, 575);
            this.BConfirmar.Name = "BConfirmar";
            this.BConfirmar.Size = new System.Drawing.Size(210, 44);
            this.BConfirmar.TabIndex = 5;
            this.BConfirmar.Text = "Confirmar Ajuste";
            this.BConfirmar.UseVisualStyleBackColor = true;
            this.BConfirmar.Click += new System.EventHandler(this.BConfirmar_Click);
            // 
            // FormAjusteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.panelCard);
            this.MinimumSize = new System.Drawing.Size(1020, 720);
            this.Name = "FormAjusteStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste de Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAjusteStock_Load);
            this.Resize += new System.EventHandler(this.FormAjusteStock_Resize);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubtitulo;
        private System.Windows.Forms.Label LSeccionBusqueda;
        private System.Windows.Forms.Label LSeccionDetalle;
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