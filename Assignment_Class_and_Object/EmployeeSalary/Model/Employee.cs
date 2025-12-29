using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary.Model
{
    public class Employee
    {
        //these fields store the data of the emoloyee
        private string name;
        private double baseSalary;
        private int yearsOfService;

        //constructor
        public Employee()
        {

        }

        //parameterized constructor
        public Employee(String _name, double _baaseSalary, int _yearsOfService)
        {
            this.name = _name;
            this.baseSalary = _baaseSalary;
            this.yearsOfService = _yearsOfService;
        }

        //Encapsulation
        public string Name
        {
            get { return name; }
            set
            {
                //name validation
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Name cannot be empty");
                else
                    name = value;
            }
        }

        // base salary valdation
        public double BaseSalary
        {
            get { return baseSalary; }
            set

            {
                //only takes salary greater than 10000
                if (value < 10000)
                    Console.WriteLine("Base Salary cannot be less than 10000");
                else
                    baseSalary = value;
            }
        }
        //getting and setter for years of service
        public int YearsOfService
        {
            get { return yearsOfService; }
            set { yearsOfService = value; }
        }

        //function to calculate bonus 
        public double CalculateBonus()
        {
            return baseSalary * 0.05 * yearsOfService;
        }


        // function to calculate total salary
        public double TotalSalary()
        {
            return baseSalary + CalculateBonus();
        }

        //Overriding
        public override string ToString()
        {
            return $"Name: {name}, Base Salary: {baseSalary}, Years of Service: {yearsOfService}, " +
                   $"Bonus: {CalculateBonus()}, Total Salary: {TotalSalary()}";
        }
    }

}
