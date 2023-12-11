using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TTTMS.Models;
using TTTMS.Pages;
using TTTMS.Services;

namespace TTTMS.Pages
{
    public class ProjectsModel(IEProjectRepository projectRepository) : PageModel
    {
        private readonly IEProjectRepository _projectRepository = projectRepository;

        public IEnumerable<Project> Project { get; set; }
        public void OnGet()
        {
            Project = _projectRepository.GetAllProjects();
        }
    }
}

