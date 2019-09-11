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
        public ActionResult Index(string arama)
        {
            List<URUN> liste = new List<URUN>();
            if (arama == null)
            {
                arama = "";
                liste = db.URUNs.ToList();
            }
            else
            {
                liste = db.URUNs.Where(u => u.URUN_ADI.Contains(arama)).ToList();
            }
            ViewData["veri"] = arama;
            return View(liste);
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                URUN u = db.URUNs.Find(id);
                if (u != null)
                {
                    db.URUNs.Remove(u);
                    db.SaveChanges();
                }
            }
            // 1.yol (verileri de yollamamız gerekir)
            // List<KATEGORI> liste = db.KATEGORIs.ToList();
            // return View("Index", liste);

            // 2.yol (veri yollamaya gerek yok)
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create(int? id)
        {
            URUN urun = new URUN();
            if (id != null)
            {
                urun = db.URUNs.Find(id);
                if (urun == null)
                {
                    urun = new URUN();
                }                               
            }
            ViewData["kategori"] = db.KATEGORIs.ToList();
            ViewBag.marka = db.MARKAs.ToList();
            return View(urun);
        }

        [HttpPost]
        public ActionResult Create(URUN u, HttpPostedFileBase RESIM1, HttpPostedFileBase RESIM2, HttpPostedFileBase RESIM3, HttpPostedFileBase RESIM4)
        {
            if (u.URUN_REFNO == 0)
            {
                db.URUNs.Add(u);
            }
            else
            {
                db.Entry(u).State = System.Data.Entity.EntityState.Modified;
            }

            if (RESIM1 != null)
            {
                RESIM1.SaveAs(Request.PhysicalApplicationPath + "/Images/" + RESIM1.FileName);
            }
            if (RESIM2 != null)
            {
                RESIM2.SaveAs(Request.PhysicalApplicationPath + "/Images/" + RESIM2.FileName);
            }
            if (RESIM3 != null)
            {
                RESIM3.SaveAs(Request.PhysicalApplicationPath + "/Images/" + RESIM3.FileName);
            }
            if (RESIM4 != null)
            {
                RESIM4.SaveAs(Request.PhysicalApplicationPath + "/Images/" + RESIM4.FileName);
            }

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Search(string txtARA)
        {
            return RedirectToAction("Index", "Urunler", new { arama = txtARA });
        }
    }
}