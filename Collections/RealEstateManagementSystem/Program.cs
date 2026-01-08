using RealEstateManagementSystem.Model;

namespace RealEstateManagementSystem
{

    // ENUM for furniture status 
    // Better safety than boolean
    public enum FurnitureStatus
    {
        UnFurnished,     //No furniture
        SemiFurnished,  //Basic furniture
        FullyFurnished  // fully furnished

    }
    // ENUM for Floor status 
    // Better safety than boolean
    public enum FloorStatus
    {
        UnFurnished,     //
        SemiFurnished,  //Basic SemiFurnished
        FullyFurnished  // fully FullyFurnished

    }
    public class RealEstateApp
    {
       
        static void Main(string[] args)
        {
            //display information and number of employees & create estate for sales
            RealEstateCompany company = new RealEstateCompany("Luxury Estates International","John Brittas", "GST 86745-86755");

            //add employee
            //get input from the user for employee

            company.AddEmployee(new Employee("Sara", "Senior Developer", 12));  //anonymous object
            company.AddEmployee(new Employee("Robert", "Property Valuer", 7));  //anonymous object
            company.AddEmployee(new Employee("David", "legal Advisor", 12));  //anonymous object


            company.AddEstate(new Apartment(120.5,4200,"Sky Tower, 500 Luxury Ave",25,true,FurnitureStatus.FullyFurnished));

            company.AddEstate(new Apartment(
                area:75.6,
                pricePerSqn:3200,
                location:"City Heights 123 Urban st",
                floorNumber:8,
                hasElevator:true,
                furnitureStatus:FurnitureStatus.FullyFurnished
                ));


            // add house 
            company.AddHouse(new House(320.5, 5000, "Kottayam Town", 25, 30,4, FloorStatus.SemiFurnished));

            //display company information
            company.DisplayCompanyInfo();

            //display Employee details
            company.DisplayEmployees();

            //Estate details
            company.DisplayAllEstates();

            company.DisplayAllHouses();


            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();  
        }
    }
}
