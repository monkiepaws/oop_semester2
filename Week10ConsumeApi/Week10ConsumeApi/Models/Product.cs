using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ConsumeApi.Models
{
    public class Product
    {
        public int id { get; set; }
        public string prodname { get; set; }
        public string desc { get; set; }
        public decimal price { get; set; }

        public override string ToString()
        {
            return $"-- Product object --\n" +
                   $"id: {this.id}\n" +
                   $"prodname: {this.prodname}\n" +
                   $"desc: {this.desc}\n" +
                   $"price: {this.price:c}";
        }
    }
}
