using System.ComponentModel;

namespace Mod3EventsDel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private void test(object sender, EventArgs e)
        //{

        //}

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount();
          //  bankAccount.LowBalance += BankAccount_LowBalance;
            bankAccount.AccountNumber=int.Parse(txtAccNum.Text);
            bankAccount.AccountBalance=double .Parse(txtBalance.Text);
        }

        // event handler
        private void BankAccount_LowBalance(double bal)
        {
            MessageBox.Show($"Balance of {bal} is too low to open an account, please enter more than $200");
        }
    }
}
