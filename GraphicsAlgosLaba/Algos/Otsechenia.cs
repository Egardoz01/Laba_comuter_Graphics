using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphicsAlgosLaba.Algos;

namespace GraphicsAlgosLaba
{
    public static class Otsechenia
    {
        private static int LEFT = 1, RIGHT = 2, BOT = 4, TOP = 8; 
        public static void DrawRect(Graphics g, Rectangle r)
        {

            LineWithIntCords.Draw(g, new Point(r.X, 0), new Point(r.X, 1000));

            LineWithIntCords.Draw(g, new Point(r.X+r.Width, 0), new Point(r.X+ r.Width, 1000));

            LineWithIntCords.Draw(g, new Point(0, r.Y), new Point(1000,r.Y));

            LineWithIntCords.Draw(g, new Point(0, r.Y+r.Height), new Point(1000, r.Y+r.Height));

        }


        private static int GetCode(Rectangle r, Point p)
        {
            int res = 0;
            if (p.X < r.X)
                res += 1;

            if (p.X > r.X+r.Width)
                res += 2;

            if (p.Y > r.Y + r.Height)
                res += 4;

            if (p.Y < r.Y)
                res += 8;


            return res;
        }

        private static bool isInside(Rectangle r, Point p)
        {
            return (r.X <= p.X && r.X+ r.Width >= p.X && r.Y <= p.Y && r.Y + r.Height >= p.Y);
        }
        public static void SredTochki(Graphics g, Rectangle r, Point p1, Point p2)
        {
            if (Math.Abs(p1.X - p2.X)<=1 && Math.Abs(p1.Y - p2.Y) <= 1)
                return;
            if (isInside(r, p1) && isInside(r, p2))
            {
                LineWithIntCords.Draw(g, p1, p2);
            }

            int code1 = GetCode(r, p1);
            int code2 = GetCode(r, p2);
            if ((code1 & code2) != 0)
                return;

            SredTochki(g, r, p1, new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2));
            SredTochki(g, r, new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2), p2);

        }

            public static void SazerlendCoen(Graphics g, Rectangle r, Point p1, Point p2)
        {
            int code, code1, code2;
            Point p;

            code1 = GetCode(r,p1);
            code2 = GetCode(r,p2);

            while (code1!=0 || code2!=0)
            {
                if ((code1 & code2) != 0)
                    return;

                if (code1 != 0)
                {
                    code = code1;
                    p = p1;
                }
                else
                {
                    code = code2;
                    p = p2;
                }

                if ((code & LEFT) !=0)
                {
                    p.Y += (p1.Y - p2.Y) * (r.X - p.X) / (p1.X - p2.X);
                    p.X = r.X;
                }
                else if ((code & RIGHT)!=0)
                {
                    p.Y += (p1.Y - p2.Y) * (r.X + r.Width - p.X) / (p1.X - p2.X);
                    p.X = r.X+r.Width;
                }
                else if ((code & BOT)!=0)
                {

                    p.X += (p1.X - p2.X) * (r.Y+r.Height - p.Y) / (p1.Y - p2.Y);
                    p.Y = r.Y + r.Height;
                }
                else if ((code & TOP)!=0)
                {
                    p.X += (p1.X - p2.X) * (r.Y  - p.Y) / (p1.Y - p2.Y);
                    p.Y = r.Y;
                }

                if (code == code1)
                {
                    p1 = p;
                    code1= GetCode(r, p1);
                }
                else
                {
                    p2 = p;
                    code2 = GetCode(r, p2);
                }

            }


            LineWithIntCords.Draw(g, p1, p2);
        }
        
    }



    public struct Segment
    {
        public readonly PointF A, B;

        public Segment(PointF a, PointF b)
        {
            A = a;
            B = b;
        }

        public bool OnLeft(PointF p)
        {
            var ab = new PointF(B.X - A.X, B.Y - A.Y);
            var ap = new PointF(p.X - A.X, p.Y - A.Y);
            return ab.Det(ap) >= 0;
        }

        public PointF Normal
        {
            get
            {
                return new PointF(B.Y - A.Y, A.X - B.X);
            }
        }

        public PointF Direction
        {
            get
            {
                return new PointF(B.X - A.X, B.Y - A.Y);
            }
        }

        public float IntersectionParameter(Segment seg)
        {
            var segment = this;
            var edge = seg;

            var segmentToEdge = edge.A.Sub(segment.A);
            var segmentDir = segment.Direction;
            var edgeDir = edge.Direction;

            var t = edgeDir.Det(segmentToEdge) / edgeDir.Det(segmentDir);

            if (float.IsNaN(t))
            {
                t = 0;
            }

            return t;
        }

        public Segment Morph(float tA, float tB)
        {
            var d = Direction;
            return new Segment(A.Add(d.Mul(tA)), A.Add(d.Mul(tB)));
        }
    }

    public class Polygon
    {
        private List<PointF> points;

        public Polygon(List<PointF> points)
        {
            this.points = points;
        }



        public List<Segment> GetEdges()
        {
            List<Segment> edges = new List<Segment>();
            for (int i = 0; i < points.Count-1; i++)
            {
                edges.Add(new Segment(points[i], points[i + 1]));
            }
            edges.Add(new Segment(points[points.Count - 1], points[0]));

            return edges;
        }

        public void DrawCirusBec(Graphics g, Segment seg)
        {
            var dir = seg.Direction;
            var tA = 0.0f;
            var tB = 1.0f;
            var edges = GetEdges();
            foreach (var edge in edges)
            {
                switch (Math.Sign(edge.Normal.ScalarMul(dir)))
                {
                    case -1:
                        {
                            var t = seg.IntersectionParameter(edge);
                            if (t > tA)
                            {
                                tA = t;
                            }
                            break;
                        }
                    case +1:
                        {
                            var t = seg.IntersectionParameter(edge);
                            if (t < tB)
                            {
                                tB = t;
                            }
                            break;
                        }
                    case 0:
                        {
                            if (!edge.OnLeft(seg.A))
                            {
                                return;
                            }
                            break;
                        }
                }
            }
            if (tA > tB)
            {
                return;
            }
            seg = seg.Morph(tA, tB);

            LineWithIntCords.Draw(g, new Point((int)Math.Round(seg.A.X), (int)Math.Round(seg.A.Y)), new Point((int)Math.Round(seg.B.X), (int)Math.Round(seg.B.Y)));
        }
    }

    public static class PointExtensions
    {
        public static PointF Add(this PointF a, PointF b)
        {
            return new PointF(a.X + b.X, a.Y + b.Y);
        }

        public static PointF Sub(this PointF a, PointF b)
        {
            return new PointF(a.X - b.X, a.Y - b.Y);
        }

        public static PointF Mul(this PointF a, float b)
        {
            return new PointF(a.X * b, a.Y * b);
        }

        public static float ScalarMul(this PointF a, PointF b)
        {
            return a.X * b.X + a.Y * b.Y;
        }

        public static float Det(this PointF a, PointF b)
        {
            return a.X * b.Y - a.Y * b.X;
        }
    }
}
