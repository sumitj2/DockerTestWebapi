using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerTestWebapi.Model;
using DockerTestWebapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerTestWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        private IEmployeesData _employeesData;
        public EmployeController(IEmployeesData  employeesData)
        {
            _employeesData = employeesData;
        }



        //public IActionResult Index()
        //{
        //    List<Employee> list = repository.GetEmployees();
        //    return View(list);
        //}     



        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var res =await _employeesData.SaveEmployee(employee);
            return Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
          //  return await _employeesData.GetAllEmployee();

            var res= await _employeesData.GetAllEmployee();
            return Ok(res);
        }

    }
}
