using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        //GET: api/Employees/
        [HttpGet("api/employees")]
        public IActionResult List()
        {
            return Ok(_employeeService.ListAll());
        }


        // GET: api/Employees/{Id}
        [HttpGet("api/employees/department/{departmentId}")]
        public IActionResult GetForFilter(string departmentId)
        {
            return Ok(_employeeService.ListAll().Where(ee => ee.Department.Address == departmentId));
        }
    }
}
