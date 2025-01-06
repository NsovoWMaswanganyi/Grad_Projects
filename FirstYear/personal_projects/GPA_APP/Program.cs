using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace GPA_APP
{
    internal class Program
    {
        const int QUIT = 0;
        static void Main(string[] args)
        {
            MinutesManager list = new MinutesManager();
            int choice;
            do
            {
                choice = Menu();

                switch (choice)
                {
                    case 1:
                        {
                            AddMinutes(list);
                        }
                        break;

                    case 2:
                        {
                            DisplayMinutesFromList(list);
                        }
                        break;

                    case QUIT:
                        {
                            WriteLine("Exiting the program!");
                        }
                        break;

                    default:
                        {
                            WriteLine("There was an error somewhere");
                        }
                        break;
                }
                list.WriteMinutes();
            } while (choice!=QUIT);
        }

        static int Menu()
        {
            WriteLine("What would you like to do? Enter 0 to quit!");
            WriteLine("1. Add Minutes.");
            WriteLine("2. Display Minutes");
            WriteLine("Enter your choice, 0 to quit!");
            int choice = int.Parse(ReadLine());
            return choice;
        }
        
        static void AddMinutes(MinutesManager list)
        {
            WriteLine("You are about to add minutes for the whole academic week!");
            Write("Enter Marks for Business Functions: ");
            double eb = double.Parse(ReadLine());

            Write("Enter Marks for Economics: ");
            double ecc = double.Parse(ReadLine());

            Write("Enter Marks for Maths: ");
            double mats = double.Parse(ReadLine());

            Write("Enter Marks for Accounting: ");
            double rncv = double.Parse(ReadLine());

            Write("Enter Marks for Programming: ");
            double av = double.Parse(ReadLine());

            Write("Enter Marks for Computing Fundamentals: ");
            double fv = double.Parse(ReadLine());

            Minutes newMin = new Minutes(eb, ecc, mats, rncv, av, fv);
            list.AddMinutes(newMin);
        }
        static void DisplayMinutesFromList(MinutesManager list)
        {
            list.DisplayMinutes();
        }
    }
}
