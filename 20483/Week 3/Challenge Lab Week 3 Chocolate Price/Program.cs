using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Lab_Week_3_Chocolate_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = GetInput<int>("Please enter the size of Array");
            int[] chocolatePrices = new int[sizeOfArray];

            for (int i = 0; i < chocolatePrices.Length; i++)
            {
                int input = GetInput<int>($"Please enter a number for [{i}]: ");
                chocolatePrices[i] = input;
            }
            int money = GetInput<int>("Enter the amount of money: ");
            Console.WriteLine(Solution.BuyChocolate(ref chocolatePrices, money)); //pass this to solution

        }

        static T GetInput<T>(string promt)
        {
            Console.Write(promt);
            string input = Console.ReadLine();
            try
            {
                var userInput = Convert.ChangeType(input, typeof(T));
                return (T)userInput;
            }
            catch (Exception exception)
            {
                Console.WriteLine($" Invalid input, please input value of type {typeof(T).Name}\n/Error Message:{exception.Message}");
                return GetInput<T>(promt);
            }
        }
    }
}
