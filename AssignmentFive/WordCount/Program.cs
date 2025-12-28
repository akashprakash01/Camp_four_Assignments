namespace WordCount
{
  
        internal class Program
        {
            static void Main(string[] args)
            {
                // Read string from user
                Console.Write("Enter a sentence: ");
                string input = Console.ReadLine();

                int wordCount = 0;
                bool inWord = false;

                // Traverse each character in the string
                for (int i = 0; i < input.Length; i++)
                {
                    // If character is not space and we are not already in a word
                    if (input[i] != ' ' && !inWord)
                    {
                        wordCount++;
                        inWord = true;
                    }
                    // If character is space, we are no longer inside a word
                    else if (input[i] == ' ')
                    {
                        inWord = false;
                    }
                }

                // Display the result
                Console.WriteLine($"Total number of words: {wordCount}");

                Console.ReadKey();
            }
        }

}
