using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    class Weapon : IShootable
    {
        private string _brand = "";
        public Weapon(string brand)
        {
            _brand = brand;
        }
        public virtual string Shoot()
        {
            return $"Shooting a {ToString()} - {_brand}";
        }

        public override string ToString()
        {
            return base.ToString();
        }

        
    }
}
