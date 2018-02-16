using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetAlert.Models
{
    public class AnimalType
    {
        [Key]
        [ForeignKey("AnimalType")]
        public int AnimalTypeID { get; set; }
        [Required]
        [Display(Name = "Type d'animal")]
        public string Name { get; set; }
    }
}