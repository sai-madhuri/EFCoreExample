using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFExample
{
    public interface IEmployeeService
    {
        List<Employee> DisplayEmployee(int id);

        void AddEmployee();
    }
}
