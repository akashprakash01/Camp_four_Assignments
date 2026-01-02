using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfGeometricFigure.Model
{

        // RectangleFigure is a derived class of GeometricFigure
        public class RectangleFigure : GeometricFigure
        {
            // private instance variables specific to rectangle
            private double length;
            private double breadth;

            // default constructor
            public RectangleFigure()
            {
            }

            // overriding base class method to read rectangle data
            public override void ReadData()
            {
                this.NoOfSides = 4;

                // reading length and breadth from user
                Console.Write("Enter length: ");
                length = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter breadth: ");
                breadth = Convert.ToDouble(Console.ReadLine());
            }

            // overriding base class method to display rectangle details
            public override void Display()
            {
                Console.WriteLine("Rectangle");
                Console.WriteLine("Length: " + length);
                Console.WriteLine("Breadth: " + breadth);
            }

            // overriding base class method to calculate area of rectangle
            public override void Area()
            {
                Console.WriteLine("Area of Rectangle: " + (length * breadth));
            }
        }
    }
