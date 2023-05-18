using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class WaterPistol : Weapon
    {

        public WaterPistol(string brand) : base(brand)
        {

        }

        public override string Shoot()
        {
            return $"Splash!! {base.Shoot()}";
        }
    }
}