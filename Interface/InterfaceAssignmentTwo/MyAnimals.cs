using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignmentTwo
{
    public class MyAnimals : Animals
    {
        // private field for body temperature
        private int bodyTemp;

        // Property with get and set accessors
        public int BodyTemp
        {
            get { return bodyTemp; }
            set { bodyTemp = value; }
        }

        // Implementing abstract method
        // This method returns the BodyTemp property value
        public override int GetBodyTemp()
        {
            return BodyTemp;
        }
    }
}
