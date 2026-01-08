using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagementSystem.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public string WorkPosition { get; set; }
        public int ExperienceYears { get; set; }

        // constructor
        public Employee(string name, string workPosition, int experienceYears)
        {
            Name = name;
            WorkPosition = workPosition;
            ExperienceYears = experienceYears;
        }
        //Display information
        public void DisplayInfo()
        {
            Console.WriteLine($" Employee: {Name}, Position: {WorkPosition}," +
                $"Experience: {ExperienceYears} years");
        }

    }
}
