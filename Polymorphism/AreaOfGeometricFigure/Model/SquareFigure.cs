using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfGeometricFigure.Model
    {
        // SquareFigure is a derived class of GeometricFigure
        public class SquareFigure : GeometricFigure
        {
            //private  instance variable specific to square
            private double side;

            // overriding base class method to read square data
            public override void ReadData()
            {
                this.NoOfSides = 4;

                // reading side length
                Console.Write("Enter side: ");
                side = Convert.ToDouble(Console.ReadLine());
            }

            // overriding base class method to display square details
            public override void Display()
            {
                Console.WriteLine("Square");
                Console.WriteLine("Side: " + side);
            }

            // overriding base class method to calculate area of square
            public override void Area()
            {
                Console.WriteLine("Area of Square: " + (side * side));
            }
        }
    }
