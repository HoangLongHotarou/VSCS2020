using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Baitap7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write an application named MultiplicationTable that prompts the user for an integer
            value, for example 7. Then display the product of every integer from 1 through 10
            when multiplied by the entered value. For example, the first three lines of the table
            might read 1 x 7 = 7, 2 x 7 = 14, and 3 x 7 = 21.
             */
            int n;
            WriteLine("------------ Multiplication Table -------------\n");
            Write("Enter your value: ");
            n = int.Parse(ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                WriteLine("{0,2} X {1,-1} = {2,1}", n, i, n * i);
            }
            ReadKey();
        }
    }
}
