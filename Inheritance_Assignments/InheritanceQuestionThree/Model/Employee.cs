using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceQuestionThree.Model
{
    public class Employee
    {
        // private fields 
        private int no;
        private string name;
        private string designation;
        private int basicSalary;

        // default constructor
        public Employee()
        {

        }


        // Property to get/set employee number
        protected int No
        {
            get { return no; } 
            set { no = value; }
        }

        // Property to get/set employee name

        protected string Name
        {
            get { return name; } 
            set { 
                if (string.IsNullOrWhiteSpace(value))
                   Console.WriteLine("Name should not be empty or null");
                else
                    name = value; 
            }
        }

        // Property to get/set employee designation
        protected string Designation
        {
            get { return designation; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Designation should not be null or empty");
                else
                    designation = value; }
        }

        // Property to get/set employee basicSalary,
        // Virtual property for basic salary can be overridden in derived classes 
        protected virtual int BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }

        //method to get data from the user
        public void ReadData()
        {
            Console.Write("Enter Employee No: ");
            No = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Designation: ");
            Designation = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            BasicSalary = Convert.ToInt32(Console.ReadLine());
        }

        // Overriding Object.ToString() to display employee details
        public override string? ToString()
        {
            return $"Name {Name}, Designation {Designation}, BasicPay {BasicSalary}";
        }
    }
}
