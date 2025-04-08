namespace _5._3a_Adjacent_Flowerbeds
{
    internal class Program
    {
        static bool CanPlantFlowers(int[] flowerbed, int n) //n is number of flowers to be planted
        {
            for (int i = 0; i < flowerbed.Length && n > 0; i++) 
            {


                if (flowerbed[i] == 0 && flowerbed[i + 1] == 0 && flowerbed[i - 1] == 0)
                {
                    flowerbed[i] = 1; //changing from 0 to 1
                    n--; //decreasing flowers left to be planted
                    i++; //moving index position (if flower is planted), then the for loop increment will push it again to skip a spot since you can't have 1, 1. not necessary, but faster
                }
            }
            return n == 0; //if n gets to zero, true
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CanPlantFlowers(new int[] { 1, 0, 1, 0, 1 }, 1)); //false
            Console.WriteLine(CanPlantFlowers(new int[] { 1, 0, 0, 0, 1 }, 1)); //true
            Console.WriteLine(CanPlantFlowers(new int[] { 1, 0, 0, 0, 1 }, 2)); //false
            Console.WriteLine(CanPlantFlowers(new int[] { 1, 0, 0, 0, 1 }, 3)); //false

            //Console.WriteLine(CanPlantFlowers(new int[] { 0, 1, 0 }, 1)); //**ISSUE HERE, why didn't this just return false?
            //Console.WriteLine(CanPlantFlowers(new int[] { 0, 0, 0, 0, 1 }, 1)); //Issue with starting at 0

        }
    }
}


//flowerbed[i] represents the value stored at index i
//i represents the index position itself in the array (i thru flowerbed.length-1)