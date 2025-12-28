namespace DuplicateElementsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the array
            int[] arr = { 1, 2, 5, 2, 4, 5, 1, 6 };

            int duplicateCount = 0;

            // Loop to compare each element with the rest of the array
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;

                // Check for duplicates of arr[i]
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        // Mark duplicate element
                        arr[j] = -1; 
                    }
                }

                // If count is greater than 1, then it is a duplicate element
                if (count > 1 && arr[i] != -1)
                {
                    duplicateCount++;
                }
            }

            // Display the result
            Console.WriteLine($"Total number of duplicate elements: {duplicateCount}");
            Console.ReadKey();
        }
    }
}
