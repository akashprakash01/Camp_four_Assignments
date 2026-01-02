using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfShapes.Model
{
    public class Shape
    {
        //default constructor
        public Shape() { }
        // Default volume Cube with side 10
        public void Volume()
        {
            int side = 10;
            Console.WriteLine("Volume of Cube (default): " + (side * side * side));
        }

        // Cube
        public void Volume(int side)
        {
            Console.WriteLine("Volume of Cube: " + (side * side * side));
        }

        // Sphere
        public void Volume(double radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * radius * radius * radius;
            Console.WriteLine("Volume of Sphere: " + volume);
        }

        // Cylinder
        public void Volume(double radius, double height)
        {
            double volume = Math.PI * radius * radius * height;
            Console.WriteLine("Volume of Cylinder: " + volume);
        }
    }
}
