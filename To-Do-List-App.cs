using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    class Program
    {
        //Collecting all the tasks
        static List<string> tasks = new List<string>();
        static void Main(string[] args)
        {
            //Boolean for running the loop 
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("This is my To-Do List Application");
                Console.WriteLine("1. Add a new task");
                Console.WriteLine("2. View all tasks");
                Console.WriteLine("3. Mark task as complete");
                Console.WriteLine("4. Delete a task");
                Console.WriteLine("5. Exit");
                Console.Write("Choose a option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": AddTask(); break;
                    case "2": ViewTask(); break;
                    case "3": CompleteTask(); break;
                    case "4": DeleteTask(); break;
                    case "5": Console.WriteLine("You exited!"); running = false; break;

                }
            }
        }
        static void AddTask()
        {
            Console.Write("Add a new task: ");
            string task = Console.ReadLine();
            tasks.Add(task); // Adding the task
            Console.WriteLine("Task added! Press any key to continue...");
            Console.ReadKey(); //Waiting the usser to press a key
        }
        static void ViewTask()
        {
            Console.WriteLine("Your current tasks:");
            //Walking through every task
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}"); //Displaying all the tasks
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void CompleteTask()
        {
            ViewTask(); //Displaying the tasks
            Console.Write("Enter a number of task to mark as complete: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber <= tasks.Count && taskNumber > 0)
            {
                //if the number is valid mark as complete
                tasks[taskNumber - 1] += " (completed)";
                Console.WriteLine("Task marked as complete! Press any key to continue...");
            }
            else
            {
                Console.WriteLine("Invalid number! Press any key to continue...");
            }
            Console.ReadKey();
        }
        static void DeleteTask()
        {
                viewDeletedTasks();
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber <= tasks.Count && taskNumber > 0)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task deleted! Press any key to continue...");
            }
            else
            {
                Console.WriteLine("Invalid number! Press any key to continue...");
            }
            Console.ReadKey();
        }
        static void viewDeletedTasks()
        {
            Console.Write("Choose task to remove: ");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}"); //Displaying all the tasks
            }
        }

    }
}
