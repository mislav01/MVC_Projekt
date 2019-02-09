using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.Projekt
{
    public class Komercijalist
    {
        public int IDKomercijalist { get; set; }
        [Display(Name = "Ime")]
        public string KomercijalistIme { get; set; }
        [Display(Name = "Prezime")]
        public string KomercijalistPrezime { get; set; }
        [Display(Name = "Stalni zaposlenik")]
        public bool StalniZaposlenik { get; set; }
    }
}