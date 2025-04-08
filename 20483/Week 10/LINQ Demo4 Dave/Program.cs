namespace LINQ_Demo4_Dave
{

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Car> list = new List<Car>()
            {
                new Car(){VIN = "ASFS222", Make = "Audi", Model = "Q5", Year = 2020, Price = 76000 },
                new Car(){VIN = "NMDFJD778", Make = "Audi", Model = "Q5", Year = 2019, Price = 56000 },
                new Car(){VIN = "ASFS222", Make = "BWM", Model = "X5", Year = 2018, Price = 56000 },
                new Car(){VIN = "ASDF22362", Make = "BMW", Model = "X3", Year = 2021, Price = 66000 },
                new Car(){VIN = "KFJ32968", Make = "Mercedes", Model = "GLC", Year = 2018, Price = 56000 },
                new Car(){VIN = "FTSJV83730", Make = "Honda", Model = "CRV", Year = 2025, Price = 56000 }
            };

            var hondas = from c in list
                         where c.Make == "Honda" //ROW FILTERING
                         select new { c.Model, c.Year }; //COLUMN FILTERING, only select the hondas model and year, not the rest of the properties
            Console.WriteLine("Hondas: ");
            foreach (var c in hondas)
            {
                Console.WriteLine($"{c.Model} - {c.Year}");
            }

            //Get count of cars made in 2020
            var cars2020 = (from c in list
                            where c.Year == 2020
                            select c).Count();

            //SAME AS from-where-select(?) but using a lambda expression
            var audis = list.FindAll(c => c.Make == "Audi" && c.Year == 2019);
            Console.WriteLine("Audis:");
            foreach (var c in audis)
                Console.WriteLine($"{c.VIN} -- {c.Make} -- {c.Model} -- {c.Year}");

        }
    }
}
