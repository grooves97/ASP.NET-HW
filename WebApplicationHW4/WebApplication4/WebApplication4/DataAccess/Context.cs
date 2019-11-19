using System;
using System.Data.Entity;
using System.Linq;
using WebApplication4.Models;

namespace WebApplication4.DataAccess
{

    public class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}