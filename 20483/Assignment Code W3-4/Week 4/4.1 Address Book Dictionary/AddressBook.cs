using _4._1_Address_Book_Dictionary;

namespace _4._1_Address_Book_Dictionary
{
    public partial class AddressBook : Form
    {
        public AddressBook()
        {
            InitializeComponent();
            UpdateGridView();
        }

        private void AddressBook_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            //phoneGrid.DataSource = ABookData.phoneBook.Values.ToList(); //Convert dictionary to list
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateGridView();
            //phoneGrid.DataSource = null;
            //phoneGrid.DataSource = ABookData.phoneBook.Values.ToList();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            AddContact addContact = new AddContact(); //new instance of AddContact class
            addContact.ShowDialog(); //display AddContact form
        }

        public void UpdateGridView()
        {
            phoneGrid.DataSource = null;
            phoneGrid.DataSource = ABookData.phoneBook.Values.ToList();
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show($"Delete contact?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Person selectedPerson = (Person)phoneGrid.CurrentRow.DataBoundItem; //get highlighted person object from the bound list
                string fullName = selectedPerson.FirstName + " " + selectedPerson.LastName;
                fullName = fullName.ToLower();
                if (ABookData.phoneBook.ContainsKey(fullName))
                {
                    ABookData.phoneBook.Remove(fullName);  //remove from dictnioary
                    UpdateGridView();
                    //MessageBox.Show("Contact removed", "Success", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Contact not found!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            string userSearch = txtSearchBox.Text.ToLower();

            if (ABookData.phoneBook.ContainsKey(userSearch))
            {
                Person foundPerson = ABookData.phoneBook[userSearch];
                string message = ($"Name: {foundPerson.FirstName} {foundPerson.LastName}\nPhone Number: {foundPerson.PhoneNumber}\nAddress: {foundPerson.Address}");

                txtSearchBox.Clear();
                MessageBox.Show(message, "Search Results", MessageBoxButtons.OK);

                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Contact not found!", "Error", MessageBoxButtons.OK);
            }
        }

    }
}

//string fullName = txtFname.Text + " " + txtLname.Text; //name fullName for key
//fullName = fullName.ToLower();

////Check if contact exists already
//if (ABookData.phoneBook.ContainsKey(fullName.ToLower()))