using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculatorDave
{
    internal class Program
    {
        static void Main(string[] args) //can also supply/send arguments to main method
        {
            const double tipRate = 0.18; //keeping tip rate as 18%
            double billTotal = 0; //will be passed in the argument up top in main, initializing it to 0

            //if billTotal was not passed (length 0, nothing input) or not in the correct format (not converted to double)
            if (args.Length == 0 || !double.TryParse(args[0], out billTotal)) //if no bill total was sent to arguments in main || or convert the billTotal to a number (out billTotal)**??
            {
                Console.WriteLine("Please enter numeric amount in this way: TipCalculator amount");
                Console.ReadKey();
                return; //come out of main method entirely because it was not entered in the correct format
            }
            double tip = billTotal * tipRate;
            Console.WriteLine();
            Console.WriteLine("********************************"); //just for formatting purposes
            Console.WriteLine($"Bill Total:\t{billTotal,8:c}");  //\t just inserts a tab. 8 spaces later, it will display currency (c)
            Console.WriteLine($"Tip total/rate:\t{tip,8:c} ({tipRate:p1})"); //p1 shows percentage sign
            Console.WriteLine(("").PadRight(25, '-')); //Padright?? will display 25 - to the right (same thing instead of doing *s in line 25)
            Console.WriteLine($"Grand Total:\t {billTotal + tip,8:c}");
        }
    }
}
