using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProfessor.Model
{
    public class Professor :Course
    {
        private string name;
        private int employeeid;
        
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name Must to Filled");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int EmployeeId
        {
            get { return employeeid; }
            set
            {
                if (value > 0)
                {
                    employeeid = value;
                }
                else
                {
                    Console.WriteLine("Enter Valid Student Id");
                }
            }
        }
        public void ReadData()
        {
            Console.Write("Enter Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Enter StudentID ");
            this.EmployeeId = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}\nStudentName {EmployeeId}\nMajor: {CourseName}");
        }
    }
}
