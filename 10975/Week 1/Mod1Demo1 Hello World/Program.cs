using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Demo1
{ //marks scope
    internal class Program
    {
        //starting point
        static void Main(string[] args)
        { //main starts

            int num = 10; //assigning value 10 to variable num data type int
            Console.WriteLine(num);
            Console.ForegroundColor = ConsoleColor.Cyan; //assigning color to foreground property, will print Hello World in cyan
            Console.WriteLine("Hello World!"); //prints on the screen
            Console.ReadKey(); //pauses program and waits for a key to be pressed/read
        } //main ends
    }
}
