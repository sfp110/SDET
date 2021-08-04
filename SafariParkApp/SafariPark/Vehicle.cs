using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;

        public Vehicle()
        {
            Speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
        }

        public int NumPassengers
        {
            get
            {
                return _numPassengers;
            }
            set
            {
                if (_capacity - _numPassengers >= 0 && _numPassengers > 0)
                {
                    _numPassengers = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int Position { get; private set; }

        //
        public int Speed { get; init; }

        public string Move()
        {
            Position = Speed;
            return "Moving along";
        }

        public string Move(int times)
        {
            Position = times * Speed;
            return $"Moving along {times} times";
        }
        //==
        //struct Speed
        //{
        //    public int X { get; }
        //    public int Y { get; }

        //    public Speed(int x, int y)
        //    {
        //        this.X = x;
        //        this.Y = y;
        //    }
        //}
    }
}
