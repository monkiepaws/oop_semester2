using System.Drawing;

namespace Vehicles
{
    public class Car : Transport
    {
        public int Wheels { get; set; }
        public string Rego { get; set; }

        public Car(string make, string model, Color colour, int wheels, string rego) :
            base(make, model, colour)
        {
            this.Wheels = wheels;
            this.Rego = rego;
        }

        public string Drive()
        {
            return "Brooooom! Broooom!";
        }
    }
}