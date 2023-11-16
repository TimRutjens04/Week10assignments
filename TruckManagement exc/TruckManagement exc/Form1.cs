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

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            //Initialize variables
            string truckType = "A";
            int numPallets = 0;
            int boxesPerPallet = 0;
            int fullTrucks = 0;
            int fullPalletsOnNonFullTruck = 0;
            int boxesOnPartialPallet = 0;
            int numBoxes = 0;
            int.TryParse(tbBoxesShipped.Text, out numBoxes);

            if (rbB.Checked)
            {
                // Calculate for truck type B
                truckType = "B";
                int.TryParse(maxPalletB.Text, out numPallets);
                int.TryParse(maxBoxB.Text, out boxesPerPallet);
            }
            else if (rbC.Checked)
            {
                // Calculate for truck type C
                truckType = "C";
                int.TryParse(maxPalletC.Text, out numPallets);
                int.TryParse(maxBoxC.Text, out boxesPerPallet);
            }
            else
            {
                // Calculate for truck type A
                int.TryParse(maxPalletA.Text, out numPallets);
                int.TryParse(maxBoxA.Text, out boxesPerPallet);
            }

            // Perform common calculations
            fullTrucks = numBoxes / (numPallets * boxesPerPallet);
            int remainingBoxes = numBoxes % (numPallets * boxesPerPallet);
            fullPalletsOnNonFullTruck = remainingBoxes / boxesPerPallet;
            boxesOnPartialPallet = remainingBoxes % boxesPerPallet;

            // Construct the result string with line breaks
            string resultMessage = $"Full Trucks: {fullTrucks}\n" +
                                   $"Full Pallets on Non-Full Truck: {fullPalletsOnNonFullTruck}\n" +
                                   $"Boxes on Non-Full Pallet: {boxesOnPartialPallet}\n" +
                                   $"Truck type: {truckType}";

            // Display the results in a single MessageBox
            MessageBox.Show(resultMessage);
        }


        

    }
}




    

