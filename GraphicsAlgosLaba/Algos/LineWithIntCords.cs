using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAlgosLaba.Algos
{
    public static class LineWithIntCords
    {
        public static void Draw(Graphics g, Point p_begin, Point p_end) 
        {
            int x = 0;
            int y = 0;
            int a = p_end.X - p_begin.X;
            int b = p_end.Y - p_begin.Y;
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
            if (a > b)
            {
                int e = 2 * b - a;
                int des = 2 * b;
                int ded = 2 * b - 2 * a;
                while (x < a)
                {

                    DrawingUtils.Plot(g, x * x_mnoj + p_begin.X, y * y_mnoj + p_begin.Y);

                    if (e > 0)
                    {
                        x++;
                        y++;
                        e += ded;
                    }
                    else
                    {
                        x++;
                        e += des;
                    }
                }
            }
            else
            {
                int e = 2 * a - b;
                int des = 2 * a;
                int ded = 2 * a - 2 * b;
                while (x < a)
                {

                    DrawingUtils.Plot(g, x * x_mnoj + p_begin.X, y * y_mnoj + p_begin.Y);

                    if (e > 0)
                    {
                        x++;
                        y++;
                        e += ded;
                    }
                    else
                    {
                        y++;
                        e += des;
                    }
                }

            }
        }
    }
}
