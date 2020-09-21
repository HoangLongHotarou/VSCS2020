using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write an application named SumFiveInts that allows the user to enter five integers
            and displays their sum.*/
            int[] list = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
                sum += list[i];
            }
            Console.WriteLine("Sum = {0}",sum);
            Console.ReadKey();
        }
    }
}
