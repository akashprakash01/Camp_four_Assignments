using ConsoleAppEmpV2026.Model;
using ConsoleAppEmpV2026.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmpV2026.Repositories
{
    public class EmployeeRepositoryImpl : IEmployeeRepository
    {

        public EmployeeRepositoryImpl()
        {
            LoadEmployeesFromFile();
        }

        //create a dictionary to store employee IDs
        // and corresponding employee details
        public static Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
        //private static int employeeIdCounter = 1000; //start with 1000 for 4-digit ID

        //int empid = rand.Next(1000,9999); 


        #region deserailizer
        private void LoadEmployeesFromFile() 
        {
            if(!File.Exists("employees.json"))
            {
                employees = new Dictionary<int, Employee>();
                return;
            }
            string json = File.ReadAllText("employees.json");
            employees = JsonConvert.DeserializeObject<Dictionary<int,Employee>>(json)
                ?? new Dictionary<int, Employee>();

        }
        #endregion

        

        #region insert
        public async Task<int> InsertEmployeeAsync(Employee employee)
        {
            try
            {
                string name = string.Empty;
                decimal salary = 0;
                DateTime dateOfJoin = DateTime.Now;
                bool inService = false;
                int departmentId = 0;

                //Get Input from the user
                //Employee Name

                while (true)
                {
                    Console.Write("Employee Name: ");
                    name = Console.ReadLine();
                    
                    //check validation
                    if(ValidationHelper.IsValidName(name))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Name: only alphabets");
                    }
                }

                //salary
                while (true)
                {
                    Console.Write("Enter salary: ");
                    string salaryInput = Console.ReadLine();

                    //check validation
                    if (ValidationHelper.IsValidSalary(salaryInput))
                    {
                        salary = decimal.Parse(salaryInput);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid salary! Only positive numbers");
                    }
                }

                //Date of Joining
                while(true)
                {
                    Console.Write(" Enter date of joining (YYYY-MM-DD):");
                    string dateOfJoiningInput = Console.ReadLine();

                    //check validation
                    if(ValidationHelper.IsValidDateJoin(dateOfJoiningInput))
                    {
                        dateOfJoin = DateTime.Parse(dateOfJoiningInput);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry! Must be within the last 5 days");
                    }
                }

                //Department ID --- List of Departments
                while(true)
                {
                    Console.WriteLine("Department : \n1. HR \n2. Admin \n3. IT \n4.Operation");
                    Console.Write("Enter Department ID (1/2/3/4) :");

                    //Get Input from the user and validate 
                    if (int.TryParse(Console.ReadLine(), out departmentId) && departmentId >=1 && departmentId <= 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Department ID. Please try again");
                    }
                }

                //Department Name
                string departmentName = departmentId switch
                {
                    1 => "HR",
                    2 => "Admin",
                    3 => "IT",
                    4 => "Operation",
                    _ => throw new AbandonedMutexException()
                };

                //Inservice
                while(true)
                {
                    Console.Write("Is the employee in service? (y/n): ");
                    string inServiceInput = Console.ReadLine();

                    //check validation
                    if(ValidationHelper.IsValidInService(inServiceInput))
                    {
                        inService = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry! Please enter 'yes' or 'no'");
                    }
                    
                }
                //Auto-generate Employee ID
                int employeeId = await GetNextEmployeeIdAsync();

                //taking all data from the file and writing to the dictornary
                string fileData = File.ReadAllText("employees.json");
                
                if ( employeeId > 0 )
                {
                    //              Key             value
                    employees.Add(employeeId, new Employee
                    {
                        Id = employeeId,
                        Name = name,
                        Salary = salary,
                        DateOfJoin = dateOfJoin,
                        InService = inService,
                        Dept = new Department
                        {
                            DepartmentId = departmentId,
                            DepartmentName = departmentName,
                        }
                    });
                    //write to JSON file
                    //Serialize with Newtonsoft.Json with pretty formatting
                    string json = JsonConvert.SerializeObject(employees,Formatting.Indented);
                    await File.WriteAllTextAsync("employees.json", json);

                    int writeResult = employees.Count;

                    if (writeResult >= 0 )
                    {
                        Console.WriteLine($"Employee added successfully with ID: {employeeId}");
                        return writeResult;
                    }
                    else
                    {
                        Console.WriteLine($"Employee added to memory but failed to save to file.");
                        return -2;
                    }
                }
               
                return -3; //ID generation error
               
            }

            catch (Exception ex)  
            {
                Console.WriteLine($"Error occurred:  {ex.Message}");
                return -1;
            }
        }
        #endregion


        #region Auto Generate employeeId
        private async Task<int> GetNextEmployeeIdAsync()
        {
            await Task.Delay(50);
            return new Random().Next(1000,9999);
        }
        #endregion
        #region List
        public Task<List<Employee>> SelectAllEmployeesAsync()
        {
            return Task.FromResult(employees.Values.ToList());

        }
        #endregion


    }
}
