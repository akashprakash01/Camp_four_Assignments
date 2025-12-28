namespace SecondSmallestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  array elements
            int[] elements = { 12, 5, 8, 20, 3, 15, 3 };
            // set the smallest element as the first element of the array
            int smallest = elements[0];
            //Find the smallest element
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] < smallest)
                {
                    smallest = elements[i];
                }
            }

            // set the secondSmallest to zero
            int secondSmallest = 0;
            bool found = false;

             // Find the second smallest element
            for (int i = 0; i < elements.Length; i++)
            {
                // Consider only elements greater than smallest
                if (elements[i] > smallest)
                {
                    if (!found || elements[i] < secondSmallest)
                    {
                        secondSmallest = elements[i];
                        found = true;
                    }
                }
            }

            // Display result
            if (found)
            {
                Console.WriteLine($"Second smallest element is: {secondSmallest}");
            }
            else
            {
                Console.WriteLine("Second smallest element does not exist.");
            }

            Console.ReadKey();
        }
    }
}
