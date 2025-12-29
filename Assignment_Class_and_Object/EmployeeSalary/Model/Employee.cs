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

        public double BaseSalary
        {
            get { return baseSalary; }
            set
            {
                if (value < 10000)
                    Console.WriteLine("Base Salary cannot be less than 10000");
                else
                    baseSalary = value;
            }
        }
        public int YearsOfService
        {
            get { return yearsOfService; }
            set { yearsOfService = value; }
        }
        public double CalculateBonus()
        {
            return baseSalary * 0.05 * yearsOfService;
        }

        public double TotalSalary()
        {
            return baseSalary + CalculateBonus();
        }

        public override string ToString()
        {
            return $"Name: {name}, Base Salary: {baseSalary}, Years of Service: {yearsOfService}, " +
                   $"Bonus: {CalculateBonus()}, Total Salary: {TotalSalary()}";
        }
    }

}
