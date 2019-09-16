using Firma_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firma_MVC.Controllers
{
    public class UrunListeController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();

        // GET: Urunler
        public ActionResult Index(int? id)
        {
            List<KATEGORI> liste = db.KATEGORIs.ToList();
            ViewData["kategoriler"] = liste;

            if (id == null)
            {
                id = db.KATEGORIs.ToList()[0].KATEGORI_REFNO;
            }

            ViewData["urunler"] = db.URUNs.Where(u => u.KATEGORI_REFNO == id).ToList();

            return View();
        }

        public ActionResult Detay(int id=0)
        {
            URUN urun = db.URUNs.Find(id);
            if (urun == null)
            {
                TempData["m"] = "Ürün bulunamadi";
                return RedirectToAction("Goster", "Mesaj");
            }
            return View(urun);
        }
    }
}