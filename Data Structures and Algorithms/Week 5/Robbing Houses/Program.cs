namespace Robbing_Houses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rob(new int[] { 1, 2, 3, 1 })); //expected 4
            Console.WriteLine(Rob(new int[] { 2, 7, 9, 3, 1 })); //expected 12
            Console.WriteLine(Rob(new int[] { 2, 7, 3, 1, 9 })); //expected 16

        }


        public static int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0; //edge case
            if (nums.Length == 1) return nums[0]; //edge case

            int maxMoneyPrevHouse = 0, // max money robbed previous house
                maxMoneyTwoHousesAgo = 0; // max money robbed 2 houses ago

            foreach (int currentHouseMoney in nums)
            {
                int tempMax = maxMoneyPrevHouse; // store previous max
                maxMoneyPrevHouse = Math.Max(maxMoneyTwoHousesAgo + currentHouseMoney, maxMoneyPrevHouse); // get max between houses not adjacent, comparing robbing current house or previous house(?)
                maxMoneyTwoHousesAgo = tempMax;
            }

            return maxMoneyPrevHouse;
        }
    }
}


//house1 = Math.Max(house2 + house, house1);
//    house2 + house: If rob current house, skip previous house
//                  , house1: If skip current house, keep previous max
//Math.Max ensures thief gets higher amount