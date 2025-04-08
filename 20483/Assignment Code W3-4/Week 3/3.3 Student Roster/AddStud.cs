using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._3_Student_Roster
{
    public partial class AddStud : Form
    {
        public AddStud()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtSid.Text != string.Empty && txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty)
            {
                var newStud = new Student();
                newStud.StudId = int.Parse(txtSid.Text);
                newStud.FirstName = txtFirstName.Text;
                newStud.LastName = txtLastName.Text;
                newStud.Address = txtAddress.Text;
                newStud.Grade = char.Parse(txtGrade.Text);
                newStud.Month = (MonthOfAdmission)(comboMonth.SelectedIndex + 1);
                Data.Students.Add(newStud);
                MessageBox.Show("Student record added");

            }
        }

        private void AddStud_Load(object sender, EventArgs e)
        {
            //loading combo box
            comboMonth.DataSource = Enum.GetValues(typeof(MonthOfAdmission));
        }

        private void txtSid_Validating(object sender, CancelEventArgs e)
        {
            if (txtSid.TextLength != 0)
            {
                int val;
                if (!int.TryParse(txtSid.Text, out val)) //if can't convert input to integer
                {
                    MessageBox.Show("Please enter digits only");
                    e.Cancel = true;
                    txtSid.Clear();
                }
                else if (int.Parse(txtSid.Text) <= 0) //else if input <=0
                {
                    MessageBox.Show("Enter valid ID");
                    e.Cancel = true;
                    txtSid.Clear();
                }
            }
        }
    }
}
