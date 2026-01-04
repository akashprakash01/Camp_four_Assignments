using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignmentSix
{
    public class Crow : Animal
    {
        public Crow()
        {
            NoOfLegs = 2;
            Color = "Black";
        }

        public override string Cry()
        {
            return "Caw Caw";
        }

        public override void Fly()
        {
            Console.WriteLine("Crow can fly up to 100 meters");
        }

        public override void Walk()
        {
            Console.WriteLine($"Crow is walking with {NoOfLegs} legs");
        }
    }
}
