using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SafariParkApp
{
    public struct Point3D
    {
        public int x, y, z;

        public Point3D(int x, int y, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

    }
}