using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
/*
 * 11/15/2019
 * CSC 253
 * Bradley Legge
 * This program creates three new instances of an employee class.  Once they are filled, they are displayed to
 * the screen in a Winform App.
 **/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates new employee instances.
            Employee employee1 = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");
            Employee employee2 = new Employee("Mark Jones", 39119, "IT", "Programmer");
            Employee employee3 = new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer");

            //Displays them to the screen.
            Console.WriteLine("Name\t\tID Number\t\tDepartment\t\tPosition");
            Console.WriteLine($"{employee1.Name}\t{employee1.IdNumber}\t\t\t{employee1.Department}\t\t{employee1.Position}");
            Console.WriteLine($"{employee2.Name}\t{employee2.IdNumber}\t\t\t{employee2.Department}\t\t\t{employee2.Position}");
            Console.WriteLine($"{employee3.Name}\t{employee3.IdNumber}\t\t\t{employee3.Department}\t\t{employee3.Position}");
            Console.ReadLine();
        }
    }
}
