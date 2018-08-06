using System.Drawing;
using System.IO;

namespace Week01Task2
{
    public class Car : Transport
    {
        internal int Wheels { get; private set; }
        internal string Rego { get; private set; }

        protected Car(string make, string model, Color colour, int wheels, string rego) : base(make, model, colour)
        {
            this.Wheels = wheels;
            this.Rego = rego;
        }

        public string Drive()
        {
            return "Broooom Broooom!";
        }
    }
}