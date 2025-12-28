namespace SeparateOddAndEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Original array
            int[] numbers = { 12, 1, 20, 4, 17, 40, 24, 3,13 };

            int evenCount = 0;
            int oddCount = 0;

            // First loop: count even and odd numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            // arrays for even and odd numbers
            int[] evenNumbers = new int[evenCount];
            int[] oddNumbers = new int[oddCount];

            int evenIndex = 0;
            int oddIndex = 0;

            // loop to separate numbers into arrays
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers[evenIndex] = numbers[i];
                    evenIndex++;
                }
                else
                {
                    oddNumbers[oddIndex] = numbers[i];
                    oddIndex++;
                }
            }

            // Display even numbers
            Console.WriteLine("Even numbers:");
            for (int i = 0; i < evenNumbers.Length; i++)
            {
                Console.Write(evenNumbers[i] + " ");
            }

            // Display odd numbers
            Console.WriteLine("\nOdd numbers:");
            for (int i = 0; i < oddNumbers.Length; i++)
            {
                Console.Write(oddNumbers[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
