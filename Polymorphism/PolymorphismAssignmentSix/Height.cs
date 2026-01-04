using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmentSix
{
    public class Height
    {
        // Data members
        public int Feet { get; set; }
        public int Inches { get; set; }

        // Constructor
        public Height(int feet, int inches)
        {
            Feet = feet;
            Inches = inches;
        }

        // Overloading + operator
        public static Height operator +(Height height)
        {
            // Increase inches by 1
            height.Inches++;

            // If inches reaches 12, reset and increase feet
            if (height.Inches == 12)
            {
                height.Inches = 0;
                height.Feet++;
            }

            return height;
        }

        // Method to display height
        public void Display()
        {
            Console.WriteLine($"Height: {Feet} Feet {Inches} Inches");
        }
    }
}
