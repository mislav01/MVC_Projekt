using ProjektMVC.Models.Projekt;
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
            return View(id);
        }
        [Authorize]
        public ActionResult Sort(int id, string sort)
        {
            switch (sort)
            {
                case "dUzlazno":
                    return PartialView("Partial_Racuni", Repository.GetRacunKomercijalistKartica(id).OrderBy(item => item.DatumIzdavanja));
                case "dSilazno":
                    return PartialView("Partial_Racuni", Repository.GetRacunKomercijalistKartica(id).OrderByDescending(item => item.DatumIzdavanja));
                case "kUzlazno":
                    return PartialView("Partial_Racuni", Repository.GetRacunKomercijalistKartica(id).OrderBy(item => item.Komercijalist.KomercijalistIme));
                case "kSilazno":
                    return PartialView("Partial_Racuni", Repository.GetRacunKomercijalistKartica(id).OrderByDescending(item => item.Komercijalist.KomercijalistIme));
                case "tUzlazno":
                    return PartialView("Partial_Racuni", Repository.GetRacunKomercijalistKartica(id).OrderBy(item => item.KreditnaKartica.TipKartice));
                case "tSilazno":
                    return PartialView("Partial_Racuni", Repository.GetRacunKomercijalistKartica(id).OrderByDescending(item => item.KreditnaKartica.TipKartice));
                default:
                    return PartialView("Partial_Racuni", Repository.GetRacunKomercijalistKartica(id).OrderBy(item => item.DatumIzdavanja));
            }
        }


        [Authorize]
        public ActionResult Stavke(int id) => View(Repository.GetStavkaProizvodPotkategorijaKategorija(id));
    }
}