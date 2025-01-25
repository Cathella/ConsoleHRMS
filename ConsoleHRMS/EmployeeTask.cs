using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHRMS
{
    internal class EmployeeTask
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public DateTime AssignedDate { get; set; }

        public EmployeeTask(int taskId, string description)
        {
            TaskId = taskId;
            Description = description;
            AssignedDate = DateTime.Now;
        }

        public void DisplayTask()
        {
            Console.WriteLine($"Task ID: {TaskId}, Description: {Description}, Assigned Date: {AssignedDate}");
        }
    }
}
