using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calendar.Services
{
    internal class TaskService
    {
        private TaskManager TaskManager = null;
        private Task CurrentTask = null;
        public TaskService(TaskManager taskManager)
        {
            TaskManager = taskManager;
        }
        public void CreateTask(string name, string description, DateTime start, DateTime end, int currentUserId)
        {
            Task task = new Task(name, description, start, end, currentUserId);
            TaskManager.AddTask(task);
            CurrentTask = task;
        }
        public void SelectTask(Task task)
        {
            CurrentTask = task;
        }
        public void EditTaskTitle(string newTitle) 
        { 
            CurrentTask.Title = newTitle;
            TaskManager.UpdateTask(CurrentTask);
        }
        public void EditTaskDescription(string newDescription)
        {
            CurrentTask.Description = newDescription;
            TaskManager.UpdateTask(CurrentTask);
        }
        public void EditTaskStartTime(DateTime newStartTime)
        {
            CurrentTask.StartTime = newStartTime;
            TaskManager.UpdateTask(CurrentTask);
        }
        public void EditTaskEndTime(DateTime newEndTime)
        {
            CurrentTask.EndTime = newEndTime;
            TaskManager.UpdateTask(CurrentTask);
        }
        public void DeleteTask() 
        {
            TaskManager.RemoveTask(CurrentTask);
            CurrentTask = null;
        }
    }
}
