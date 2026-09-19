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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BAgregarUsuario = new System.Windows.Forms.Button();
            this.dataGridRegistroUsuario = new System.Windows.Forms.DataGridView();
            this.LGestionUsuario = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.LBuscar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LRol = new System.Windows.Forms.Label();
            this.LEstado = new System.Windows.Forms.Label();
            this.colIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDesactivar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BAgregarUsuario
            // 
            this.BAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.BAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarUsuario.Location = new System.Drawing.Point(514, 115);
            this.BAgregarUsuario.Name = "BAgregarUsuario";
            this.BAgregarUsuario.Size = new System.Drawing.Size(139, 32);
            this.BAgregarUsuario.TabIndex = 0;
            this.BAgregarUsuario.Text = "Agregar Usuario";
            this.BAgregarUsuario.UseVisualStyleBackColor = false;
            this.BAgregarUsuario.Click += new System.EventHandler(this.BAgregarUsuario_Click);
            // 
            // dataGridRegistroUsuario
            // 
            this.dataGridRegistroUsuario.AllowUserToAddRows = false;
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
            this.colRol,
            this.colModificar,
            this.colDesactivar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRegistroUsuario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRegistroUsuario.EnableHeadersVisualStyles = false;
            this.dataGridRegistroUsuario.Location = new System.Drawing.Point(0, 3);
            this.dataGridRegistroUsuario.Name = "dataGridRegistroUsuario";
            this.dataGridRegistroUsuario.ReadOnly = true;
            this.dataGridRegistroUsuario.RowHeadersVisible = false;
            this.dataGridRegistroUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRegistroUsuario.Size = new System.Drawing.Size(767, 180);
            this.dataGridRegistroUsuario.TabIndex = 1;
            this.dataGridRegistroUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRegistroUsuario_CellContentClick);
            // 
            // LGestionUsuario
            // 
            this.LGestionUsuario.AutoSize = true;
            this.LGestionUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestionUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(105)))), ((int)(((byte)(100)))));
            this.LGestionUsuario.Location = new System.Drawing.Point(27, 115);
            this.LGestionUsuario.Name = "LGestionUsuario";
            this.LGestionUsuario.Size = new System.Drawing.Size(279, 32);
            this.LGestionUsuario.TabIndex = 2;
            this.LGestionUsuario.Text = "GESTIÓN DE USUARIOS";
            this.LGestionUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(64, 14);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(100, 20);
            this.TBBuscar.TabIndex = 3;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.ForeColor = System.Drawing.Color.Black;
            this.LBuscar.Location = new System.Drawing.Point(18, 17);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(43, 13);
            this.LBuscar.TabIndex = 4;
            this.LBuscar.Text = "Buscar:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridRegistroUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 186);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LEstado);
            this.panel2.Controls.Add(this.LRol);
            this.panel2.Controls.Add(this.CBEstado);
            this.panel2.Controls.Add(this.CBRol);
            this.panel2.Controls.Add(this.TBBuscar);
            this.panel2.Controls.Add(this.LBuscar);
            this.panel2.Location = new System.Drawing.Point(0, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 50);
            this.panel2.TabIndex = 6;
            // 
            // CBRol
            // 
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(390, 14);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(121, 21);
            this.CBRol.TabIndex = 5;
            this.CBRol.SelectedIndexChanged += new System.EventHandler(this.CBRol_SelectedIndexChanged);
            // 
            // CBEstado
            // 
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(605, 14);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(121, 21);
            this.CBEstado.TabIndex = 6;
            this.CBEstado.SelectedIndexChanged += new System.EventHandler(this.CBEstado_SelectedIndexChanged);
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.ForeColor = System.Drawing.Color.Black;
            this.LRol.Location = new System.Drawing.Point(355, 17);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(29, 13);
            this.LRol.TabIndex = 7;
            this.LRol.Text = "Rol: ";
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.ForeColor = System.Drawing.Color.Black;
            this.LEstado.Location = new System.Drawing.Point(556, 17);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(43, 13);
            this.LEstado.TabIndex = 8;
            this.LEstado.Text = "Estado:";
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
            // colModificar
            // 
            this.colModificar.FillWeight = 30F;
            this.colModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colModificar.HeaderText = "Modificar";
            this.colModificar.Name = "colModificar";
            this.colModificar.ReadOnly = true;
            this.colModificar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colModificar.Text = "Modificar";
            this.colModificar.UseColumnTextForButtonValue = true;
            // 
            // colDesactivar
            // 
            this.colDesactivar.FillWeight = 30F;
            this.colDesactivar.HeaderText = "Desactivar";
            this.colDesactivar.Name = "colDesactivar";
            this.colDesactivar.ReadOnly = true;
            this.colDesactivar.Text = "Desactivar";
            this.colDesactivar.UseColumnTextForButtonValue = true;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(770, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LGestionUsuario);
            this.Controls.Add(this.BAgregarUsuario);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAgregarUsuario;
        private System.Windows.Forms.DataGridView dataGridRegistroUsuario;
        private System.Windows.Forms.Label LGestionUsuario;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewButtonColumn colModificar;
        private System.Windows.Forms.DataGridViewButtonColumn colDesactivar;
    }
}