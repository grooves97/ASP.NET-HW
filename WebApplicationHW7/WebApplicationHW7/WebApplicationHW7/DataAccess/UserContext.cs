namespace WebApplicationHW7.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApplicationHW7.Models;

    public class UserContext : DbContext
    {
        public UserContext()
            : base("name=UserContext")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}