using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppEmpV2026.Utilities
{
    public class ValidationHelper
    {
        //Name, DepartmentName,Address,ParentName,
       public static bool IsValidName(string _name)
        {
            if (string.IsNullOrEmpty(_name))
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(_name, @"^(?! )[A-Za-z]+( [A-Za-z]+)*$");
            }
        }

        //salary
        public static bool IsValidSalary(string _stringInput)
        {
            decimal _salary;
            if (decimal.TryParse(_stringInput, out _salary) && _salary > 0 )
            {
                return true; // valid positive number
            }
            return false; //Invalid
        }

        //Date  of join
        public static bool IsValidDateJoin(string _StringInput)
        {
            DateTime validDate;
            if(DateTime.TryParse(_StringInput, out validDate)
                && validDate >= DateTime.Now.AddDays(-5)
                && validDate <= DateTime.Now)
            {
                return true; //valid date of join
            }
            return false; //invalid
        }

        //Is in Service
        public static bool IsValidInService(string _inputString)
        {
            string inService = _inputString.Trim().ToLower();

            if(inService.StartsWith("y"))
            {
                return true; //valid

            }
            return false; //invalid
        }
    }
}
