using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1JaggedArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------JAGGED ARRAYS, array of arrays


            Console.WriteLine("Jagged Array Demo");
            int[][] temp_cities = new int[4][]; //creating new array. [4] indicates 4 cities(rows). [] blank allocates size for temps (cols)

            //i going to temp_cities.Length. Length is better since we don't know
            for (int i = 0; i < temp_cities.Length; i++) //how many cities(rows)/horizontal arrays do you need
            {

                Console.WriteLine($"Enter number of readings you expect for City{i}"); //asking how many readings you're expecting for each city (row) GET DATA
                int readings = int.Parse(Console.ReadLine()); //getting number of temps for (1st) or (i) city
                temp_cities[i] = new int[readings]; //[i] indicates city in the row--allocates size to horizontal row

                for (int j = 0; j < readings; j++) //or temp_cities[i].Length --i indicates which row(city) you're looking at right now --how many in each row/city/array
                {
                    Console.Write($"temp_cities[{i}][{j}]: "); //just displaying in brackets which index in the array you're in
                    temp_cities[i][j] = int.Parse(Console.ReadLine()); //if you want temps in decimals, change int.Parse to float.Parse
                }
            }

            Console.WriteLine("Temp readings"); //DISPLAY DATA
            for (int i = 0; i < temp_cities.Length; i++)
            {
                Console.Write($"City {i}: "); // will write down city of 0, then 1, then 2...
                
                for (int j = 0; j <  temp_cities[i].Length; j++)
                {
                    Console.Write(temp_cities[i][j] + "F\t"); //F for Fahrenheight
                }
                Console.WriteLine(); //adds line between rows

            }
            Console.ReadKey();
        }
    }
}
