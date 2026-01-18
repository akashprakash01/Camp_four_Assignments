using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmpV2026.Model
{
    public class Employee
    {
        //Fields //properties
        public int Id { get; set; } //Auto generated 4 digits
        public string Name { get; set; } //validates employee name
                                        //(alphabets with single space allowed
                                        // not starting with space)

        public DateTime DateOfJoin { get; set; } // should be within last 5 days
        public decimal Salary { get; set; }      // Accepts only digits
        //object oriented class Model
        public Department Dept { get; set; }

        public bool InService { get; set; }

    }
}
