using ConsoleHRMS;
using System;
using System.Collections.Generic;

class Program
{
    static List<Employee> employees = new List<Employee>();
    static int taskIdCounter = 1;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n === Employee Task Manager === ");
            Console.WriteLine("1. Register an Employee");
            Console.WriteLine("2. View Number of Employees");
            Console.WriteLine("3. Assign Task to Employee");
            Console.WriteLine("4. Display Tasks of an Employee");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterEmployee();
                    break;
                case "2":
                    ViewEmployeeCount();
                    break;
                case "3":
                    AssignTask();
                    break;
                case "4":
                    DisplayEmployeeTasks();
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }

    static void RegisterEmployee()
    {
        Console.Write("Enter Employee ID: ");
        string? idInput = Console.ReadLine();
        if (!int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Invalid input for Employee ID. Please enter a valid number.");
            return;
        }

        Console.Write("Enter Employee Name: ");
        string? name = Console.ReadLine();
        if (string.IsNullOrEmpty(name)) 
        {
            Console.WriteLine("Employee name cannot be empty.");
            return;
        }

        Employee newEmployee = new Employee(id, name);
        employees.Add(newEmployee);

        Console.WriteLine($"Employee {name} registered successfully.");
    }

    static void ViewEmployeeCount()
    {
        Console.WriteLine($"Total number of employees: {employees.Count}");
    }

    static void AssignTask()
    {
        Console.Write("Enter Employee ID to assign a task: ");
        string? idInput = Console.ReadLine();
        if (!int.TryParse(idInput, out int id)) 
        {
            Console.WriteLine("Invalid input for Employee ID. Please enter a valid number.");
            return;
        }

        Employee? employee = employees.Find(e => e.Id == id);
        if (employee != null)
        {
            Console.Write("Enter the task description: ");
            string? description = Console.ReadLine();
            if (string.IsNullOrEmpty(description))
            {
                Console.WriteLine("Task description cannot be empty.");
                return;
            }

            EmployeeTask task = new EmployeeTask(taskIdCounter++, description);
            employee.AssignTask(task);
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    static void DisplayEmployeeTasks()
    {
        Console.Write("Enter Employee ID to view tasks: ");
        string? idInput = Console.ReadLine();
        if (!int.TryParse (idInput, out int id))
        {
            Console.WriteLine("Invalid input for Employee ID. Please enter a valid number.");
            return;
        }

        Employee? employee = employees.Find(e => e.Id == id);
        if (employee != null)
        {
            employee.DisplayTasks();
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}
