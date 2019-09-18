using Firma_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firma_MVC.Areas.Admin.Controllers
{
    [Authorize]
    public class SayfalarController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();
        int sayfadakiSatirSayisi = 5;
        // GET: Admin/Sayfalar
        public ActionResult Index(string arama, int aktifsayfa=0)
        {
            List<SAYFA> liste = new List<SAYFA>();
            if (arama == null)
            {
                arama = "";
                Sayfalama(db.SAYFAs.Count());
                liste = db.SAYFAs.OrderBy(u => u.SAYFA_REFNO)
                                .Skip(aktifsayfa * sayfadakiSatirSayisi)
                                .Take(sayfadakiSatirSayisi).ToList();
            }
            else
            {
                Sayfalama(db.SAYFAs.Where(u => u.BASLIK.Contains(arama)).Count());
                liste = db.SAYFAs.OrderBy(u => u.SAYFA_REFNO)
                                .Where(u => u.BASLIK.Contains(arama))
                                .Skip(aktifsayfa * sayfadakiSatirSayisi)
                                .Take(sayfadakiSatirSayisi).ToList();
            }

            ViewData["veri"] = arama;
            ViewData["aktifsayfa"] = aktifsayfa;
            return View(liste);
        }

        public void Sayfalama(int satirsayisi)
        {
            int toplamsatir = satirsayisi;
            int toplamsayfa = toplamsatir / sayfadakiSatirSayisi;
            if (toplamsatir % sayfadakiSatirSayisi != 0)
            {
                toplamsayfa++;
            }

            ViewData["toplamsatir"] = toplamsatir;
            ViewData["toplamsayfa"] = toplamsayfa;
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