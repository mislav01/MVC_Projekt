using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.AW
{
    public class KreditnaKartica
    {
        public int IDKreditnaKartica { get; set; }
        public string TipKartice { get; set; }
        public string BrojKartice { get; set; }
        public byte IstekMjesec { get; set; }
        public short IstekGodina { get; set; }
    }
}