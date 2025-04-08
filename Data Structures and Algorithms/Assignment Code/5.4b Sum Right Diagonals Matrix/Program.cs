namespace _5._4b_Sum_Right_Diagonals_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----GET matrix
            Console.Write("Input square size of matrix: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            Console.WriteLine("Input elements for the matrix");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element -  [{i}],[{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //----Hardcoding matrix in
            //int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            //----DISPLAY matrix
            Console.WriteLine("The matrix is: ");
            for (int i = 0; i < matrix.GetLength(0); i++) //(0) is # of rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //(1) is # of cols
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

           //----CALCULATE the sum by iterating through the matrix, getting the element where row==col(row)
            int rightDiagSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) //starts at row0, then moves to row1 to find element at [i,i]
            {
                rightDiagSum += matrix[i, i]; //element where row index == col index, adding to rightdiagsum
            }

            Console.WriteLine($"Sum of right diagonal elements is: {rightDiagSum}");
        }
    }
}