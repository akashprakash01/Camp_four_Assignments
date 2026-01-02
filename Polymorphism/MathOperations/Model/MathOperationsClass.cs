using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.Model
{
    // Implementing the interface and providing concrete implementations for its methods
    public class MathOperationsClass : Interface.MathOperationsInterface
    {
        //default constructor
        public MathOperationsClass()
        {
            
        }

        // Implements addition operation and returns the result
        public int Add(int a, int b)
        {
            Console.WriteLine($"Adding numbers {a} and {b}");
            return a + b;
        }

        // Implements subtraction operation and returns the result
        public int Subtract(int a, int b)
        {
            Console.WriteLine($"Subtracting numbers {a} from {b}");
            return a - b;
        }

        // Implements Multiplication operation and returns the result
        public int Multiply(int a, int b)
        {
            Console.WriteLine($"Multiplying numbers {a} and {b}");
            return a * b;
        }
        // Implements division operation and returns the result
        public double Divide(int a, int b)
        {
            Console.WriteLine($"Dividing numbers {a} and {b}");
            return a / b;
        }

        

    }
}
