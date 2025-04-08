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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            //LOADING COMBO BOX
            //Data source comes frum enum Department
            //reading all values from Department enum and putting them in combo box for selection
            comboDept.DataSource = Enum.GetValues(typeof(Department));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //create a new employee record (after submitting on new employee) from AddForm.cs [Design]
            if (txtEid.Text != string.Empty && txtName.Text != string.Empty) //if Eid is not empty and name is not empty, create new employee
            {
                var newEmp = new Employee();
                newEmp.EmployeeId = int.Parse(txtEid.Text); //have to parse it because Id is int and ... is string from the text block Eid
                newEmp.FullName = txtName.Text;
                newEmp.Address = txtAddress.Text;
                newEmp.Salary = double.Parse(txtSalary.Text);
                newEmp.Dept = (Department)(comboDept.SelectedIndex + 1); //0+1=1 because the index starts at 0 and is not associated with a department, casting it to Department type(?)
                Data.Employees.Add(newEmp); //Adding new employee to the record/list
                MessageBox.Show("Record added");

            }
        }



        private void txtEid_Validating(object sender, CancelEventArgs e)
        {

            if (txtEid.TextLength != 0) //User entered some data and I need to validate
            {
                int val;
                if (!int.TryParse(txtEid.Text, out val))
                {
                    MessageBox.Show("Please enter digits only");
                    e.Cancel = true; //cancel out the event to let user put it in again, focus on same textbox
                    txtEid.Clear();
                }
                else if (int.Parse(txtEid.Text) <= 0)
                {
                    MessageBox.Show("Enter valid ID");
                    e.Cancel = true;
                    txtEid.Clear();
                }
            }
        }



        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (txtSalary.TextLength != 0)
            {
                int val;
                if (!int.TryParse(txtSalary.Text, out val))
                {
                    MessageBox.Show("Please enter numbers!");
                    e.Cancel = true;
                    txtSalary.Clear();
                }
            }

        }
    }
}
