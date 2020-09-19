using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundedButtonWinForm
{
    public class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddArc(rect.X, rect.Y, 50, 50, 180, 90);
            grPath.AddArc(rect.X + rect.Width - 50, rect.Y, 50, 50, 270, 90);
            grPath.AddArc(rect.X + rect.Width - 50, rect.Y + rect.Height - 50, 50, 50, 0, 90);
            grPath.AddArc(rect.X, rect.Y + rect.Height - 50, 50, 50, 90, 90);
            this.Region = new Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
