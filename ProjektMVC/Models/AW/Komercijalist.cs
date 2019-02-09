using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.AW
{
    public class Komercijalist
    {
        public int IDKomercijalist { get; set; }
        public string KomercijalistIme { get; set; }
        public string KomercijalistPrezime { get; set; }
        public bool StalniZaposlenik { get; set; }
    }
}