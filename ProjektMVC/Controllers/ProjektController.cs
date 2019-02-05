using ProjektMVC.Models.AW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektMVC.Controllers
{
    public class ProjektController : Controller
    {
        // GET: Projekt
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Drzave()
        {
            return View(Repository.GetDrzave());
        }

        public ActionResult Gradovi(int id)
        {
            return View(Repository.GetGradByDrzavaID(id));
        }

        public ActionResult Kupci(int id)
        {
            return View(Repository.GetKupacByGradID(id));
        }
    }
}