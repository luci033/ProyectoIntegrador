using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public static class EstiloUI
    {
        // Paleta base ALBA
        public static readonly Color ColorBorgoña = Color.FromArgb(42, 8, 12);
        public static readonly Color ColorSeleccion = Color.FromArgb(235, 228, 222);
        public static readonly Color ColorInactivo = Color.Gray;

        public static void AplicarEstiloGrilla(DataGridView dgv)
        {
            // Opciones básicas de comportamiento
            dgv.BackgroundColor = ColorSeleccion;
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cabecera uniforme
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 32;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorBorgoña;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorBorgoña;

            // Filas uniformes
            dgv.RowTemplate.Height = 28;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = ColorSeleccion;
            dgv.DefaultCellStyle.SelectionForeColor = ColorBorgoña;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Regular);

            // Fuerza el estilo de las columnas tipo botón justo antes de que se dibujen en pantalla
            dgv.CellFormatting += (sender, e) =>
            {
                if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn colBoton)
                {
                    colBoton.FlatStyle = FlatStyle.Flat;
                    e.CellStyle.BackColor = ColorBorgoña;
                    e.CellStyle.SelectionBackColor = ColorBorgoña;
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.SelectionForeColor = Color.White;
                }
            };
        }
        // Nueva paleta de fondo
        public static readonly Color ColorFondo = Color.FromArgb(239, 236, 232);

        public static void AplicarEstiloTitulo(Label titulo)
        {
            titulo.Font = new Font("Georgia", 24f, FontStyle.Bold);
            titulo.ForeColor = ColorBorgoña;
            titulo.BackColor = Color.Transparent;
        }

        public static void AplicarEstiloFormulario(Form formulario)
        {
            formulario.BackColor = ColorFondo;
        }

        public static void AplicarEstiloBoton(Button boton)
        {
            boton.Font = new Font("Georgia", boton.Font.Size > 0 ? boton.Font.Size : 11f, FontStyle.Bold);
            boton.ForeColor = Color.White;
            boton.BackColor = ColorBorgoña;

            // Quita el diseño por defecto de Windows para aplicar tus colores
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Cursor = Cursors.Hand;
        }

        public static readonly Color ColorBotonSecundario = Color.FromArgb(215, 208, 201);
        public static readonly Color ColorBotonSecundarioTexto = Color.FromArgb(42, 8, 12);
        public static readonly Color ColorCard = Color.White;
        public static readonly Color ColorBorde = Color.FromArgb(200, 195, 189);

        public static void AplicarEstiloBotonSecundario(Button boton)
        {
            boton.Font = new Font("Georgia", boton.Font.Size > 0 ? boton.Font.Size : 10f, FontStyle.Bold);
            boton.ForeColor = ColorBotonSecundarioTexto;
            boton.BackColor = ColorBotonSecundario;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Cursor = Cursors.Hand;
        }

        public static void AplicarEstiloTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;
        }

        public static void CentrarControl(Control hijo, Control contenedor)
        {
            if (hijo == null || contenedor == null) return;
            hijo.Left = Math.Max(10, (contenedor.ClientSize.Width - hijo.Width) / 2);
            hijo.Top = Math.Max(10, (contenedor.ClientSize.Height - hijo.Height) / 2);
        }
    }
}