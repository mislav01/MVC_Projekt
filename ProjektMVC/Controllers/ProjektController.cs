using ProjektMVC.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektMVC.Controllers
{
    public class ProjektController : Controller
    {
        [Authorize]
        public ActionResult Drzave() => View(Repository.GetDrzave());
        [Authorize(Roles = "Administrator")]
        public ActionResult CreateDrzava() => View();

        [Authorize]
        public ActionResult Gradovi(int id) => View(Repository.GetGradByDrzavaID(id));

        [Authorize]
        public ActionResult Kupci(int id) => View(Repository.GetKupacByGradID(id));
        [Authorize(Roles = "Administrator")]
        public ActionResult EditKupac(int id)
        {
            ViewData["Drzave"] = Repository.GetDrzave();
            return View(Repository.GetKupacByID(id));
        }

        [Authorize]
        public ActionResult Racuni(int id)
        {
            return View(Repository.GetRacunKomercijalistKartica(id));
        }


        [Authorize]
        public ActionResult Stavke(int id) => View(Repository.GetStavkaProizvodPotkategorijaKategorija(id));
    }
}