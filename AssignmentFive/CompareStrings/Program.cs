namespace CompareStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input string
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            // user input string
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            bool isEqual = true;

            // length comparison 
            int len1 = 0, len2 = 0;

            foreach (char ch in str1)
                len1++;

            foreach (char ch in str2)
                len2++;

            if (len1 != len2)
            {
                isEqual = false;
            }
            else
            {
                // Compare characters one by one
                for (int i = 0; i < len1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }

            // Display result
            if (isEqual)
            {
                Console.WriteLine("Both strings are equal.");
            }
            else
            {
                Console.WriteLine("Both strings are not equal.");
            }

            Console.ReadKey();
        }
    }
}
