namespace _5._4a_Print_Digit_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input a number: ");
            //int input;
            ////int input = int.Parse(Console.ReadLine());

            //while (!int.TryParse(Console.ReadLine(), out input))
            //{
            //    Console.WriteLine("Enter numbers only, without spaces");
            //}

            //PrintNums(input);
            //Console.WriteLine();

            Console.WriteLine("Test data: 1234");
            PrintNums(1234);
            
        }

        static void PrintNums(int num)
        {
            if (num < 10) //takes care of single digit input
            {
                Console.Write($"{num} ");
                return;
            }

            PrintNums(num / 10); //chops off last digit, sends new number through method
            Console.Write(num % 10 + " "); //when recursion is unwinding, chops last digit off and prints it
        }

    }
}

/*
 * 
 * 
 * 
 * 
 * 
 * 
 */