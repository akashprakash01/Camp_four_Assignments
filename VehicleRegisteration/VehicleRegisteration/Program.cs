using System;
using VehicleRegisteration.Model;
using VehicleRegistration.Model;

namespace VehicleRegistration
{
    internal class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Creating an object of RegistrationCrud using interface reference
            // This helps in achieving loose coupling
            IRegistrationProcess registration = new RegistrationCrud();

            // Infinite loop to repeatedly show the menu until user exits
            while (true)
            {
                // Displaying menu options to the user
                Console.WriteLine("\n------ Vehicle Registration System ------");
                Console.WriteLine("1. Add New Vehicle");
                Console.WriteLine("2. Search Vehicle by License Number");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                // Reading user's menu choice
                string choice = Console.ReadLine();

                // Switch case to perform actions based on user's choice
                switch (choice)
                {
                    // Case 1: Add a new vehicle
                    case "1":
                        // Creating a Vehicle object
                        Vehicle vehicle = new Vehicle();

                        // Reading vehicle details from the user
                        vehicle.UserData();

                        // Adding the vehicle to the collection
                        registration.AddingNewVehicle(vehicle);
                        break;

                    // Case 2: Search and display vehicle using license number
                    case "2":
                        // Asking user to enter the license number
                        Console.Write("Enter License Number to search: ");
                        string numberPlate = Console.ReadLine();

                        // Retrieving and displaying the vehicle details
                        registration.DisplayVehicle(numberPlate);
                        break;

                    // Case 3: Exit the application
                    case "3":
                        Console.WriteLine("Exiting application...");
                        return;

                    // Default case for invalid menu choice
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
