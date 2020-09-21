using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an application named EnterUppercaseLetters that asks the user to type an
            //uppercase letter from the keyboard.If the character entered is an uppercase letter,
            //display OK; if it is not an uppercase letter, display an error message. The program
            //continues until the user types an exclamation point.
            char user;
            while (true)
            {
                Console.Write("Type an uppercase letter from the keyboard: ");
                user = char.Parse(Console.ReadLine());
                if('A'<=user&&user<='Z')
                {
                    Console.WriteLine("OK");
                    break;
                }
                else
                {
                    Console.WriteLine("Error message: Please Type an uppercase letter from the keyboard.");
                }
            }
            Console.ReadKey();
        }
    }
}
