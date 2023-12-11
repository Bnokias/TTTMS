namespace TTTMS.Models
{
    public class Project
    {
        // Parameterless constructor
        public Project()
        {
        }

        public Project (int projectId, string projectName, string projectDescription, string startDate, string endDate, string status , string priority,string projectManager)
        {
            ProjectID = projectId;
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            Priority = priority;
            ProjectManager = projectManager;

        }

        public int ProjectID { get; set; } // Add a public setter for the Id property

        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Status { get; set; }

        public string Priority { get; set; }

        public string ProjectManager { get; set; }
        public string AssignedGroup { get; set; }
    }

}
