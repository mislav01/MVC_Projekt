using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjektMVC.Models.AW;
using System.Web.Mvc;

namespace ProjektMVC.Controllers
{
    [Authorize]
    public class ProjektController : Controller
    {
        public ActionResult Drzave() => View(Repository.GetDrzave());

        public ActionResult Gradovi(int id) => View(Repository.GetGradByDrzavaID(id));

        public ActionResult Kupci(int id) => View(Repository.GetKupacByGradID(id));

        public ActionResult Racuni(int id) => View(Repository.GetRacunKomercijalistKartica(id));

        public ActionResult Stavke(int id) => View(Repository.GetStavkaProizvodPotkategorijaKategorija(id));
    }
}