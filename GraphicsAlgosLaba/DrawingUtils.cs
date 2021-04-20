using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAlgosLaba
{
    public static class DrawingUtils
    {
        public static void Plot(Graphics g, int x, int y)
        {
            g.DrawRectangle(new Pen(new SolidBrush(Color.Black)), x, y, 1, 1);
        }
    }
}
