using System.Collections.Generic;
using PetAlert.Models;

namespace PetAlert.Models
{
    public  class AnimalModel
    {
        public Animal Animal { get; internal set; }

        public AnimalType AnimalType { get; internal set; }

        public WantedAd WantedAd { get; internal set; }

        public List<AnimalType> AnimalTypes { get; internal set; }

        public List<Animal> Animals { get; internal set; }
    }
}