namespace ProyectoIntegrador.Formularios.Usuarios
{
    partial class FormUsuarios
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
            this.BAgregarUsuario = new System.Windows.Forms.Button();
            this.dataGridRegistroUsuario = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDesactivar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // BAgregarUsuario
            // 
            this.BAgregarUsuario.Location = new System.Drawing.Point(462, 132);
            this.BAgregarUsuario.Name = "BAgregarUsuario";
            this.BAgregarUsuario.Size = new System.Drawing.Size(129, 22);
            this.BAgregarUsuario.TabIndex = 0;
            this.BAgregarUsuario.Text = "Agregar Usuario";
            this.BAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // dataGridRegistroUsuario
            // 
            this.dataGridRegistroUsuario.AllowUserToAddRows = false;
            this.dataGridRegistroUsuario.AllowUserToDeleteRows = false;
            this.dataGridRegistroUsuario.AllowUserToResizeColumns = false;
            this.dataGridRegistroUsuario.AllowUserToResizeRows = false;
            this.dataGridRegistroUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRegistroUsuario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridRegistroUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistroUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApellido,
            this.colCorreo,
            this.col,
            this.colModificar,
            this.colDesactivar});
            this.dataGridRegistroUsuario.Location = new System.Drawing.Point(-2, 184);
            this.dataGridRegistroUsuario.Name = "dataGridRegistroUsuario";
            this.dataGridRegistroUsuario.RowHeadersVisible = false;
            this.dataGridRegistroUsuario.Size = new System.Drawing.Size(655, 109);
            this.dataGridRegistroUsuario.TabIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            // 
            // col
            // 
            this.col.HeaderText = "Usuario";
            this.col.Name = "col";
            this.col.ReadOnly = true;
            // 
            // colModificar
            // 
            this.colModificar.HeaderText = "";
            this.colModificar.Name = "colModificar";
            // 
            // colDesactivar
            // 
            this.colDesactivar.HeaderText = "";
            this.colDesactivar.Name = "colDesactivar";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 343);
            this.Controls.Add(this.dataGridRegistroUsuario);
            this.Controls.Add(this.BAgregarUsuario);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAgregarUsuario;
        private System.Windows.Forms.DataGridView dataGridRegistroUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewButtonColumn colModificar;
        private System.Windows.Forms.DataGridViewButtonColumn colDesactivar;
    }
}