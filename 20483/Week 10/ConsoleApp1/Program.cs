using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        enum color
        {
            red,
            green,
            blue
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            color c;
            c = color.red;
            Console.WriteLine(c);



            int[,,] a = new int[3, 2, 3];
            Console.WriteLine(a.Length);

            String s1 = "ALL MEN ARE CREATED EQUAL";
            String s2;
            s2 = s1.Substring(12, 3);
            Console.WriteLine(s2);

        }
    }
}
