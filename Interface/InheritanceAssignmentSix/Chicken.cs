using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignmentSix
{
    public class Chicken : Animal
    {
        public Chicken()
        {
            NoOfLegs = 2;
            Color = "Brown";
        }

        public override string Cry()
        {
            return "Cluck Cluck";
        }

        public override void Fly()
        {
            Console.WriteLine("Chicken can fly up to 10 meters");
        }

        public override void Walk()
        {
            Console.WriteLine($"Chicken is walking with {NoOfLegs} legs");
        }
    }
}
