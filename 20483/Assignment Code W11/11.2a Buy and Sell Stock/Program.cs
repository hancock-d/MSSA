namespace _11._2a_Buy_and_Sell_Stock
{
    internal class Program
    {
        //O(n) Time
        //O(1) Space
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1)
                return 0;

            int buy = prices[0]; //set buy price to value at 0th index
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++) //starting i at 1 because 0 is already taken
            {
                //set baseline for current sell
                int sell = prices[i];
                //Set baseline for profit
                int profit = sell - buy;

                //check to update maxProfit
                if (profit > maxProfit)
                    maxProfit = profit;

                //Check to see if you need to update where you're buying 
                if (sell < buy)
                    buy = sell;

            }
            return maxProfit;
        }

        static void PrintArray(int[] arry)
        {
            Console.Write("[ ");
            for (int i =0; i < arry.Length; i++)
            {
                Console.Write(arry[i] + " ");
            }
            Console.WriteLine( "]");
        }
        static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int[] prices2 = { 7, 6, 4, 3, 1 };
            int[] prices3 = { 1 };
            int[] prices4 = { 1, 3, 6, 9, 11 };
            int[] prices5 = { 7, 10, 1, 3, 6, 9, 2 };

            PrintArray(prices);
            Console.WriteLine($"Max profit is: {MaxProfit(prices)}"); //5
            PrintArray(prices2);
            Console.WriteLine($"Max profit is: {MaxProfit(prices2)}"); //0
            //PrintArray(prices3);
            //Console.WriteLine($"Max profit is: {MaxProfit(prices3)}"); //0
            //PrintArray(prices4);
            //Console.WriteLine($"Max profit is: {MaxProfit(prices4)}"); //10
            //PrintArray(prices5);
            //Console.WriteLine($"Max profit is: {MaxProfit(prices5)}"); //8
        }
    }
}
