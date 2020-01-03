using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFExample
{
    public class EmployeeService : IEmployeeService
    {
       
        public void AddEmployee()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                var employee = new Employee { Name = "Madhuri", FullName="Madhuri Chunduri" };
                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }

        public List<Employee> DisplayEmployee(int id)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                var employees = db.Employees
                    .Where(b => b.Id == id)
                    .ToList();
                return employees;
            }
        }
    }
}
