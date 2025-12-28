namespace MatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;

            // Read size of square matrices
            Console.Write("Enter the size of the square matrix: ");
            size = Convert.ToInt32(Console.ReadLine());

            int[,] matrixA = new int[size, size];
            int[,] matrixB = new int[size, size];
            int[,] resultMatrix = new int[size, size];

            // Read elements of first matrix
            Console.WriteLine("\nEnter elements of first matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Read elements of second matrix
            Console.WriteLine("\nEnter elements of second matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Matrix multiplication
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    resultMatrix[i, j] = 0;

                    for (int k = 0; k < size; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            // Display the result matrix
            Console.WriteLine("\nResultant matrix after multiplication:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
