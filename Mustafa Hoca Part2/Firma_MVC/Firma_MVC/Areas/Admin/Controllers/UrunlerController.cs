using Firma_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firma_MVC.Areas.Admin.Controllers
{
    [Authorize]
    public class UrunlerController : Controller
    {
        // GET: Admin/Urunler
        FIRMAMODEL db = new FIRMAMODEL();
        // int toplamsatir = 0;
        int sayfadakiSatirSayisi = 5;
        // int toplamsayfa = 0;
        // int aktifsayfa = 0;

        public ActionResult Index(string arama, int aktifsayfa=0)
        {
            List<URUN> liste = new List<URUN>();
            if (arama == null)
            {
                arama = "";
                Sayfalama(db.URUNs.Count());
                liste = db.URUNs.OrderBy(u => u.URUN_REFNO)
                                .Skip(aktifsayfa * sayfadakiSatirSayisi)
                                .Take(sayfadakiSatirSayisi).ToList();
            }
            else
            {
                Sayfalama(db.URUNs.Where(u => u.URUN_ADI.Contains(arama)).Count());
                liste = db.URUNs.OrderBy(u => u.URUN_REFNO)
                                .Where(u => u.URUN_ADI.Contains(arama))
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
            if (ModelState.IsValid)
            {
                if (RESIM1 != null)
                {
                    u.RESIM1 = RESIM1.FileName;
                }
                if (RESIM2 != null)
                {
                    u.RESIM2 = RESIM2.FileName;
                }
                if (RESIM3 != null)
                {
                    u.RESIM3 = RESIM3.FileName;
                }
                if (RESIM4 != null)
                {
                    u.RESIM4 = RESIM4.FileName;
                }

                if (u.URUN_REFNO == 0)
                {
                    db.URUNs.Add(u);
                }
                else
                {
                    db.Entry(u).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();

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
            }
            else
            {
                string hatalar = "";
                foreach (var item in ModelState.Values)
                {
                    for (int i = 0; i < item.Errors.Count; i++)
                    {
                        hatalar += item.Errors[i].ErrorMessage;
                    }
                }

                ViewData["hatalar"] = hatalar;
                ViewData["kategori"] = db.KATEGORIs.ToList();
                ViewBag.marka = db.MARKAs.ToList();
                return View(u);
            }        
            return RedirectToAction("Index");
        }

        public ActionResult Search(string txtARA)
        {
            return RedirectToAction("Index", "Urunler", new { arama = txtARA });
        }
    }
}