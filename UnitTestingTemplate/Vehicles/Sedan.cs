using System.Drawing;

namespace Vehicles
{
    public class Sedan : Car
    {
        public int Doors { get; set; }
        public int PassengerLimit { get; set; }
        public int Passengers { get; set; }

        public Sedan(string make, string model, Color colour, int wheels, string rego, int doors, int passengerLimit,
            int passengers) :
            base(make, model, colour, wheels, rego)
        {
            this.Doors = doors;
            this.PassengerLimit = passengerLimit;
            this.Passengers = passengers;
        }

        public bool AddPassengers(int passengersToAdd)
        {
            if (this.Passengers + passengersToAdd > this.PassengerLimit)
            {
                return false;
            }

            this.Passengers += passengersToAdd;
            return true;
        }
    }
}