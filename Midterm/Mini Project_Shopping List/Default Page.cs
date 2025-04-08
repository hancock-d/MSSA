namespace Mini_Project_Shopping_List
{
    public partial class DefaultPageForm : Form
    {
        public DefaultPageForm()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Full_List_Page fullListPage = new Full_List_Page();
            fullListPage.Show();

            this.Hide();
        }

        //Add store A and store B to the dictionary
        private void btnAddStore_Click(object sender, EventArgs e)
        {
            string storeAName = txtInputStoreA.Text.Trim();
            string storeBName = txtInputStoreB.Text.Trim();

            //Leave store names to A and B as default
            if (string.IsNullOrEmpty(storeAName))
                storeAName = "Store A";
            if (string.IsNullOrEmpty(storeBName))
                storeBName = "Store B";

            //add storenames to dictionary for enum
            GroceryData.StoreNames[StoreName.StoreA] = storeAName;
            GroceryData.StoreNames[StoreName.StoreB] = storeBName;

            //set label text to store names
            lblStoreA.Text = GroceryData.StoreNames[StoreName.StoreA];
            lblStoreB.Text = GroceryData.StoreNames[StoreName.StoreB];

            txtInputStoreA.Clear();
            txtInputStoreB.Clear();
            txtInputStoreA.Visible = false;
            txtInputStoreB.Visible = false;
            lblStoreA.Visible = true;
            lblStoreB.Visible = true;

            MessageBox.Show("Stores added", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void DefaultPageForm_Load(object sender, EventArgs e)
        {
            lblStoreA.Visible = false;
            lblStoreB.Visible = false;
        }
    }
}
