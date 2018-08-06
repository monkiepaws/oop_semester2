using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Week01Task2
{
    public class Driver
    {
        private List<Transport> Vehicles = new List<Transport>();

        public Driver()
        {
            this.Vehicles.Add(AddAeroplane());
            this.Vehicles.Add(AddUte());
            this.Vehicles.Add(AddSedan());
        }

        private Transport AddAeroplane()
        {
            return new Aeroplane("Boeing", "747", Color.White, 60, 300);
        }
        
        private Transport AddUte()
        {
            return new Ute("Holden", "Commodore", Color.Pink, 4, "ABC123", 10, 0);
        }

        private Transport AddSedan()
        {
            return new Sedan("Ford", "Falcon", Color.Purple, 4, "CBA321", 4, 5, 0);
        }

        public override string ToString()
        {
            if (Vehicles.Count <= 0)
            {
                return "Empty";
            }
            
            StringBuilder formattedList = new StringBuilder();

            formattedList.AppendLine("-----------START------------");
            
            foreach (Transport vehicle in Vehicles)
            {
                formattedList.Append(vehicle.ToString());
                formattedList.AppendLine("***************************");
            }
            
            formattedList.AppendLine("------------END-------------");

            return formattedList.ToString();
        }
    }
}