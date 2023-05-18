using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace SafariParkApp
{
    public class Vehicle : IMovable
    {
        //--Fields--
        private int _capacity = 1;
        private int _numPassengers = 0;
        private int _distance = 0;
        //--Properties--
        public int NumPassengers 
        { get 
            { return _numPassengers; } 
          set 
            {
                if (value < 0) throw new ArgumentException($"Passengers can't be less than zero");
                if (value > _capacity) throw new ArgumentException($"Passengers {value} over capacity {_capacity}");
                _numPassengers = value;
            } 
        }
        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }
        public int Speed { get; init; } = 10;

        //--Methods--
        public virtual string Move()
        {
            Distance += Speed;
            return "Moving along";
        }
        public virtual string Move(int times)
        {
            Distance += Speed * times;
            return $"Moving along {times} times";
        }
        public Vehicle() { }
        public Vehicle(int capactity, int speed = 10)
        {
            _capacity = capactity;
            Speed = speed;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Capacity: {_capacity} Passengers: {_numPassengers} Speed: {Speed} Position: {Distance}";
        }
    }
}