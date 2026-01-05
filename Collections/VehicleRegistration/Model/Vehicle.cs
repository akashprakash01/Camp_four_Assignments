using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistrationProcess.Model
{
    public class Vehicle
    {
        //private fields
        private int licenseNumber;
        private string vehicleName;

        //parameterless constructor
        public Vehicle()
        {
        }

        //property to access the private fields and provide getter and setter for data allocation
        public int LicenseNumber
        {
            get { return licenseNumber; } 
            set { licenseNumber = value; }
        }

        public string VehicleName
        {
            get { return vehicleName; }
            set { vehicleName = value; }
        }

        //method to read data from the user
        public void GetData()
        {
            Console.WriteLine("Enter your License Number");
            this.LicenseNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the vehicle Name");
            this.VehicleName = Console.ReadLine();

        }


        
    }
}
