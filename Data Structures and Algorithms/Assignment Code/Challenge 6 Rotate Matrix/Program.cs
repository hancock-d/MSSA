namespace Challenge_6_Rotate_Matrix
{
    internal class Program
    {
        static void RotateMatrix(int[,] matrix)
        {
            //Transpose the matrix
            for (int i = 0; i < matrix.GetLength(0); i++) //moving through horizontal rows
            {
                for (int j = i; j < matrix.GetLength(1); j++) //moving across vert cols
                {
                    //swap matrix[i,j] and matrix[j,i]
                    int temp = matrix[i, j]; //store current value...
                    matrix[i, j] = matrix[j, i]; //overwrite it with transposed counterpart
                    matrix[j, i] = temp; //put stored value in the new position 
                }
            }

            //Reverse the rows
            for (int i = 0; i < matrix.GetLength(0); i++) //iterate rows -- could also use matrix(0).length (rows) and matrix(1).length  (cols)
            {
                var k = matrix.GetLength(1) - 1; //pointer moving right to left while j moves left to right
                for (int j = 0; j < k; j++, k--) //iterate cols til hits k
                {
                    //swap elements at beginning and end of row, moving inwards
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();

            }
        }


        static void Main(string[] args)
        {
            int[,] matrix1 =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            int[,] matrix2 =
            {
                {5,1,9,11 },
                {2,4,8,10 },
                {13,3,6,7 },
                {15,14,12,16 }
            };

            //MAtrix 1
            Console.WriteLine("Original matrix:");
            PrintMatrix(matrix1);
            RotateMatrix(matrix1);
            Console.WriteLine("Rotated matrix:");
            PrintMatrix(matrix1);

            Console.WriteLine();

            //MAtrix2
            Console.WriteLine("Original matrix: ");
            PrintMatrix(matrix2);
            RotateMatrix(matrix2);
            Console.WriteLine("Rotated matrix: ");
            PrintMatrix(matrix2);
        }
    }
}
