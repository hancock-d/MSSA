using System.Data;

namespace _4._2_Teacher_LMS
{
    public partial class LoginPageForm : Form
    {
        public LoginPageForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.ToLower() == "teacher" && txtPassword.Text == "Admin")
            {
                MessageBox.Show("Login successful");

                TeacherPortalForm teacherPortal = new TeacherPortalForm();
                teacherPortal.Show();
                //this.Close(); //Closes the login form, which closes the whole program
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username and password don't match", "Warning", MessageBoxButtons.OK);
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}
