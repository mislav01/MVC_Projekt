﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.Projekt
{
    public class Proizvod
    {
        public int IDProizvod { get; set; }
        [Display(Name = "Naziv proizvoda")]
        public string Naziv { get; set; }
        [Display(Name = "Broj proizvoda")]
        public string BrojProizvoda { get; set; }
        [Display(Name = "Boja")]
        public string Boja { get; set; }
        [Display(Name = "Minimalna količina na skladištu")]
        public short MinimalnaKolicinaNaSkladistu { get; set; }
        [Display(Name = "Cijena bez PDV-a")]
        public decimal CijenaBezPDV { get; set; }
    }
}