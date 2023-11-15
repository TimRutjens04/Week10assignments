using System.Runtime.Intrinsics.X86;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My name is Rick Sanchez.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.progressBar1.Value = this.trackBar1.Value;
            this.label1.Text = this.trackBar1.Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void btBGSwitch_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Red;
            }
            else if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.Green;
            }
            else if (this.BackColor == Color.Green)
            {
                this.BackColor = Color.Blue;
            }
            else this.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bBMI_Click(object sender, EventArgs e)
        {
            double Height;
            double Weight;

            if (double.TryParse(tbHeight.Text, out Height) && Height > 0)
            {
                if (double.TryParse(tbWeight.Text, out Weight) && Weight > 0)
                {
                    double BMI = Weight / (Height * Height);

                    if (BMI > 0)
                    {
                        string classification;

                        if (BMI < 18.5)
                        {
                            classification = "Underweight";
                        }
                        else if (BMI < 25.0)
                        {
                            classification = "Normal weight";
                        }
                        else if (BMI < 30.0)
                        {
                            classification = "Overweight";
                        }
                        else
                        {
                            classification = "Obese";
                        }

                        MessageBox.Show($"BMI: {BMI:F2}\nClassification: {classification}");
                    }
                }                
            }           
        }
    }
}