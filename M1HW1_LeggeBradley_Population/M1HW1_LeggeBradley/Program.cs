using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 8/29/2019
 * CSC 253
 * Bradley Legge
 * This program predicts the approximate size of a population of organisms.
 */
namespace M1HW1_LeggeBradley
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double numOfOrg;
            double dailyInc;
            double dailyPerc;
            double numDays;
            double pop = 0;
            double popTotal = 0;

            Console.Write("Starting number of organisms: > ");
            userInput = Console.ReadLine();

            if (Double.TryParse(userInput, out numOfOrg))
            {
                Console.Write("Average daily increase percentage (Ex: 30): > ");
                userInput = Console.ReadLine();

                if (Double.TryParse(userInput, out dailyInc))
                {
                    dailyPerc = dailyInc / 100;

                    Console.Write("Number of days to multiply: > ");
                    userInput = Console.ReadLine();

                    if (Double.TryParse(userInput, out numDays))
                    {
                        pop = numOfOrg * dailyPerc;
                        popTotal = numOfOrg + pop;

                        Console.WriteLine("");
                        Console.WriteLine("Day \t Approximate Population");
                        Console.WriteLine($"1 \t {numOfOrg}");

                        for (int i = 2; i <= numDays; i++)
                        {
                            Console.WriteLine($"{i} \t {popTotal}");
                            popTotal += (popTotal * dailyPerc);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invaild input! Enter another number!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Enter another number!");
            }
            Console.ReadLine();
        }
    }
}
