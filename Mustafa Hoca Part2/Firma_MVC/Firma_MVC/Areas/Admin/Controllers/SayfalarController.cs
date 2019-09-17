using Firma_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firma_MVC.Areas.Admin.Controllers
{
    public class SayfalarController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();
        // GET: Admin/Sayfalar
        public ActionResult Index(string arama)
        {
            List<SAYFA> liste = new List<SAYFA>();
            if (arama == null)
            {
                arama = "";
                liste = db.SAYFAs.ToList();
            }
            else
            {
                liste = db.SAYFAs.Where(s => s.BASLIK.Contains(arama)).ToList();
            }
            ViewData["veri"] = arama;
            return View(liste);
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                SAYFA s = db.SAYFAs.Find(id);
                if (s != null)
                {
                    db.SAYFAs.Remove(s);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create(int? id)
        {
            SAYFA s = new SAYFA();
            if (id != null)
            {
                s = db.SAYFAs.Find(id);
            }
            else
            {
                s = new SAYFA();
            }

            return View(s);
        }

        [HttpPost]        
        [ValidateInput(false)]
        public ActionResult Create(SAYFA s)
        {
            if (ModelState.IsValid)
            {
                if (s.SAYFA_REFNO == 0)
                {
                    db.SAYFAs.Add(s);
                }
                else
                {
                    db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(s);
        }

        public ActionResult Search(string txtARA)
        {
            return RedirectToAction("Index", "Sayfalar", new { arama = txtARA });
        }
    }
}