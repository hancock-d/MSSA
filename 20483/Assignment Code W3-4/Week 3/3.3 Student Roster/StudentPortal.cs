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
    public partial class StudentPortalForm : Form
    {
        public StudentPortalForm()
        {
            InitializeComponent();
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            //display AddStud Form
            AddStud addStud = new AddStud();
            addStud.ShowDialog();
        }

        private void btnRemoveStud_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Remove this student from the database?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.Students.RemoveAt(studGrid.CurrentRow.Index);
                studGrid.DataSource = null;
                studGrid.DataSource = Data.Students;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            studGrid.DataSource = null;
            studGrid.DataSource= Data.Students;
        }

        private void StudentPortalForm_Load(object sender, EventArgs e)
        {
            studGrid.DataSource = Data.Students;
            //studGrid.Columns[3].DisplayIndex = 1; //move index 3 to index 1 in the grid for display
        }
    }
}
