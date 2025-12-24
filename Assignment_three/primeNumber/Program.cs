namespace primeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get the input from the user to check if it is prime or not
            Console.WriteLine("Enter a number");
            int userInput = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= userInput; i++)
            {
                if (userInput % i == 0 && count <= 2)
                {
                    count++;

                }


            }
            if (count <= 2)
            {
                Console.WriteLine($"{userInput} is a Prime number");
            }
            else
            {
                Console.WriteLine($"{userInput} is a Not a Prime number");
            }

            Console.WriteLine("Enter any key to exit");
            Console.ReadLine();

        }
    }
}
