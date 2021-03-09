using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockEmployeeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Mary", Department = "HR", Email = "Mary@blahblah.com"},
                new Employee() {Id = 2, Name = "john", Department = "IT", Email = "John@blahblah.com"},
                new Employee() {Id = 3, Name = "mike", Department = "IT", Email = "mike@blahblah.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
