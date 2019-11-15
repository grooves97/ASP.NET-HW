using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Models;

namespace WebApplication9.DataAccess
{
    public class CardContext : DbContext
    {
        public CardContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().HasData(
                new Card
                {
                    CardHolder="Aslan",
                    DateExpire="01/28",
                    CVV=777
                },
                new Card
                {
                    CardHolder = "Azat",
                    DateExpire = "08/24",
                    CVV = 123
                });
        }
    }
}
