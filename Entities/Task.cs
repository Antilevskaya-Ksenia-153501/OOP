using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calendar
{
    internal class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TaskId { get; private set; }
        public int UserId { get; private set; }
        public Task(string title, string description, DateTime startTime, DateTime endTime, int userId)
        {
            Title = title;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            TaskId = title.GetHashCode();
            UserId = userId;
        }
    }
}
