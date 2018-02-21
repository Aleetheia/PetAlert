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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnimalID { get; set; }

        [Display(Name = "Nom")]
        public string Name { get; set; }
        
        [Display(Name = "Type d'animal")]
        [ForeignKey("AnimalType")]
        public int AnimalTypeID { get; set; }
        public virtual AnimalType AnimalType { get; set; }

        [Display(Name = "Couleur")]
        public string Colour { get; set; }

        [Display(Name = "Perdu ?")]
        public bool Lost { get; set; }
    }
}