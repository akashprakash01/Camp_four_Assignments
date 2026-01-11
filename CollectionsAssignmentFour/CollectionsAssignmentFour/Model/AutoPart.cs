using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignmentFour.Model
{
    public class AutoPart
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }

        // One manufacturing company
        public ManufacturingCompany Manufacturer { get; set; }

        // One part can be compatible with many car models
        public List<CarModel> CompatibleCars { get; set; }

        public AutoPart()
        {
            CompatibleCars = new List<CarModel>();
        }

        public void DisplayPart()
        {
            Console.WriteLine("\n--- Auto Part Details ---");
            Console.WriteLine($"Code: {Code}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Purchase Price: {PurchasePrice}");
            Console.WriteLine($"Sale Price: {SalePrice}");

            Console.WriteLine("\nManufactured By:");
            Manufacturer.DisplayCompany();

            Console.WriteLine("\nCompatible Car Models:");
            foreach (var car in CompatibleCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
