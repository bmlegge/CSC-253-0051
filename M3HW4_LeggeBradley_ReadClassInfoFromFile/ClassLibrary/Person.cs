using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public Person()
        {
            FirstName = "";
            LastName = "";
            Age = 0;
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

    }
}
