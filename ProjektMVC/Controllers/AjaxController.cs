using ProjektMVC.Models.Projekt;
using ProjektMVC.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjektMVC.Controllers
{
    public class AjaxController : Controller
    {
        public ActionResult GetGradovi(int id)
        {
            return Json(Repository.GetGradByDrzavaID(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult EditKupac(Kupac kupac)
        {
            if (Repository.EditKupac(kupac) != null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotModified);
            }
        }
    }
}