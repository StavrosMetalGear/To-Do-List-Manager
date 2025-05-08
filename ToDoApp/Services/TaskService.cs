// Services/TaskService.cs

using ToDoApp.Models;
using System;
using System.Collections.Generic;

namespace ToDoApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly List<TaskItem> _tasks = new();
        private int _nextId = 1;

        public void AddTask(string description)
        {
            _tasks.Add(new TaskItem { Id = _nextId++, Description = description });
            Console.WriteLine("Task added successfully.\n");
        }

        public void ListTasks()
        {
            if (_tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.\n");
                return;
            }

            Console.WriteLine("Your Tasks:");
            foreach (var task in _tasks)
            {
                string status = task.IsCompleted ? "[Completed]" : "[Pending]";
                Console.WriteLine($"{task.Id}. {task.Description} {status}");
            }
            Console.WriteLine();
        }

        public void CompleteTask(int id)
        {
            var task = _tasks.Find(t => t.Id == id);
            if (task == null)
            {
                Console.WriteLine("Task not found.\n");
                return;
            }

            task.IsCompleted = true;
            Console.WriteLine("Task marked as completed.\n");
        }
    }
}