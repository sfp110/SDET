using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Vehicle : IMovable
    {
        private int Capacity;
        private int _numPassengers;

        public Vehicle()
        {
            Speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            Capacity = capacity;
            Speed = speed;
        }

        public int NumPassengers
        {
            get => _numPassengers;
            init
            {
                if (Capacity - _numPassengers >= 0 && _numPassengers >= 0)
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

        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += times * Speed;
            return $"Moving along {times} times";
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" capacity: {Capacity} passengers: {_numPassengers} speed: {Speed} position {Position}";
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
