using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 8/30/2019
 * CSC 253
 * Bradley Legge
 * This program calculates the total cost for a hospital stay.
 */

namespace M1HW2_LeggeBradley
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalCost = CalcTotalCharges();  //call CalcTotalCharges method and assigns return value;

            //Displays to user the total charges for the hospital stay.
            Console.WriteLine($"The total charges for your hospital stay are $ {totalCost}");
            Console.ReadLine();
        }

        static decimal CalcStayCharges()
        {
            const decimal PRICE_PER_DAY = 350.00m;      //constant fee per day for stay
            int daysStayed;         //holds amount of days in hospital
            decimal totalStayPrice;     //holds total cost of stay

            //Ask user how many days were spent in hospital
            Console.Write("How many days where spent in the hospital? > ");
            string userInput = Console.ReadLine();

            //parse user input from string to integer.
            if(!int.TryParse(userInput, out daysStayed))
            {
                Console.WriteLine("Invalid Input! Please enter a number!");
                return 0;
            }
            else
            {
                //calcualtion and return total amout.
                totalStayPrice = PRICE_PER_DAY * daysStayed;
                return totalStayPrice;
            }

        }

        static decimal CalcMiscCharges()
        {
            decimal medCharge;  //holds medication charges.
            decimal surgCharge;     //holds surgery charges.
            decimal labFees;    //holds lab fees.
            decimal rehab;  //holds rehab fees.
            decimal miscCharge;     //holds total misc fees.

            //Ask for medication fees.
            Console.Write("What is the amount of medication charges? > $ ");
            string userInput = Console.ReadLine();

            //Parse string to decimal.
            if (!decimal.TryParse(userInput, out medCharge))
            {
                Console.WriteLine("Invalid Input! Please enter a number!");
                return 0;
            }
            else
            {
                //Ask for surgical fees.
                Console.Write("What is the amount of surgical charges? > $ ");
                userInput = Console.ReadLine();

                //Parse string to decimal.
                if (!decimal.TryParse(userInput, out surgCharge))
                {
                    Console.WriteLine("Invalid Input! Please enter a number!");
                    return 0;
                }
                else
                {
                    //Ask for lab fees.
                    Console.Write("What is the amount of lab fees? > $ ");
                    userInput = Console.ReadLine();

                    //Parse string to decimal.
                    if (!decimal.TryParse(userInput, out labFees))
                    {
                        Console.WriteLine("Invalid Input! Please enter a number!");
                        return 0;
                    }
                    else
                    {
                        //Ask for rehab fees.
                        Console.Write("What is the amount of physical rehabilitation charges? > $ ");
                        userInput = Console.ReadLine();

                        //Parse string to decimal.
                        if (!decimal.TryParse(userInput, out rehab))
                        {
                            Console.WriteLine("Invalid Input! Please enter a number!");
                            return 0;
                        }
                        else
                        {
                            //Calculates total misc fees and returns value.
                            miscCharge = medCharge + surgCharge + labFees + rehab;
                            return miscCharge;
                        }
                    }
                }
            }
        }

        static decimal CalcTotalCharges()
        {
            decimal stayCost = CalcStayCharges();   //calls method and assigns returned value
            decimal miscCost = CalcMiscCharges();   //calls method and assigns returned value
            decimal totalCost;  //holds total cost of hospital visit.

            //calculates total hospital visit.
            totalCost = stayCost + miscCost;   

            //returns total hospital visit cost.
            return totalCost;
        }

    }
}
