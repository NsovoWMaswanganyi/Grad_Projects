using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace To_Do_List
{
    internal class Program
    {
        static void Main()
        {
            string[] todoList = new string[10];
            int nrEl = 0, choice;
            do
            {
                choice = DisplayOptions();
                switch (choice)
                {
                    case 1:
                        AddTask(todoList, ref nrEl);
                        break;

                    case 2:
                        DisplayTasks(todoList, nrEl);
                        break;

                    case 3:
                        RemoveTask(todoList, ref nrEl);
                        break;

                    case 4:
                        Write("Exiting the program...Press ENTER to leave!");
                        break;

                    default:
                        WriteLine("Error!! Try again");
                        break;
                }
            } while (choice != 4);
            ReadLine();
        }
        static int DisplayOptions()
        {
            WriteLine("Menu:");
            WriteLine("1. Add Task");
            WriteLine("2. Display Tasks");
            WriteLine("3. Remove task");
            WriteLine("4. Quit");
            WriteLine();
            Write("Enter your choice: ");
            int choice = int.Parse(ReadLine());
            return choice;
        }
        static void AddTask(string[] todoList, ref int nrEl)
        {
            if (nrEl >= todoList.Length)
            {
                Write("The list is full");
                WriteLine();
            }
            else
            {
                Write("Enter the task to add: ");
                string task = ReadLine();
                task = task.ToLower();
                todoList[nrEl] = task;
                WriteLine("The task has been added successfully");
                nrEl++;
                WriteLine();
            }
        }

        static void DisplayTasks(string[] todoList, int nrEl)
        {
            if (nrEl == 0)
            {
                WriteLine("No tasks found. Consider addidng some task to the list");
                WriteLine();
            }
            else
            {
                WriteLine();
                WriteLine("Tasks:");
                for (int i = 0; i < nrEl; i++)
                {
                    WriteLine($"{i + 1}. {todoList[i]}");
                }
                WriteLine();
            }
        }
        static void RemoveTask(string[] todoList, ref int nrEl)
        {
            if (nrEl == 0)
            {
                WriteLine("No tasks to delete.");
            }
            else
            {
                Write("Enter the task to delete: ");
                string task = ReadLine();
                task = task.ToLower();
                int position = FindTask(todoList, nrEl, task);

                if (position >= 0)
                {
                    for (int i = position; i < nrEl - 1; i++)
                    {
                        todoList[i] = todoList[i + 1];
                    }
                    nrEl--;
                    WriteLine("Task has been Deleted from the list");
                    WriteLine();
                }
                else
                {
                    WriteLine("Task is not found in the list");
                    WriteLine();
                }
            }
        }
        static int FindTask(string[] todoList, int nrEl, string wanted)
        {
            int i = 0;
            bool found = false;
            while (!found && i < nrEl)
            {
                if (todoList[i] == wanted)
                {
                    found = true;
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}
