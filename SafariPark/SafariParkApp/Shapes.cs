using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public abstract class Shapes
    {
        public abstract int CalulateArea();
    }

    public sealed class Rectangle : Shapes
    {
        private int _width;
        private int _height;

        public Rectangle(int width = 0, int height = 0)
        {
            _width = width;
            _height = height;
        }

        public override int CalulateArea()
        {
            return _width * _height;
        }

        public override string ToString()
        {
            return $"{base.ToString()}  Area: {CalulateArea()}";
        }
        
    }
}