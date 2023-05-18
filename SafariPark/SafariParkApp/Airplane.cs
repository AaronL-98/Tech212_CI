using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Airplane : Vehicle
    {
        private string _airline;
        public int Altitude { get; set; } = 0;

        public Airplane(int capacity) : base(capacity)
        {
            _airline = "";
        }
        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }

        public void Ascend(int distance)
        {
            Altitude += distance;
        }
        public void Descend(int distance)
        {
            Altitude -= distance;
        }

        public override string Move()
        {
            return $"{base.Move()} at an altidute of {Altitude} meters";
        }
        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altidute of {Altitude} meters";
        }

        public override string ToString()
        {
            return $"Thankyou for flying {_airline}: {base.ToString()} Altitude: {Altitude}";
        }

    }
}