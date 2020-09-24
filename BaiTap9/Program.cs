using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BaiTap9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write an application named Sum200 that sums the integers from 1 through 200.
            Display the running total when the program is halfway complete (after the first 100
            numbers), and at the end.
             */
            int sum = 0;
            WriteLine("Sum200");
            for (int i = 1; i <= 200; i++)
            {
                sum += i;
                if (i >= 100)
                {
                    WriteLine(sum);
                }
            }
            ReadKey();

        }
    }
}
