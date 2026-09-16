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
            this.LGestionUsuario = new System.Windows.Forms.Label();
            this.colIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // BAgregarUsuario
            // 
            this.BAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarUsuario.Location = new System.Drawing.Point(432, 93);
            this.BAgregarUsuario.Name = "BAgregarUsuario";
            this.BAgregarUsuario.Size = new System.Drawing.Size(139, 32);
            this.BAgregarUsuario.TabIndex = 0;
            this.BAgregarUsuario.Text = "Agregar Usuario";
            this.BAgregarUsuario.UseVisualStyleBackColor = false;
            this.BAgregarUsuario.Click += new System.EventHandler(this.BAgregarUsuario_Click);
            // 
            // dataGridRegistroUsuario
            // 
            this.dataGridRegistroUsuario.AllowUserToDeleteRows = false;
            this.dataGridRegistroUsuario.AllowUserToResizeColumns = false;
            this.dataGridRegistroUsuario.AllowUserToResizeRows = false;
            this.dataGridRegistroUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRegistroUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRegistroUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRegistroUsuario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridRegistroUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistroUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdUsuario,
            this.colDni,
            this.colNombre,
            this.colApellido,
            this.colUsuario,
            this.colRol});
            this.dataGridRegistroUsuario.Location = new System.Drawing.Point(0, 158);
            this.dataGridRegistroUsuario.Name = "dataGridRegistroUsuario";
            this.dataGridRegistroUsuario.ReadOnly = true;
            this.dataGridRegistroUsuario.RowHeadersVisible = false;
            this.dataGridRegistroUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRegistroUsuario.Size = new System.Drawing.Size(685, 110);
            this.dataGridRegistroUsuario.TabIndex = 1;
            this.dataGridRegistroUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRegistroUsuario_CellContentClick);
            // 
            // LGestionUsuario
            // 
            this.LGestionUsuario.AutoSize = true;
            this.LGestionUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestionUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(105)))), ((int)(((byte)(100)))));
            this.LGestionUsuario.Location = new System.Drawing.Point(40, 39);
            this.LGestionUsuario.Name = "LGestionUsuario";
            this.LGestionUsuario.Size = new System.Drawing.Size(279, 32);
            this.LGestionUsuario.TabIndex = 2;
            this.LGestionUsuario.Text = "GESTIÓN DE USUARIOS";
            this.LGestionUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.HeaderText = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.ReadOnly = true;
            this.colIdUsuario.Visible = false;
            // 
            // colDni
            // 
            this.colDni.FillWeight = 15F;
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            this.colDni.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 20F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.FillWeight = 20F;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.FillWeight = 30F;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // colRol
            // 
            this.colRol.FillWeight = 15F;
            this.colRol.HeaderText = "Rol";
            this.colRol.Name = "colRol";
            this.colRol.ReadOnly = true;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(686, 347);
            this.Controls.Add(this.LGestionUsuario);
            this.Controls.Add(this.dataGridRegistroUsuario);
            this.Controls.Add(this.BAgregarUsuario);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAgregarUsuario;
        private System.Windows.Forms.DataGridView dataGridRegistroUsuario;
        private System.Windows.Forms.Label LGestionUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
    }
}