using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Yacht : SailBoat
    {
        public string Sponsor { get; set; }
        public int RequiredStaff { get; set; }
        public int Staff { get; set; }
        public bool HasSuperDuperNavigationComputer { get; set; }

        public Yacht(string make, string model, Color colour, int passengerLimit, int passengers, int hullLength, string callSign, string hullMaterial, int numberOfSails, string sponsor, int requiredStaff, int staff, bool hasNavigationComputer) : 
            base(make, model, colour, passengerLimit, passengers, hullLength, callSign, hullMaterial, numberOfSails, false, false)
        {
            this.Sponsor = sponsor;
            this.RequiredStaff = requiredStaff;
            this.Staff = staff;
            this.HasSuperDuperNavigationComputer = hasNavigationComputer;
        }

        public bool AddStaff(int staffToAdd)
        {
            if (this.Passengers + this.Staff + staffToAdd > PassengerLimit)
            {
                return false;
            }

            this.Staff += staffToAdd;
            return true;
        }

        public string SetSail()
        {
            if (Staff < RequiredStaff)
            {
                return "Can't undock yet, where are the staff?";
            }
            else
            {
                return "Set sail!";
            }
        }

        public string SetNavigator(string destination)
        {
            if (HasSuperDuperNavigationComputer == true)
            {
                return $"Target {destination} locked in!";
            }
            else
            {
                return "Are you sure you trust your navigator?";
            }
        }
    }
}
