using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an application named OddNums that displays all the odd numbers from 1
            //through 99.
            Console.WriteLine("Odd Nums: ");
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0) 
                {
                    if (i < 10)
                    {
                        Console.Write("{0,-2}", i);
                    }
                    else
                    {
                        Console.Write("{0,-3}", i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
