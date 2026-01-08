using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagementSystem.Model
{
    public class Apartment : Estate
    {
        public int FloorNumber { get; set; }
        public bool HasElevator { get; set; }

        public FurnitureStatus FurnitureStatus { get; set; }

        //constructor
        public Apartment()
        {
            
        }

        public Apartment(double area, decimal pricePerSqn, string location,
            int floorNumber, bool hasElevator, FurnitureStatus furnitureStatus) : base(area, pricePerSqn, location)
        {
            FloorNumber = floorNumber;
            HasElevator = hasElevator;
            FurnitureStatus = furnitureStatus;
        }


        // basic information
        public override void DisplayDetails()
        {
            Console.WriteLine("========Apartment Details=====");
            base.DisplayBasicInfo();
            Console.WriteLine($"Floor: {FloorNumber}");
            Console.WriteLine($"Elevator: {(HasElevator ? "Yes" : "No")}");
            Console.WriteLine($" Furniture: {FurnitureStatus}"); //Enum displayed
        }


    }
}
