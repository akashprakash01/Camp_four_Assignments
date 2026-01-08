using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagementSystem.Model
{
    //Basic class for all types of Estates
    //contains common properties for all estate types
    public abstract class Estate
    {
        // common properties for all estates
        public double Area { get; set; } // in square meters
        public decimal PricePerSqn { get; set; }  //price per square meters
        public string Location { get; set; }  //address/area location

        public bool Isavailable { get; set; }  //available or not

        //lambda expression
        public decimal TotalPrice => PricePerSqn * (decimal)Area;

        //default constructor
        public Estate()
        {
            
        }
        //constructor
        protected Estate(double area, decimal pricePerSqn, string location)
        {
            Area = area;
            PricePerSqn = pricePerSqn;
            Location = location;
        }
        // Basic Information
        public virtual void DisplayBasicInfo()
        {
            Console.WriteLine($" Area: {Area} sqn, Location: {Location}");
            Console.WriteLine($" Price per sqn: ${PricePerSqn}, Total: {TotalPrice}");
            Console.WriteLine($"  Available: {Isavailable}");

        }
        // EstateType Info
        public abstract void DisplayDetails();





    }
}
