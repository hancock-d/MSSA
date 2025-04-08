namespace _7._1a_Sort_Exam_Scores
{
    internal class Program
    {
        static void SelectionSort(int[] arr)
        {
            //int minPosition = 0;
            //int temp = 0;

            for (int i =0; i < arr.Length-1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
        
        static void PrintScores(int[] scores)
        {
            SelectionSort(scores);
            Console.WriteLine("Sorted Scores Method: ");
            foreach (var i in scores)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //int[] scores1 = { 80, 85, 90, 95, 100 };
            //int[] scores2 = { -50, 25, 50, 75, 100 };
            int[] scores3 = { 100, 80, 95, 80, 85 };

            //PrintScores(scores1);
            //PrintScores(scores2);
            PrintScores(scores3);


            //SelectionSort(scores1);
            //Console.WriteLine("Sorted scores: ");
            //foreach (var i in scores1)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
