using EmployeeSalary.Model;

namespace EmployeeSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display application heading
            Console.WriteLine("------Employee Details------");

            // Create an Employee object using the default constructor
            Employee employeeOne = new Employee();

            // Assign employee details using properties
            employeeOne.Name = "Sam";
            employeeOne.BaseSalary = 20000;
            employeeOne.YearsOfService = 7;

            // Display employee salary details using overridden ToString()
            Console.WriteLine(employeeOne.ToString());

            // Pause the console to view output
            Console.ReadKey();
        }
    }
}
