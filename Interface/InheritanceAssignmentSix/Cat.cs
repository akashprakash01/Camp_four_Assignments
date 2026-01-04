using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignmentSix
{
    public class Cat : Animal
    {
        public Cat()
        {
            NoOfLegs = 4;
            Color = "Black";
        }

        public override string Cry()
        {
            return "Meow";
        }

        public override void Fly()
        {
            Console.WriteLine("Cat cannot fly");
        }

        public override void Walk()
        {
            Console.WriteLine($"Cat is walking with {NoOfLegs} legs");
        }
    }
}
