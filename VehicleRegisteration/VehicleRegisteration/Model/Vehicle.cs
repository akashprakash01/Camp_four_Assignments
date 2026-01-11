using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistration.Model
{
    public class Vehicle
    {
        //using access modifier hiding the fields
        private string licenseNumber;
        private int model;
        private string carCompany;

        //default constructor
        public Vehicle()
        {
            
        }

        //public property to access the private field and get value from the user and set value to the variable 
        public string LicenseNumber
        {
            get { return licenseNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("License Number cannot be empty or null");

                licenseNumber = value;
            }
        }

        public int Model
        {
            get { return model; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid model year");

                model = value;
            }
        }

        public string CarCompany
        {
            get { return carCompany; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Car company name cannot be empty or null");

                carCompany = value;
            }
        }


        //Method to get data from the user
        public void UserData()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter your car License Number: ");
                    LicenseNumber = Console.ReadLine();

                    Console.Write("Enter the Vehicle model year: ");
                    Model = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the name of the car company: ");
                    CarCompany = Console.ReadLine();

                    break; // exit only if all inputs are valid
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again.\n");
                }
            }
        }

    }
}
