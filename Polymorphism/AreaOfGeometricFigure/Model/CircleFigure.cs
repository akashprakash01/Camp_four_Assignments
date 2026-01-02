using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfGeometricFigure.Model
    {
        // CircleFigure is a derived class of GeometricFigure
        // It represents a circle and computes its area
        public class CircleFigure : GeometricFigure
        {
            // instance variable specific to circle
            private double radius;

            // overriding base class method to read circle data
            public override void ReadData()
            {
                // circle has no sides
                this.NoOfSides = 0;

                // reading radius from user
                Console.Write("Enter radius: ");
                radius = Convert.ToDouble(Console.ReadLine());
            }

            // overriding base class method to display circle details
            public override void Display()
            {
                Console.WriteLine("Circle");
                Console.WriteLine("Radius: " + radius);
            }

            // overriding base class method to calculate area of circle
            public override void Area()
            {
                Console.WriteLine("Area of Circle: " + (Math.PI * radius * radius));
            }
        }
    }
