using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO;

    public interface ITaskOperation
{
        public List<Task> GetAllTask();
        public Task CreateTask(Task task);
        public Task UpdateTask(Task task);
        public bool DeleteTask(int taskId);
    }

