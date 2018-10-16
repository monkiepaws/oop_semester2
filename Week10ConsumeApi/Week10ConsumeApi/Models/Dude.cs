using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ConsumeApi.Models
{
    public class Dude
    {
        public int did { get; set; }
        public string name { get; set; }
        public string details { get; set; }
        public override string ToString()
        {
            return $"-- Dude object --\n" +
                   $"did: {this.did}\n" +
                   $"name: {this.name}\n" +
                   $"details: {this.details}";
        }
    }
}
