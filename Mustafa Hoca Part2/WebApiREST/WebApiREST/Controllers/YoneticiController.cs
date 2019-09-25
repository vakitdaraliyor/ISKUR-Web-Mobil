using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiREST.Models;

namespace WebApiREST.Controllers
{
    public class YoneticiController : ApiController
    {
        Model1 db = new Model1();
        
        public List<YONETICI> Get(string arama)
        {
            if (arama != null)
            {
                return db.YONETICIs.Where(y => y.KULLANICI_ADI.Contains(arama)).ToList();
            }
            else
            {
                return db.YONETICIs.ToList();
            }
        }

        public YONETICI Get(int id)
        {
            YONETICI yonetici = db.YONETICIs.Find(id);
            return yonetici;
        }



    }
}