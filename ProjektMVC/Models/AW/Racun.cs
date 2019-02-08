using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.AW
{
    public class Racun
    {
        public int IDRacun { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public string BrojRacuna { get; set; }
        public string Komentar { get; set; }
        public string KomercijalistIme { get; set; }
        public string KomercijalistPrezime { get; set; }
        public bool StalniZaposlenik { get; set; }
        public string TipKartice { get; set; }
        public string BrojKartice { get; set; }
        public byte IstekMjesec { get; set; }
        public short IstekGodina { get; set; }
    }
}