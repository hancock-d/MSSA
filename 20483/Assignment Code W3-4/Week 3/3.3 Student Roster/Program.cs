using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._3_Student_Roster
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Data.Students.Add(new Student() { StudId = 101, FirstName = "Dave", LastName = "Hancock", Address = "Ohio", Grade = 'B', Month = MonthOfAdmission.January });
            Data.Students.Add(new Student() { StudId = 102, FirstName = "Frankie", LastName = "Spirakes", Address = "Illinois", Grade = 'A', Month = MonthOfAdmission.March });
            Data.Students.Add(new Student() { StudId = 103, FirstName = "Lindsey", LastName = "Thielmann", Address = "Washington", Grade = 'A', Month = MonthOfAdmission.September });

            Application.Run(new StudentPortalForm());
        }
    }
}
