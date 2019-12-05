using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

/**
 * 10/28/2019
 * CSC 253
 * Bradley Legge
 * This program creates an object of the ShiftSupervior class and lets the user enter data for each of the object's properties.
 * Then it retrieve the object's properties and displys their values.
 */



namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            string userInput;
            string employeeName = null;
            int employeeNum = 0;
            double annualSalary = 0;
            double productionBonus = 5000;

            // Get user input
            Console.WriteLine("Enter your name: > ");
            employeeName = Console.ReadLine();

            Console.WriteLine("Enter your employee number: > ");
            employeeNum = Parse.IntParse(Console.ReadLine());

            Console.WriteLine("Enter your annual salary: > ");
            annualSalary = Parse.DoubleParse(Console.ReadLine());

            Console.WriteLine("Did your team meet production goals? (y/n) > ");
            userInput = Console.ReadLine();

            // Create an instance of the ShiftSupervisor class with Employee parent class.
            ShiftSupervisor newSupervisor = new ShiftSupervisor(employeeName, employeeNum, annualSalary, productionBonus);

            // If statement dependent on whether team met production goals or not.
            if (userInput == "Y" || userInput == "y")
            {
                Console.WriteLine($"{newSupervisor.EmployeeName}, your employee number is {newSupervisor.EmployeeNum}.  Your annual salary " +
                    $"is {newSupervisor.AnnualSalary} and your team made production goals so your bonus is {newSupervisor.ProductionBonus}");
            }

            else
            {
                Console.WriteLine($"{newSupervisor.EmployeeName}, your employee number is {newSupervisor.EmployeeNum}.  Your annual salary " +
                    $"is {newSupervisor.AnnualSalary} however your team didn't make production goals so you don't get the bonus.");
            }
            Console.ReadLine();
        }
    }
}
