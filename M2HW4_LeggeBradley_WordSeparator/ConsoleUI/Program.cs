using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 9/15/2019
 * CSC253
 * Bradley Legge
 * This program asks the user for a string that is combined together with an uppercase letter where the string 
 * should be seperated.  The program then seperates the string with a whitespace and changes all but initial uppercase
 * to lowercase letters.
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;         //stores the user string
            string str2 = "";   //stores string that is changed.

            Console.Write("Enter a sentence where all letters are ran together but the first character of each word " +
                          "is uppercase. > ");
            str = Console.ReadLine();

           //for loop to loop through the string entered by user.
           for(int i = 0; i < str.Length; i++)
            {
                if(i == 0) 
                {
                    str2 += char.ToUpper(str[i]);  //sets first element in string to uppercase
                    continue;                      //continues out of the if statement.
                }
                if (char.IsUpper(str[i])) 
                {
                    str2 += " " + char.ToLower(str[i]);     //if char is uppercase, append a whitespace before and lowercase the char.
                }
                else
                    str2 += str[i];         //if it's not first char or an uppercase char return the same value.
                
            }
            Console.WriteLine($"The string is {str2} now.");    //prints out the new string.
            Console.ReadLine();
        }
    }
}
