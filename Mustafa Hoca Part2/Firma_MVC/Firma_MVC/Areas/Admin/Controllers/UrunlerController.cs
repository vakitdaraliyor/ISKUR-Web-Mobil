using Firma_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firma_MVC.Areas.Admin.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Admin/Urunler
        FIRMAMODEL db = new FIRMAMODEL();
        public ActionResult Index()
        {
            List<URUN> liste = db.URUNs.ToList();
            return View(liste);
        }

        public ActionResult Delete(int id)
        {
            URUN u = db.URUNs.Find(id);

            if (u != null)
            {
                db.URUNs.Remove(u);
                db.SaveChanges();
            }

            // 1.yol (verileri de yollamamız gerekir)
            // List<KATEGORI> liste = db.KATEGORIs.ToList();
            // return View("Index", liste);

            // 2.yol (veri yollamaya gerek yok)
            return RedirectToAction("Index");
        }
    }
}