using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Parse
    {
        public static int IntParse(string input)
        {
            bool exit = false;
            int num = 0;

            while(!exit)
            {
                if(int.TryParse(input, out num))
                {
                    exit = true;
                }
                else
                {
                    Console.Write("Invalid input! Enter a number: > ");
                    input = Console.ReadLine();
                }
            }
            return num;
        }

        public static double DoubleParse(string input)
        {
            bool exit = false;
            double num = 0;

            while(!exit)
            {
                if(double.TryParse(input, out num))
                {
                    exit = true;
                }
                else
                {
                    Console.Write("Invalid input! Enter a number: > ");
                    input = Console.ReadLine();
                }
            }
            return num;
        }
    }
}
