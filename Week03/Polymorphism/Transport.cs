using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Transport
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public Color Colour { get; set; }
        public int PassengerLimit { get; set; }
        public int Passengers { get; set; }

        public Transport(string make, string model, Color colour, int passengerLimit, int passengers)
        {
            this.Make = make;
            this.Model = model;
            this.Colour = colour;
            this.PassengerLimit = passengerLimit;
            this.Passengers = passengers;
        }

        public bool AddPassenger(int passengersToAdd)
        {
            if (Passengers + passengersToAdd > PassengerLimit)
            {
                return false;
            }

            Passengers += passengersToAdd;
            return true;
        }
    }
}
