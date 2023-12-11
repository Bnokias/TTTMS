using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TTTMS.Models;
using TTTMS.Services;

namespace TTTMS.Pages
{
    public class TasksModel(IETaskRepository taskRepository) : PageModel
    {
        private readonly IETaskRepository _taskRepository = taskRepository;

        public IEnumerable<ETask> ETask { get; set; }

        public void OnGet()
        {
            ETask = _taskRepository.GetAllTasks();
        }
      
    }
}
