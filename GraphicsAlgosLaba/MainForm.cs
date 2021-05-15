using GraphicsAlgosLaba.Algos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgosLaba
{
    public partial class MainForm : Form
    {

        private bool is_begin;
        private bool is_drawing;
        private Point p_begin;
        private Point p_end;
        private Point center;
        private int radius;
        private KeyValuePair<double,double> p_begin_double;
        private KeyValuePair<double, double> p_end_double;
        private List<Point> points;
        public MainForm()
        {
            InitializeComponent();
            InitLinesWithIntChords();
            InitBezie();
        }

        #region Lines_Int_Chords

        private void InitLinesWithIntChords()
        {
            is_drawing = false;
            is_begin = true;
        }

        private void InitBezie()
        {
            points = new List<Point>();
            is_drawing = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControle1.SelectedIndex == 0)
                InitLinesWithIntChords();
            if (tabControle1.SelectedIndex == 3)
                InitBezie();
            if (tabControle1.SelectedIndex == 4)
                InitLinesWithIntChords();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (is_begin)
            {
                is_begin = false;
                p_begin = e.Location;
            }
            else
            {
                p_end = e.Location;
                label1.Text = $"Начало=({p_begin.X}, {p_begin.Y})";
                label2.Text = $"Конец=({p_end.X}, {p_end.Y})";
                is_begin = true;
                is_drawing = true;
                panelLineWithIntChords.Refresh();
            }
        }

        private void DrawLineWithIntCords(Graphics g)
        {
            if (is_drawing)
            {
                is_drawing = false;
                LineWithIntCords.Draw(g, p_begin, p_end);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs pea)
        {
            DrawLineWithIntCords(pea.Graphics);
        }

        #endregion

        #region Lines_not_int_Chords


        #endregion

        private void DrawLineWithNotIntCords(Graphics g)
        {
            if (is_drawing)
            {
                is_drawing = false;
                LineWithRationalCords.Draw(g, p_begin_double, p_end_double);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(txtBoxLNICH_x1.Text);
                double y1 = double.Parse(txtBoxLNICH_y1.Text);

                double x2 = double.Parse(txtBoxLNICH_x2.Text);
                double y2 = double.Parse(txtBoxLNICH_y2.Text);

                if (x1 < 0 || x1 >=panelLinesNotIntChords.Width || x2<0 || x2>=panelLinesNotIntChords.Width)
                {
                    MessageBox.Show("Х должен дыть в диапазоне от 0 до " + (panelLinesNotIntChords.Width-1));
                    return;
                }

                if (y1 < 0 || y1 >= panelLinesNotIntChords.Height|| y2 < 0 || y2 >= panelLinesNotIntChords.Height)
                {
                    MessageBox.Show("Y должен дыть в диапазоне от 0 до " + (panelLinesNotIntChords.Height- 1));
                    return;
                }

                if (rbInt.Checked)
                {//Приближаем к целым значениям

                    p_begin = new Point((int)Math.Round(x1),(int)Math.Round(y1));
                    p_end =  new Point((int)Math.Round(x2), (int)Math.Round(y2));
                    is_drawing = true;
                    panelLinesNotIntChords.Refresh();
                }
                if (rbNotInt.Checked)
                {
                    p_begin_double = new KeyValuePair<double, double>(x1, y1);
                    p_end_double = new KeyValuePair<double, double>(x2, y2);
                    is_drawing = true;
                    panelLinesNotIntChords.Refresh();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (rbInt.Checked)
            {//Приближаем к целым значениям
                DrawLineWithIntCords(e.Graphics);
            }
            if (rbNotInt.Checked)
            {
                DrawLineWithNotIntCords(e.Graphics);
            }
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            is_drawing = true;
            try
            {
                int x = int.Parse(txtBoxCircle_x.Text);
                int y = int.Parse(txtBoxCircle_y.Text);
                int r = int.Parse(txtBoxCircle_r.Text);

                if (x < 0 || x >= panelCircle.Width)
                {
                    MessageBox.Show("Х должен дыть в диапазоне от 0 до " + (panelCircle.Width - 1));
                    return;
                }

                if (y < 0 || y >= panelCircle.Height )
                {
                    MessageBox.Show("Y должен дыть в диапазоне от 0 до " + (panelCircle.Height - 1));
                    return;
                }
                if (r <=0 || r > Math.Max(panelCircle.Height, panelCircle.Width))
                {
                    MessageBox.Show("R должен дыть в диапазоне от 0 до " + Math.Max(panelCircle.Height, panelCircle.Width));
                }

                center.X = x;
                center.Y = y;
                radius = r;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }

            panelCircle.Refresh();
        }

        private void panelCircle_Paint(object sender, PaintEventArgs e)
        {
            if (is_drawing)
            {
                is_drawing = false;
                Circle.Draw(e.Graphics, center.X, center.Y, radius);
            }
        }

        private void panelBezie_Paint(object sender, PaintEventArgs e)
        {
            if (is_drawing)
            {
                Bizie.Draw(e.Graphics, points);
                is_drawing = false;

                points.Clear();
            }
            else
            {
                foreach (var p in points)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 2), p.X, p.Y, 1,  1);
                }
            }
        }

        private void panelBezie_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            panelBezie.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            is_drawing = true;
            panelBezie.Refresh();
        }

        private void panelSezerlendAlgo_Paint(object sender, PaintEventArgs e)
        {
            int h = panelSezerlendAlgo.Height;
            int w = panelSezerlendAlgo.Width;
            int x = (w - 300) / 2;
            int y = (h - 200) / 2;
            Rectangle r = new Rectangle(new Point(x, y), new Size(300, 200));
            Otsechenia.DrawRect(e.Graphics, r);
            if (is_drawing)
            {
                is_drawing = false;
                if (rbSezerlendCOen.Checked)
                    Otsechenia.SazerlendCoen(e.Graphics, r, p_begin, p_end);
                if(rbSredTochka.Checked)
                    Otsechenia.SredTochki(e.Graphics, r, p_begin, p_end);
                if (rbCirusBec.Checked)
                {
                    List<PointF> points = new List<PointF>();
                    points.Add(new PointF(x, y));
                    points.Add(new PointF(x+300, y));
                    points.Add(new PointF(x+300, y+200));
                    points.Add(new PointF(x, y + 200));
                    Polygon p = new Polygon(points);
                    p.DrawCirusBec(e.Graphics, new Segment(p_begin, p_end));

                }

            }
        }

        private void panelSezerlendAlgo_MouseClick(object sender, MouseEventArgs e)
        {
            if (is_begin)
            {
                is_begin = false;
                p_begin = e.Location;
            }
            else
            {
                p_end = e.Location;
                is_drawing = true;
                panelSezerlendAlgo.Refresh();
                is_begin = true;
            }
        }
    }
}
