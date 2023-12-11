namespace TTTMS.Models
{
    public class ETask(int taskId, int projectId, string taskName, string taskDescription, string taskStatus, double taskDuration, double overTime)
    {
        public int TaskID { get; set; } = taskId;

        public int ProjectID { get; set; } = projectId;
        public string TaskName { get; set; } = taskName;
        public string TaskDescription { get; set; } = taskDescription;
        public string TaskStatus { get; set; } = taskStatus;
        public double TaskDuration { get; set; } = taskDuration;

        public double OverTime { get; set; } = overTime;
    }

}
