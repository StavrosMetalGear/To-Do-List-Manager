using ToDoApp.Models;
using System.Collections.Generic;
namespace ToDoApp.Services
{
    public interface ITaskService
    {
        void AddTask(string description);
        void ListTasks();
        void CompleteTask(int id);
    }
}

