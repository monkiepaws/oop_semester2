using System.Drawing;

namespace Vehicles
{
    public class Aeroplane : Transport
    {
        public int WingSpan { get; set; }
        public int PassengerLimit { get; set; }
        public int Passengers { get; set; }

        public Aeroplane(string make, string model, Color colour, int wingSpan, int passengerLimit, int passengers) :
            base(make, model, colour)
        {
            this.WingSpan = wingSpan;
            this.PassengerLimit = passengerLimit;
            this.Passengers = passengers;
        }

        public string Fly()
        {
            return "Whooosh!";
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