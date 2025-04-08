using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4aAlternate
{
    public struct Point //declare struct name Point, public modifier makes the following code accessible outside the struct
    {
        public int x; //created attributes point x and y to store data for Point struct
        public int y;

        public Point(int x, int y) //defines a constructor for Point, for creating/initializing points (objects) for x and y. Makes Point point1 = new Point(point1x, point1y) possible
        {
            this.x = x; //referring to field x on line 11, of the current constructor
            this.y = y; //without this. ,it will refer to parameter passed to the constructor
        }
        /*static void Compare(Point point1, Point point2) //took this out of struct because I felt like it shouldn't be here?
        {
            if (point1.x > point2.x)
            {
                Console.WriteLine("Point 1 is to the right of point 2");
            }
            else if (point1.x < point2.x)
            {
                Console.WriteLine("Point 1 is to the left of point 2");
            }
            else
            {
                Console.WriteLine("Point 1 and point 2 are on the same X axis");
            }
        }*/
    }
}