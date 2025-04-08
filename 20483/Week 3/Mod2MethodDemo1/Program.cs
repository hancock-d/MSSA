using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2MethodDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------Method Demo 1

            //named parameters, flexibility in order, more readable code
            CalculateTax(baseSalary: 56565, state: "ny", filingType: 'M', dependants: 0, contributions: 5466); //just changing order of parameters or makes code more readable

            int sum;
            long product;
            int[] values = { 66, 89, 56, 34, 9012 };
            //if there are multiple return types of different datatypes, then use out
            Results(out sum, out product, values); //returning out sum and product, but values are considered input so not returning (out) values

            Console.WriteLine($"sum: {sum} and product: {product}");
            Console.ReadKey();

        }
        //static bool TryParse(string s, out int result) //if string S can be converted, it will return type true, and return result
        //{

        //}
        static void Add(int i, int j) //overload --changes the signature
        {
            Console.WriteLine(i + j); //not returning anything back
        }
        static int Add(int i, int j, int k) //overload --changes the signature
        {
            return i + j + k;
        }
        //optional parameters: specify default value any parameter would take in and you can omit passing values to it, but can also send a value if needed
        //optional parameters does not create an overload
        //optional parameters must be at the end (int dependants = 0, char filingType='S')
        static void CalculateTax(double baseSalary, double contributions, string state, int dependants = 0, char filingType = 'S') //Not returning anything, just sending parameters. canl also set them at default and make them optional (int dependats =0, char filingType='S')
        {
            //logic written to Calculate the Tax
        }

        //return type is void, not sending back any data, but specifying out int sum
        //params used when you want to specify multiple values being sent in an array...???
        //out means passing that value by its address
        static void Results(out int sum, out long product, params int[] values) //values is only going in, the rest are coming out (returning)
        {
            product = 1;
            sum = 0;
            foreach (int i in values)
            {
                product = product * i;
                sum = sum + i;
                //not saying return because job of return is already being done by saying OUT above
            }
        }





    }
}
