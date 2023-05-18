using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person : IMovable, IEquatable<Person?>, IComparable<Person>
    {
        public string FirstName { get; private set; } = "";
        public string LastName { get; private set; } = "";
        private int _age = 0;
        private int _distance = 0;

        public int Speed { get; init; } = 1;

        public int Age 
        { 
            get { return _age; } 
            set 
            {
                if (value < 0 || value > 1000) throw new ArgumentException($"Valid age = 0-150 Value = {value}");
                _age = value; 
            } 
        }

        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        public Person() { Distance = 0; }

        public Person(string firstName = "", string lastName = "", int age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Distance = 0;
        }

        public string FullName => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return $"{base.ToString()} Name: {FullName} Age: {Age}";
        }

        public virtual string Move()
        {
            Distance += Speed;
            return "Walking along";
        }
        public virtual string Move(int times)
        {
            Distance += Speed * times;
            return $"walking along {times} times";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   _age == other._age &&
                   _distance == other._distance &&
                   Speed == other.Speed &&
                   Age == other.Age &&
                   Distance == other.Distance &&
                   FullName == other.FullName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, _age, _distance, Speed, Age, Distance, FullName);
        }

        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            if (LastName != other.LastName) return LastName.CompareTo(other.LastName);
            else if (FirstName != other.FirstName) return LastName.CompareTo(other.FirstName);
            else return Age.CompareTo(other.Age);
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right); // Default = Default Value - Data Been Processed
                                                                         // String - string, int - int
        }
        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}