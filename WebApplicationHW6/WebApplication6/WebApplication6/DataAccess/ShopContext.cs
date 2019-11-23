using System;
using System.Data.Entity;
using System.Linq;
using WebApplication6.Models;

namespace WebApplication6.DataAccess
{
    public class ShopContext : DbContext
    {
        public ShopContext()
            : base("name=ShopContext")
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}