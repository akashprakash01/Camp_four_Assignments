namespace Trianglepattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region user input
           
            //getting user inputs
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            int width = int.Parse(Console.ReadLine());

            #endregion

            #region triangle forming logic
            //logic for printing triangle pattern
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }

            #endregion

            Console.ReadKey();


        }
    }
}
