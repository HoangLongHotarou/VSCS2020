using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BaiTap6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Write an application named DisplayMultiplicationTable that displays a table of the
            products of every combination of two integers from 1 through 10.
            */
            WriteLine("Display Multiplication Table: ");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Write("{0,4}",i * j);
                }
                WriteLine(" ");
            }
            ReadKey();
        }
    }
}
