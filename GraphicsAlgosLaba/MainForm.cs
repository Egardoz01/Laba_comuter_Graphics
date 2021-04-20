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

        private KeyValuePair<double,double> p_begin_double;
        private KeyValuePair<double, double> p_end_double;
        public MainForm()
        {
            InitializeComponent();
            InitLinesWithIntChords();
        }

        #region Lines_Int_Chords

        private void InitLinesWithIntChords()
        {
            is_drawing = false;
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
    }
}
