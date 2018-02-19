using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetAlert.Models
{
    public class Town
    {
        public int TownID { get; set; }

        [Display(Name = "Ville")]
        public string Name { get; set; }
    }
}