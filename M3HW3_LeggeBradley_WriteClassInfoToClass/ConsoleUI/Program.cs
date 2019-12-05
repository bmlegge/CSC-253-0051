using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.IO;
/**
 * 10/1/2019
 * CSC 253
 * Bradley Legge
 * This program reads in the first name, last name, and age from user and creates an object to store that data.
 * The information is written to the file and then retrieved from the file and displayed to the user.
 */
namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreatePerson();     //calls the CreatePerson method.
            ReadFile();     //calls the ReadFile method.
        }

        public static void CreatePerson()
        {
            //Creates a new object called person
            Person person = new Person();

            //Get user input.
            Console.Write("Enter your first name > ");
            person.FirstName = Console.ReadLine();

            //Get user input.
            Console.Write("Enter your last name > ");
            person.LastName = Console.ReadLine();

            //Get user input.
            Console.Write("Enter your age > ");
            person.Age = int.Parse(Console.ReadLine());

            //Pass the instance of person to the WriteFile method.
            WriteFile(person);
        }

        public static void WriteFile(Person person)
        {
            try
            {
                //Opens the file.
                StreamWriter outputFile = File.CreateText("Person.txt");

                //Write the objects contents into the file.
                outputFile.WriteLine(person.FirstName);
                outputFile.WriteLine(person.LastName);
                outputFile.WriteLine(person.Age);

                //Closes the file.
                outputFile.Close();

                //Tells user the file was created.
                Console.WriteLine("Content written to file Person.txt.");
                Console.WriteLine();
            }
            catch (Exception)
            {
                //If problem arises when creating file.
                Console.WriteLine("Error reading file.");
            }
        }

        public static void ReadFile()
        {
            try
            {
                //Opens the file.
                StreamReader inputFile = File.OpenText("Person.txt");

                //Reads the file until the end.
                while (!inputFile.EndOfStream)
                {
                    //Reads lines from the text file.
                    string firstName = inputFile.ReadLine();
                    string lastName = inputFile.ReadLine();
                    int age = int.Parse(inputFile.ReadLine());

                    //Creates new object from the text file.
                    Person newPerson = new Person(firstName, lastName, age);

                    //Displays information to user.
                    Console.WriteLine("Here is the information from the file 'Person.txt'.");
                    Console.WriteLine($"First name: {newPerson.FirstName} " +
                                      $"\nLast name: {newPerson.LastName} " +
                                      $"\nAge: {newPerson.Age}.");
                    Console.ReadLine();
                }

                //Closes the file.
                inputFile.Close();
            }
            catch(Exception)
            {
                Console.WriteLine("Error reading file.");
            }
        }
    }
}
