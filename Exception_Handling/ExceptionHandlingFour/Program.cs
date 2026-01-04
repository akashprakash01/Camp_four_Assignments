using System;

namespace ExceptionHandlingFour
{
    internal class Program
    {
        // Method to generate a random number
        public static int GenerateRandomNumber()
        {
            Random rand = new Random();

            // Generate a random number between 1 and 50
            int number = rand.Next(1, 51);

            int count = 0;

            // Check whether the number is prime
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }

            // Prime numbers have exactly 2 factors
            if (count == 2)
            {
                throw new Exception("Prime number generated: " + number);
            }

            // Return number if it is not prime
            return number;
        }

        static void Main(string[] args)
        {
            try
            {
                // Calling the method
                int result = GenerateRandomNumber();
                Console.WriteLine("Generated number (not prime): " + result);
            }
            catch (Exception e)
            {
                // Handling the exception
                Console.WriteLine("Exception caught: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
