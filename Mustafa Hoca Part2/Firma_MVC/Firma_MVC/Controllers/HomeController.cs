using Firma_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firma_MVC.Controllers
{
    public class HomeController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();
        public ActionResult Index()
        {
            ViewData["slider"] = db.SLIDERs.Where(s => s.DURUMU == true).ToList();
            ViewData["projeler"] = db.PROJEs.OrderBy(p => p.PROJE_REFNO).Take(2).ToList();
            ViewData["urunler"] = db.URUNs.OrderBy(p => p.URUN_REFNO).Take(2).ToList();
            return View();
        }

        public ActionResult Kurumsal()
        {
            ViewData["sayfa"] = db.SAYFAs.Where(s => s.BASLIK == "kurumsal").SingleOrDefault();

            return View();
        }

        public ActionResult Iletisim()
        {
            ViewData["sayfa"] = db.SAYFAs.Where(s => s.BASLIK == "iletisim").SingleOrDefault();

            return View("Kurumsal");
        }
    }
}