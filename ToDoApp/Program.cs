using System;
using ToDoApp.Services;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITaskService taskService = new TaskService();
            bool running = true;

            Console.WriteLine("Welcome to the To-Do List Manager!");

            while (running)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Tasks");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter task description: ");
                        string? desc = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(desc))
                            taskService.AddTask(desc);
                        else
                            Console.WriteLine("Description cannot be empty.\n");
                        break;

                    case "2":
                        taskService.ListTasks();
                        break;

                    case "3":
                        Console.Write("Enter task ID to complete: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                            taskService.CompleteTask(id);
                        else
                            Console.WriteLine("Invalid ID.\n");
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.\n");
                        break;
                }
            }
        }
    }
}

