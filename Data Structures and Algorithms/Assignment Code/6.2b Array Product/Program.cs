namespace _6._2b_Array_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] nums2 = { -1, 1, 0, -3, 3 };

            var nums3 = ProductExceptSelf(nums);
            PrintArray(nums3);
            var nums4 = ProductExceptSelf(nums2);
            PrintArray(nums4);

        }

        static int[] ProductExceptSelf(int[] nums)
        {
            int size = nums.Length;
            int[] leftProduct = new int[size];
            int[] rightProduct = new int[size];
            int[] result = new int[size];

            //store product of all elements left of index i
            leftProduct[0] = 1; //have to set [0] to 1 so the multiplication is true to the result
            for (int i = 1; i < size; i++)
            {
                leftProduct[i] = nums[i - 1] * leftProduct[i - 1];
            }

            //store product of all elements to the right of index i
            rightProduct[size - 1] = 1;
            for (int j = size - 2; j >= 0; j--)
            {
                rightProduct[j] = nums[j + 1] * rightProduct[j + 1];
            }

            //get result array by multiplying left by right
            for (int i = 0; i < size; i++)
            {
                result[i] = leftProduct[i] * rightProduct[i];
            }
            return result;


        }

        static void PrintArray(int[] nums)
        {
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                if (i < nums.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

    }
}
