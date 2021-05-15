using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAlgosLaba
{
    public static class Bizie
    {
        public static void Draw(Graphics g ,List<Point> points)
        {
            int M=1000;
            double dt = 1.0/M;
            double t = 0;
            List<PointF> v = new List<PointF>();
            while (t < 1)
            {
                double x = 0;
                double y = 0;
                for (int i = 0; i < points.Count; i++)
                {
                    double d = countCoef(i, points.Count - 1, t);
                    x += points[i].X * d;
                    y += points[i].Y * d;
                }
                v.Add(new PointF((float)x, (float)y));
                t += dt;
            }


            foreach (var p in v)
            {
                g.DrawRectangle(new Pen(Color.Red, 2), p.X, p.Y, 1, 1);
            }
        }

        private static int countF(int n)
        {
            return n <= 1 ? 1 : countF(n - 1) * n;
        }

        private static int countC(int n, int k)
        {
            return countF(n) / (countF(k) * countF(n - k));
        }

        private static double countCoef(int i, int n, double t)
        {
            return countC(n, i) * Math.Pow(t, i) * Math.Pow(1 - t, n - i);
        }

    }
}
