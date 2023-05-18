using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Camera : IShootable
    {
        private string _brand;

        public Camera(string brand)
        {
            _brand = brand;
        }

        string IShootable.Shoot()
        {
            return $"Shooting a {ToString()} {_brand}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} using a {_brand}";
        }
    }
}