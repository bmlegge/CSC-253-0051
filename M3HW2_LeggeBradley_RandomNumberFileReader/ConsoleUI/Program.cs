using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/**
 * 9/24/2019
 * CSC 2019
 * Bradley Legge
 * This program will read in a file that contains random numbers.  It will total all the numbers as well
 * as the amount of random numbers in the file.
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            getRandNum();       //Call the getRandNum method.

            int num;        //holds parsed integer read from file
            int sum = 0;    //holds the sum of all numbers in file
            int count = 0;  //holds total number in file.

            try
            {   
                //StreamReader variable
                StreamReader inputFile;

                //Open the file and get a StreamReader file.
                inputFile = File.OpenText("RandNum.txt");

                //Create blank line.
                Console.WriteLine();

                //Run until end of file.
                while (!inputFile.EndOfStream)
                {
                    num = int.Parse(inputFile.ReadLine());      //Parse string from file to integer.
                    sum += num;             //Add each line in the text file together.
                    count++;                //Count each line in the text file.

                    //Display each number in the text file.
                    Console.WriteLine($"Num {count}: {num}");
                }

                Console.WriteLine();        
                Console.WriteLine($"There are {count} random numbers. ");       //Display the amount of numbers in the text file.
                Console.WriteLine($"The sum of these numbers is: {sum}");       //Display the sum of all the numbers in the text file.
                Console.ReadLine();

                inputFile.Close();      // Close the text file.

               
            }
            catch (Exception)
            {
                //Display an error if program cannot read the file.
                Console.WriteLine("Error reading file 'RandNum.txt'");
            }
        }

        public static void getRandNum()
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
                for (int i = 0; i < numOfRand; i++)
                {
                    // Creates a random number between 1-100
                    num = rand.Next(100) + 1;
                    // Writes the number to the file.
                    outputFile.WriteLine(num);
                }

                // Closes the file.
                outputFile.Close();

                Console.WriteLine("Numbers read into file!");
            }
            catch (Exception)
            {
                // Catch if there is a problem reading file.
                Console.WriteLine("Error reading file 'RandNum.txt'");
            }
        }

        public static int IntParse(string userInput)
        {
            int num;    // Variable to hold number.

            // Try parse string into integer.
            if (int.TryParse(userInput, out num))
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
