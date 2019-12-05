using HW7.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace HW7.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("name=UserContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}