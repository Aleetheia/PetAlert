using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PetAlert.Models;
using PetAlert.DAL;

namespace PetAlert.DAL
{
    public class PetAlertInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PetAlertContext>
    {
        protected override void Seed(PetAlertContext context)
        {
            var animalTypes = new List<AnimalType>
            {
                new AnimalType { AnimalTypeID=1,Name="Cat" },
                new AnimalType { AnimalTypeID=2,Name="Dog" }
            };
            animalTypes.ForEach(s => context.AnimalType.Add(s));
            context.SaveChanges();

            var animals = new List<Animal>
            {
                new Animal { AnimalID=1,Name="Felix",AnimalTypeID=1,Age=6,Lost=true }
            };
            animals.ForEach(s => context.Animal.Add(s));
            context.SaveChanges();

            var authors = new List<Author>
            {
                new Author { AuthorID=1,FirstName="Emmanuel",LastName="Macron",TownID=1 }
            };
            authors.ForEach(s => context.Author.Add(s));
            context.SaveChanges();

            var towns = new List<Town>
            {
                new Town { TownID=1,Name="Paris" }
            };
            towns.ForEach(s => context.Town.Add(s));
            context.SaveChanges();

            var wantedAds = new List<WantedAd>
            {
                new WantedAd { WantedAdID=1,Title="Chatounne perdue",AnimalID=1,AnimalTypeID=1,AuthorID=1,TownID=1,Date=DateTime.Now,Finished=false }
            };
            wantedAds.ForEach(s => context.WantedAd.Add(s));
            context.SaveChanges();
        }
    }   
}