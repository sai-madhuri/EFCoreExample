using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace EFExample.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class EmployeeController : Microsoft.AspNetCore.Mvc.ControllerBase
        {
            public IEmployeeService EmployeeService { get; set; }

            public EmployeeController(IEmployeeService ConnectionService)
            {
                this.EmployeeService = ConnectionService;
            }

            [HttpGet("{id}")]
            public List<Employee> Get(int id)
            {
                return this.EmployeeService.DisplayEmployee(id);
            }

            [Route("addConnection")]
            public void AddEmployee()
            {
                this.EmployeeService.AddEmployee();
            }
        }
    }
