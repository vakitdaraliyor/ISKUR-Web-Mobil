using Firma_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firma_MVC.Controllers
{
    public class ProjeListeController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();
        // GET: ProjeListe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detay(int id=0)
        {
            PROJE proje = db.PROJEs.Find(id);
            if (proje == null)
            {
                TempData["m"] = "Proje Bulunamadı.";
                return RedirectToAction("Goster", "Mesaj");
            }
            return View(proje);
        }
    }
}