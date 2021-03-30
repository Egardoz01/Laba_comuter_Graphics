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
        private bool is_paint;
        private Point p_begin;
        private Point p_end;
        private Panel drawind_panel;
        public MainForm()
        {
            InitializeComponent();
            InitLinesWithIntChords();
        }

        private void Plot(Graphics g, int x, int y)
        {
            g.DrawRectangle(new Pen(new SolidBrush(Color.Black)), x,y,1,1);
        }

        #region Lines_Int_Chords

        private void InitLinesWithIntChords()
        {
            is_paint = false;
            is_begin = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                InitLinesWithIntChords();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (is_begin)
            {
                is_paint = false;
                is_begin = false;
                p_begin = e.Location;
            }
            else
            {
                p_end = e.Location;
                label1.Text = $"Начало=({p_begin.X}, {p_begin.Y})";
                label2.Text = $"Конец=({p_end.X}, {p_end.Y})";
                is_begin = true;
                is_paint = true;
                panel1.Refresh();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs pea)
        {
            if (is_paint)
            {
                //e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)),p_begin, p_end);

                int x = 0;
                int y = 0;
                int a = p_end.X - p_begin.X;
                int b = p_end.Y - p_begin.Y;
                int x_mnoj = 1, y_mnoj=1;
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

                        Plot(pea.Graphics, x * x_mnoj + p_begin.X, y * y_mnoj + p_begin.Y);

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

                        Plot(pea.Graphics, x * x_mnoj + p_begin.X, y * y_mnoj + p_begin.Y);

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

        #endregion
    }
}
