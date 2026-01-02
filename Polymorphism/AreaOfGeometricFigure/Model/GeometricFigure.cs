using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfGeometricFigure.Model
{
    public class GeometricFigure
    {
        //data hiding
        private int noOfSides;

        //default Constructor
        public GeometricFigure()
        {
            
        }

        //property to get and set value to the hidden field  noOfSides
        protected int NoOfSides
        {
            get { return noOfSides; }
            set { noOfSides = value; }
        }

        public virtual void ReadData()
        {
            Console.WriteLine("Enter the number of sides of shape");
            this.NoOfSides = Convert.ToInt32(Console.ReadLine());
        }
        // Display number of sides
        public virtual void Display()
        {
            Console.WriteLine("Number of sides: " + noOfSides);
        }

        // Virtual Area method
        public virtual void Area()
        {
            Console.WriteLine("Area calculation not defined for base class");
        }




    }
}
