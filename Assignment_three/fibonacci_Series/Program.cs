namespace fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0,1,1,2,3, 5, 8, 13, 21, 34, 55, 89, ...
            //getting the limit from the user
            Console.WriteLine("Enter the limit");
            int limit = int.Parse(Console.ReadLine());
            int pre = 0;
            int sum = 0;
            for (int i = 0; i <= limit; i++)
            {
                if (i == 0)
                {
                    sum = 0;
                }
                else if (i == 1)
                {
                    sum = 1;
                }
                else
                {
                    sum = pre + sum;
                    pre = sum - pre;
                }
                Console.Write(sum + " ");

            }
            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }
}
