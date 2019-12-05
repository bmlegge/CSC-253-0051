using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 9/10/2019
 * CSC253
 * Bradley Legge
 * This program asks the user to enter a string and then displays the amount of words in the string as well as
 * the average number of letters in each word.
 */
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;     //stores string entered by user.
            int averageLetter;  //stores average letter in string.

            //Ask user for a sentence and stores it.
            Console.Write("Enter a sentence and I will tell you how many words are in it: > ");
            str = Console.ReadLine();

            //Calculation to find average number of letters in string.
            averageLetter = stringAmount(str) / averageNumLetter(str); 

            //displays the amount of words in the users sentence.
            Console.WriteLine($"The average amout of letters in each words in that sentence are: {averageLetter}");
            Console.ReadLine();
        }

        static int stringAmount(string str)
        {
            int wordCount = 0;  //holds the amount of words in the sentence.
            int index = 0;      //used to find determine if index in string is whitespace or char.

            //if the first element in the array is a white space skip it.
            while (index < str.Length && char.IsWhiteSpace(str[index]))
                index++;

            //while the index are smaller than string elements.
            while (index < str.Length)
            {
                //determines if element is a char and not a whitespace.
                while (index < str.Length && !char.IsWhiteSpace(str[index]))

                    index++;

                //when loop reaches whitespace counts that word.
                wordCount++;

                //skips whitespace until next char is found.
                while (index < str.Length && char.IsWhiteSpace(str[index]))
                    index++;
            }

            //returns the words counted to main method.
            return wordCount;
        }

        static int averageNumLetter(string str)
        {
            int count = 0;  //initalize accumulator

            //foreach loop to count characters in string.
            foreach (char c in str)
            {
                //if characters are a letter or digit add to count
                if (char.IsLetterOrDigit(c))
                {
                    count++;    //accumulator
                }
            }
            //returns the number of letters to main method.
            return count;
        }
    }
}
