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
            var wantedAds = new List<WantedAd>
            {
                new WantedAd { WantedAdID=1,Title="Chatounne perdue",Animal= "Felix",AnimalType="Chat",Author="Benjamin",Town="Nantes",Date=DateTime.Now,Finished=false },
                new WantedAd { WantedAdID=2,Title="Où est Medor ?",Animal= "Medor", AnimalType="Chien",Author="Laura",Town="Paris",Date=DateTime.Now,Finished=false },
                new WantedAd { WantedAdID=3,Title="Et la marmotte...",Animal= "Aspirine", AnimalType="Lapin",Author="Emmanuel",Town="Lyon",Date=DateTime.Now,Finished=false },
                new WantedAd { WantedAdID=4,Title="J'ai crié par la fenêtre",Animal= "Felicity",AnimalType="Chat",Author="Michelle",Town="Nantes",Date=DateTime.Now,Finished=false }
            };
            wantedAds.ForEach(s => context.WantedAd.Add(s));
            context.SaveChanges();

            var animalTypes = new List<AnimalType>
            {
                new AnimalType {  AnimalTypeID=1, Name="Cat" },
                new AnimalType {  AnimalTypeID=2, Name="Dog" }
            };
            animalTypes.ForEach(s => context.AnimalType.Add(s));
            context.SaveChanges();

            var animals = new List<Animal>
            {
                new Animal { AnimalID=1,Town="Paris",AnimalType="Cat",Colour="Red",Lost=true },
                new Animal { AnimalID=2,Town="Nantes",AnimalType="Dog",Colour="Blue",Lost=true },
                new Animal { AnimalID=3,Town="Lyon",AnimalType="Dog",Colour="Gris",Lost=true }
            };
            animals.ForEach(s => context.Animal.Add(s));
            context.SaveChanges();


        }
    }   
}