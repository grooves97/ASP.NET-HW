using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBest.Models;

namespace TheBest.DataAccess
{
    public class CardContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public CardContext(DbContextOptions<CardContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
