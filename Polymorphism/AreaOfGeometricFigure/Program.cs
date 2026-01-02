using System;
using AreaOfGeometricFigure.Model;

namespace AreaOfGeometricFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----- Accessing through BASE CLASS reference (Runtime Polymorphism) -----
            GeometricFigure figure = new RectangleFigure(); ;
            figure.ReadData();
            figure.Display();
            figure.Area();

            Console.WriteLine();

            figure = new SquareFigure();
            figure.ReadData();
            figure.Display();
            figure.Area();

            Console.WriteLine();

            figure = new CircleFigure();
            figure.ReadData();
            figure.Display();
            figure.Area();

            //  Accessing through DERIVED CLASS reference 
            Console.WriteLine("\nUsing Derived Class Reference:");

            RectangleFigure rectangle = new RectangleFigure();
            rectangle.ReadData();
            rectangle.Display();
            rectangle.Area();

            Console.ReadKey();
        }
    }
}
