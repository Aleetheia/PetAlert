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
        public string Title { get; set; }
        [Required]
        [ForeignKey("Animal")]
        public int AnimalID { get; set; }
        public virtual Animal Animal { get; set; }
        public int AnimalTypeID { get; set; }
        public int AuthorID { get; set; }
        public int TownID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public bool Finished { get; set; }
    }
}