using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignmentThree
{
    public class Cat : Animals
    {
        public override void SaySomething()
        {
            Console.WriteLine("Cat says Mew");
        }
    }
}
