using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTTMS.Models;

namespace TTTMS.Services
{
    public interface IETaskRepository
    {
        IEnumerable<ETask> GetAllTasks();
        ETask GetTaskById(int taskId); // Add this method
        
    }
}
