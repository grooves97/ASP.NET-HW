namespace WebApplicationHW8.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModels : DbContext
    {
        public DBModels()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.ImageCaption)
                .IsUnicode(false);
        }
    }
}
