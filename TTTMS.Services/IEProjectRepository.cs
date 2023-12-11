using TTTMS.Models;

namespace TTTMS.Services
{
    public interface IEProjectRepository
    {
        IEnumerable<Project> GetAllProjects();
        Project GetProjectById(int projectID); // Add this method
        void AddProject(Project project);    // Add this method if not already present
    }

}