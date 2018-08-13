using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Car : Transport
    {
        public int Wheels { get; set; }
        public string Rego { get; set; }

        public Car(string make, string model, Color colour, int passengerLimit, int passengers, int wheels, string rego) : base(make, model, colour, passengerLimit, passengers)
        {
            this.Wheels = wheels;
            this.Rego = rego;
        }

        public string Drive()
        {
            return "Brooooom broooom!";
        }
    }
}
