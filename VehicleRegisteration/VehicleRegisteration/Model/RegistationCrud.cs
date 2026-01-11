using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRegistration.Model;

namespace VehicleRegisteration.Model
{
    public class RegistrationCrud : IRegistrationProcess
    {
        private Dictionary<string, Vehicle> vehicles;

        // constructor
        public RegistrationCrud()
        {
            vehicles = new Dictionary<string, Vehicle>();
        }



        // AddingNewVehicle method implementation
        public void AddingNewVehicle(Vehicle vehicle)
        {
            if (vehicles.ContainsKey(vehicle.LicenseNumber))
            {
                Console.WriteLine("\n License Number Already Exist");
            }
            else
            {
                vehicles.Add(vehicle.LicenseNumber, vehicle);
                Console.WriteLine("\nVehicle registered");
            }
        }

        //method to list all the vehicles
        public void DisplayVehicle(string numberPlate)
        {
            if (!vehicles.ContainsKey(numberPlate))
            {
                Console.WriteLine("This vehicle doesn't exist");
            }
            else
            {
                Vehicle vehicle = vehicles[numberPlate];

                Console.WriteLine(
                    $"Number Plate: {vehicle.LicenseNumber}, " +
                    $"Model: {vehicle.Model}, " +
                    $"Company: {vehicle.CarCompany}"
                );
            }
        }

    }
}
