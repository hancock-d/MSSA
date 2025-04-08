namespace _4._3a_Electricity_Bill
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int UnitsConsumed { get; set; }

        public double CalculateBill(out double rate, out double amount, out double surcharge)
        {
            if (UnitsConsumed < 200)
            {
                rate = 1.20;
            }
            else if (UnitsConsumed >= 200 && UnitsConsumed < 400)
            {
                rate = 1.50;
            }
            else if (UnitsConsumed >= 400 && UnitsConsumed < 600)
            {
                rate = 1.80;
            }
            else
            {
                rate = 2.00;
            }

            amount = UnitsConsumed * rate;

            if (amount > 400)
            {
                surcharge = amount * 0.15;
            }
            else
            {
                surcharge = 0;
            }

            double netAmount = amount + surcharge;
            return netAmount;
        }

        internal class Program
        {

            static void Main(string[] args)
            {
                Customer customer = new Customer();

                Console.Write("Customer ID: ");
                customer.ID = int.Parse(Console.ReadLine());

                Console.Write("Custoner Name: ");
                customer.Name = Console.ReadLine();

                Console.Write("Units consumed: ");
                customer.UnitsConsumed = int.Parse(Console.ReadLine());

                double rate;
                double amount;
                double surcharge;
                double grandTotal = customer.CalculateBill(out rate, out amount, out surcharge);

                Console.WriteLine($"\nCustomer ID: {customer.ID}");
                Console.WriteLine($"Customer Name: {customer.Name}");
                Console.WriteLine($"Units consumed: {customer.UnitsConsumed}");

                Console.WriteLine($"Amount Charge Rate = ${rate:F2} per unit: ${amount:F2}");
                Console.WriteLine($"Surcharge Amount: ${surcharge:F2}");
                Console.WriteLine($"Grand total paid by customer: ${grandTotal:F2}");

                Console.ReadKey();
            }

        }

    }
}
