namespace Functionvalues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Function to display values
            //loop and calculation for displaying function value
            for(int i=-5;i<=5;i++)
            {
                float value = (i * i) + (2 * i) + 1;
                Console.WriteLine($"value of the function: {value}");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
