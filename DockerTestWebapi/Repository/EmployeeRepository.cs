﻿using DockerTestWebapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerTestWebapi.Repository
{
    public class EmployeeRepository : IEmployeesData
    {


        private EmployeeContext dbcontext;



        public EmployeeRepository(EmployeeContext context)
        {
            dbcontext = context;
        }


        public async Task<List<Employee>> GetAllEmployee()
        {
            // return  dbcontext.Employee.ToList();
            return await Task.Run(() => {

                return dbcontext.Employee.ToList();
            });
        }

        public async Task<int> SaveEmployee(Employee employee)
        {

            return await Task.Run(() => {

                dbcontext.Employee.Add(employee);
                return dbcontext.SaveChanges();
            });

           // dbcontext.Employee.Add(employee);
           //return dbcontext.SaveChanges();            
        }
    }
}
