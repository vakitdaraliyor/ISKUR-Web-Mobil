using Firma_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firma_MVC.Areas.Admin.Controllers
{
    public class ProjelerController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();
        // GET: Admin/Projeler
        public ActionResult Index(string arama)
        {
            List<PROJE> liste = new List<PROJE>();
            if (arama == null)
            {
                arama = "";
                liste = db.PROJEs.ToList();
            }
            else
            {
                liste = db.PROJEs.Where(p => p.PROJE_ADI.Contains(arama)).ToList();
            }
            ViewData["veri"] = arama;
            return View(liste);
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                PROJE p = db.PROJEs.Find(id);
                if (p != null)
                {
                    db.PROJEs.Remove(p);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create(int? id)
        {
            PROJE p = new PROJE();
            if (id != null)
            {
                p = db.PROJEs.Find(id);
                if (p == null)
                {
                    p = new PROJE();
                }
            }
            return View(p);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(PROJE p)
        {
            if (ModelState.IsValid)
            {
                if (p.PROJE_REFNO == 0)
                {
                    db.PROJEs.Add(p);
                }
                else
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }

        public ActionResult Search(string txtARA)
        {
            return RedirectToAction("Index", "Projeler", new { arama = txtARA });
        }
    }
}