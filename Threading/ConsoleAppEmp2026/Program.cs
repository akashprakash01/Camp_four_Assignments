using ConsoleAppEmpV2026.Model;
using ConsoleAppEmpV2026.Repositories;
using ConsoleAppEmpV2026.Services;
using ClassLibraryMessageNotifier;

namespace ConsoleAppEmpV2026
{
    public  class EmpV2026
    {
        //1 - field
        private readonly IEmployeeServices _employeeServices;

        //2 - constructor  injection

        public EmpV2026(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }
        static async Task Main(string[] args)
        {

            //Request flow : UI(validation)--->Services -----> Repository  ---->Container/File/DB
            //User can see Response : <---- UI <-----Services <----- Repository <----Container/File/DB

            //3 - Instance of EmpV2026
            var empApp = new EmpV2026(new EmployeeServicesImp(new EmployeeRepositoryImpl()));

            //Menu driven
            while (true)
            {
                Console.WriteLine("==========Employee Management System ========");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. List all Employees");
                Console.WriteLine("6. Exit");

                //get choice from the user
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Invalid Choice. Please try again");
                    continue;
                }
                // logic for the choice
                try
                {
                    switch (choice)
                    {
                        case 1:
                           
                            //add employee
                            int newId = await empApp._employeeServices.AddEmployeeServiceAsync(new Employee());

                            if (newId != -1)
                            {
                                Console.WriteLine("employee Added successfully");
                            }
                            else
                            {
                                Console.WriteLine($"An error occurred ");
                            }
                                break;
                        case 5:
                            //gettring from classLibrary
                            string result = new MessageNotifier().SendPlNumber();
                            Console.WriteLine(result);
                            var employees = await empApp._employeeServices
                                                        .ListAllEmployeesServiceAsync();

                            if (employees == null || employees.Count == 0)
                            {
                                Console.WriteLine("No employees found.");
                            }
                            else
                            {
                                Console.WriteLine("\n================== Employee List ==================\n");

                                // Header
                                Console.WriteLine(
                                    $"{"ID",-6} {"Name",-15} {"Salary",-10} {"Joined",-12} {"InService",-10} {"Department",-12}");
                                Console.WriteLine(
                                    new string('-', 70));

                                // Rows
                                foreach (var emp in employees)
                                {
                                    Console.WriteLine(
                                        $"{emp.Id,-6} {emp.Name,-15} {emp.Salary,-10} {emp.DateOfJoin:yyyy-MM-dd,-12} {(emp.InService ? "Yes" : "No"),-10} {emp.Dept?.DepartmentName,-12}");
                                }

                                Console.WriteLine(
                                    new string('-', 70));
                                Console.WriteLine($"Total Employees: {employees.Count}\n");
                            }
                            break;


                        case 6:
                        //exit
                            Console.WriteLine("Exiting the application...");
                            Environment.Exit(0);
                            return;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message} ");

                }
            }




            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();  
        }
    }
}
