namespace CarExc
{
    public partial class Form1 : Form
    {
        int currentSpeed = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            //init var
            int maxSpeed = 0;
            int accelerate = 0;
            //int braking = 0;

            if (rbFerrari.Checked)
            {
                maxSpeed = 300;
                accelerate = 20;
                //braking = 30;
                lblTopSpeed.Text = maxSpeed.ToString();
            }
            else if (rbFiat.Checked)
            {
                maxSpeed = 170;
                accelerate = 12;
                //braking = 20;
                lblTopSpeed.Text = maxSpeed.ToString();
            }
            else if (rbSaab.Checked)
            {
                maxSpeed = 150;
                accelerate = 10;
                //braking = 18;
                lblTopSpeed.Text = maxSpeed.ToString();
            }
            else { MessageBox.Show("Please select a brand"); }

            if (currentSpeed >= maxSpeed) { MessageBox.Show("You're already at max speed."); }
            else { currentSpeed = (currentSpeed + accelerate); }
            lblCurrentSpeed.Text = currentSpeed.ToString();
            pbSpeed.Maximum = maxSpeed;
            pbSpeed.Value = Math.Min(currentSpeed, maxSpeed);


        }

        private void rbFerrari_CheckedChanged(object sender, EventArgs e)
        {
            int maxSpeed = 300;
            lblTopSpeed.Text = maxSpeed.ToString();
        }

        private void rbFiat_CheckedChanged(object sender, EventArgs e)
        {
            int maxSpeed = 170;
            lblTopSpeed.Text = maxSpeed.ToString();
        }

        private void rbSaab_CheckedChanged(object sender, EventArgs e)
        {
            int maxSpeed = 150;
            lblTopSpeed.Text = maxSpeed.ToString();
        }
    }
    /* 
     Going to use radiobuttons to select 3 different brands of cars: Ferrari, Fiat, Saab. Ferrari acc = 20km br 30km, Fiat acc=12km br 20km, saab acc =10km br=18km

     */
}

