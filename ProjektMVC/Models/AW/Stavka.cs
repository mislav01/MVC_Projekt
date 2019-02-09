using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.AW
{
    public class Stavka
    {
        public int IDStavka { get; set; }
        public short Kolicina { get; set; }
        public decimal CijenaPoKomadu { get; set; }
        public decimal Popust { get; set; }
        public decimal UkupnaCijena { get; set; }
        public Proizvod Proizvod { get; set; }
        public Potkategorija Potkategorija { get; set; }
        public Kategorija Kategorija { get; set; }
    }
}