using System;
using System.Data.Entity;
using System.Linq;
using WebApplication7.Models;

namespace WebApplication7.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("name=UserContext")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAdmin> UserAdmins { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}