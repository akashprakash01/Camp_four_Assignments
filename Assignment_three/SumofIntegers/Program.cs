namespace SumofIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable to stores the sum of numbers between 100 and 200 which is divisible by 9
            int sum = 0;
            //count variable to store the count of digits which is divisible by 9 in between 100 and 200
            int count = 0;
            
            //for loop to iterate up to 200 starting from 100
            for (int i = 100; i < 200; i++)
            {
                // checking weather the iterating number is divisible by 9 if yes add to sum
                if ( i%9 == 0)
                {
                    count = count + 1;
                    sum += i;
                }
            }
            // display the total sum after iteration completion.
            Console.WriteLine($"Sum of numbers between 100 and 200 which is divisible by 9 is: {sum} and count of numbers are: {count}");
            Console.ReadKey();
        }
    }
}
