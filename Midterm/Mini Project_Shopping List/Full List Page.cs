using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project_Shopping_List
{
    public partial class Full_List_Page : Form
    {
        public Full_List_Page()
        {
            InitializeComponent();

        }

        // Create the columns for Store grids
        private void SetupGridView(DataGridView gridView)
        {
            gridView.Columns.Clear();
            gridView.AutoGenerateColumns = true; //automatically create columns


            //add in a checkmark column
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = ""; //no header text for check column
            checkColumn.Name = "Purchased";
            checkColumn.Width = 50;
            checkColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridView.Columns.Add(checkColumn);
        }

        private void UpdateGridViews()
        {
            //clear existing data
            storeAGrid.DataSource = null;
            storeBGrid.DataSource = null;

            //create a list for each store to hold the grocery objects
            List<object> storeAItems = new List<object>();
            List<object> storeBItems = new List<object>();

            //Loop through GroceryData groceries list and to add items to the correct store
            foreach (var grocery in GroceryData.Groceries)
            {
                //create temporary object to hold each grocery
                var item = new { Item = grocery.GroceryItem, Quantity = (int)grocery.Quantity };  //also creates ITem and Quant headers/columns

                if (grocery.StoreName == StoreName.StoreA)
                {
                    storeAItems.Add(item); //add to list of items in store A
                }
                else if (grocery.StoreName == StoreName.StoreB)
                {
                    storeBItems.Add(item);
                }
            }

            //set the grid datasource to the list of items
            storeAGrid.DataSource = storeAItems;
            storeBGrid.DataSource = storeBItems;

            //Change Quantity header to #
            if (storeAGrid.Columns.Contains("Quantity"))
                storeAGrid.Columns["Quantity"].HeaderText = "#";
            if (storeBGrid.Columns.Contains("Quantity"))
                storeBGrid.Columns["Quantity"].HeaderText = "#";
        }
        private void Full_List_Page_Load(object sender, EventArgs e)
        {
            //Load combo boxes, radio buttons, and grids
            int[] quantityValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //solves issue of _# loading in combo box
            comboQuant.DataSource = quantityValues;

            rdoStoreA.Text = GroceryData.StoreNames[StoreName.StoreA]; //load radio button names
            rdoStoreB.Text = GroceryData.StoreNames[StoreName.StoreB];
            lblStoreA.Text = GroceryData.StoreNames[StoreName.StoreA]; //load label names
            lblStoreB.Text = GroceryData.StoreNames[StoreName.StoreB];

            SetupGridView(storeAGrid);
            SetupGridView(storeBGrid);

            UpdateGridViews();

        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddItem.Text))
            {
                int selectedQuantity = (int)comboQuant.SelectedItem;

                StoreName selectedStore;

                if (rdoStoreA.Checked)
                {
                    selectedStore = StoreName.StoreA;
                }
                else if (rdoStoreB.Checked)
                {
                    selectedStore = StoreName.StoreB;
                }
                else
                    selectedStore = StoreName.StoreA; //default to store A

                //Add the item to the GroceryData groceries list
                GroceryData.Groceries.Add(new Grocery(txtAddItem.Text, selectedQuantity, selectedStore));

                txtAddItem.Clear();
                comboQuant.SelectedItem = 1;

                UpdateGridViews();
            }

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            RemoveCheckedItems(storeAGrid, StoreName.StoreA);
            RemoveCheckedItems(storeBGrid, StoreName.StoreB);

            UpdateGridViews();
        }

        private void RemoveCheckedItems(DataGridView grid, StoreName store)
        {
            //create list of items to be removed
            List<string> itemsToRemove = new List<string>();

            //loop through and find all checked items
            foreach (DataGridViewRow row in grid.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["Purchased"].Value);
                if (isChecked)
                {
                    string itemName = row.Cells["Item"].Value.ToString(); //take value from the Item cell, convert to string
                    itemsToRemove.Add(itemName); //add it to the list
                }
            }

            foreach (var item in itemsToRemove) //go through each item in list
            {
                for (int i = 0; i <= GroceryData.Groceries.Count - 1; i++)
                {
                    if (GroceryData.Groceries[i].GroceryItem == item && GroceryData.Groceries[i].StoreName == store) //compare item from remove list with Groceries list
                    {
                        GroceryData.Groceries.RemoveAt(i); //remove it at list index
                    }
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
