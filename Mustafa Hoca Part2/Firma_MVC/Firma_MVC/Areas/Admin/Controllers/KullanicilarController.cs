using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Firma_MVC.Models;

namespace Firma_MVC.Areas.Admin.Controllers
{
    public class KullanicilarController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();

        // GET: Admin/Kullanicilar
        public ActionResult Index(string arama)
        {
            List<KULLANICI> liste = new List<KULLANICI>();
            if (arama == null)
            {
                arama = "";
                liste = db.KULLANICIs.ToList();
            }
            else
            {
                liste = db.KULLANICIs.Where(k => k.KULLANICI_ADI.Contains(arama)).ToList();
            }
            ViewData["veri"] = arama;
            return View(liste);
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                KULLANICI k = db.KULLANICIs.Find(id);
                if (k != null)
                {
                    db.KULLANICIs.Remove(k);
                    db.SaveChanges();
                }                
            }            

            return RedirectToAction("Index");
        }

        // /Admin/Kullanicilar/Create  yeni
        // /Admin/Kullanicilar/Create/4  update
        [HttpGet]
        public ActionResult Create(int? id)
        {
            KULLANICI k = new KULLANICI();
            if (id != null)
            {
                k = db.KULLANICIs.Find(id);
                if (k == null)
                {
                    k = new KULLANICI();
                }                
            }

            return View(k); // Model Binding
        }

        [HttpPost]
        public ActionResult Create(KULLANICI k)
        {
            if (ModelState.IsValid)
            {
                if (k.KULLANICI_REFNO == 0)
                {
                   
                    db.KULLANICIs.Add(k);
                }
                else
                {
                    db.Entry(k).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            // hata var kayit ekranı açılacak
            return View(k);
        }

        public ActionResult Search(string txtARA)
        {
            return RedirectToAction("Index", "Kullanicilar", new { arama = txtARA });
        }
    }
}