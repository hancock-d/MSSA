using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4GenericsDemo2Dave
{
    // exe : main method, it starts when  I double click on exe
    // .dll : collection of classts/structs/delegates/interfaces/class library
    class Conversions //utility class, internal by default
    {

        public static double CelciustoFahrenheit(double celcius) //expect the data as celcius, do the conversion in the method, return back that value
        {
            int temp; //have to make variable static because in statc class
            return (celcius * 9 / 5) + 32;
        }
    }
}
