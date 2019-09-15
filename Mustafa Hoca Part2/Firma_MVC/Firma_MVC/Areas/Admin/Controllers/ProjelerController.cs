using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Firma_MVC.Models;

namespace Firma_MVC.Areas.Admin.Controllers
{
    public class ProjelerController : Controller
    {
        private FIRMAMODEL db = new FIRMAMODEL();

        // GET: Admin/Projeler
        public ActionResult Index()
        {
            return View(db.PROJEs.ToList());
        }

        // GET: Admin/Projeler/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROJE pROJE = db.PROJEs.Find(id);
            if (pROJE == null)
            {
                return HttpNotFound();
            }
            return View(pROJE);
        }

        // GET: Admin/Projeler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Projeler/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "PROJE_REFNO,PROJE_ADI,RESIM,ACIKLAMA")] PROJE pROJE)
        {
            if (ModelState.IsValid)
            {
                db.PROJEs.Add(pROJE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pROJE);
        }

        // GET: Admin/Projeler/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROJE pROJE = db.PROJEs.Find(id);
            if (pROJE == null)
            {
                return HttpNotFound();
            }
            return View(pROJE);
        }

        // POST: Admin/Projeler/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "PROJE_REFNO,PROJE_ADI,RESIM,ACIKLAMA")] PROJE pROJE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pROJE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pROJE);
        }

        // GET: Admin/Projeler/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROJE pROJE = db.PROJEs.Find(id);
            if (pROJE == null)
            {
                return HttpNotFound();
            }
            return View(pROJE);
        }

        // POST: Admin/Projeler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PROJE pROJE = db.PROJEs.Find(id);
            db.PROJEs.Remove(pROJE);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
