using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GPA_APP
{
    internal class Marks
    {
        static void YRLYgpa()
        {
            double MATS102 = 0, RNCV112 = 0, WRFV102 = 0, WRAV102 = 0, EB122 = 0, ECC102 = 0;
            double tmin = MATS102 + RNCV112 + WRFV102 + WRAV102 + EB122 + ECC102;

            double gpa = (MATS102 + EB122 + ECC102 + RNCV112 + WRAV102 + WRFV102) / 6;

            WriteLine("---------------------------------------------------");
            WriteLine("                   Year x");
            WriteLine("---------------------------------------------------");
            WriteLine("");
            WriteLine("Mathematics 1A                            : x%");
            WriteLine("");
            WriteLine("Entreprenuership and Business Management  : x%");
            WriteLine("");
            WriteLine("Computer Fundamentals 1A                  : x%");
            WriteLine("");
            WriteLine("Microeconomics                            : x%");
            WriteLine("");
            WriteLine("Programming Fundamentals 1A               : x%");
            WriteLine("");
            WriteLine("Business Accounting 1A                    : x%");
            WriteLine("");

            WriteLine("Mathematics 1B                            : {0:F2}%", MATS102);
            WriteLine("");
            WriteLine("Business Functions                        : {0:F2}%", EB122);
            WriteLine("");
            WriteLine("Computer Fundamentals 1B                  : {0:F2}%", WRFV102);
            WriteLine("");
            WriteLine("Macroeconomics                            : {0:F2}%", ECC102);
            WriteLine("");
            WriteLine("Programming Fundamentals 1B               : {0:F2}%", WRAV102);
            WriteLine("");
            WriteLine("Business Accounting 1B                    : {0:F2}%", RNCV112);
            WriteLine("---------------------------------------------------");
            WriteLine("");
            WriteLine("GPA                                       = {0:F2}%", gpa);
            WriteLine("---------------------------------------------------");

        }
    }
}
