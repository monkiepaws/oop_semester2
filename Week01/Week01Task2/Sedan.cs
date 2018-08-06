using System.Drawing;
using System.Management.Instrumentation;

namespace Week01Task2
{
    public class Sedan : Car
    {
        private int Doors { get; set; }
        private int PassengerLimit { get; set; }
        private int Passengers { get; set; }

        public Sedan(string make, string model, Color colour, int wheels, string rego,
            int doors, int passengerLimit, int passengers) 
            : base(make, model, colour, wheels, rego)
        {
            this.Doors = doors;
            this.PassengerLimit = passengerLimit;
            this.Passengers = passengers;
        }

        public bool AddPassenger()
        {
            if (Passengers + 1 > PassengerLimit)
            {
                return false;
            }

            Passengers++;
            return true;
        }
        
        public override string ToString()
        {
            return $"Make:           {this.Make}\n" +
                   $"Model:          {this.Model}\n" +
                   $"Colour:         {this.Colour}\n" +
                   $"Wheels:         {this.Wheels}\n" +
                   $"Rego:           {this.Rego}\n" +
                   $"PassengerLimit: {this.PassengerLimit}\n" +
                   $"Passengers:     {this.Passengers}\n" +
                   $"Doors:          {this.Doors}\n";
        }
    }
}