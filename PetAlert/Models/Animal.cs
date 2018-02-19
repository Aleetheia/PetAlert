using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace PetAlert.Models
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set;}

        [Display(Name = "Nom")]
        public string Name { get; set; }

        [ForeignKey("AnimalType")]
        [Display(Name = "Type d'animal")]
        public int AnimalTypeID { get; set; }
        public virtual AnimalType AnimalType { get; set; }
        public IEnumerable<SelectListItem> AnimalTypes { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Perdu ?")]
        public bool Lost { get; set; }

        public AType TypeAnimal { get; set; }
    }
    public enum AType
    {
        Cat,
        Dog
    }
}