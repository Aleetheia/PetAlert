using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetAlert.Models
{
    public class WantedAd
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WantedAdID { get; set; }
        [Required]
        [Display(Name = "Titre de l'annonce")]
        public string Title { get; set; }
        
        [ForeignKey("Animal")]
        [Display(Name = "Animal")]
        public int AnimalID { get; set; }
        public virtual Animal Animal { get; set; }

        //[ForeignKey("AnimalType")]
        [Display(Name = "Type d'animal")]
        public int AnimalTypeID { get; set; }
       // public virtual AnimalType AnimalType { get; set; }

        [ForeignKey("Author")]
        [Display(Name = "Auteur de l'avis")]
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }

        [ForeignKey("Town")]
        [Display(Name = "Ville")]
        public int TownID { get; set; }
        public virtual Town Town { get; set; }

        [Display(Name = "Date de publication")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Terminé ?")]
        public bool Finished { get; set; }
    }
}