namespace MatrixEqualityCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;
            bool isEqual = true;

            // Read matrix size
            Console.Write("Enter number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[rows, columns];
            int[,] matrix2 = new int[rows, columns];

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

            // Compare matrices
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        isEqual = false;
                        break;
                    }
                }
                if (!isEqual)
                    break;
            }

            // Display result
            if (isEqual)
            {
                Console.WriteLine("\nThe two matrices are equal.");
            }
            else
            {
                Console.WriteLine("\nThe two matrices are not equal.");
            }

            Console.ReadKey();
        }
    }
}
