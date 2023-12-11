using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TTTMS.Models;
using TTTMS.Services;

public class AddProjectModel(IEProjectRepository projectRepository) : PageModel
{
    private readonly IEProjectRepository _projectRepository = projectRepository;

    [BindProperty]
    public Project Project { get; set; }

    public void OnGet()
    {
        // Optional: Any logic to perform when the page is initially loaded
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Save the project using the repository
        _projectRepository.AddProject(Project);
        Console.WriteLine("Saved to projects");

        return RedirectToPage("/Projects"); // Redirect to the Projects page after saving
    }
}
