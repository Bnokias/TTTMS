using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using TTTMS.Models;
using TTTMS.Services;

public class EditEmployeeModel : PageModel
{
    private readonly IEmployeeRepository _employeeRepository;

    [BindProperty]
    public Employee Employee { get; set; }

    public EditEmployeeModel(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public IActionResult OnGet(int id)
    {
        Employee = _employeeRepository.GetEmployeeById(id);

        if (Employee == null)
        {
            return NotFound();
        }

        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _employeeRepository.UpdateEmployee(Employee);
        return RedirectToPage("/Index");
    }
}
