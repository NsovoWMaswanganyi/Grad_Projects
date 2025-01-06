using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GPA_APP
{
    class Minutes
    {
        double EB122, ECC102, MATS102, RNCV112, WRAV102, WRFV102;

        public Minutes(double EB122, double ECC102, double MATS102, double RNCV112, double WRAV102, double WRFV102)
        {
            this.EB122 = EB122;
            this.ECC102 = ECC102;
            this.MATS102 = MATS102;
            this.RNCV112 = RNCV112;
            this.WRAV102 = WRAV102;
            this.WRFV102 = WRFV102;
        }

        public double EB
        {
            get
            {
                return EB122;
            }
            set
            {
                EB122 = value;
            }
        }

        public double Mats
        {
            get
            {
                return MATS102;
            }
            set
            {
                MATS102 = value;
            }
        }

        public double AV
        {
            get
            {
                return WRAV102;
            }
            set
            {
                WRAV102 = value;
            }
        }

        public double FV
        {
            get
            {
                return WRFV102;
            }
            set
            {
                WRFV102 = value;
            }
        }
        public double EC
        {
            get
            {
                return ECC102;
            }
            set
            {
                ECC102 = value;
            }
        }

        public double CV
        {
            get
            {
                return RNCV112;
            }
            set
            {
                RNCV112 = value;
            }
        }

        public void Display(int week_num)
        {

            double tmin = MATS102 + RNCV112 + WRFV102 + WRAV102 + EB122 + ECC102;

            WriteLine("-----------------------------------");
            WriteLine("     Weekly Hours for Semester 2");
            WriteLine("-----------------------------------");
            WriteLine("");
            WriteLine($"Week {week_num}");
            WriteLine("------");
            WriteLine("");
            WriteLine($"Mathematics              : {MATS102}/300");
            WriteLine("");
            WriteLine($"Computer Fundamentals    : {WRFV102}/300");
            WriteLine("");
            WriteLine($"Programming Fundamentals : {WRAV102}/300");
            WriteLine("");
            WriteLine($"Business Accounting      : {RNCV112}/480");
            WriteLine("");
            WriteLine($"Business Functions       : {EB122}/480");
            WriteLine("");
            WriteLine($"Economics                : {ECC102}/480");
            WriteLine("___________________________________");
            WriteLine("");
            WriteLine($"Total Academic Minutes   : {tmin}/2340");
            WriteLine("-----------------------------------");
        }
    }
    
}
