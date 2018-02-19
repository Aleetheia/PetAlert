using System;
using PetAlert.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PetAlert.DAL
{
    public class PetAlertContext : DbContext
    {
        public PetAlertContext() : base ("PetAlertContext")
        {
        }

        public DbSet<AnimalType> AnimalType { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<WantedAd> WantedAd { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Town> Town { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<AnimalType>()
            //        .HasRequired(m => m.Name)
            //        .WithMany(t => t.Name)
            //        .HasForeignKey(m => m.AnimalTypeID)
            //        .WillCascadeOnDelete(true);
        }
    }
}