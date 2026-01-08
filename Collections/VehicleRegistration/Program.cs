using System;
using VehicleRegistrationProcess.Model;

namespace VehicleRegistrationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object for VehicleRegistration class
            VehicleRegistration registeVehicle = new VehicleRegistration();
            int choice;

            //do while loop to  handle menu
            do
            {
                Console.WriteLine("\n---- Vehicle Registration Menu ----");
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. Search Vehicle");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                //switch case to handle choice
                switch (choice)
                {
                    case 1:
                        registeVehicle.GenerateVehicle();
                        break;

                    case 2:
                        Console.Write("Enter license number to search: ");
                        int num = int.Parse(Console.ReadLine());

                        Vehicle veicleName = registeVehicle.GetVehicle(num);

                        if (veicleName != null)
                            Console.WriteLine("Vehicle Name: " + veicleName.VehicleName);
                        else
                            Console.WriteLine("Vehicle not found");
                        break;

                    case 3:
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 3);

            Console.ReadKey();
        }
    }
}
