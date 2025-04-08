namespace LINQ_Demo3_Dave
{

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade_Math { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>
            {
                new Student { Id = 1, Name = "Rose", Age = 15, Grade_Math = 88 },
                new Student { Id = 2, Name = "Zoe", Age = 14, Grade_Math = 78 },
                new Student { Id = 3, Name = "Rob", Age = 16, Grade_Math = 45 },
                new Student { Id = 4, Name = "Rob", Age = 14, Grade_Math = 66 },
                new Student { Id = 5, Name = "Amy", Age = 12, Grade_Math = 55 },
                new Student { Id = 6, Name = "Nathan", Age = 13, Grade_Math = 90 },
                new Student { Id = 7, Name = "Nicolas", Age = 11, Grade_Math = 60 },

            };

            var result_age = from s in list
                             where s.Age >= 13 && s.Age <= 16
                             select s;
            Console.WriteLine("Students in age group 13 to 16:");
            foreach (var student in result_age)
            {
                //Console.WriteLine(student.Name + student.Age);
                Console.WriteLine($"Name: {student.Name} \tAge: {student.Age}");
            }

            var ascendingresult = from s in list
                                  orderby s.Name, s.Age //ascending is optional (orderby s.Name ascending)--done that way automatically. Sorts by name and age
                                  select s;

            Console.WriteLine("Students in ascending order by name:");
            foreach (var student in ascendingresult)
            {
                Console.WriteLine($"{student.Name} has grade: {student.Grade_Math}");
            }

            var avgage = list.Average(s => s.Age);
            Console.WriteLine(avgage);
            var maxGrade = list.Max(s => s.Grade_Math); //selecting one max grade
            Console.WriteLine(maxGrade);
            var maxGrades = list.Select(s => (s.Grade_Math == list.Max(s => s.Grade_Math))); //selecting all students who had the same max grade
            foreach (var student in maxGrades)
                Console.WriteLine(student);

        }
    }
}
