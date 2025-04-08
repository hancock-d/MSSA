namespace Mod7_Selection_Sort
{
    internal class Program
    {
        // [3 5 9 8 6 2]
        // minposition =0, i=0, j=1
        //if(5 < 3) ..do nothing  --comparing with 3 because 3 is i
        //j=2 (because j++)
        //if (a[j] < a[minposition] == if(9 < 3)...do nothing
        //j = 3     if (8<3)...do nothing
        //j = 4     if(6<3)...do nothing
        //j=5       if (2<3)....update minposition = value of j, then perform swap
        //                      minposition = 5  found a # which is < 3
        //                      swap 2 and 3 ---> [2 5 9 8 6 3]
        // i=1 (outer for loop), minposition =1 (because it =i), j=2 (cause j = i+1)
        //if(5<A[minposition]....

        //unstable, O(n^2)
        //easy process, easy to implement

        static void SelectionSort(int[] A) //passing int array called A to it
        {
            int minPosition = 0; //to track the position of min element in existing array
            int temp = 0;  //variable to hold swapping element

            for (int i = 0; i < A.Length - 1; i++) //tracking how many times we're doing the logic
            {
                minPosition = i;
                //starting j at i+1 so it's comparing i with the element next to it (j+1)
                for (int j = i + 1; j < A.Length; j++) //to get the min element's index positio 
                {
                    if (A[j] < A[minPosition]) //if "A of j" is < A of min position
                    {
                        minPosition = j; //update the minposition to the newly found min element's position
                    }
                }
                //SWAP LOGIC
                //swap a[i] position with minposition
                if (minPosition != i) //make sure it's not swapping with itself
                {
                    temp = A[i];
                    A[i] = A[minPosition];
                    A[minPosition] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 3, 5, 8, 9, 6, 2 };

            SelectionSort(A);
            Console.WriteLine("Sorted Array: ");
            foreach (int i in A)
                Console.WriteLine(i);

        }
    }
}
