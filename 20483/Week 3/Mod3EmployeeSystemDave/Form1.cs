namespace Mod3EmployeeSystemDave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "HR" && txtPassword.Text == "Password") //hard coding username and password
            {
                //Can also add logic here to set a max on attempts
                MessageBox.Show("Welcome HR!");
                //Go back to MainForm by creating a new object of the MainForm
                MainForm mainForm = new MainForm();
                mainForm.Show(); //mainForm (second form) will show up
                this.Hide(); //this. references Form1 and will hide it
            }
            else
            {
                MessageBox.Show("Invalid attempt, please login again");
                txtUsername.Clear(); //clearing username and password from the text box
                txtPassword.Clear();
            }
        }
    }
}
