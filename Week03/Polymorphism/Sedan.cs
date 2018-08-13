using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Sedan : Car
    {
        public int Doors { get; set; }
        public Sedan(string make, string model, Color colour, int passengerLimit, int passengers, int wheels, string rego, int doors) : 
            base(make, model, colour, passengerLimit, passengers, wheels, rego)
        {
            this.Doors = doors;
        }
    }
}
