using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    class Camera : IShootable
    {
        string _brand = "";
        public Camera(string brand)
        {
            _brand = brand;
        }
        public string Shoot()
        {
            return $"Snapped a {ToString()} - {_brand}";
        }

        public override string ToString()
        {
            return base.ToString();
        }
       
    }
}
