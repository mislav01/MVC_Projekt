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
        public Komercijalist Komercijalist { get; set; }
        public KreditnaKartica KreditnaKartica { get; set; }
    }
}