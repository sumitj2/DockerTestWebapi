using DockerTestWebapi.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerTestWebapi.Repository
{
   
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstring = "Server=tcp:employeeserver22.database.windows.net,1433;Initial Catalog=Employee;Persist Security Info=False;User ID=dbadmin;Password='tester@12345';";// GetConnectionString().GetAwaiter().GetResult();

            optionsBuilder.UseSqlServer(connstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasData(
            //    new Employee { Id = 1, Name = "James A", Surname = "james", Address = "Badlapur" },
            //    new Employee { Id = 2, Name = "Malcolm B", Surname = "jagtap", Address = "Airoli" }
            //    );
        }

        //private async Task<string> GetConnectionString()
        //{
            

        //    return secret.Value;
        //}
    }
}
