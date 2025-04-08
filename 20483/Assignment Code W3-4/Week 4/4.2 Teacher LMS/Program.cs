using System.Security.Cryptography.X509Certificates;

namespace _4._2_Teacher_LMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            StudentData.Students.Add(new Student(101, "Dave", "Hancock", 3.5f));
            StudentData.Students.Add(new Student(102, "Frankie", "Spirakes", 4.0f));
            StudentData.Students.Add(new Student(103, "Lindsey", "Thielmann", 4.0f));
            StudentData.Students.Add(new Student(104, "Jer", "Bear", 3.8f));
            StudentData.Students.Add(new Student(105, "Brian", "Blake", 3.2f));
            StudentData.Students.Add(new Student(106, "Charlie", "Sparks", 3.4f));

            Application.Run(new LoginPageForm());



        }
    }
}

/*
 *
 Class.listname.Add(new Student(int sid, string firstName, string lastName, float gpa))
{
    Sid = sid;
    FirstName = firstName;
    LastName = lastName;
    GPA = gpa;
}
*/