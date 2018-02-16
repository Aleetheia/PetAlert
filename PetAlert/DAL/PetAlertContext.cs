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

            modelBuilder.Entity<Animal>()
                .HasKey(c => c.AnimalType);
        }
    }
}