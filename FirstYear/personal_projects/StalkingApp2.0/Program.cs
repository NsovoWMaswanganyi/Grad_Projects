/*
Nsovo W. Maswanganyi
Exit 0

This program, as unethical as it may sound, was written so i could check who in my first-year programming class had passed or not( I was bored what do you expect from a 2 month summer break).
A lot is going on here, so i don't expect anyone to read and understand this code.
I don't think I'll be able to understand it myself after a few months(I whipped it in less than 3 hours).

The varibles and the names of other properties are supposed to be changed(I hope I do this before you can see the mess)
because there was a lot of trial and error and the original idea changed while i was coding. So yeah, some of the names you see here
will need you to have some superpowers to understand what they are doing


With that said, if you can read it and understand it, be sure to comment on where I could've done better
I only wrote this code for a single purpose - for it TO RUN!

But if you don't care too much to understand it, but just want to use it to stalk your fellow classmates,
here are a few things you must do:

- Provide the program with your list of current and previous period students(I've used text files for this - look for ...txt in my code)
- Make sure the location of the txt files are located in the correct directory; i.e inside "bin/Debug/here.txt"
- RUN IT!

Future Plans for the Stalking App
Well, so far this app is just a console app, so I'm thinking of writing another program, but in Django this time,
so i can see the data on the web.

So yeah, Good Luck!!
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using static System.Console;

namespace StalkingApp
{

    class Program
    {
        const int PreviousSize = 270;
        const int CurrentSize = 300;
        const int FailedPrevSize = 300;
        readonly string[] PreviousStudents = new string[PreviousSize];
        readonly string[] CurrentStudents = new string[CurrentSize];
        readonly string[] FailedPreviousStudents = new string[FailedPrevSize];
        readonly string[] FailedStudentsinCurrentLevel = new string[FailedPrevSize];
        readonly string[] PassedPreviousStudents = new string[PreviousSize];

        static void Main(string[] args)
        {
            Program program = new Program();
            program.ReadData();

            WriteLine("Displaying Data");
            program.DisplayData();
        }

        void DisplayData()
        {
            bool FoundFailed, founds;
            int ff = 0, fs = 0, p = 0;

            WriteLine();
            WriteLine("Students That Passed");
            WriteLine();
            for (int i = 0; i < PreviousStudents.Length; i++)
            {
                if (!string.IsNullOrEmpty(PreviousStudents[i]))
                {
                    FoundFailed = false;
                    for (int j = 0; j < CurrentStudents.Length; j++)
                    {
                        if (!string.IsNullOrEmpty(CurrentStudents[j]) && PreviousStudents[i] == CurrentStudents[j])
                        {
                            PassedPreviousStudents[p] = PreviousStudents[i];
                            p++;
                            WriteLine(PreviousStudents[i]);
                            FoundFailed = true;
                            break;
                        }
                    }
                    if (!FoundFailed)
                    {
                        FailedPreviousStudents[ff] = PreviousStudents[i];
                        ff++;
                    }
                }
            }

            for (int i = 0; i < CurrentStudents.Length; i++)
            {
                if (!string.IsNullOrEmpty(CurrentStudents[i]))
                {
                    founds = false;
                    for (int j = 0; j < PassedPreviousStudents.Length; j++)
                    {
                        if (!string.IsNullOrEmpty(CurrentStudents[i]) && CurrentStudents[i] == PassedPreviousStudents[j])
                        {
                            founds = true;
                            break;
                        }
                    }
                    if (!founds)
                    {
                        FailedStudentsinCurrentLevel[fs] = CurrentStudents[i];
                        fs++;
                    }
                }
            }

            WriteLine();
            WriteLine("Students that failed");
            WriteLine();
            if (ff == 0)
            {
                WriteLine("No students failed");
            }
            else
            {
                WriteLine($"IN FIRST YEAR: {FailedPreviousStudents.Length} "); WriteLine();
                for (int i = 0; i < FailedPreviousStudents.Length; i++)
                {
                    if (!string.IsNullOrEmpty(FailedPreviousStudents[i]))
                    {
                        WriteLine(FailedPreviousStudents[i]);
                    }
                }
                WriteLine();
                WriteLine($"IN SECOND YEAR: {FailedStudentsinCurrentLevel.Length} "); WriteLine();
                for (int i = 0; i < FailedStudentsinCurrentLevel.Length; i++)
                {
                    if (!string.IsNullOrEmpty(FailedStudentsinCurrentLevel[i]))
                    {
                        WriteLine(FailedStudentsinCurrentLevel[i]);
                    }
                }
            }
            ReadLine();
        }
        void ReadData()
        {
            int s = 0, b = 0;
            StreamReader PreviousReader = new StreamReader("previous.txt");
            StreamReader CurrentReader = new StreamReader("current.txt");

            string PreviousLine = PreviousReader.ReadLine();
            string CuurentLine = CurrentReader.ReadLine();

            while (PreviousLine != null && s < PreviousSize)
            {
                PreviousStudents[s] = PreviousLine.ToLower();
                s++;
                PreviousLine = PreviousReader.ReadLine();
            }
            PreviousReader.Close();

            while (CuurentLine != null && b < CurrentSize)
            {
                CurrentStudents[b] = CuurentLine.ToLower();
                b++;
                CuurentLine = CurrentReader.ReadLine();
            }
            CurrentReader.Close();
        }
    }
}
