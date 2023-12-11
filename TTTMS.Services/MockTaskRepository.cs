using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTTMS.Models;

namespace TTTMS.Services
{
    public class MockTaskRepository : IETaskRepository
    {
        private List<ETask> _taskList;

        public MockTaskRepository()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            _taskList =
            [
                new ETask (1,1,"Complete ERD","Identify classes and their attributes","Not Started",1.5,0.0),
            ];
        }

        public IEnumerable<ETask> GetAllTasks()
        {
            return _taskList;
        }

        public ETask GetTaskById(int taskId)
        {
            return _taskList.FirstOrDefault(t => t.TaskID == taskId);
        }

    }

}
