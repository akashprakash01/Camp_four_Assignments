namespace PatternPrinting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number of rows to be printed
            int rows = 4;

            // Outer loop for row rows
            for (int i = 1; i <= rows; i++)
            {
                // Printing alphabets in increasing order
                for (int j = 0; j < i; j++)
                {
                    // Convert ASCII value to character
                    Console.Write((char)('A' + j) + " ");
                }

                // Printing alphabets in decreasing order
                for (int j = i - 2; j >= 0; j--)
                {
                    // Print characters in reverse order
                    Console.Write((char)('A' + j) + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
