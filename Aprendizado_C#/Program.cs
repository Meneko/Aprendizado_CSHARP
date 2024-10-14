
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
            tasks[taskID] = new task { id = -1, content = null, done = false };
        }

        private static void listTask(int taskQuantity)
        {
            for (int taskID = 0 ; taskID <= taskQuantity; ++taskID) 
            { 
                if (tasks[taskID].id != -1) 
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
            taskIdTracker
            while (true) 
            {
                System.Console.WriteLine("Type 'add' to add a task, 'remove' to remove a task,");
                System.Console.Write("and 'done' to mark a task as done: ");
                string option = System.Console.ReadLine();
                switch (option) 
                {
                    case "add": 
                        {
                            System.Console.Write("Enter the task content");
                            taskManager.taskManager.addTask()
                            break;
                        }
                    case "remove": 
                        {
                            break;
                        }
                    case "done": 
                        {
                            break;
                        }
                    default: 
                        { 
                            System.Console.WriteLine("Invalid option!\n");
                            break;
                        }
                }
            }
        }
    }
}