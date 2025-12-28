namespace ExtractSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read original string
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Read starting position
            Console.Write("Enter starting position: ");
            int startIndex = Convert.ToInt32(Console.ReadLine());

            // Read length of substring
            Console.Write("Enter length of substring: ");
            int length = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (startIndex < 0 || startIndex + length > input.Length)
            {
                Console.WriteLine("Invalid position or length.");
                Console.ReadKey();
                return;
            }

            // Extract substring manually
            string result = "";

            for (int i = startIndex; i < startIndex + length; i++)
            {
                result += input[i];
            }

            // Display result
            Console.WriteLine($"Extracted substring: {result}");

            Console.ReadKey();
        }
    }
}
