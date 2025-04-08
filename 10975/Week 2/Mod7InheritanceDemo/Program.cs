using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(); //Creating new BankAccount object (account) from BankAccount class

            SavingsAccount savingsAccount = new SavingsAccount(); //Creating new SavingsAccount object, , also setting min balance
            savingsAccount.AccountNumber = 224242;
            savingsAccount.HolderName = "Frank S";
            Console.WriteLine($"For account {savingsAccount.AccountNumber} please set the balance:");
            double balance = double.Parse(Console.ReadLine()); //holding their valuable temporarily in banace variable to compare it
            if (balance >= savingsAccount.MinBalance)
            {
                savingsAccount.Balance = balance; //setting savings account Balance = to the value of balance entered
            }
            //savingsAccount.Balance = 200; //200 is too low for the required minBalance 300, need to check it
            //Setting the savingsAccount Balance if you don't want the user to input it

            // logic to do transactions (like adding more money)
            Console.WriteLine($"Balance is {savingsAccount.Balance}");
            Console.ReadKey();

            //CREATING NEW OBJECT CHECKINGACCOUNT
            CheckingAccount checkingAccount = new CheckingAccount(); //using camel case for LOCAL variables (only in the scope of main right now)
            Console.WriteLine($"Min balance for checking is {checkingAccount.MinBalance}");
            Console.ReadKey();

        }
    }
}
