namespace squareAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task to get the n number form the user and display its square and sum

            //getting the userInput
            Console.Write("Enter the  number: ");
            int limit = int.Parse(Console.ReadLine());

            // sum to store the sum of squares
            int sum = 0;

            //loop for iterate up to the limit from 1
            for (int i = 1; i <= limit; i++)
            {
                // displaying the square of the current iterating element
                Console.WriteLine($"{i} * {i} = {i * i}");
                //adding the square to the sum
                sum = (i * i) + sum;
            }
            // display the total square sum of n numbers
            Console.WriteLine("Total sum = " + sum);

            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }
}
