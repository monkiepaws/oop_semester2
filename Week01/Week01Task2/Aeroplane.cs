using System.Drawing;

namespace Week01Task2
{
    public class Aeroplane : Transport
    {
        private int WingSpan { get; set; }
        private int PassengerLimit { get; set; }
        private int Passengers { get; set; }

        public Aeroplane(string make, string model, Color colour, int wingSpan, int passengerLimit, int passengers = 0) 
            : base(make, model, colour)
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
            if (Passengers + passengersToAdd > PassengerLimit)
            {
                return false;
            }

            Passengers += passengersToAdd;
            return true;
        }
        
        public override string ToString()
        {
            return $"Make:           {this.Make}\n" +
                   $"Model:          {this.Model}\n" +
                   $"Colour:         {this.Colour}\n" +
                   $"WingSpan:       {this.WingSpan}m\n" +
                   $"PassengerLimit: {this.PassengerLimit}\n";
        }
    }
}