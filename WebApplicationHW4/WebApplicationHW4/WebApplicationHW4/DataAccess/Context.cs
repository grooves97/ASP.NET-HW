using System;
using System.Data.Entity;
using System.Linq;
using WebApplicationHW4.Models;

namespace WebApplicationHW4.DataAccess
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