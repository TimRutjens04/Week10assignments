namespace CarExc
{
    public partial class Form1 : Form
    {
        private int currentSpeed = 0;
        private int maxSpeed;
        private int accelerate;
        private int braking;
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
                accelerate = 15;
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
            //lblCurrentSpeed.Text = Convert.ToString(0);
            currentSpeed = 0;
            int maxSpeed = 300;
            lblTopSpeed.Text = maxSpeed.ToString();
        }

        private void rbFiat_CheckedChanged(object sender, EventArgs e)
        {
            //lblCurrentSpeed.Text = Convert.ToString(0);
            currentSpeed = 0;
            int maxSpeed = 168;
            lblTopSpeed.Text = maxSpeed.ToString();
        }

        private void rbSaab_CheckedChanged(object sender, EventArgs e)
        {
            //lblCurrentSpeed.Text = Convert.ToString(0);
            currentSpeed = 0;
            int maxSpeed = 150;
            lblTopSpeed.Text = maxSpeed.ToString();
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            int maxSpeed = 0;
            int braking = 0;

            if (rbFerrari.Checked)
            {
                maxSpeed = 300;
                braking = 30;
            }
            else if (rbFiat.Checked)
            {
                maxSpeed = 168;
                braking = 20;
            }
            else if (rbSaab.Checked)
            {
                maxSpeed = 150;
                braking = 18;
            }
            else
            {
                MessageBox.Show("Please select a brand.");
            }

            if (currentSpeed == 0)
            {
                MessageBox.Show("You are currently standing still");
            }
            else
            {
                currentSpeed = currentSpeed - braking;

                if (currentSpeed < braking)
                {
                    currentSpeed = 0;
                }

                lblCurrentSpeed.Text = currentSpeed.ToString();
                pbSpeed.Value = Math.Max(0, Math.Min(currentSpeed, maxSpeed));
            }
        }

    }
    /* 
     Going to use radiobuttons to select 3 different brands of cars: Ferrari, Fiat, Saab. Ferrari acc = 20km br 30km, Fiat acc=12km br 20km, saab acc =10km br=18km

     */
}

