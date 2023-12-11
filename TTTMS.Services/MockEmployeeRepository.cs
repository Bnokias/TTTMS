using System;
using System.Collections.Generic;
using System.Linq;
using TTTMS.Models;

namespace TTTMS.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeesList;

        public MockEmployeeRepository()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            _employeesList =
            [
                new Employee(1, "BNokias@cipc.co.za", "Bonolo", "No", "System Administrator", "BISG"),
                new Employee(2, "TestNok@cipc.co.za", "Test", "Nok", "System Manager", "BISG"),
                new Employee(3, "TNB@cipc.co.za", "TNB", "Noki", "Software Engineer", "IT"),
                new Employee(4, "TestNokia@cipc.co.za", "Test1", "Nokia", "Project Manager", "PMO"),
                new Employee(5, "TestNokias@cipc.co.za", "Test2", "Nokias", "QA Analyst", "QA"),
            ];
        }


        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeesList;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _employeesList.FirstOrDefault(e => e.Id == employeeId);
        }

        public void AddEmployee(Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee);

            // Simulate database-generated ID
            employee.Id = _employeesList.Max(e => e.Id) + 1;

            _employeesList.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee);

            var existingEmployee = _employeesList.FirstOrDefault(e => e.Id == employee.Id);

            if (existingEmployee != null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Email = employee.Email;
                existingEmployee.JobTitle = employee.JobTitle;
                existingEmployee.Department = employee.Department;
            }
            else
            {
                throw new InvalidOperationException($"Employee with ID {employee.Id} not found.");
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            var employeeToRemove = _employeesList.FirstOrDefault(e => e.Id == employeeId);

            if (employeeToRemove != null)
            {
                _employeesList.Remove(employeeToRemove);
            }
            else
            {
                throw new InvalidOperationException($"Employee with ID {employeeId} not found.");
            }
        }
    }
}
