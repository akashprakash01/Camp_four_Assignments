using CollectionsAssignmentFour.Model;

namespace CollectionsAssignmentFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Collection to store all auto parts in the store
            List<AutoPart> storeInventory = new List<AutoPart>();

            // Manufacturing companies
            ManufacturingCompany bosch = new ManufacturingCompany
            {
                Name = "Bosch",
                Country = "Germany",
                Address = "Stuttgart, Germany",
                Phone = "+49-123456",
                Fax = "+49-654321"
            };

            ManufacturingCompany michelin = new ManufacturingCompany
            {
                Name = "Michelin",
                Country = "France",
                Address = "Clermont-Ferrand, France",
                Phone = "+33-987654",
                Fax = "+33-456789"
            };

            // Car models
            CarModel car1 = new CarModel { Brand = "Mercedes", Model = "C320", Year = 2008 };
            CarModel car2 = new CarModel { Brand = "BMW", Model = "X5", Year = 2015 };
            CarModel car3 = new CarModel { Brand = "Audi", Model = "A6", Year = 2012 };

            // Auto part 1
            AutoPart engineFilter = new AutoPart
            {
                Code = "ENG001",
                Name = "Engine Oil Filter",
                Category = "Engine",
                PurchasePrice = 1200,
                SalePrice = 1800,
                Manufacturer = bosch
            };
            engineFilter.CompatibleCars.Add(car1);
            engineFilter.CompatibleCars.Add(car2);

            // Auto part 2
            AutoPart tyre = new AutoPart
            {
                Code = "TYR101",
                Name = "Radial Tyre",
                Category = "Tires and Wheels",
                PurchasePrice = 3500,
                SalePrice = 5200,
                Manufacturer = michelin
            };
            tyre.CompatibleCars.Add(car2);
            tyre.CompatibleCars.Add(car3);

            // Adding parts to store inventory collection
            storeInventory.Add(engineFilter);
            storeInventory.Add(tyre);

            // Displaying all auto parts in the store
            Console.WriteLine("====== AUTO PARTS STORE INVENTORY ======");

            foreach (AutoPart part in storeInventory)
            {
                part.DisplayPart();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
