using System;
using System.Collections.Generic;

class ToDoTask
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateTime { get; set; }

    public ToDoTask(string name, string description, DateTime dateTime)
    {
        Name = name;
        Description = description;
        DateTime = dateTime;
    }
}

class ToDoList
{
    static void Main(string[] args)
    {
        List<ToDoTask> toDoList = new List<ToDoTask>();

        while (true)
        {
            Console.WriteLine("1. Add task to list");
            Console.WriteLine("2. Remove task from list");
            Console.WriteLine("3. View list");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter task name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter task description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter task due date (yyyy-mm-dd): ");
                    string date = Console.ReadLine();
                    Console.Write("Enter task due time (hh:mm): ");
                    string time = Console.ReadLine();
                    DateTime dateTime = DateTime.Parse(date + " " + time);
                    toDoList.Add(new ToDoTask(name, description, dateTime));
                    Console.WriteLine("Task added!");
                    break;

                case 2:
                    Console.Write("Enter task number to remove: ");
                    int taskNum = int.Parse(Console.ReadLine());
                    toDoList.RemoveAt(taskNum - 1);
                    Console.WriteLine("Task removed!");
                    break;
                case 3:
                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + toDoList[i].Name + " - " + toDoList[i].Description + " - " + toDoList[i].DateTime);
                    }
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
