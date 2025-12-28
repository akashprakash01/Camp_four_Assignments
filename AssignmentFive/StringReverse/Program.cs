namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read string from user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            
            // Print characters in reverse order
            Console.WriteLine("\nCharacters in reverse order:");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }

            Console.ReadKey();
        }
    }
}
