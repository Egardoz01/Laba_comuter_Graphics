namespace GraphicsAlgosLaba
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLineWithIntChords = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInt = new System.Windows.Forms.RadioButton();
            this.rbNotInt = new System.Windows.Forms.RadioButton();
            this.btnDrawLineWithNotIntChords = new System.Windows.Forms.Button();
            this.txtBoxLNICH_y2 = new System.Windows.Forms.TextBox();
            this.txtBoxLNICH_x2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxLNICH_y1 = new System.Windows.Forms.TextBox();
            this.txtBoxLNICH_x1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLinesNotIntChords = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.txtBoxCircle_y = new System.Windows.Forms.TextBox();
            this.txtBoxCircle_x = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelCircle = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxCircle_r = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 600);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panelLineWithIntChords);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отрезки с целыми координатами";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(831, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конец";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начало ";
            // 
            // panelLineWithIntChords
            // 
            this.panelLineWithIntChords.BackColor = System.Drawing.SystemColors.Control;
            this.panelLineWithIntChords.Location = new System.Drawing.Point(9, 7);
            this.panelLineWithIntChords.Name = "panelLineWithIntChords";
            this.panelLineWithIntChords.Size = new System.Drawing.Size(813, 561);
            this.panelLineWithIntChords.TabIndex = 0;
            this.panelLineWithIntChords.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelLineWithIntChords.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnDrawLineWithNotIntChords);
            this.tabPage2.Controls.Add(this.txtBoxLNICH_y2);
            this.tabPage2.Controls.Add(this.txtBoxLNICH_x2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtBoxLNICH_y1);
            this.tabPage2.Controls.Add(this.txtBoxLNICH_x1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.panelLinesNotIntChords);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отрезки с не целыми координатами";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInt);
            this.groupBox1.Controls.Add(this.rbNotInt);
            this.groupBox1.Location = new System.Drawing.Point(830, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rbInt
            // 
            this.rbInt.AutoSize = true;
            this.rbInt.Checked = true;
            this.rbInt.Location = new System.Drawing.Point(12, 29);
            this.rbInt.Name = "rbInt";
            this.rbInt.Size = new System.Drawing.Size(131, 17);
            this.rbInt.TabIndex = 13;
            this.rbInt.TabStop = true;
            this.rbInt.Text = "Округлить до целого";
            this.rbInt.UseVisualStyleBackColor = true;
            // 
            // rbNotInt
            // 
            this.rbNotInt.AutoSize = true;
            this.rbNotInt.Location = new System.Drawing.Point(12, 63);
            this.rbNotInt.Name = "rbNotInt";
            this.rbNotInt.Size = new System.Drawing.Size(114, 17);
            this.rbNotInt.TabIndex = 14;
            this.rbNotInt.Text = "Хитрый алгоритм";
            this.rbNotInt.UseVisualStyleBackColor = true;
            // 
            // btnDrawLineWithNotIntChords
            // 
            this.btnDrawLineWithNotIntChords.Location = new System.Drawing.Point(842, 348);
            this.btnDrawLineWithNotIntChords.Name = "btnDrawLineWithNotIntChords";
            this.btnDrawLineWithNotIntChords.Size = new System.Drawing.Size(107, 23);
            this.btnDrawLineWithNotIntChords.TabIndex = 12;
            this.btnDrawLineWithNotIntChords.Text = "Нарисовать";
            this.btnDrawLineWithNotIntChords.UseVisualStyleBackColor = true;
            this.btnDrawLineWithNotIntChords.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxLNICH_y2
            // 
            this.txtBoxLNICH_y2.Location = new System.Drawing.Point(868, 182);
            this.txtBoxLNICH_y2.Name = "txtBoxLNICH_y2";
            this.txtBoxLNICH_y2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLNICH_y2.TabIndex = 11;
            // 
            // txtBoxLNICH_x2
            // 
            this.txtBoxLNICH_x2.Location = new System.Drawing.Point(868, 151);
            this.txtBoxLNICH_x2.Name = "txtBoxLNICH_x2";
            this.txtBoxLNICH_x2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLNICH_x2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(827, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(827, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "X";
            // 
            // txtBoxLNICH_y1
            // 
            this.txtBoxLNICH_y1.Location = new System.Drawing.Point(868, 85);
            this.txtBoxLNICH_y1.Name = "txtBoxLNICH_y1";
            this.txtBoxLNICH_y1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLNICH_y1.TabIndex = 7;
            // 
            // txtBoxLNICH_x1
            // 
            this.txtBoxLNICH_x1.Location = new System.Drawing.Point(868, 54);
            this.txtBoxLNICH_x1.Name = "txtBoxLNICH_x1";
            this.txtBoxLNICH_x1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLNICH_x1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(827, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(827, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Начало";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(827, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Начало";
            // 
            // panelLinesNotIntChords
            // 
            this.panelLinesNotIntChords.BackColor = System.Drawing.SystemColors.Control;
            this.panelLinesNotIntChords.Location = new System.Drawing.Point(8, 6);
            this.panelLinesNotIntChords.Name = "panelLinesNotIntChords";
            this.panelLinesNotIntChords.Size = new System.Drawing.Size(813, 561);
            this.panelLinesNotIntChords.TabIndex = 1;
            this.panelLinesNotIntChords.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBoxCircle_r);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnDrawCircle);
            this.tabPage3.Controls.Add(this.txtBoxCircle_y);
            this.tabPage3.Controls.Add(this.txtBoxCircle_x);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.panelCircle);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 574);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Окружности";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.Location = new System.Drawing.Point(850, 207);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(107, 23);
            this.btnDrawCircle.TabIndex = 27;
            this.btnDrawCircle.Text = "Нарисовать";
            this.btnDrawCircle.UseVisualStyleBackColor = true;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // txtBoxCircle_y
            // 
            this.txtBoxCircle_y.Location = new System.Drawing.Point(867, 86);
            this.txtBoxCircle_y.Name = "txtBoxCircle_y";
            this.txtBoxCircle_y.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCircle_y.TabIndex = 22;
            // 
            // txtBoxCircle_x
            // 
            this.txtBoxCircle_x.Location = new System.Drawing.Point(867, 55);
            this.txtBoxCircle_x.Name = "txtBoxCircle_x";
            this.txtBoxCircle_x.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCircle_x.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(826, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(826, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(826, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Центр окружности";
            // 
            // panelCircle
            // 
            this.panelCircle.BackColor = System.Drawing.SystemColors.Control;
            this.panelCircle.Location = new System.Drawing.Point(7, 7);
            this.panelCircle.Name = "panelCircle";
            this.panelCircle.Size = new System.Drawing.Size(813, 561);
            this.panelCircle.TabIndex = 16;
            this.panelCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCircle_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(864, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Радиус";
            // 
            // txtBoxCircle_r
            // 
            this.txtBoxCircle_r.Location = new System.Drawing.Point(867, 152);
            this.txtBoxCircle_r.Name = "txtBoxCircle_r";
            this.txtBoxCircle_r.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCircle_r.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(826, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "R";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 606);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Лаба по компьютерной графике, Климов";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelLineWithIntChords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxLNICH_y1;
        private System.Windows.Forms.TextBox txtBoxLNICH_x1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLinesNotIntChords;
        private System.Windows.Forms.RadioButton rbNotInt;
        private System.Windows.Forms.RadioButton rbInt;
        private System.Windows.Forms.Button btnDrawLineWithNotIntChords;
        private System.Windows.Forms.TextBox txtBoxLNICH_y2;
        private System.Windows.Forms.TextBox txtBoxLNICH_x2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBoxCircle_r;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDrawCircle;
        private System.Windows.Forms.TextBox txtBoxCircle_y;
        private System.Windows.Forms.TextBox txtBoxCircle_x;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelCircle;
    }
}

