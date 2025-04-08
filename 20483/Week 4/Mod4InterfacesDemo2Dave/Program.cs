namespace Mod4InterfacesDemo2Dave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 200, 100, 30, 1000 };
            list.Sort();
            foreach (int i in list)
                Console.WriteLine(i);

            List<string> names = new List<string>() { "Nathan", "Jim", "Don" };
            names.Sort();
            foreach (string name in names)
                Console.WriteLine(name);

            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1, Age = 12, GPA = 4.5f, Name = "Zach" });
            students.Add(new Student() { Id = 2, Age = 8, GPA = 3.0f, Name = "Frank" });
            students.Add(new Student() { Id = 3, Age = 11, GPA = 4f, Name = "Elizabeth" });
            students.Add(new Student() { Id = 4, Age = 14, GPA = 5.5f, Name = "Alex" });
            students.Sort(); // Icomparable (compareTo)--sorting by name A-Z
            foreach (Student student in students)
                Console.WriteLine(student.Name + " " + student.Age);

            Console.WriteLine("GPA sorting");
            students.Sort(new StudentGPAComparer()); //says logic we're looking for is in StudentGPAComparer class, using icomparer--sorting by GPA low to high
            foreach (Student student in students)
                Console.WriteLine(student.Name + " " + student.GPA);
            Console.ReadKey();
        }
    }
}
