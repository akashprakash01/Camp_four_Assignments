using ConsoleAppEmpV2026.Model;
using ConsoleAppEmpV2026.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmpV2026.Services
{
    public class EmployeeServicesImp : IEmployeeServices
    {
        // field 
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeServicesImp(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public  async Task<int> AddEmployeeServiceAsync(Employee employee)
        {
           return  await _employeeRepository.InsertEmployeeAsync(employee);
        }

        public async Task<List<Employee>> ListAllEmployeesServiceAsync()
        {
            return await _employeeRepository.SelectAllEmployeesAsync();
        }

       

    }
}
