using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegat_2_
{
    public class Task
    {

        public Task(string title, string desc)
        {
            this.Title = title;
            this.Description = desc;
            this.isCompleted = false;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        private bool isCompleted;

        public bool IsCompleted
        {
            get { return this.isCompleted; }
            set { this.isCompleted = value; }
        }
    }

    public class TaskManager
    {
        public delegate void TaskCompletedEventHandler(Task task);
        public event TaskCompletedEventHandler TaskCompleted;
        public void CompleteTask(Task task)
        {
            task.IsCompleted = true;
            TaskCompleted?.Invoke(task);
        }
    }
    public class TaskNotification
    {
        public void TaskCompletedNotification(Task task)
        {
            Console.WriteLine($"Задача \"{task.Title}\" выполнена!");
        }

    }
}