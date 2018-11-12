using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFNewDatabaseTutorial.Models
{
    public class ApplicationDatabaseContext : DbContext
    {
        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options) { }
    }
}
