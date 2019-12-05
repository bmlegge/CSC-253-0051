using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLibrary;
/**
 * 9/1/2019
 * CSC 253
 * Bradley Legge
 * This program asks the user to input the year and make of a car.  It then asks them if they wish
 * to see the current speed of the car after they accelerate or brake the car.
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool value to keep dowhile going.
            bool exit = false;

            //new car object
            Car car = new Car();

            do
            {
                //call the DisplayMenu method in the Message class
                //which displays the main menu.
                Messages.DisplayMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        car = CarBuild.GetCarInfo();    //calls the GetCarInfo method in the CarBuild class
                        break;                          
                    case "2":
                        car.Accelerate();               //accerlates the car 5mph.
                        Messages.DisplayCarSpeed(car);  //pass the speed into the DisplayCarSpeed method inside the Messages class.
                        break;
                    case "3":
                        car.Brake();                    //brakes the car 5mph.
                        Messages.DisplayCarSpeed(car);  //pass the speed into the DisplayCarSpeed method inside the Messages class.
                        break;
                    case "4":
                        exit = true;        //breaks out of the do while loop and exits the program.
                        break;
                    default:
                        Messages.MenuError();   //calls the MenuError method in the Messages class.
                        break;
                }
            } while (exit == false);
        }
    }
}
