using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFExample
{
    public static class DepartmentBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DeptId = 1,
                    DeptName = "CSE",
                    DeptLocation = "Hyderabad",
                    DeptManager = "PadmaRaju Sir"
                }
                );

        }
    }
}
