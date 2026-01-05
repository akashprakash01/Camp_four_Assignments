using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistrationProcess.Model
{
    public class VehicleRegistration 
    {
        // created a dictonay for storing key and value 
        Dictionary<int, Vehicle> vehicles = new Dictionary<int, Vehicle>();

        public void GenerateVehicle()
        {
            //creating object for Vehicle class
            Vehicle vehicleOne = new Vehicle();
            //invoking GetData method
            vehicleOne.GetData();

            //adding that data to the dictionary  
            vehicles[vehicleOne.LicenseNumber] = vehicleOne;
            

        }
        // Applying search for a car
        public Vehicle GetVehicle(int licenseNumber)
        {
            if (vehicles.ContainsKey(licenseNumber))
                return vehicles[licenseNumber];
            
            return null;
        }
        

    }
}
