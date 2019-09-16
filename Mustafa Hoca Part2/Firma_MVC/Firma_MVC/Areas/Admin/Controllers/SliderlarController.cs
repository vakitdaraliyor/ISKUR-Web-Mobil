using Firma_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firma_MVC.Areas.Admin.Controllers
{
    public class SliderlarController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();
        // GET: Admin/Sliderlar
        public ActionResult Index(string arama)
        {
            List<SLIDER> liste = new List<SLIDER>();
            if (arama == null)
            {
                arama = "";
                liste = db.SLIDERs.ToList();
            }
            else
            {
                liste = db.SLIDERs.Where(s => s.BASLIK.Contains(arama)).ToList();
            }

            ViewData["veri"] = arama;
            return View(liste);
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                SLIDER s = db.SLIDERs.Find(id);
                if (s != null)
                {
                    db.SLIDERs.Remove(s);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create(int? id)
        {
            SLIDER s = new SLIDER();
            if (id != null)
            {
                s = db.SLIDERs.Find(id);
                if (s == null)
                {
                    s = new SLIDER();
                    return View(s);
                }
            }

            return View(s);
        }

        [HttpPost]
        public ActionResult Create(SLIDER s, HttpPostedFileBase RESIM)
        {
            if (ModelState.IsValid)
            {
                if (RESIM != null)
                {
                    s.RESIM = RESIM.FileName;
                }
                if (s.SLIDER_REFNO == 0)
                {
                    db.SLIDERs.Add(s);
                }
                else
                {
                    db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                if (RESIM != null)
                {
                    RESIM.SaveAs(Request.PhysicalApplicationPath + "/Images" + RESIM.FileName);
                }                
            }
            else
            {
                return View(s);
            }
            return RedirectToAction("Index");

        }

        public ActionResult Search(string txtARA)
        {
            return RedirectToAction("Index", "Sliderlar", new { arama = txtARA });
        }
    }
}