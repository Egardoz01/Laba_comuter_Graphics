using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAlgosLaba.Algos
{
    public static class LineWithRationalCords
    {
        public static void Draw(Graphics g, KeyValuePair<double, double> p_end_double, KeyValuePair<double, double> p_begin_double)
        {

            int x = 0;
            int y = 0;
            int a = (int)Math.Round(p_end_double.Key - p_begin_double.Key);
            int b = (int)Math.Round(p_end_double.Value - p_begin_double.Value);
            int x_mnoj = 1, y_mnoj = 1;
            if (a < 0)
            {
                a = -a;
                x_mnoj = -1;
            }
            if (b < 0)
            {
                b = -b;
                y_mnoj = -1;
            }
            int c = 1000;
            double dh = c / Math.Abs(p_end_double.Key - p_begin_double.Key);
            //  double h = dh*(1-p_begin_double.Key);
            double h = 0;
            double dv = c / Math.Abs(p_end_double.Value - p_begin_double.Value);
            // double v = dv * (1 - p_begin_double.Value);
            double v = 0;
            while (h < c && v < c)
            {
                DrawingUtils.Plot(g, x * x_mnoj + (int)Math.Round(p_begin_double.Key), y * y_mnoj + (int)Math.Round(p_begin_double.Value));
                if (h < v)
                {
                    x++;
                    h += dh;
                }
                else if (h > v)
                {
                    y++;
                    v += dv;
                }
                else
                {
                    DrawingUtils.Plot(g, x * x_mnoj + (int)Math.Round(p_begin_double.Key), (y + 1) * y_mnoj + (int)Math.Round(p_begin_double.Value));
                    x++;
                    y++;
                    h += dh;
                    v += dv;
                }
            }
        }
    }
}
