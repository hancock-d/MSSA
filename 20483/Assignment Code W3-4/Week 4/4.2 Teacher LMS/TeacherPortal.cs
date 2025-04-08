using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; //need to add this for StreamWriter
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4._2_Teacher_LMS;

namespace _4._2_Teacher_LMS
{
    public partial class TeacherPortalForm : Form
    {
        public TeacherPortalForm()
        {
            InitializeComponent();
        }

        private void TeacherPortal_Load(object sender, EventArgs e)
        {
            UpdateStudGrid();
        }
        private void UpdateStudGrid()
        {
            studGrid.DataSource = null;
            studGrid.DataSource = StudentData.Students; //referencing StudentData class, List of Students
        }
        private void UpdateStudGridId()
        {
            StudentData.Students.Sort(new StudentIDComparer()); //make updatestudgrid sort students by ID--got help on this
            studGrid.DataSource = null;
            studGrid.DataSource = StudentData.Students; //referencing StudentData class, List of Students
        }
        private void ClearAll() //clear the boxes
        {
            txtId.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtGPA.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e) //resets studGrid/grid box to sort by ID#
        {
            UpdateStudGridId();
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty && txtFirstname.Text != string.Empty && txtLastname.Text != string.Empty && txtGPA.Text != string.Empty)
            {
                var newStud = new Student(int.Parse(txtId.Text), txtFirstname.Text, txtLastname.Text, float.Parse(txtGPA.Text));
                //var newStud = new Student();  //Error in new Student because it needs parameters for constructor?
                //newStud.Sid = int.Parse(txtId.Text);
                //newStud.FirstName = txtFirstname.Text;
                //newStud.LastName = txtLastname.Text;
                //newStud.GPA = float.Parse(txtGPA.Text);

                if (StudentData.Students.Contains(newStud)) //COME BACK TO THIS--CHECK IF STUDENT ALREADY EXISTS
                {
                    MessageBox.Show("Student already exists");
                }
                else
                {
                    ClearAll();
                    StudentData.Students.Add(newStud);
                    UpdateStudGrid();
                    MessageBox.Show("Student added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //UpdateStudGrid();
                //MessageBox.Show("Student added");
            }
            else
            {
                MessageBox.Show("Please fill in all values for the student", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveStud_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Remove this student from database?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                StudentData.Students.RemoveAt(studGrid.CurrentRow.Index);
                UpdateStudGrid();
            }
            //else //not necessary
        }

        private void btnSort_Click(object sender, EventArgs e) //Sort Students by GPA High to Low
        {
            StudentData.Students.Sort(new StudentGPAComparer()); //Sorts the list in-place vs GPAComp
            UpdateStudGrid(); //refreshes grid to show new sorted list, until a new sorting action occurs
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDownload_Click(object sender, EventArgs e) //Write Highest GPA to files folder
        {
            StudentData.Students.Sort(new StudentGPAComparer()); //sort students by GPA
            //const string path = @"C:\Files\"; //declaring file path (and txt document)
            //string fileName = "Highest GPA Students_Hancock.txt"; //declaring txt document
            //string filePath = path + fileName;
            const string filePath = @"C:\Files\Highest GPA Student_Hancock.txt";

            StreamWriter writer = null; //declare the writer

            try
            {
                if (!File.Exists(filePath)) //if file doesn't exist
                {
                    writer = File.CreateText(filePath); //creating file

                    //writes only student with highest GPA (in index 0 from being sorted, does not count multiple highest GPA)
                    writer.WriteLine("==================== Highest GPA ====================");
                    writer.WriteLine($"Student ID#: {StudentData.Students[0].Sid}, {StudentData.Students[0].FirstName} {StudentData.Students[0].LastName}");
                    writer.WriteLine($"GPA: {StudentData.Students[0].GPA}");
                    writer.WriteLine("\n==================== All Students ====================");

                    //Wanted to keep this here for future reference
                    foreach (Student student in StudentData.Students) //writes all students, sorted by GPA--high to low
                    {
                        writer.WriteLine($"Student: ID# {student.Sid}, {student.FirstName} {student.LastName}");
                        //writer.WriteLine($"Student Name: {student.FirstName} {student.LastName}");
                        writer.WriteLine($"GPA: {student.GPA}\n");
                    }



                    MessageBox.Show("File created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else //if file already exists
                {
                    File.AppendAllText(filePath, "\n\n==================== Updating File ====================");
                    File.AppendAllText(filePath, $"\nStudent ID#: {StudentData.Students[0].Sid}, {StudentData.Students[0].FirstName} {StudentData.Students[0].LastName}");
                    File.AppendAllText(filePath, $"\nGPA: {StudentData.Students[0].GPA}");
                    File.AppendAllText(filePath, "\n==================== Updates Complete ====================");

                    MessageBox.Show("File appended", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (writer != null) //if writer doesn't point to a file then..
                    writer.Close(); //it closes
            }
        }

        private void txtGPA_Validating(object sender, CancelEventArgs e)
        {
            if (txtGPA.Text.Length != 0)
            {
                float val;
                if (!float.TryParse(txtGPA.Text, out val)) //if can't convert to float...
                {
                    MessageBox.Show("Please enter a proper GPA", "Error", MessageBoxButtons.OK);
                    e.Cancel = true;
                    txtGPA.Clear();
                }
            }
        }
    }
}

//var newStud = new Student((int.Parse(txtID), FN, LN, float.Parse(GPA));
// StudentData.Students.Add(new Student(101, "Dave", "Hancock", 3.5f));


//foreach (Student student in StudentData.Students)
//{

//}