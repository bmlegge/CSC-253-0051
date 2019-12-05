using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

/**
 * 10/25/2019
 * CSC 253
 * Bradley Legge
 * This program creates an object of the ProductionWorker class and lets user enter data for each of the object's properties.
 * Then it retrieves the object's properties and display their values.
 */
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeName = null;
            int employeeNum = 0;
            int shiftNum = 0; ;
            double payRate = 0.0;

            Console.Write("Enter your name: > ");
            employeeName = Console.ReadLine();

            Console.Write("Enter your employee number > ");
            employeeNum = Parse.IntParse(Console.ReadLine());

            Console.Write("Enter 1 for day shift, 2 for night shift > ");
            shiftNum = Parse.IntParse(Console.ReadLine());

            Console.Write("Enter your pay rate > ");
            payRate = Parse.DoubleParse(Console.ReadLine());

            ProductionWorker newWorker = new ProductionWorker(employeeName, employeeNum, shiftNum, payRate);

            Console.WriteLine();
            Console.WriteLine($"{newWorker.EmployeeName}, your employee number is {newWorker.EmployeeNum}." +
                               $"\nYou work shift {newWorker.ShiftNum} and make {newWorker.PayRate} dollars an hour.");
            Console.ReadLine();
        }
    }
}
