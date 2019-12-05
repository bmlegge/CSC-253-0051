using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string employeeName;
            int employeeNum;
            int shiftNum;
            double payRate;
            double bonus = 5000;
            double minTrainHours;
            double trainHoursDone;

            Console.Write("Enter your employee name: > ");
            employeeName = Console.ReadLine();

            Console.Write("Enter your employee number: > ");
            employeeNum = Parse.IntParse(Console.ReadLine());

            Console.Write("Enter your shift number: (1/2) > ");
            shiftNum = Parse.IntParse(Console.ReadLine());

            Console.Write("Enter your pay rate: > ");
            payRate = Parse.DoubleParse(Console.ReadLine());

            Console.Write("What is the minimum amount of training hours needed to attend?: > ");
            minTrainHours = Parse.DoubleParse(Console.ReadLine());

            Console.Write("How many training hours have you attended?: > ");
            trainHoursDone = Parse.DoubleParse(Console.ReadLine());

            TeamLeader newTeamLead = new TeamLeader(employeeName, employeeNum, shiftNum, payRate, bonus, minTrainHours, trainHoursDone);

            Console.WriteLine($"{newTeamLead.EmployeeName}, your employee number is {newTeamLead.EmployeeNum}. " +
                              $"\nYou work shift {newTeamLead.ShiftNum}. Your pay rate is {newTeamLead.PayRate} and your " +
                              $"\nmonthly bonus is {newTeamLead.MonthlyBonus}. The minimum amount of training hours you have " +
                              $"\nto attend is {newTeamLead.MinTrainHours} and you have attended {newTeamLead.TrainHoursDone} so far.");
            Console.ReadLine();
        }
    }
}
