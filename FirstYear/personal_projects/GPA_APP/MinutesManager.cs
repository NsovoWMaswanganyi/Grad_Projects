using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_APP
{
    class MinutesManager
    {
        ArrayList list = new ArrayList();

        public MinutesManager()
        {
            ReadMinutes();
        }

        void ReadMinutes()
        {
            StreamReader Reader = new StreamReader("Minutes.txt");
            string[] parts = new string[6];
            string inputline = Reader.ReadLine();

            while (inputline != null)
            {
                parts = inputline.Split(',');

                double eb = double.Parse(parts[0]);
                double ecc = double.Parse(parts[1]);
                double mats = double.Parse(parts[2]);
                double rncv = double.Parse(parts[3]);
                double wrav = double.Parse(parts[4]);
                double wrfv = double.Parse(parts[5]);

                Minutes newMins = new Minutes(eb, ecc, mats, rncv, wrav, wrfv);
                AddMinutes(newMins);
                inputline = Reader.ReadLine();
            }
            Reader.Close();
        }

        public void AddMinutes(Minutes minutes)
        {
            list.Add(minutes);
        }

        public void WriteMinutes()
        {
            StreamWriter Writer = new StreamWriter("Minutes.txt");

            for (int i = 0; i < list.Count; i++)
            {
                Minutes minutes = (Minutes)list[i];
                Writer.Write(minutes.EB + ",");
                Writer.Write(minutes.EC + ",");
                Writer.Write(minutes.Mats + ",");
                Writer.Write(minutes.CV + ",");
                Writer.Write(minutes.AV + ",");
                Writer.WriteLine(minutes.FV);
            }
            Writer.Close();
        }

        public void DisplayMinutes()
        {
            for(int i = 0; i < list.Count; i++)
            {
                Minutes temp = (Minutes)list[i];
                temp.Display(i+1);
            }
        }
    }
}
