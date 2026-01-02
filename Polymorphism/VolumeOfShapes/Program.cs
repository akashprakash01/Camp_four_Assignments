using VolumeOfShapes.Model;
using System;

namespace VolumeOfShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Program to find the volume of Cube, Sphere, Cylinder ----");

            Shape shape = new Shape();
            // Default cube
            shape.Volume();
            // Cube
            shape.Volume(12);
            // Sphere
            shape.Volume(5.5);
            // Cylinder
            shape.Volume(12, 2);        

            Console.ReadKey();
        }
    }
}
