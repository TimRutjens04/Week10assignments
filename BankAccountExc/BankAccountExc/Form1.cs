namespace BankAccountExc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class BankAccount 
    {
        private string client;
        private int accountNo;
        private double balance;

        public void InitializeBankAccount(string newClient, int newAccountNo) 
        {
            client = newClient;
            accountNo = newAccountNo;
            balance = 0;
        }
        public void DepositMoney(double amount)
        {
            balance = (balance + amount);
        }
        public bool WithdrawMoney(double amount) 
        {
            if (balance < amount)
            {
                MessageBox.Show("You can't withdraw more than your balance.");
                return false;
            }
            else 
            {
                balance = (balance - amount);
                return true;
            }

        }
        public string GetInfo() 
        {
            string infoMessage = $"Client: {client} ({accountNo})\n" + $"Balance: {balance}";
            MessageBox.Show(infoMessage);
            return infoMessage;
        }
    }
}