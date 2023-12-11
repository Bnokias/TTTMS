using TTTMS.Models;

namespace TTTMS.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId); // Add this method
        void UpdateEmployee(Employee employee);    // Add this method if not already present
    }

}