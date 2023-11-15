namespace TruckManagement_exc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbC_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Parse user input
            if (int.TryParse(maxPalletA.Text, out int numPallets) && int.TryParse(maxBoxA.Text, out int boxesPerPallet))
            {
                // Calculate total number of boxes
                int numBoxes = numPallets * boxesPerPallet;

                // Initialize variables for results
                int fullTrucks = 0;
                int fullPalletsOnNonFullTruck = 0;
                int boxesOnPartialPallet = 0;

                // Determine truck type based on radio buttons
                string truckType = "A";
                if (rbB.Checked)
                {
                    truckType = "B";
                }
                else if (rbC.Checked)
                {
                    truckType = "C";
                }

                // Calculate based on the selected truck type
                switch (truckType)
                {
                    case "A":
                    case "B":
                    case "C":
                        fullTrucks = numBoxes / (numPallets * boxesPerPallet);
                        break;
                }

                // Calculate remaining boxes for non-full truck
                int remainingBoxes = numBoxes % (numPallets * boxesPerPallet);

                // Calculate full pallets for non-full truck
                fullPalletsOnNonFullTruck = remainingBoxes / boxesPerPallet;

                // Calculate boxes on the non-full pallet
                boxesOnPartialPallet = remainingBoxes % boxesPerPallet;

                // Display results
                MessageBox.Show($"Full Trucks: {fullTrucks}");
                MessageBox.Show($"Full Pallets on Non-Full Truck: {fullPalletsOnNonFullTruck}");
                MessageBox.Show($"Boxes on Non-Full Pallet: {boxesOnPartialPallet}");
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for the number of pallets and boxes per pallet.");
            }
        }


    }
}