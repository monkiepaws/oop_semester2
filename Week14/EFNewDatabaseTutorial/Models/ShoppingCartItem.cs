using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFNewDatabaseTutorial.Models
{
    public class ShoppingCartItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
