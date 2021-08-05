using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    class WasterPistol : Weapon
    {
        public WasterPistol(string brand) : base(brand)
        {

        }

        public override string Shoot()
        {
            return $"Splash!! {base.Shoot()}";
        }
    }
}
