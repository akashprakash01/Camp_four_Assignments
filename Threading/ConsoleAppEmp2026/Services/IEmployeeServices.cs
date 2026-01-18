using ConsoleAppEmpV2026.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmpV2026.Services
{
    public interface IEmployeeServices
    {
        //make all model asynchronous
        Task <int>AddEmployeeServiceAsync(Employee employee);
        Task<List<Employee>> ListAllEmployeesServiceAsync(); 

    }
}
