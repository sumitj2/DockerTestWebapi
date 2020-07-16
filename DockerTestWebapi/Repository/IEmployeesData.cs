using DockerTestWebapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DockerTestWebapi.Repository
{
    public interface IEmployeesData
    {
        Task<List<Employee>> GetAllEmployee();

        Task<int> SaveEmployee(Employee employee);
    }
}
