using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 9/13/2019
 * CSC 253
 * Bradley Legge
 * This program allows a user to enter a string and then displays the character that appears most frequently in that string.
 **/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int index = 0;
            int count = 0;

            Console.WriteLine("Type a sentence and I will tell you which character appears most.");
            str = Console.ReadLine();

            while (str.Length > 0)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Count is {count}.");
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            
            Console.ReadLine();
        }
    }
}
