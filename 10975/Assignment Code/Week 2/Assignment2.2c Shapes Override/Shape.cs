using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2c
{
    internal abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public abstract decimal CalculateArea(); //CalculateArea only serves as a placeholder and -must- be overridden later unless the derived class it's used in is also abstract
    }

    internal class Circle : Shape
    {
        public int Radius { get; set; }
        public override decimal CalculateArea()
        {
            return Convert.ToDecimal(Math.PI * Radius * Radius);
        }
    }

    internal class Square : Shape
    {
        public decimal Side { get; set; }
        public override decimal CalculateArea()
        {
            return Convert.ToDecimal(Side * Side);
        }
    }
}