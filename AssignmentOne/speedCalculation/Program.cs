namespace speedCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region user input
            //getting user inputs distance and time
            Console.Write("Enter the Distance(km): ");
            float distance = float.Parse(Console.ReadLine());
            Console.Write("Enter the time(hrs): ");
            float time = float.Parse(Console.ReadLine());
            #endregion

            #region speed calculation
            //calculating speed in km per hr
            float speed  = distance / time;
            Console.WriteLine("speed in km per hr:"+speed);

            //calculating speed in miles per hr
            double milesPerhour = speed * 0.621371;
            Console.Write($"Speed in miles per hour: {milesPerhour}");
            #endregion

            Console.ReadKey();
        }
    }
}
