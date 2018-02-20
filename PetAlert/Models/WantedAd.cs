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
        public int AnimalID { get; set; }
        public virtual Animal Animal { get; set; }

        public int AnimalTypeID { get; set; }
        public virtual AnimalType AnimalType { get { return Animal?.AnimalType; } }

        [Display(Name = "Auteur de l'avis")]
        public string Author { get; set; }

        [Display(Name = "Ville")]
        public string Town { get; set; }

        [Display(Name = "Date de publication")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }

        [Display(Name = "Terminé ?")]
        public bool Finished { get; set; }
    }
}