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
                new AnimalType {  AnimalTypeID=1, Name="Cat" },
                new AnimalType {  AnimalTypeID=2, Name="Dog" }
            };
            animalTypes.ForEach(s => context.AnimalType.Add(s));
            context.SaveChanges();

            var animals = new List<Animal>
            {
                new Animal { AnimalID=1,Name="Felisse",AnimalTypeID=1,Colour="Red",Lost=true },
                new Animal { AnimalID=2,Name="Chouchou",AnimalTypeID=2,Colour="Blue",Lost=true },
                new Animal { AnimalID=3,Name="Sushi",AnimalTypeID=1,Colour="Grey",Lost=true }
            };
            animals.ForEach(s => context.Animal.Add(s));
            context.SaveChanges();

            //var wantedAds = new List<WantedAd>
            //{
            //    new WantedAd { WantedAdID=1,Title="Chatounne perdue",AnimalID=1, AnimalTypeID=1,Author="Emmanuel",Town="Nantes",Date=DateTime.Now,Finished=false }
           // };
            //wantedAds.ForEach(s => context.WantedAd.Add(s));
           // context.SaveChanges();
        }
    }   
}