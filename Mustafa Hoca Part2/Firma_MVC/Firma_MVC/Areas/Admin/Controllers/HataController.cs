using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firma_MVC.Areas.Admin.Controllers
{
    public class HataController : Controller
    {
        // GET: Admin/Hata
        public ActionResult Index(string mesaj)
        {
            ViewData["mesaj"] = mesaj;
            return View();
        }
    }
}