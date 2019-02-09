using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.Projekt
{
    public class Potkategorija
    {
        public int IDPotkategorija { get; set; }
        [Display(Name = "Naziv potkategorije")]
        public string Naziv { get; set; }
    }
}