using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariPark
{
    public class Person
    {
        //private readonly string _firstName;
        //private string _lastName;

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private int age;
        //public string FullName => _firstName + " " + _lastName;

        //public int Age { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                age = value;
            }
        }

        public Person (string firstName, string lastName = "", int age = 0)
        {
            //_firstName = firstName;
            //_lastName = lastName;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
            //return _firstName + " " + _lastName;
            //return $"{_firstName} {_lastName}";
        }

        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }
    }
}