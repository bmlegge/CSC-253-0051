using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLibrary
{
    public class CarBuild
    {
        public static Car GetCarInfo()
        {
            //Create a new car object.
            Car output = new Car();

            //Get the year of the car.
            Console.Write("What is the year of the car? > ");
            output.Year = int.Parse(Console.ReadLine());

            //Get the make of the car.
            Console.Write("What is the make of the car? > ");
            output.Make = Console.ReadLine();

            //return the output to the Car class.
            Console.WriteLine("");
            return output;
        }
    }
}
