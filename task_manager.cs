using System;
using System.Collections.Generic;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new list to store tasks
            List<string> tasks = new List<string>();

            while (true)
            {
                // Display options to the user
                Console.WriteLine("Task Manager");
                Console.WriteLine("1. Add task");
                Console.WriteLine("2. View tasks");
                Console.WriteLine("3. Exit");

                // Get the user's choice
                int choice = int.Parse(Console.ReadLine());

                // Perform the chosen action
                if (choice == 1)
                {
                    Console.WriteLine("Enter a new task:");
                    string newTask = Console.ReadLine();
                    tasks.Add(newTask);
                    Console.WriteLine("Task added!");
                }
                else if (choice == 2)
                {
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks to display.");
                    }
                    else
                    {
                        Console.WriteLine("Tasks:");
                        foreach (string task in tasks)
                        {
                            Console.WriteLine("- " + task);
                        }
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}

