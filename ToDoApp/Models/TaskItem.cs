﻿

namespace ToDoApp.Models
{
    internal class TaskItem
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public bool IsCompleted { get; set; } = false;
    }
}
