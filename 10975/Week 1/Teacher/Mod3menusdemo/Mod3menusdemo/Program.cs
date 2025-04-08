using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3menusdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            while(choice=='y' ||  choice=='Y') 
            {
                CallMenu();
                Console.WriteLine("Do you want to continue? (y/Y or N/n");
                choice=char.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }

        static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        static void CallMenu()
        {
            Console.WriteLine("Mathematical operations:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("Enter the choice in number (1,2,3,or 4):");
            int choice=int.Parse(Console.ReadLine());
           // float val = float.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter 2 numbers");
                    int num1=int.Parse(Console.ReadLine());
                    int num2=int.Parse(Console.ReadLine());
                    Console.WriteLine($"Sum is {Addition(num1, num2)}");
                     // call addition
                     break;
                case 2://call subtraction
                    break;

                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }

    }
}
