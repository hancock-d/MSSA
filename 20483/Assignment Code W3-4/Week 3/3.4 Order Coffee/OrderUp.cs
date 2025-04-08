using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._4_Order_Coffee
{
    public partial class OrderUp : Form
    {
        public OrderUp()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e) //Loading combo boxes and grid
        {
            ordersGrid.DataSource = Data.Coffee;
            ordersGrid.Columns[5].DisplayIndex = 1;  //TRying to move name to index 1, not working
            comboTemp.DataSource = Enum.GetValues(typeof(Temperature));
            comboCup.DataSource = Enum.GetValues(typeof(CupSize));
            comboDrink.DataSource = Enum.GetValues(typeof(DrinkName));
            comboBean.DataSource = Enum.GetValues(typeof(BeanType));
            comboRoast.DataSource = Enum.GetValues(typeof(RoastStrength));



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ordersGrid.DataSource = null;
            ordersGrid.DataSource = Data.Coffee;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != string.Empty)
            {
            var newCoffee = new Coffee();
            newCoffee.CustomerName = txtCustomerName.Text;
            newCoffee.Temp = (Temperature)(comboTemp.SelectedIndex + 1);
            newCoffee.Cup = (CupSize)(comboCup.SelectedIndex + 1);
            newCoffee.Drink = (DrinkName)(comboDrink.SelectedIndex + 1);
            newCoffee.Bean = (BeanType)(comboBean.SelectedIndex + 1);
            newCoffee.Roast = (RoastStrength)(comboRoast.SelectedIndex + 1);
            Data.Coffee.Add(newCoffee);
            MessageBox.Show("Order up!");

            txtCustomerName.Clear();
            ordersGrid.DataSource = null;
            ordersGrid.DataSource = Data.Coffee;
            }
            else
            {
                MessageBox.Show("Please enter your name", "Error!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Cancel the order?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.Coffee.RemoveAt(ordersGrid.CurrentRow.Index);
                ordersGrid.DataSource = null;
                ordersGrid.DataSource = Data.Coffee;
            }
        }
    }
}
