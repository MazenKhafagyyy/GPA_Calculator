namespace GPA_Calculator
{
    public partial class Form1 : Form
    {

        private decimal switch_letter_grade(string letter_grade)
        {
            decimal value = 0;

            if (letter_grade == "A+" || letter_grade == "A")
            {
                value = (decimal)4.0;
            }
            else if (letter_grade == "A-")
            {
                value = (decimal)3.7;
            }
            else if (letter_grade == "B+")
            {
                value = (decimal)3.3;
            }
            else if (letter_grade == "B")
            {
                value = (decimal)3.0;
            }
            else if (letter_grade == "B-")
            {
                value = (decimal)2.7;
            }
            else if (letter_grade == "C+")
            {
                value = (decimal)2.3;
            }
            else if (letter_grade == "C")
            {
                value = (decimal)2.0;
            }
            else if (letter_grade == "C-")
            {
                value = (decimal)1.7;
            }
            else if (letter_grade == "D+")
            {
                value = (decimal)1.3;
            }
            else if (letter_grade == "D")
            {
                value = (decimal)1.0;
            }
            else if (letter_grade == "D-")
            {
                value = (decimal)0.7;
            }
            else if (letter_grade == "F")
            {
                value = (decimal)0.0;
            }

            //NEED ERROR CHECKING HERE

            return value;
        }

        private decimal gpa = 0;
        private decimal total_credits = 0;
        private decimal grade_points = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total_credits = numericUpDown1.Value + numericUpDown2.Value +
                            numericUpDown3.Value + numericUpDown4.Value +
                            numericUpDown5.Value + numericUpDown6.Value +
                            numericUpDown7.Value;

            grade_points = numericUpDown1.Value * switch_letter_grade(comboBox1.Text) +
                           numericUpDown2.Value * switch_letter_grade(comboBox2.Text) +
                           numericUpDown3.Value * switch_letter_grade(comboBox3.Text) +
                           numericUpDown4.Value * switch_letter_grade(comboBox4.Text) +
                           numericUpDown5.Value * switch_letter_grade(comboBox5.Text) +
                           numericUpDown6.Value * switch_letter_grade(comboBox6.Text) +
                           numericUpDown7.Value * switch_letter_grade(comboBox7.Text);

            gpa = (decimal)(grade_points / total_credits);

            //APPROXIMATE TO 1 DECIMAL PLACE
            gpa = Math.Round(gpa, 1);
            //NEED TO OUTPUT TOTAL CREDITS AND GRADE POINTS
            output_box.Text = gpa.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings1.Default.Save();
        }
    }
}