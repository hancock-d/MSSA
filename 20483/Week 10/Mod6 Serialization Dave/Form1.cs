using System.Text.Json;
using System.Xml.Serialization;

namespace Mod6_Serialization_Dave
{
    public partial class Form1 : Form
    {
        Student student; //declare student at class level so accessible everywhere
        string jsonpath = @"C:\Files\pcad16json.txt";
        string xmlpath = @"C:\Files\pcad16xml.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)  //Create student object
        {
            //student = new Student(12);
            student = new Student(); //instantiate the student here (create new student with details from text boxes)
            student.Id = int.Parse(txtId.Text);
            student.Name = txtName.Text;
            student.Address = txtAddress.Text;
            student.GPA = float.Parse(txtGPA.Text);

            MessageBox.Show("Student created!");

            /*
            File.WriteAllText("c:\\dummy.txt", student.Name); //Have to do this for all properties of the student
            File.WriteAllText("c:\\dummy.txt", student.Address); //very inefficient way to do it and does not store it as a single object
            See the JSONser button code
             */

        }

        ////SERIALIZATION PROCESS--Convert state of an object into a form that can be persisted/maintained/saved or transported

        private void btnJSONser_Click(object sender, EventArgs e)
        {
            if (File.Exists(jsonpath))
            {
                File.Delete(jsonpath);
            }
            FileStream jsonstream = new FileStream(jsonpath, FileMode.OpenOrCreate, FileAccess.Write);
            JsonSerializer.Serialize(jsonstream, student);
            //JsonSerializer.Serialize(where you want to put the object, object);
            jsonstream.Close();
            MessageBox.Show("Object is serialized");

        }

        ////DE-SERIALIZATION PROCESS
        private void btnJSONdeser_Click(object sender, EventArgs e)
        {
            // json2csharp website, convert json file to c# to be used in your app
            FileStream jsonstream = new FileStream(jsonpath, FileMode.Open, FileAccess.Read);
            var obj = JsonSerializer.Deserialize<Student>(jsonstream); //<obj> specify which object you will deserialize
            MessageBox.Show($"Stud name: {obj.Name} , GPA: {obj.GPA}");
            jsonstream.Close();
        }

        private void btnXMLser_Click(object sender, EventArgs e)
        {
            if (File.Exists(xmlpath))
            {
                File.Delete(xmlpath);
            }
            FileStream xmlstream = new FileStream(xmlpath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student)); //specify which type of object you will serialize
            xmlSerializer.Serialize(xmlstream, student);
            xmlstream.Close();
            MessageBox.Show("Student is serialized");
        }

        private void btnXMLdeser_Click(object sender, EventArgs e)
        {
            FileStream xmlstream = new FileStream(xmlpath, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            var obj = (Student)xmlSerializer.Deserialize(xmlstream); //Will have to type-cast (Student)
            MessageBox.Show($"Student Name: {obj.Name} Stud ID: {obj.Id} Stud GPA: {obj.GPA}");
            //MessageBox.Show($"Student Name: {obj.Name} Stud GPA: {obj.GPA}");

            xmlstream.Close();
        }
    }
}
