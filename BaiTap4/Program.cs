using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace BaiTap4
{
    class DailyTemps
    {
        static void Main(string[] args)
        {
            WriteLine("Patrick Barnes");
            WriteLine("DailyTemps");
            int count = 0;
            double sum = 0;
            double entry = 0;

            WriteLine("Enter 999 to stop");
            while (entry != 999)
            {
                Write("Temp {0}:", count);
                entry = double.Parse(ReadLine());
                if (entry >= -20 && entry <= 130)
                {
                    count++;
                    sum += entry;
                }
                else if (entry != 999)
                {
                    WriteLine("Error, -20 to 130 . 999 to quit.");
                }
            }
            WriteLine("Count:{0}", count);
            WriteLine("Avg  :{0}", sum / count);

            WriteLine("--End--");
            ReadKey();
        }
    }
}