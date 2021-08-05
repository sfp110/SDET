using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariPark
{
    public class Person : IMovable
    {
        //private readonly string _firstName;
        //private string _lastName;

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private int _age;
        //public string FullName => _firstName + " " + _lastName;

        //public int Age { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _age = value;
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

        public string FullName => $"{FirstName} {LastName}";

        public string Move()
        {
            return $"Walking along";
            //throw new NotImplementedException();
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
            //throw new NotImplementedException();
        }
    }
}