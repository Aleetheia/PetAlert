using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAlert.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        [Display(Name = "Auteur")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TownID { get; set; }
    }
}