namespace MatrixAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;

            // Read number of rows
            Console.Write("Enter number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            // Read number of columns
            Console.Write("Enter number of columns: ");
            columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[rows, columns];
            int[,] matrix2 = new int[rows, columns];
            int[,] sumMatrix = new int[rows, columns];

            // Read elements of first matrix
            Console.WriteLine("\nEnter elements of first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Read elements of second matrix
            Console.WriteLine("\nEnter elements of second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Add the two matrices
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Display the resultant matrix
            Console.WriteLine("\nSum of the two matrices:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(sumMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
