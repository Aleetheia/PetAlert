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
                new AnimalType { AnimalTypeID=0,Name="Cat" },
                new AnimalType { AnimalTypeID=1,Name="Dog" }
            };
            animalTypes.ForEach(s => context.AnimalType.Add(s));
            context.SaveChanges();

            var animals = new List<Animal>
            {
                new Animal { AnimalID=0,Name="Felix",AnimalTypeID=0,Age=6,Lost=true }
            };
            animals.ForEach(s => context.Animal.Add(s));
            context.SaveChanges();

            var wantedAds = new List<WantedAd>
            {
                new WantedAd { WantedAdID=0,Title="Chatounne perdue",AnimalID=0, AnimalTypeID=0,Author="Emmanuel",Town="Nantes",Date=DateTime.Now,Finished=false }
            };
            wantedAds.ForEach(s => context.WantedAd.Add(s));
            context.SaveChanges();
        }
    }   
}