namespace ExceptionHandlingThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            try
            {
                
                    Console.WriteLine(numbers[11]);
                
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
            
        }
    }
}
