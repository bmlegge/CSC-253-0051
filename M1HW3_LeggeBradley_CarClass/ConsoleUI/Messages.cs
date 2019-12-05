using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLibrary;

namespace ConsoleUI
{
    public class Messages
    {
        //Method to display the main menu.
        public static void DisplayMenu()
        {
            Console.WriteLine("1. Create a car.");
            Console.WriteLine("2. Accelerate and show current speed.");
            Console.WriteLine("3. Brake and show current speed.");
            Console.WriteLine("4. Exit.");
            Console.Write("1,2,3, or 4 > ");
        }
        
        //Method to display error if user doesn't enter 1-4.
        public static void MenuError()
        {
            Console.WriteLine("Not a valid choice!");
            Console.WriteLine("");
        }

        //Method to display user input and speed of car.
        public static void DisplayCarSpeed(Car input)
        {
            Console.WriteLine($"The {input.Year} {input.Make} is going {input.Speed} mph.");
            Console.WriteLine("");
        }
    }
}
