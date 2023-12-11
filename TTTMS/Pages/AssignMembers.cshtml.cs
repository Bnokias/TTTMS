using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TTTMS.Models;
using TTTMS.Services;
using System.Collections.Generic;
using System.Linq;

namespace TTTMS.Pages
{
    public class AssignMembersModel(IEmployeeRepository employeeRepository, IEProjectRepository projectRepository) : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository = employeeRepository;
        private readonly IEProjectRepository _projectRepository = projectRepository;

        public List<Employee> Employees { get; set; }
        public List<Project> Projects { get; set; }

        public IActionResult OnGet()
        {
            Employees = _employeeRepository.GetAllEmployees().ToList();
            Projects = _projectRepository.GetAllProjects().ToList();
            return Page();
        }

        public IActionResult OnPostAssign(string employeeId, string projectId, string assignedGroup)
        {
            if (string.IsNullOrEmpty(assignedGroup))
            {
                throw new ArgumentException($"'{nameof(assignedGroup)}' cannot be null or empty.", nameof(assignedGroup));
            }

            ArgumentNullException.ThrowIfNull(employeeId);

            // Implement logic to assign the employee to the project with the specified group
            // You can use the employeeId and projectId to identify the employee and project
            // and update their AssignedGroup properties.


            return RedirectToPage("AssignMembers");
        }
    }
}
