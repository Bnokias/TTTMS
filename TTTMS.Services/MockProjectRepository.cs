using System;
using System.Collections.Generic;
using System.Linq;
using TTTMS.Models;

namespace TTTMS.Services
{
    public class MockProjectRepository : IEProjectRepository
    {
        private List<Project> _projectList;

        public MockProjectRepository()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            _projectList =
            [
                new Project (1, "Bizportal", "Develop the bizportal System", "01-01-2001", "01-01-2002", "Completed", "High"," Onke Mzondo"),
            ];
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _projectList;
        }

        public Project GetProjectById(int projectId)
        {
            return _projectList.FirstOrDefault(p => p.ProjectID == projectId);
        }

        public void AddProject(Project project)
        {
            ArgumentNullException.ThrowIfNull(project);

            // Simulate database-generated ID
            project.ProjectID = _projectList.Max(p => p.ProjectID) + 1;

            _projectList.Add(project);
        }

        public void UpdateProject(Project project)
        {
            var existingProject = _projectList.FirstOrDefault(p => p.ProjectID == project.ProjectID);

            if (existingProject != null)
            {
                // Implement logic to update the project
                existingProject.ProjectName = project.ProjectName;
                // Update other properties as needed
            }
            else
            {
                throw new InvalidOperationException($"Project with ID {project.ProjectID} not found.");
            }
        }

        public void DeleteProject(int projectId)
        {
            var projectToRemove = _projectList.FirstOrDefault(p => p.ProjectID == projectId);

            if (projectToRemove != null)
            {
                _projectList.Remove(projectToRemove);
            }
            else
            {
                throw new InvalidOperationException($"Project with ID {projectId} not found.");
            }
        }

        public void UpdateProject(Employee employee)
        {
            throw new NotImplementedException();
        }
    }

}
