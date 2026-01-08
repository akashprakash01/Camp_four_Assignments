using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagementSystem.Model
{
    public class House : Estate
    {
        public double UndevelopedArea { get; set; }
        public double DevelopedArea { get; set; }
        public int Floor { get; set; }

        public FloorStatus FloorStatus { get; set; }

        public House()
        {
            
        }

        public House(double area, decimal pricePerSqn, string location,
            double undevelopedArea, double developedArea,int floor, FloorStatus floorStatus) : base(area, pricePerSqn, location)
        {
            UndevelopedArea = undevelopedArea;
            DevelopedArea = developedArea;
            Floor = floor;

        }
        // basic information
        public override void DisplayDetails()
        {
            Console.WriteLine("========House Details=====");
            base.DisplayBasicInfo();
            Console.WriteLine($"undeveloped Area : {UndevelopedArea}");
            Console.WriteLine($" Developed Area: {UndevelopedArea}");
            Console.WriteLine($" Floor: {FloorStatus}"); //Enum displayed
        }
    }
}
