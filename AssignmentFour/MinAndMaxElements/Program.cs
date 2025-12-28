namespace MinAndMaxElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the array
            int[] elements = { 1, 5, 22, 15, 32, 4, 100, 105, 2000, 5000, 5001, 10, 20 };

            // Initialize min and max with the first element
            int minElement = elements[0];
            int maxElement = elements[0];

            // Loop through the array to find min and max
            for (int i = 1; i < elements.Length; i++)
            {
                // Check for minimum
                if (elements[i] < minElement)
                {
                    minElement = elements[i];
                }

                // Check for maximum
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            // Display the results
            Console.WriteLine($"Minimum element in the array: {minElement}");
            Console.WriteLine($"Maximum element in the array: {maxElement}");

            Console.ReadKey();
        }
    }
}
