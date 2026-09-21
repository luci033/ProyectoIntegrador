using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public static class EstiloUI
    {
        // Paleta base ALBA
        public static readonly Color ColorBorgoña = Color.FromArgb(42, 8, 12);
        public static readonly Color ColorSeleccion = Color.FromArgb(235, 228, 222);
        public static readonly Color ColorInactivo = Color.Gray;
        public static readonly Color ColorFondo = Color.FromArgb(239, 236, 232);
        public static readonly Color ColorBotonSecundario = Color.FromArgb(215, 208, 201);
        public static readonly Color ColorBotonSecundarioTexto = Color.FromArgb(42, 8, 12);
        public static readonly Color ColorCard = Color.White;
        public static readonly Color ColorBorde = Color.FromArgb(200, 195, 189);

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

            // Cabecera uniforme con altura y fuente mejoradas
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 36;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorBorgoña;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorBorgoña;

            // Filas uniformes con altura y legibilidad mejoradas
            dgv.RowTemplate.Height = 32;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = ColorSeleccion;
            dgv.DefaultCellStyle.SelectionForeColor = ColorBorgoña;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);

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
            AplicarBordesRedondeados(boton, 4);
        }

        public static void AplicarEstiloBotonSecundario(Button boton)
        {
            boton.Font = new Font("Georgia", boton.Font.Size > 0 ? boton.Font.Size : 10f, FontStyle.Bold);
            boton.ForeColor = ColorBotonSecundarioTexto;
            boton.BackColor = ColorBotonSecundario;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Cursor = Cursors.Hand;
            AplicarBordesRedondeados(boton, 4);
        }

        public static void AplicarEstiloTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Segoe UI", 10.5f, FontStyle.Regular);
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

        /// <summary>
        /// Crea una ruta gráfica de rectángulo con esquinas redondeadas.
        /// </summary>
        public static GraphicsPath CrearRutaRedondeada(Rectangle bounds, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            if (radio <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            int diametro = radio * 2;
            if (diametro > bounds.Width) diametro = bounds.Width;
            if (diametro > bounds.Height) diametro = bounds.Height;

            Rectangle arc = new Rectangle(bounds.X, bounds.Y, diametro, diametro);

            // Esquina superior izquierda
            path.AddArc(arc, 180, 90);
            // Esquina superior derecha
            arc.X = bounds.Right - diametro;
            path.AddArc(arc, 270, 90);
            // Esquina inferior derecha
            arc.Y = bounds.Bottom - diametro;
            path.AddArc(arc, 0, 90);
            // Esquina inferior izquierda
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Aplica bordes redondeados a cualquier control recortando su región y recalculándola en Resize.
        /// </summary>
        public static void AplicarBordesRedondeados(Control control, int radio = 4)
        {
            if (control == null) return;

            void ActualizarRegion()
            {
                if (control.Width <= 0 || control.Height <= 0) return;
                using (GraphicsPath path = CrearRutaRedondeada(new Rectangle(0, 0, control.Width, control.Height), radio))
                {
                    control.Region = new Region(path);
                }
            }

            ActualizarRegion();
            control.Resize += (s, e) => ActualizarRegion();
        }

        /// <summary>
        /// Configura un panel como tarjeta ejecutiva: fondo blanco, esquinas redondeadas y borde sutil con AntiAlias.
        /// </summary>
        public static void AplicarEstiloCard(Panel panel, int radio = 14)
        {
            if (panel == null) return;
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.None;

            void ActualizarRegion()
            {
                if (panel.Width <= 0 || panel.Height <= 0) return;
                using (GraphicsPath path = CrearRutaRedondeada(new Rectangle(0, 0, panel.Width, panel.Height), radio))
                {
                    panel.Region = new Region(path);
                }
            }

            ActualizarRegion();
            panel.Resize += (s, e) =>
            {
                ActualizarRegion();
                panel.Invalidate();
            };

            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = CrearRutaRedondeada(new Rectangle(0, 0, panel.Width - 1, panel.Height - 1), radio))
                using (Pen pen = new Pen(ColorBorde, 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }

        /// <summary>
        /// Configura un panel como sub-sección o barra de filtros: fondo suave, esquinas redondeadas y borde sutil.
        /// </summary>
        public static void AplicarEstiloPanelSeccion(Panel panel, int radio = 10, Color? fondo = null)
        {
            if (panel == null) return;
            panel.BackColor = fondo ?? Color.FromArgb(250, 249, 247);
            panel.BorderStyle = BorderStyle.None;

            void ActualizarRegion()
            {
                if (panel.Width <= 0 || panel.Height <= 0) return;
                using (GraphicsPath path = CrearRutaRedondeada(new Rectangle(0, 0, panel.Width, panel.Height), radio))
                {
                    panel.Region = new Region(path);
                }
            }

            ActualizarRegion();
            panel.Resize += (s, e) =>
            {
                ActualizarRegion();
                panel.Invalidate();
            };

            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = CrearRutaRedondeada(new Rectangle(0, 0, panel.Width - 1, panel.Height - 1), radio))
                using (Pen pen = new Pen(ColorBorde, 1f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }
    }
}