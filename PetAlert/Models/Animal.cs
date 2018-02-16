using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetAlert.Models
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set;}
        public string Name { get; set; }
        [ForeignKey("AnimalType")]
        public int AnimalTypeID { get; set; }
        public virtual AnimalType AnimalType { get; set; }
        public int Age { get; set; }
        public bool Lost { get; set; }

    }
}