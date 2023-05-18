using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public interface IMovable
    {
        public int Distance { get; set; }
        string Move();
        string Move(int times);
    }
}