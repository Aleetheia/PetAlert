using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetAlert.Models
{
    public class Animal
    {
        public int AnimalID { get; set;}
        public string Name { get; set; }
        public int AnimalTypeID { get; set; }
        public virtual AnimalType AnimalType { get; set; }
        public int Age { get; set; }
        public bool Lost { get; set; }

    }
}