using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ConsumeApi.Models
{
    public class Inventory
    {
        public int id { get; set; }
        public int prodid { get; set; }
        public int instock { get; set; }
        public int backorder { get; set; }

        public override string ToString()
        {
            return $"-- Inventory object --\n" +
                   $"id: {this.id}\n" +
                   $"prodid: {this.prodid}\n" +
                   $"instock: {this.instock}\n" +
                   $"backorder: {this.backorder}";
        }
    }
}
