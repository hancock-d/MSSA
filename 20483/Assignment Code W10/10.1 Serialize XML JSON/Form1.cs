using System.Text.Json;
using System.Xml.Serialization;

namespace _10._1_Serialize_XML_JSON
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        //Student student;

        string jsonPath = @"C:\Files\JSON\students.txt";
        string xmlPath = @"C:\Files\XML\students.xml";

        public Form1()
        {
            InitializeComponent();

            students.Add(new Student("Dave", "Tacoma", 3.7f));
            students.Add(new Student("Frankie", "Tacoma", 4.0f));
            students.Add(new Student("Lindsey", "Chicago", 3.9f));
            students.Add(new Student("Jim", "LA", 3.8f));
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            float gpa = float.Parse(txtGPA.Text);

            Student newStudent = new Student(name, address, gpa);
            students.Add(newStudent);

            MessageBox.Show("New student created");

            txtName.Clear();
            txtAddress.Clear();
            txtGPA.Clear();
        }

        private void btnJSONSer_Click(object sender, EventArgs e)
        {
            if (File.Exists(jsonPath))
                File.Delete(jsonPath);

            FileStream jsonStream = new FileStream(jsonPath, FileMode.OpenOrCreate, FileAccess.Write);
            JsonSerializer.Serialize(jsonStream, students);
            jsonStream.Close();

            MessageBox.Show("Students serialized to JSON");
        }

        private void btnXMLser_Click(object sender, EventArgs e)
        {
            if (File.Exists(xmlPath))
                File.Delete(xmlPath);

            FileStream xmlStream = new FileStream(xmlPath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            xmlSerializer.Serialize(xmlStream, students);
            xmlStream.Close();

            MessageBox.Show("Students serialized to XML");
        }

        private void btnJSONdeser_Click(object sender, EventArgs e)
        {
            FileStream jsonStream = new FileStream(jsonPath, FileMode.Open, FileAccess.Read);
            var obj = JsonSerializer.Deserialize<List<Student>>(jsonStream);

            MessageBox.Show("Students deserialized from JSON");
            //ShowStudentList();

            string message = "";
            foreach (var o in obj)
            {
                message += $"Name: {o.Name} \tAddress: {o.Address} \tGPA: {o.GPA}\n";
            }
            MessageBox.Show(message);

            jsonStream.Close();
        }



        private void btnXMLdeser_Click(object sender, EventArgs e)
        {
            FileStream xmlStream = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            var obj = (List<Student>)xmlSerializer.Deserialize(xmlStream);

            MessageBox.Show("Students deserialized from XML");
            //ShowStudentList();

            string message = "";
            foreach (var o in obj)
            {
                message += $"Name: {o.Name} \tAddress: {o.Address} \tGPA: {o.GPA}\n";
            }
            MessageBox.Show(message);

            xmlStream.Close();

        }

        //Can't do a separate method because it won't accurately pull from a file not created in the program
        //private void ShowStudentList()
        //{
        //    string showStuds = "";
        //    foreach (Student student in students)
        //    {
        //        showStuds += $"Name: {student.Name} \tAddress: {student.Address} \tGPA: {student.GPA}\n";
        //    }

        //    MessageBox.Show(showStuds);
        //}
    }
}


