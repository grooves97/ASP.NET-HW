using System;
using System.Data.Entity;
using System.Linq;
using WebApplicationHW5.Models;

namespace WebApplicationHW5.DataAcces
{
    public class WallContext : DbContext
    {
        public WallContext()
            : base("name=WallContext")
        {
            Database.SetInitializer(new WallInitializer());
        }
        public DbSet<Message> Messages { get; set; }
    }
}