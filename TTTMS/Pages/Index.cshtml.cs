using Microsoft.AspNetCore.Mvc.RazorPages;
using TTTMS.Models;
using TTTMS.Services;
using System.Collections.Generic;

namespace TTTMS.Pages
{
    public class IndexModel(IEmployeeRepository employeeRepository) : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository = employeeRepository;

        public IEnumerable<Employee> Employees { get; set; }

        public void OnGet()
        {
            Employees = _employeeRepository.GetAllEmployees();
        }
    }
}
