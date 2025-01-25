using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHRMS
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<EmployeeTask> Tasks { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            Tasks = new List<EmployeeTask>();
        }

        public void AssignTask(EmployeeTask task)
        {
            Tasks.Add(task);
            Console.WriteLine($"Task '{task.Description}' assigned to {Name}.");
        }

        public void DisplayTasks()
        {
            Console.WriteLine($"\nTasks for {Name}:");
            foreach (var task in Tasks)
            {
                task.DisplayTask();
            }
        }
    }
}
