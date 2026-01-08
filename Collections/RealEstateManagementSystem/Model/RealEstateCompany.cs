using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagementSystem.Model
{
    //company class that manages RealEstate Business
    public class RealEstateCompany
    {
        public string Name { get; set; }

        public string Owner { get; set; }

        public string TaxId { get; set; }


        //object Oriented Model
        private List<Employee> employees;
        private List<Estate> estatesForSale;
        private List<House> housesForSale;

        //constructor
        public RealEstateCompany(string name, string owner, string taxId)
        {
            Name = name;
            Owner = owner;
            TaxId = taxId;
            employees = new List<Employee>();
            estatesForSale = new List<Estate>();
            housesForSale = new List<House>();  
        }

        //Add employee
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        //Display Employees
        public void DisplayEmployees()
        {
            if (employees.Count == 0 )
            {
                Console.WriteLine("No employees yet");
            }
            else
            {
                foreach (var employee in employees)
                {
                    employee.DisplayInfo();
                }

            }
                
        }
        public void AddEstate(Estate estate)
        {
            estatesForSale.Add(estate);
        }

        public void AddHouse(House house)
        {
            housesForSale.Add(house);
        }


        public void DisplayAllHouses()
        {
            if (housesForSale.Count == 0)
            {
                Console.WriteLine(" NO Houses available.");
            }
            else
            {
                for (int i = 0; i < housesForSale.Count; i++)
                {
                    housesForSale[i].DisplayDetails();
                }
            }
        }


        public void DisplayAllEstates()
        {
            if (estatesForSale.Count == 0)
            {
                Console.WriteLine(" NO estates available.");
            }
            else
            {
                for (int i = 0; i < estatesForSale.Count; i++)
                {
                    estatesForSale[i].DisplayDetails();
                }
            }
        }

        //Display Company Info

        public void DisplayCompanyInfo()
        {
            Console.WriteLine("\n----- Company Information -----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Tax ID: {TaxId}");
            Console.WriteLine($"Number of Employees: {employees.Count}");
            Console.WriteLine($"Estates for Sale: {estatesForSale.Count}");
        }



    }
}
