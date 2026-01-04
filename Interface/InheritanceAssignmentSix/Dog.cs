using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignmentSix
{
    public class Dog : Animal
    {
        public Dog()
        {
            NoOfLegs = 4;
            Color = "Brown";
        }

        public override string Cry()
        {
            return "Bow Wow";
        }

        public override void Fly()
        {
            Console.WriteLine("Dog cannot fly");
        }

        public override void Walk()
        {
            Console.WriteLine($"Dog is walking with {NoOfLegs} legs");
        }
    }
}
