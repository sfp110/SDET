using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    class Airplane : Vehicle
    {
        private string _airline;

        public Airplane(int capacity) : base(capacity)
        {
            _capacity = capacity;
        }

        public Airplane(int capacity, int speed, string airline = "EasyJet") : base(capacity, speed)
        {
            _capacity = capacity;
            _airline = airline;
        }

        public int Altitude { get; private set; }

        public void Ascend(int distance) //500
        {
            Altitude += distance;
        }

        public void Descend(int distance)
        {
            Altitude -= distance;
        }

        public override string Move()
        {
            base.Move();
            //Position += Speed;
            return $"Moving along at an altitude of {Altitude} meters.";
        }

        public override string Move(int times) //3
        {
            //Position += times * Speed;
            base.Move(times);
            return $"Moving along {times} times at an altitude of {Altitude} meters.";
        }

        public override string ToString()
        {
            return $"Thank you for flying with {_airline}: {base.ToString()} capacity: {_capacity} passengers: {NumPassengers} speed: {Speed} position: {Position} altitude: {Altitude} \n ";
        }
    }
}
