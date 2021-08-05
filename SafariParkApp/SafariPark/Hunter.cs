using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariPark
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {Shooter}";
        }

        //The constructor can't run if the base Person doesn't send in the required elements
        public Hunter(string firstName, string lastName, IShootable shooter) : base(firstName, lastName)
        {
            Shooter = shooter;
        }

        public virtual string Shoot()
        {
            return $"{GetFullName()}: {Shooter.Shoot()}";
            //return $"{GetFullName()} has taken a photo with their {Shooter}";
        }
        
        public string CameraName()
        {
            return $"{Shooter}";
        }

        //public string Camera => Shooter;
    }
}