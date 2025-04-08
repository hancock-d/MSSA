namespace _10._2_LINQ
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ////===============10.2a LINQ Query Positive Nums
            ///Write a program in C# Sharp to find the +v2 (positive) numbers from a list of numbers using where conditions in LINQ Query
            ///Input: { 2, -1, 3, -3, 10, -200}
            ///Expected output: {2, 3, 10}
            Console.WriteLine("===============10.2a LINQ Query Positive Nums");

            int[] arr = { 2, -1, 3, -3, 10, -200 };

            var posNums = from num in arr
                          where num > 0
                          select num;

            Console.WriteLine("From the array, positive numbers are:");
            foreach (int i in posNums)
                Console.Write($"{i} ");
            Console.WriteLine();
            //==========
            List<int> nums = new List<int> { 2, -1, 3, -3, 10, -200 };

            var posNums2 = nums.FindAll(num => num > 0);

            Console.WriteLine("From the list, positive numbers are:");
            foreach (int i in posNums2)
                Console.Write($"{i} ");



            ////===============10.2b Employee Salary
            ///Write a program to create a list of employees. Consider a hard coded list.
            ///Display all employees who have salary more than $5000 and age < 30.
            Console.WriteLine("\n\n===============10.2b Employee Salary");

            List<Employee> employees = new List<Employee>
            {
                new Employee{ Name = "Dave", Age = 38, Salary = 5000 },
                new Employee{ Name = "Lindsey", Age = 35, Salary = 7000 },
                new Employee{ Name = "Frankie", Age = 3, Salary = 10000 },
                new Employee{ Name = "Lou", Age = 5, Salary = 1000 },
                new Employee{ Name = "Jenny", Age = 29, Salary = 8675309 },
            };

            var youngMoney = from e in employees
                             where e.Age < 30 && e.Salary > 5000
                             select e;
            foreach (var emp in youngMoney)
                Console.Write($"Employee: {emp.Name} \tAge: {emp.Age} \tSalary: {emp.Salary}\n");



            ////===============10.2c String Specific Char
            ///Write a program in C# Sharp to find a string that starts and ends with a specific character.
            ///The cities are: 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
            ///Input starting character for the string: A
            ///Input ending character for the string: M
            ///Expected Output: The city starting with A and ending with M is : AMSTERDAM
            Console.WriteLine("\n\n===============10.2c String Specific Char");

            List<string> cities = new List<string>
            {
                "ROME",
                "LONDON",
                "NAIROBI",
                "CALIFORNIA",
                "ZURICH",
                "NEW DELHI",
                "AMSTERDAM",
                "ABU DHABI",
                "PARIS",
            };

            var cities_am = from c in cities
                            where c.StartsWith('A') && c.EndsWith('M')
                            select c;
            foreach (var c in cities_am)
                Console.Write(c);

            ////===============10.2d Numbers > 80
            ////Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
            ///The members of the list are: 55 200 740 76 230 482 95
            ///Expected Output: 200, 740, 230, 482, 95
            Console.WriteLine("\n\n===============10.2d Numbers > 80");

            List<int> nums2 = new List<int> { 55, 200, 740, 76, 230, 482, 95 };

            /*
            var numsBig = from n in nums2
                          where n > 80
                          select n;
            */

            var numsBig2 = nums2.FindAll(n => n > 80);
            foreach (var n in numsBig2)
                Console.Write(n + " ");
            Console.WriteLine();

        }
    }
}
