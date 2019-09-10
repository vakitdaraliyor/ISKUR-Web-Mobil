using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Firma_MVC.Models;

namespace Firma_MVC.Areas.Admin.Controllers
{
    public class KategorilerController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();

        // GET: Kategoriler
        // View e veri yollama yontemleri 1-DataBinding ve 2-ViewData
        public ActionResult Index(string arama)
        {
            List<KATEGORI> liste = new List<KATEGORI>();

            if (arama == null)
            {
                arama = "";
                liste = db.KATEGORIs.ToList();
            }
            else
            {
                liste = db.KATEGORIs.Where(k => k.KATEGORI_ADI.Contains(arama)).ToList();
            }

            ViewData["veri"] = arama; // veri yollama yontemi(2)

            // return View();
            return View(liste); // veri yollama yontemi(1)
            // return View("index");
            // return View("index", liste);
        }

        public ActionResult Delete(int id)
        {
            KATEGORI k = db.KATEGORIs.Find(id);

            if (k != null)
            {
                db.KATEGORIs.Remove(k);
                db.SaveChanges();
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
            if (id == null)
            {
                KATEGORI k = new KATEGORI();
                return View(k);
            }
            else
            {
                KATEGORI k = db.KATEGORIs.Find(id);
                return View(k);
            }            
        }

        [HttpPost]
        public ActionResult Create(KATEGORI k)
        {
            if (k.KATEGORI_REFNO == 0)
            {
                db.KATEGORIs.Add(k);
            }
            else
            {
                db.Entry(k).State = System.Data.Entity.EntityState.Modified;                
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Search(string txtARA)
        {            
            // List<KATEGORI> liste =  db.KATEGORIs.Where(k => k.KATEGORI_ADI.Contains(txtARA)).ToList();

            return RedirectToAction("Index", "Kategoriler", new { arama = txtARA});            
        }
    }
}