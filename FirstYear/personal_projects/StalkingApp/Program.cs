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
        const int sSIZE = 270;
        const int bSIZE = 60;
        const int ffSIZE = 50;
        readonly string[] SouthStudents = new string[sSIZE];
        readonly string[] BITStudents = new string[bSIZE];
        readonly string[] FailedFStudents = new string[ffSIZE];
        readonly string[] FailedSStudents = new string[ffSIZE];
        readonly string[] PassedFStudents = new string[sSIZE];

        static void Main(string[] args)
        {
            Program program = new Program();
            program.ReadData();

            WriteLine("Displaying Data");
            program.DisplayData();
        }

        void DisplayData()
        {
            bool foundf, founds;
            int ff = 0, fs = 0, p = 0;

            WriteLine();
            WriteLine("Students That Passed");
            WriteLine();
            for (int i = 0; i < SouthStudents.Length; i++)
            {
                if (!string.IsNullOrEmpty(SouthStudents[i]))
                {
                    foundf = false;
                    for (int j = 0; j < BITStudents.Length; j++)
                    {
                        if (!string.IsNullOrEmpty(BITStudents[j]) && SouthStudents[i] == BITStudents[j])
                        {
                            PassedFStudents[p] = SouthStudents[i];
                            p++;
                            WriteLine(SouthStudents[i]);
                            foundf = true;
                            break;
                        }
                    }
                    if (!foundf)
                    {
                        FailedFStudents[ff] = SouthStudents[i];
                        ff++;
                    }
                }
            }

            for (int i = 0; i < BITStudents.Length; i++)
            {
                if (!string.IsNullOrEmpty(BITStudents[i]))
                {
                    founds = false;
                    for (int j = 0; j < PassedFStudents.Length; j++)
                    {
                        if (!string.IsNullOrEmpty(BITStudents[i]) && BITStudents[i] == PassedFStudents[j])
                        {
                            founds = true;
                            break;
                        }
                    }
                    if (!founds)
                    {
                        FailedSStudents[fs] = BITStudents[i];
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
                WriteLine("IN FIRST YEAR: "); WriteLine();
                for (int i = 0; i < FailedFStudents.Length; i++)
                {
                    if (!string.IsNullOrEmpty(FailedFStudents[i]))
                    {
                        WriteLine(FailedFStudents[i]);
                    }
                }
                WriteLine();
                WriteLine("IN SECOND YEAR: "); WriteLine();
                for (int i = 0; i < FailedSStudents.Length; i++)
                {
                    if (!string.IsNullOrEmpty(FailedSStudents[i]))
                    {
                        WriteLine(FailedSStudents[i]);
                    }
                }
            }
            ReadLine();
        }
        void ReadData()
        {
            int s = 0, b = 0;
            StreamReader SouthReader = new StreamReader("first.txt");
            StreamReader BITReader = new StreamReader("second.txt");

            string sLine = SouthReader.ReadLine();
            string bLine = BITReader.ReadLine();

            while (sLine != null && s < sSIZE)
            {
                SouthStudents[s] = sLine.ToLower();
                s++;
                sLine = SouthReader.ReadLine();
            }
            SouthReader.Close();

            while (bLine != null && b < bSIZE)
            {
                BITStudents[b] = bLine.ToLower();
                b++;
                bLine = BITReader.ReadLine();
            }
            BITReader.Close();
        }
    }
}
