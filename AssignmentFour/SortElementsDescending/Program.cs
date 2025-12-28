namespace SortElementsDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the array
            int[] numbers = { 22, 54, 23, 32, 59, 1 };

            int temp;

            // Outer loop selects each element
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                // Inner loop compares selected element with the rest
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // If current element is smaller, swap
                    if (numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            // Display sorted array
            Console.WriteLine("Array elements in descending order:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
