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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // panel1
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
            // radioButton1
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
            // radioButton2
            // 
            this.rbNotInt.AutoSize = true;
            this.rbNotInt.Location = new System.Drawing.Point(12, 63);
            this.rbNotInt.Name = "rbNotInt";
            this.rbNotInt.Size = new System.Drawing.Size(114, 17);
            this.rbNotInt.TabIndex = 14;
            this.rbNotInt.Text = "Хитрый алгоритм";
            this.rbNotInt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.btnDrawLineWithNotIntChords.Location = new System.Drawing.Point(842, 348);
            this.btnDrawLineWithNotIntChords.Name = "button1";
            this.btnDrawLineWithNotIntChords.Size = new System.Drawing.Size(107, 23);
            this.btnDrawLineWithNotIntChords.TabIndex = 12;
            this.btnDrawLineWithNotIntChords.Text = "Нарисовать";
            this.btnDrawLineWithNotIntChords.UseVisualStyleBackColor = true;
            this.btnDrawLineWithNotIntChords.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.txtBoxLNICH_y2.Location = new System.Drawing.Point(868, 182);
            this.txtBoxLNICH_y2.Name = "txtBoxLNICH_y2";
            this.txtBoxLNICH_y2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLNICH_y2.TabIndex = 11;
            // 
            // textBox4
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
            // textBox2
            // 
            this.txtBoxLNICH_y1.Location = new System.Drawing.Point(868, 85);
            this.txtBoxLNICH_y1.Name = "txtBoxLNICH_y1";
            this.txtBoxLNICH_y1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLNICH_y1.TabIndex = 7;
            // 
            // textBox1
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
            // Конец
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(827, 120);
            this.label8.Name = "Конец";
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
            // panel2
            // 
            this.panelLinesNotIntChords.BackColor = System.Drawing.SystemColors.Control;
            this.panelLinesNotIntChords.Location = new System.Drawing.Point(8, 6);
            this.panelLinesNotIntChords.Name = "panelLinesNotIntChords";
            this.panelLinesNotIntChords.Size = new System.Drawing.Size(813, 561);
            this.panelLinesNotIntChords.TabIndex = 1;
            this.panelLinesNotIntChords.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
    }
}

