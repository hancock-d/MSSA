using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1b_Leap_Year
{
    internal class Program
    {
        static void Main(string[] args)
            //--------------Is year a leap year
        {
            Console.WriteLine(CheckLeapYear(2016));     //should be true (4 yes, 100 no)
            Console.WriteLine(CheckLeapYear(1997));     //should be false (4 no)
            Console.WriteLine(CheckLeapYear(2012));     //should be true (4 yes, 100 no)
            Console.WriteLine(CheckLeapYear(1900));     //should be false (4 yes, 100 yes, 400 no)
            Console.WriteLine(CheckLeapYear(2000));     //should be true  (4 yes, 100 yes, 400 yes)

            Console.ReadKey();
        }

        static bool CheckLeapYear(int year) //static = belongs to class program, not an instance. Can call method within class without creating object
        {
            //if year not divisible by 4 = not a leap year
            if (year % 4 != 0) //not a leap
            {
                return false;
            }
            else //if year is divisible by 4...
            {
                if (year % 100 == 0) //and divisible by 100
                {
                    if (year % 400 == 0) //and divisible by 400
                    {
                        return true; //yes leap
                    }
                    else //but not divisible by 400
                    {
                        return false; //not leap
                    }
                }
                else //not divisible by 100
                {
                    return true; //leap year
                }
            }
        }
    }
}


/*
 * Identify the year
 * 
 * 
 * hardcode the years
 * Output true if year is leap year; false if not
 * 
 *      
 * 4 = no, no
 * 4 = yes, 100 = yes, 400 = yes, yes
 * 4 = yes, 100 = yes, 400 - no, no
 * 4 = yes, 100 = no, yes
 *      
 *
 *if year / 4 = no, no
 *else if year / 4 = yes
 *      if year / 100 = yes
 *          if year / 400 = yes, yes
 *          else year / 100 = no = no
 *      else year / 100 = no, yes
 *  
 * 
 */