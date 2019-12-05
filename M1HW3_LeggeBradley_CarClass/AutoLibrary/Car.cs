using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLibrary
{
    public class Car
    {
        //fields
        private int _year;
        private string _make;
        private int _speed;

        //default constructor
        public Car()
        {
            _year = 0;
            _make = null;
            _speed = 0;
        }

        //overloaded constructor
        public Car(int year, string make)
        {
            Year = year;
            Make = make;
            Speed = 0;
        }

        //Year property
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        //Make property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        //Speed property
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        //Method to accelerate the car by 5mph
        public void Accelerate()
        {
            _speed += 5;
        }

        //Method to brake the care 5mph
        public void Brake()
        {
            if (_speed != 0)
            {
                _speed -= 5;
            }
        }
    }
}