using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4GenericsDemo2Dave
{
    //Generic T
    internal class Swap<T> //T provides a placeholder for a data type
    {
        // Only have to write the function one type to represent multiple variable types
        // T will be replaced by the data type whenever you create its instance
        public void SwapData(ref T num1, ref T num2) //variables named num1 and num2
        {
            T temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }

    class CustomList<T>
    {
        public T[] items;
        public CustomList()
        {
            items = new T[50];
        }
        public T GetValue(int index) //incoming parameter integer, has to be int for an array
        {
            return items[index]; //don't know what type of items will be getting returned
        }
        public void Add(T item)
        {
            //logic to add item being sent to internal list
        }
    }
}
