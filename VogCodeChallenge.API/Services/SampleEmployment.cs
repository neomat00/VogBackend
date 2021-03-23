using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Services
{
    public class SampleEmployment : IEmployeeService
    {
        private IList<Employee> _employees;

        private IList<Department> _departments;

        public SampleEmployment()
        {
            _departments = new List<Department>
            {
                new Department { Name = "Hr", Address = "TEST1", Id = 1},
                new Department { Name = "Dev", Address = "TEST2", Id = 2},
                new Department { Name = "Pr", Address = "TEST3", Id = 3}
            };
            _employees = new List<Employee>
            {
                new Employee { FirstName = "Test1FN", LastName = "Test1LN", Address = "Test1A", Department = _departments[0]},
                new Employee { FirstName = "Test2FN", LastName = "Test2LN", Address = "Test2A", Department= _departments[1] },
                new Employee { FirstName = "Test3FN", LastName = "Test3LN", Address = "Test3A", Department = _departments[2]},
            };

        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public IList<Employee> ListAll()
        {
            return _employees;
        }
    }
}
