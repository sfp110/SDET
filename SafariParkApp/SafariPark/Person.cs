using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace SafariPark
{
    public class Person : IMovable, IEquatable<Person>, IComparable<Person>
    {
        private string _firstName;
        private string _lastName;

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }

        public string FirstName 
        { 
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName 
        {   
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }

        }

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

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   _firstName == other._firstName &&
                   _lastName == other._lastName &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   _age == other._age &&
                   Age == other.Age &&
                   FullName == other.FullName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_firstName, _lastName, FirstName, LastName, _age, Age, FullName);
        }

        public int CompareTo([AllowNull] Person other)
        {
            if (other == null) return 1;

            if (this._lastName != other._lastName)
            {
                return this._lastName.CompareTo(other._lastName);
            }
            else if (this._firstName != other._firstName)
            {
                return this._firstName.CompareTo(other._firstName);
            }
            else
            {
                return this.Age.CompareTo(other.Age);
            }
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}