using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.Projekt
{
    public class Kategorija
    {
        public int IDKategorija { get; set; }
        [Display(Name = "Naziv kategorije")]
        public string Naziv { get; set; }
    }
}