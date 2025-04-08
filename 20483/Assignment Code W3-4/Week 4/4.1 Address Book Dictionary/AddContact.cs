using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._1_Address_Book_Dictionary
{
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
            comboType.DataSource = Enum.GetValues(typeof(PhoneType));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Ensure all pertinent fields are filled (first/last name, #, address
            if (txtFname.Text != string.Empty &&
                txtLname.Text != string.Empty &&
                txtPnumber.Text != string.Empty &&
                txtAddress.Text != string.Empty)
            {
                string fullName = txtFname.Text + " " + txtLname.Text; //adding fullName as key
                fullName = fullName.ToLower();

                //Check if contact exists already
                if (ABookData.phoneBook.ContainsKey(fullName.ToLower()))
                {
                    MessageBox.Show("This contact already exists!", "Error", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    var newContact = new Person();
                    newContact.FirstName = txtFname.Text;
                    newContact.LastName = txtLname.Text;
                    newContact.PhoneNumber = txtPnumber.Text;
                    newContact.PhoneType = (PhoneType)(comboType.SelectedIndex);
                    newContact.Address = txtAddress.Text;
                    ABookData.phoneBook.Add(fullName, newContact);
                    MessageBox.Show("Contact added, please refresh your book", "Success", MessageBoxButtons.OK);
                    
                }

                this.Close(); //close form after adding contact
            }
            else
            {
                MessageBox.Show("Cannot leave any fields blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
