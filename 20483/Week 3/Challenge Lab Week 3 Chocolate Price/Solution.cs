using System;
using System.Data.SqlTypes;

namespace Challenge_Lab_Week_3_Chocolate_Price
{
    internal class Solution
    {
        internal static int BuyChocolate(ref int[] ints, int money)
        {
            Array.Sort(ints);

            if (ints.Length < 2) return money;

            int minValueCost = ints[0] + ints[1];

            if (minValueCost <= money)
            {
                return money - minValueCost;
            }

            return money;
        }
    }
}