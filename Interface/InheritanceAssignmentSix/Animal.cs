using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignmentSix
{
    // Abstract base class
    public abstract class Animal
    {
        // Common attributes
        public int NoOfLegs { get; set; }
        public string Color { get; set; }

        // Abstract methods
        public abstract string Cry();
        public abstract void Fly();
        public abstract void Walk();
    }
}
