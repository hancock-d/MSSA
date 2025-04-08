using _10._3CarsDB.Models;
using _10._3CarsDB.Services;

namespace _10._3CarsDB
{
    public partial class Form1 : Form
    {
        CRUD crud; //declare it here so it's accessible everywhere here; can't instantiate here cause
                   //requires db connection(?)
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crud = new CRUD(); //instanciate it once so you don't have to with each new event
            carGrid.DataSource = crud.GetCars();
            carGrid.BackgroundColor = Color.White;
            btnUpdate.Enabled = false;
        }

        private void Clear()
        {
            txtVin.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVin.Text) &&
               !string.IsNullOrEmpty(txtMake.Text) &&
               !string.IsNullOrEmpty(txtModel.Text) &&
               !string.IsNullOrEmpty(txtYear.Text) &&
               !string.IsNullOrEmpty(txtPrice.Text))
            {
                var newcar = new Car
                {
                    VIN = txtVin.Text,
                    Make = txtMake.Text,
                    Model = txtModel.Text,
                    //Year = int.Parse(txtYear.Text),
                    Year = int.TryParse(txtYear.Text, out int year) ? year : 0, //default to 0 if invalid
                    //Price = double.Parse(txtPrice.Text)
                    Price = double.TryParse(txtPrice.Text, out double price) ? price : 0,
                };
                crud.AddInventory(newcar);
                MessageBox.Show("Vehicle added to inventory");
                carGrid.DataSource = crud.GetCars();
                Clear();
            }
            else
            { MessageBox.Show("Please fill out all fields"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get vin from grid
            var vin = carGrid.CurrentRow.Cells[0].Value;
            crud.RemoveInventory((string)vin);
            MessageBox.Show("Vehicle deleted from inventory");
            carGrid.DataSource = crud.GetCars();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            var vin = carGrid.CurrentRow.Cells[0].Value; //to.string?
            var cartoupdate = crud.FindCar((string)vin);
            txtVin.Text = cartoupdate.VIN;
            txtMake.Text = cartoupdate.Make;
            txtModel.Text = cartoupdate.Model;
            txtYear.Text = cartoupdate.Year.ToString();
            txtPrice.Text = cartoupdate.Price.ToString();
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var vin = txtVin.Text;
            var cartoupdate = crud.FindCar((string)vin);
            cartoupdate.VIN = txtVin.Text;
            cartoupdate.Make = txtMake.Text;
            cartoupdate.Model = txtModel.Text;
            //cartoupdate.Year = int.Parse(txtYear.Text);
            cartoupdate.Year = int.TryParse(txtYear.Text, out int year) ? year : 0;
            //cartoupdate.Price = double.Parse(txtPrice.Text);
            cartoupdate.Price = double.TryParse(txtPrice.Text, out double price) ? price : 0;
            crud.EditInventory(vin, cartoupdate);
            MessageBox.Show("Vehicle updated in inventory");
            carGrid.DataSource = crud.GetCars();
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            Clear();

        }
    }
}
