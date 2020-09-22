using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BaiTap4
{
    class DailyTemps
    {
        static void Main(string[] args)
        {
            /*Write an application named DailyTemps that continuously prompts a user for a series
            of daily high temperatures until the user enters a sentinel value. Valid temperatures
            range from -20 through 130 Fahrenheit. When the user enters a valid temperature,
            add it to a total; when the user enters an invalid temperature, display an error message.
            Before the program ends, display the number of temperatures entered and the average
            temperature.*/

            const double least = -20, highest = 130;
            double temperature=0,sum=0, count=0;
            WriteLine("============ Daily Temps ==============");
            WriteLine("Enter a temperature (Enter 999 to Exit)");
            while (temperature!=999)
            {
                Write("times {0}: ", count + 1);
                temperature = double.Parse(ReadLine());
                if (least <= temperature && temperature <= highest)
                {
                    sum += temperature;
                    count++;
                }
                else if(temperature!=999)
                {
                    WriteLine("Error, Valid temperatures range from - 20 through 130 Fahrenheit");
                    break;
                }
            }
            WriteLine("the number of temperatures entered : {0}", count);
            WriteLine("Average Temperature: {0}", Math.Round((sum/count),2));
            ReadKey();
        }
    }
}