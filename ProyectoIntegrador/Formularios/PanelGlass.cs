using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class PanelGlass : Panel
{
    protected override void OnPaintBackground(PaintEventArgs e)
    {
        // Verifica que el formulario padre tenga una imagen de fondo
        if (Parent != null && Parent.BackgroundImage != null)
        {
            // 1. Recortar la sección del fondo que queda detrás del panel
            Rectangle rect = new Rectangle(this.Location, this.Size);
            Bitmap recorte = new Bitmap(this.Width, this.Height);

            using (Graphics g = Graphics.FromImage(recorte))
            {
                g.DrawImage(Parent.BackgroundImage, new Rectangle(0, 0, this.Width, this.Height), rect, GraphicsUnit.Pixel);
            }

            // 1. Convertí el recorte al formato que exige AForge
            Bitmap recorte24 = recorte.Clone(new Rectangle(0, 0, recorte.Width, recorte.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            // 2. Aplicá el desenfoque gaussiano (ajustá el 5 y el 11 para modificar la intensidad)
            GaussianBlur blur = new GaussianBlur(5, 11);
            blur.ApplyInPlace(recorte24);

            // 3. Dibujá el resultado
            e.Graphics.DrawImage(recorte24, new Rectangle(0, 0, this.Width, this.Height));

            // 3. Capa translúcida (Brillo del vidrio)
            using (SolidBrush brocha = new SolidBrush(Color.FromArgb(70, 255, 255, 255)))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }
        else
        {
            base.OnPaintBackground(e);
        }
    }

    private GraphicsPath ObtenerBordesRedondeados(Rectangle rect, int radio)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, radio, radio, 180, 90); // Arriba izquierda
        path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90); // Arriba derecha
        path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90); // Abajo derecha
        path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90); // Abajo izquierda
        path.CloseFigure();
        return path;
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        // Cambiá el número 30 para darle más o menos curvatura al borde
        this.Region = new Region(ObtenerBordesRedondeados(this.ClientRectangle, 30));
    }
}