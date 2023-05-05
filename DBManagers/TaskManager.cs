using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calendar
{
    internal class TaskManager
    {
        private List<Task> tasks = new List<Task>();
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        public void UpdateTask(Task updatedTask)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].TaskId == updatedTask.TaskId)
                {
                    tasks[i] = updatedTask;
                    break;
                }
            }
        }
        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }
        public void RemoveAllTasksOfUser(int userId)
        {
            foreach (Task task in tasks)
            {
                if (task.UserId == userId)
                { 
                    tasks.Remove(task);
                }
            }
        }
    }
}
