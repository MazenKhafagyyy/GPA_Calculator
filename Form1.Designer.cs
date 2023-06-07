namespace GPA_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            button1 = new Button();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox7 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown7 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            credits_lbl = new Label();
            course_lbl = new Label();
            grade_lbl = new Label();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            output_box = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-", "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            comboBox1.Location = new Point(725, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 41);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(377, 539);
            button1.Name = "button1";
            button1.Size = new Size(173, 47);
            button1.TabIndex = 22;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "-", "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            comboBox5.Location = new Point(725, 328);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(279, 41);
            comboBox5.TabIndex = 14;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "-", "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            comboBox4.Location = new Point(725, 281);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(279, 41);
            comboBox4.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "-", "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            comboBox3.Location = new Point(725, 234);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(279, 41);
            comboBox3.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "-", "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            comboBox2.Location = new Point(725, 186);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(279, 41);
            comboBox2.TabIndex = 5;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "-", "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            comboBox6.Location = new Point(725, 376);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(279, 41);
            comboBox6.TabIndex = 18;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "-", "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            comboBox7.Location = new Point(725, 423);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(279, 41);
            comboBox7.TabIndex = 21;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(441, 140);
            numericUpDown1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(277, 41);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown7
            // 
            numericUpDown7.DecimalPlaces = 1;
            numericUpDown7.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown7.Location = new Point(441, 424);
            numericUpDown7.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size(277, 41);
            numericUpDown7.TabIndex = 20;
            // 
            // numericUpDown6
            // 
            numericUpDown6.DecimalPlaces = 1;
            numericUpDown6.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown6.Location = new Point(441, 376);
            numericUpDown6.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(277, 41);
            numericUpDown6.TabIndex = 17;
            // 
            // numericUpDown5
            // 
            numericUpDown5.DecimalPlaces = 1;
            numericUpDown5.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown5.Location = new Point(441, 330);
            numericUpDown5.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(277, 41);
            numericUpDown5.TabIndex = 13;
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 1;
            numericUpDown4.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown4.Location = new Point(441, 282);
            numericUpDown4.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(277, 41);
            numericUpDown4.TabIndex = 10;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 1;
            numericUpDown3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown3.Location = new Point(441, 235);
            numericUpDown3.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(277, 41);
            numericUpDown3.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 1;
            numericUpDown2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown2.Location = new Point(441, 186);
            numericUpDown2.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(277, 41);
            numericUpDown2.TabIndex = 4;
            // 
            // credits_lbl
            // 
            credits_lbl.AutoSize = true;
            credits_lbl.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            credits_lbl.Location = new Point(518, 57);
            credits_lbl.Name = "credits_lbl";
            credits_lbl.Size = new Size(119, 42);
            credits_lbl.TabIndex = 15;
            credits_lbl.Text = "Credits";
            credits_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // course_lbl
            // 
            course_lbl.AutoSize = true;
            course_lbl.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            course_lbl.Location = new Point(241, 57);
            course_lbl.Name = "course_lbl";
            course_lbl.Size = new Size(113, 42);
            course_lbl.TabIndex = 16;
            course_lbl.Text = "Course";
            course_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grade_lbl
            // 
            grade_lbl.AutoSize = true;
            grade_lbl.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            grade_lbl.Location = new Point(809, 57);
            grade_lbl.Name = "grade_lbl";
            grade_lbl.Size = new Size(100, 42);
            grade_lbl.TabIndex = 17;
            grade_lbl.Text = "Grade";
            grade_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 41);
            textBox1.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(152, 330);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(283, 41);
            textBox5.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 41);
            textBox2.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(152, 377);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(283, 41);
            textBox6.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 41);
            textBox3.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(152, 424);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(283, 41);
            textBox7.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(152, 283);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(283, 41);
            textBox4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Chicken_removebg_preview1;
            pictureBox1.Location = new Point(-2, 626);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(483, 360);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.NYAN_PC;
            pictureBox2.Location = new Point(838, 697);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(277, 177);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // output_box
            // 
            output_box.BackColor = Color.White;
            output_box.Enabled = false;
            output_box.Location = new Point(622, 545);
            output_box.Name = "output_box";
            output_box.Size = new Size(200, 41);
            output_box.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1181, 980);
            Controls.Add(output_box);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox7);
            Controls.Add(textBox3);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(grade_lbl);
            Controls.Add(course_lbl);
            Controls.Add(credits_lbl);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown6);
            Controls.Add(numericUpDown7);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox7);
            Controls.Add(comboBox6);
            Controls.Add(comboBox2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox4);
            Controls.Add(comboBox5);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            DoubleBuffered = true;
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "GPA Calculator";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion




        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private Label credits_lbl;
        private Label course_lbl;
        private Label grade_lbl;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox2;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox7;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox output_box;
    }
}