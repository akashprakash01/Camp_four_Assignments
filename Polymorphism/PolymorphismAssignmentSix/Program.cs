namespace PolymorphismAssignmentSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Height object
            Height h1 = new Height(5, 11);

            Console.WriteLine("Before increment:");
            h1.Display();

            // Using overloaded + operator
            h1 = +h1;

            Console.WriteLine("After increment:");
            h1.Display();

            Console.ReadKey();
        }
    }
}

