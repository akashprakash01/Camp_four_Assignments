namespace AreaOfRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of Rectangle Calculation Program");
            Rectangle rectangleOne = new Rectangle();
            rectangleOne.GetInput();
            rectangleOne.CalculateArea();
            Console.WriteLine(rectangleOne.ToString());


            //pass parameter to 
          Rectangle rectangleTwo = new Rectangle(5, 10);
            rectangleTwo.CalculateArea();
            Console.WriteLine(rectangleTwo.ToString());
            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }
}
