using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.Projekt
{
    public class Kupac
    {
        public int IDKupac { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "{0} mora biti barem {2} znaka dugo.", MinimumLength = 3)]
        public string Ime { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "{0} mora biti barem {2} znaka dugo.", MinimumLength = 3)]
        public string Prezime { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "{0} mora biti barem {2} znakova dug.", MinimumLength = 10)]
        public string Telefon { get; set; }
        [Required]
        [Display(Name = "Grad")]
        public int GradID { get; set; }
    }
}