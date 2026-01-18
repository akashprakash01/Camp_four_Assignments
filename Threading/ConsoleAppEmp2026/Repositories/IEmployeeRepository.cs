using ConsoleAppEmpV2026.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmpV2026.Repositories
{
    public interface IEmployeeRepository
    {
        //container/File/DB
        //insert Employee
        Task<int> InsertEmployeeAsync(Employee employee);

        //select All Employees
        Task<List<Employee>> SelectAllEmployeesAsync();
    }
}
