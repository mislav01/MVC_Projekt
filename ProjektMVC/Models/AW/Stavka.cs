using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.AW
{
    public class Stavka
    {
        public int IDStavka { get; set; }
        public int RacunID { get; set; }
        public short Kolicina { get; set; }
        public int ProizvodID { get; set; }
        public decimal CijenaPoKomadu { get; set; }
        public decimal Popust { get; set; }
        public decimal UkupnaCijena { get; set; }
    }
}