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
            int num = 0;

            while (!int.TryParse(input, out num))
            {
                Console.Write("Invalid input! Enter a number: > ");
                input = Console.ReadLine();
            }
            return num;
        }

        public static double DoubleParse(string input)
        {
            double num = 0;

            while(!double.TryParse(input, out num))
            {
                Console.Write("Invalid input! Enter a number: > ");
                input = Console.ReadLine();
            }
            return num;
        }
    }
}
