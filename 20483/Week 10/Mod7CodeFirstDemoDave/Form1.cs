using Mod7CodeFirstDemoDave.Models;
using Mod7CodeFirstDemoDave.Services;

namespace Mod7CodeFirstDemoDave
{
    public partial class Form1 : Form
    {
        CRUD crud; //crud variable
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crud = new CRUD();   //instantiate crud variable
            empGrid.DataSource = crud.GetEmployees(); //display employees on grid
            empGrid.Columns[4].Visible = false; //hide 4th column
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
            foreach (var d in crud.GetDepartment())
            {
                comboDept.Items.Add(d.DepartmentName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtEid.Text = (crud.GetMaxId() + 1).ToString();
            txtEid.ReadOnly = true;
            txtName.Clear();
            txtSalary.Clear();
            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEid.Text) && !string.IsNullOrEmpty(txtName.Text)) //Make sure it's not null since Eid is the primary key
            {
                if (comboDept.SelectedIndex != -1) //Make sure combo box is selected
                {
                    var newemp = new Employee();
                    newemp.EmpId = int.Parse(txtEid.Text);
                    newemp.Name = txtName.Text;
                    newemp.Salary = double.Parse(txtSalary.Text);
                    newemp.DepartmentId = comboDept.SelectedIndex + 1;
                    crud.AddRecord(newemp);
                    MessageBox.Show("Record added");
                }
            }
            btnSubmit.Enabled = false;
            empGrid.DataSource = crud.GetEmployees();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get ID from grid
            var id = empGrid.CurrentRow.Cells[0].Value; //0 is first column
            crud.DeleteRecord((int)id); //convert it to type int
            MessageBox.Show("Record deleted");
            empGrid.DataSource = crud.GetEmployees();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var id = empGrid.CurrentRow.Cells[0].Value;
            var emptoupdate = crud.FindEmployee((int)id);
            txtEid.Text = emptoupdate.EmpId.ToString();
            txtEid.ReadOnly = true;
            txtName.Text = emptoupdate.Name;
            txtSalary.Text = emptoupdate.Salary.ToString();
            comboDept.SelectedIndex = emptoupdate.DepartmentId - 1;
            btnUpdate.Enabled = true;
        }

        private void Clear()
        {
            txtEid.Clear();
            txtName.Clear();
            txtSalary.Clear();
            comboDept.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtEid.Text);
            var emptoupdate = crud.FindEmployee((int)id);
            emptoupdate.Name = txtName.Text;
            emptoupdate.Salary = double.Parse(txtSalary.Text);
            emptoupdate.DepartmentId = comboDept.SelectedIndex + 1;
            crud.UpdateRecord(id, emptoupdate);
            MessageBox.Show("Record updated");
            empGrid.DataSource = crud.GetEmployees();
            btnUpdate.Enabled = false;
            Clear();
        }
    }
}
