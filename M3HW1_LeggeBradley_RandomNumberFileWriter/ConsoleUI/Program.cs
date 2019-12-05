using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/**
* 9/18/2019
* CSC 253
* Bradley Legge
* This program creates an amount of random numbers entered by the user within a range of 1-100.  It then stores those random numbers to a file.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numOfRand;      //stores number of random numbers the user wishes to enter
                int num;            //stores random number

                //StreamWriter variable
                StreamWriter outputFile;

                //Create the file and get a StreamWriter object.
                outputFile = File.CreateText("RandNum.txt");

                // Create a random object
                Random rand = new Random();

                // Asks the user how many random numbers they wish to enter.
                Console.Write("How many rand numbers do you wish to recieve: > ");
                numOfRand = IntParse(Console.ReadLine());

                // For loop to get amount of random numbers users ask for.
                for(int i = 0; i < numOfRand; i++)
                {
                    // Creates a random number between 1-100
                    num = rand.Next(100) + 1;
                    // Writes the number to the file.
                    outputFile.WriteLine(num);
                }

                // Closes the file.
                outputFile.Close();

                Console.WriteLine("Numbers read into file!");
                Console.ReadLine();
            }
            catch(Exception)
            {   
                // Catch if there is a problem reading file.
                Console.WriteLine("Error reading file 'RandNum.txt'");
            }
        }

        static int IntParse(string userInput)
        {
            int num;    // Variable to hold number.

            // Try parse string into integer.
            if(int.TryParse(userInput, out num))
            {
                return num;     // Returns num to main method.
            }
            else
            {
                Console.WriteLine("Invalid input! Must be greater than 0!");
                return 0;
            }
        }
    }
}
