// See https://aka.ms/new-console-template for more information
using delegat_2_;

Console.WriteLine("Hello, World!");
TaskManager taskManager = new TaskManager();

TaskNotification notification = new TaskNotification();
taskManager.TaskCompleted += notification.TaskCompletedNotification;

// Добавляем задачи
delegat_2_.Task task1 = new delegat_2_.Task("Задача1","Сложная");
delegat_2_.Task task2 = new delegat_2_.Task("Задача2", "Легкая");
taskManager.CompleteTask(task1);
taskManager.CompleteTask(task2);