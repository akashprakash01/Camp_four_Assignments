using MathOperations.Interface;
using MathOperations.Model;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Mathematics Operations ------");

            //using interface as type and creating object for MathOperationsClass class
            MathOperationsInterface UserInput = new MathOperationsClass();

            //using object calling each concrete method implemented in class
            Console.WriteLine("Addition: " + UserInput.Add(10, 5));
            Console.WriteLine("Subtraction: " + UserInput.Subtract(10, 5));
            Console.WriteLine("Multiplication: " + UserInput.Multiply(10, 5));
            Console.WriteLine("Division: " + UserInput.Divide(10, 5));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
