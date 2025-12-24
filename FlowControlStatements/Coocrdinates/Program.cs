namespace Coocrdinates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get input from user
            Console.Write("Enter X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // if condition to check the quadrant
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The points{x},{y} belongs to First Quadrant.");

            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The points {x},{y} belongs to Second Quadrant.");

            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The points {x},{y} belongs to third Quadrant");

            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The points {x},{y} belongs to Fourth Quadrant.");
            }
            else if (x ==0  && y == 0)
            {
                Console.WriteLine($"The points {x},{y} belongs to Origin.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
