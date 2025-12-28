namespace CharacterCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input string from user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int alphabets = 0;
            int digits = 0;
            int specialChars = 0;

            // Traverse each character in the string
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                // Check for alphabets 
                if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                {
                    alphabets++;
                }
                // Check for digits 
                else if (ch >= '0' && ch <= '9')
                {
                    digits++;
                }
                // Remaining characters are special characters
                else
                {
                    specialChars++;
                }
            }

            // Display the results
            Console.WriteLine($"Alphabets: {alphabets}");
            Console.WriteLine($"Digits: {digits}");
            Console.WriteLine($"Special characters: {specialChars}");

            Console.ReadKey();
        }
    }
}
