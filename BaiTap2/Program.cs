using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an application named SumInts that allows the user to enter any number of
            //integers continuously until the user enters 999.Display the sum of the values entered,
            //not including 999
            const int endNum= 999;
            int sum = 0;
            int user = 0;
            do
            {
                user = int.Parse(Console.ReadLine());
                if (user == endNum) break;
                sum += user;
            } while (user != endNum);
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadKey();
        }
    }
}