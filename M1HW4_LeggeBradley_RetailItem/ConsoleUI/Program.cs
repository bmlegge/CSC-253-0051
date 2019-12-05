using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailItem;
/**
 * 9/1/2019
 * CSC 253
 * Bradley Legge
 * This program holds information about retail items in a class.  The information is then stored into an array and
 * displayed to the user.
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 3;     //assign array size to 3.

            //create a new object array
            Items[] itemArray = new Items[SIZE];

            //assign values to each array.
            itemArray[0] = new Items("Jacket", 12, 59.95m); 
            itemArray[1] = new Items("Jeans", 40, 34.95m);
            itemArray[2] = new Items("Shirt", 20, 24.95m);

            //table headings
            Console.WriteLine($"\t Description \t Units on Hand \t Price");

            //for loop to step through each element of the array.
            for (int i = 0; i < itemArray.Length; i++)
            {
                Console.WriteLine($"Item {i+1} {itemArray[i].Description, 10:0} {itemArray[i].UnitsOnHand, 15:0}" +
                                  $"{itemArray[i].Price, 14:C}");
            }

            Console.ReadLine();
        }
    }
}
