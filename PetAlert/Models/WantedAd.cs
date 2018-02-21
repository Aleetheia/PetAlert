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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WantedAdID { get; set; }

        [Required]
        [Display(Name = "Titre")]
        public string Title { get; set; }

        [Display(Name = "Nom")]
        public string Animal { get; set; }
        [Display(Name = "Typel")]
        public string AnimalType { get; set; }

        [Display(Name = "Auteur")]
        public string Author { get; set; }

        [Display(Name = "Ville")]
        public string Town { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }

        [Display(Name = "Terminé ?")]
        public bool Finished { get; set; }
    }
}