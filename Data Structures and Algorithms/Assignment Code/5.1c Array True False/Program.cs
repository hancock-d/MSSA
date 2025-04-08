namespace _5._1c_Array_True_False
{
    internal class Program
    {
        //Method--check if array contains duplicates--return true/false
        static bool ContainsDuplicates(int[] nums)
        {
            HashSet<int> numbersHash = new HashSet<int>(); //creating hashset to store unique numbers

            int i = 0;
            while (i < nums.Length)
            {
                if (numbersHash.Contains(nums[i])) // Check if number at index[i] is already in the hashset
                {
                    return true; //if yes, stop building the hashset and return true to caller/function ends
                }
                else
                {
                    numbersHash.Add(nums[i]); //if not, add it to hash set
                    i++; // move to next array index/element
                }


            }
            return false; //if loop completes, no duplicates found, returns false to caller
        }

        //Method--print the array--practice writing loops
        static void PrintArray(int[] nums)
        {
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++) //loop through array
            {
                Console.Write(nums[i]); //write the element of nums(1) array at index slot i

                if (i < nums.Length - 1) //if i(index) is not at the end of array...
                {
                    Console.Write(","); //add a comma, go back to top of for loop
                }
            }
            Console.Write("] : "); // loop ends

        }



        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 1 }; //true
            int[] nums2 = { 1, 2, 3, 4 }; //false 
            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }; //true

            PrintArray(nums1); //print the array
            Console.WriteLine(ContainsDuplicates(nums1)); //print expected output
            PrintArray(nums2);
            Console.WriteLine(ContainsDuplicates(nums2)); 
            PrintArray(nums3);
            Console.WriteLine(ContainsDuplicates(nums3)); 
        }
    }
}

//nums[i] = actual value of that element in the array
//i = the index of the array