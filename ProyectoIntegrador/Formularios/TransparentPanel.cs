using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class TransparentPanel : Panel
{
    public TransparentPanel()
    {
        // Activa el soporte para transparencias en el control
        this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                      ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.UserPaint, true);
        this.UpdateStyles();
    }
}
