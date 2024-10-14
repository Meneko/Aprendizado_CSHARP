
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace taskManager{
    public static class taskManager
    { 
        struct task
        {
            public int id;
            public string content;
            public bool done;
        }

        private static task[] tasks = new task[100];

        public static void addTask(int taskID, string taskContent)
        {
            tasks[taskID] = new task { id = taskID, content = taskContent, done = false};
            System.Console.WriteLine("Task added succesfully!\n");
        }

        public static void removeTask(int taskID)
        {
            if (tasks[taskID].content.Length <= 0)
            {
                System.Console.WriteLine("Task not found!\n");
            }
            tasks[taskID] = new task { id = 0, content = null, done = false };
            System.Console.WriteLine("Task removed succesfully!\n");
        }

        public static void listTask()
        {
            for (int taskID = 1 ; taskID <= tasks.Length; ++taskID) 
            {
                if (tasks[taskID].content.Length >= 1) 
                {
                    task actualTask = tasks[taskID];
                    System.Console.WriteLine($"{actualTask.id} {actualTask.content} {actualTask.done}");
                }
            }
        }

        public static void doneTask(int taskID)
        {
            tasks[taskID].done = true;
        }
    }
}

namespace Aprendizado_C
{
    class Program
    { 
        static void Main(string[] args) 
        {
            System.Console.WriteLine("This a task manager program in C#.\n");
            int taskIdTracker = 1;
            while (true) 
            {
                System.Console.WriteLine("Type 'add' to add a task, 'remove' to remove a task,");
                System.Console.Write("'done' to mark a task as done and 'exit' to exit: ");
                string option = System.Console.ReadLine();
                option = option.ToLower();
                System.Console.WriteLine(option);

                if (option != "add" && option != "remove" && option != "done" && option != "exit") 
                {
                    continue;
                }

                switch (option) 
                {
                    case "add": 
                        {
                            System.Console.Write("Enter the task content: ");
                            taskManager.taskManager.addTask(taskIdTracker, System.Console.ReadLine());
                            break;
                        }
                    case "remove": 
                        {
                            System.Console.WriteLine("Enter the task ID to remove: ");
                            int taskID = Convert.ToInt32(System.Console.ReadLine());
                            taskManager.taskManager.removeTask(taskID);
                            break;
                        }
                    case "done": 
                        {
                            System.Console.WriteLine("Enter the task ID to mark as done: ");
                            int taskID = Convert.ToInt32(System.Console.ReadLine());
                            taskManager.taskManager.doneTask(taskID);
                            break;
                        }
                    case "exit":
                        {
                            System.Console.WriteLine("Exiting the program...");
                            return;
                        }
                    default: 
                        { 
                            System.Console.WriteLine("Invalid option!\n");
                            break;
                        }
                }
                taskManager.taskManager.listTask();
            }
        }
    }
}