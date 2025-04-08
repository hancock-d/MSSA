using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4_Order_Coffee
{
    enum CupSize
    {
        Small=1,
        Medium,
        Large,
    }
    enum DrinkName
    {
        Drip=1,
        Espresso,
        Latte,
    }
    enum BeanType
    {
        Arabica=1,
        Columbian,
    }
    enum RoastStrength
    {
        Breakfast=1,
        Mild,
        Dark,
    }
    enum Temperature
    {
        Hot=1,
        Cold,
    }
    internal abstract class Beverage
    {
        public string CustomerName { get; set; }
        public  Temperature Temp { get; set; } //hot cold
        public CupSize Cup { get; set; } //use Enum
    }

    internal class  Coffee : Beverage
    {
        public DrinkName Drink { get; set; } //drip, espresso, latte
        public BeanType Bean { get; set; } //Arabica, columbian
        public RoastStrength Roast { get; set; }
    }
}
