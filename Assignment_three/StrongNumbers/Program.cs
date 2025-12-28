namespace StrongNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int start, end;

            // Get starting number from user
            Console.Write("Enter the starting number: ");
            start = Convert.ToInt32(Console.ReadLine());

            // Get ending number from user
            Console.Write("Enter the ending number: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nStrong numbers in the given range are:");

            // Loop through each number in the given range
            for (int num = start; num <= end; num++)
            {
                int originalNumber = num;
                int sum = 0;

                // Copy of number to extract digits
                int temp = num;

                // Calculate sum of factorials of digits
                while (temp > 0)
                {
                    int digit = temp % 10;
                    int fact = 1;

                    // Calculate factorial of the digit
                    for (int i = 1; i <= digit; i++)
                    {
                        fact *= i;
                    }

                    sum += fact;
                    temp /= 10;
                }

                // Check whether the number is a Strong Number
                if (sum == originalNumber)
                {
                    Console.WriteLine(originalNumber);
                }
            }

            Console.ReadKey();
        }
    }
}
