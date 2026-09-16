using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public static class EstiloUI
    {
        // Paleta base ALBA
        public static readonly Color ColorBorgoña = Color.FromArgb(42, 8, 12);
        public static readonly Color ColorSeleccion = Color.FromArgb(235, 228, 222);

        public static void AplicarEstiloGrilla(DataGridView dgv)
        {
            // Opciones básicas de comportamiento
            dgv.BackgroundColor = Color.White;
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

            // Filas uniformes
            dgv.RowTemplate.Height = 28;
            dgv.DefaultCellStyle.SelectionBackColor = ColorSeleccion;
            dgv.DefaultCellStyle.SelectionForeColor = ColorBorgoña;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
        }
    }
}