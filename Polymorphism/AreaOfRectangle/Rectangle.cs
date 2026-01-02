using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    public class Rectangle
    {
        //private fields
        private int xCoordinate;
        private int yCoordinate;

        //default constructor
        public Rectangle()
        {
            
        }
        //parameterized constructor
        public Rectangle(int _xCoordinate, int _yCoordinate)
        {
            xCoordinate = _xCoordinate;
            yCoordinate = _yCoordinate;
        }

        // property to access private xCoordinate field
        public int XCoordinate
        {
            get { return xCoordinate; }
            set
            {
                if (value < 0)
                    Console.WriteLine("X coordinate cannot be negative");
                else
                    xCoordinate = value;
            }
        }

        // property to access private yCoordinate field
        public int YCoordinate
        {
            get { return yCoordinate; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Y coordinate cannot be negative");
                else
                    yCoordinate = value;
            }
        }

        //method to get input from user
        public void GetInput()
        {
            Console.WriteLine("Enter the XCoordinate of the rectangle:");
            this.XCoordinate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the YCoordinate of the rectangle:");
            this.YCoordinate = Convert.ToInt32(Console.ReadLine());
        }

        //method to calculate area of rectangle
        public void CalculateArea()
        {
            int area = this.XCoordinate * this.YCoordinate;
            Console.WriteLine($"Calculated Area: {area}");
        }

        // overriding ToString() method to display rectangle details using string interpolation
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rectangle Details:");
            sb.AppendLine($"Length: {this.XCoordinate}");
            sb.AppendLine($"Breadth: {this.YCoordinate}");
            sb.AppendLine($"Area: {this.XCoordinate * this.YCoordinate}");
            return sb.ToString();
        }
    }
}
