using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTest_Dave_
{
    public partial class Form1 : Form //Form1 has already inherited from windows class Form
    {
        public Form1() //Constructor
        {
            InitializeComponent();
        }

        //click --> event handler
        private void btnLogin_Click(object sender, EventArgs e) //Event Handler
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Password") //.Text is a property of the text box
            {
                MessageBox.Show("Login successful");
            }
            else
            {
                MessageBox.Show("Enter details again");
                txtUsername.Clear();
                txtPassword.Clear();
            }

        }
    }
}
