using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BaiTap5
{
    class Program
    {
        enum Name
        {
            Danielle,
            Edward,
            Francis
        }

        static void Main(string[] args)
        {
            /*
            * Danielle, Edward, and Francis are three salespeople at Holiday Homes. Write an
            application named HomeSales that prompts the user for a salesperson initial (D, E,
            or F). Either uppercase or lowercase initials are valid. While the user does not type Z,
            continue by prompting for the amount of a sale. Issue an error message for any invalid
            initials entered. Keep a running total of the amounts sold by each salesperson. After
            the user types Z or z for an initial, display each salesperson’s total, a grand total for all
            sales, and the name of the salesperson with the highest total.
             */
            Name namOfStaff;
            double[] list = {0,0,0};

            double
                Danielle = 0,
                Edward = 0,
                Francis = 0,
                grandTotal = 0;
            int
                countD = 0,
                countE = 0,
                countF = 0,
                pos;

            char user;

            while (true)
            {
                Write("Enter a character (D,E,F, Finish enter Z): ");
                user = char.Parse(ReadLine());
                user = char.ToUpper(user);
                switch (user)
                {
                    case 'D':
                        WriteLine("times {0}: Enter amounts of Danielle: ",countD+1);
                        Danielle = double.Parse(ReadLine());
                        list[0] += Danielle;
                        countD++;
                        break;

                    case 'E':
                        WriteLine("times {0}: Enter amounts of Edward: ",countE+1);
                        Edward = double.Parse(ReadLine());
                        list[1] += Edward;
                        countE++;
                        break;

                    case 'F':
                        WriteLine("times {0}: Enter amounts of Francis: ",countF+1);
                        Francis = double.Parse(ReadLine());
                        list[2] += Francis;
                        countF++;
                        break;

                    default:
                        if(user!='Z')
                        {
                            WriteLine("Error");
                        }
                        break;
                }
                if(user=='Z')
                {
                    break;
                }
            }

            for (int i = 0; i < list.Length; i++)
            {
                namOfStaff = (Name)i;
                WriteLine("the total amounts of {0}: {1}", namOfStaff, list[i]);
                grandTotal += list[i];
            }
            WriteLine("Grand total: {0}", grandTotal);

            //highest total
            pos = 0;
            for (int i = 1; i < list.Length; i++)
            {
                if (list[pos] < list[i])
                {
                    pos = i;
                }
            }
            WriteLine("the name of the salesperson with the highest total: {0}",(Name)pos);
            ReadKey();
        }
    }
}
