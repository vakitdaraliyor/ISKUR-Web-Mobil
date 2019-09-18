using Firma_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Firma_MVC.Areas.Admin.Controllers
{
    public class GirisController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();
        // GET: Admin/Giris
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckUser(string KULLANICI_ADI, string PAROLA)
        {
            KULLANICI kullanici = db.KULLANICIs.Where(k => k.KULLANICI_ADI == KULLANICI_ADI && k.PAROLA == PAROLA).SingleOrDefault();

            if (kullanici != null)
            {
                FormsAuthentication.SetAuthCookie(KULLANICI_ADI, false);
                return RedirectToAction("Index", "Urunler");
            }
            else
            {
                return RedirectToAction("Index");
            }            
        }

        public ActionResult Cikis()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}