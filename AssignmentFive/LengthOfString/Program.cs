namespace LengthOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read string from user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int length = 0;

            // Count characters manually
            foreach (char ch in input)
            {
                length++;
            }

            // Display result
            Console.WriteLine($"Length of the string is: {length}");

            Console.ReadKey();
        }
    }
}
