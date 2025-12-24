namespace AreasOfGeometricalShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Calculate the Areas for different shapes-----");

            int choice;

            while (true)
            {
                // Display menu
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Rectangle");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                string input = Console.ReadLine();

                // Try to parse the input as integer
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        // geting inputs and calculating areas of circle 
                        case 1:
                            Console.Write("Enter the radius of the circle: ");
                            double circleRadius = double.Parse(Console.ReadLine());
                            double circleArea = Math.PI * circleRadius * circleRadius;
                            Console.WriteLine("The area of the circle is " + circleArea);
                            break;

                        // geting inputs and calculating area of square
                        case 2:
                            Console.Write("Enter the side of the square: ");
                            double squareSide = double.Parse(Console.ReadLine());
                            Console.WriteLine("The area of the square is " + squareSide * squareSide);
                            break;
                        // geting inputs and calculating area of triangle
                        case 3:
                            Console.Write("Enter the base of the triangle: ");
                            double triangleBase = double.Parse(Console.ReadLine());
                            Console.Write("Enter the height of the triangle: ");
                            double triangleHeight = double.Parse(Console.ReadLine());
                            Console.WriteLine("The area of the triangle is " + (0.5 * triangleBase * triangleHeight));
                            break;
                        // geting inputs and calculating area of rectangle
                        case 4:
                            Console.Write("Enter the length of the rectangle: ");
                            double rectangleLength = double.Parse(Console.ReadLine());
                            Console.Write("Enter the breadth of the rectangle: ");
                            double rectangleBreadth = double.Parse(Console.ReadLine());
                            Console.WriteLine("The area of the rectangle is " + rectangleLength * rectangleBreadth);
                            break;
                        // exiting the program
                        case 5:
                            return;

                        // handling invalid choices
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid number between 1 and 5.");
                            break;
                    }

                }
                else
                {
                    // Try to parse the input as integer
                    Console.WriteLine("Invalid input! Please enter a number.");
                }


               
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
