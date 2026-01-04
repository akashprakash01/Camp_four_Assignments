using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignmentSix
{
    public class Goat : Animal
    {
        public Goat()
        {
            NoOfLegs = 4;
            Color = "White";
        }

        public override string Cry()
        {
            return "Baa Baa";
        }

        public override void Fly()
        {
            Console.WriteLine("Goat cannot fly");
        }

        public override void Walk()
        {
            Console.WriteLine($"Goat is walking with {NoOfLegs} legs");
        }
    }
}
