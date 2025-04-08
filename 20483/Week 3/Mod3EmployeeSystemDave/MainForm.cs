using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod3EmployeeSystemDave
{
    public partial class MainForm : Form
    {
        public MainForm() //constructor called
        {
            InitializeComponent(); //initialization of (?)constructor(?)
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            empGrid.DataSource = Data.Employees; //attaaching list of employees to the grid
            empGrid.Columns[3].DisplayIndex = 1; //rearranging column/index 3 (FullName) to display in column/index 1
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Ask user for confirmation before deleting. "Warning"=message box header
            var result = MessageBox.Show("Are you sure you want to delete the employee?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.Employees.RemoveAt(empGrid.CurrentRow.Index); //gets the current index at the grid and selects that employee
                empGrid.DataSource = null; //set it to null so it gets refreshed
                empGrid.DataSource = Data.Employees; //re-sets it back to the source (collection Class (Employees) coming from Data)
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //display the AddForm
            AddForm addForm = new AddForm();
            addForm.ShowDialog(); //will show the addForm(?)
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //setting the grid to null, the setting it back to employees list
            empGrid.DataSource = null;
            empGrid.DataSource = Data.Employees;
        }
    }
}
