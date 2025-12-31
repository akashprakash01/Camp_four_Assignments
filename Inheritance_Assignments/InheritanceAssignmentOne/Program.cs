using InheritanceAssignmentOne.Model;

namespace InheritanceAssignmentOne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.ReadData();
            student.GetData();
            student.ComputeGrade();
            student.DisplayData();


            Employee employeeOne = new Employee();
            employeeOne.ReadData();
            employeeOne.GetData();
            employeeOne.ComputeSalary();
            employeeOne.DisplayData();


            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }
}
