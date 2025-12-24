namespace PrimeNumbersUpToLimit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // getting the limit from the user
            Console.Write("Enter the limit: ");
            int limit = int.Parse(Console.ReadLine());

            //for loop for outer loop
            for (int i = 2; i <= limit; i++)
            {
                //count initialization
                int count = 0;

                //inner loop updated
                for (int j = 1; j <= i; j++)
                {
                    // if rem is zero then count will be incremented
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                //checks whether count exactly 2 if yes it is a prime number
                if (count == 2)
                {
                    Console.WriteLine($"{i} is a prime number");
                }
            }

            Console.ReadKey();
        }
    }
}
