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

        public HttpResponseMessage Post([FromBody] YONETICI yonetici)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (yonetici != null)
                    {
                        db.YONETICIs.Add(yonetici);
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "Yeni kayıt başarı ile eklendi");
                    }
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Bulunamadı");
                }
                catch (Exception)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Ekleme Başarısız!");
                }
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ModelState);
            }

                      
        }

        public HttpResponseMessage Put([FromBody] YONETICI yonetici)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (yonetici != null)
                    {
                        db.Entry(yonetici).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "Güncelleme Başarılı");
                    }
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Bulunamadı");
                }
                catch (Exception)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Güncelleme Başarısız!");
                }
            }
            else
            {
                var hatalar = ModelState.ToList();
                string sonuc = "";
                foreach (var item in hatalar)
                {
                    sonuc = item.Key+ " " + item.Value;
                }
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, sonuc);
            }

            
        }            

        public HttpResponseMessage Delete(int id)
        {
            YONETICI y = db.YONETICIs.Find(id);
            try
            {
                if (y != null)
                {
                    db.YONETICIs.Remove(y);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Başarıyla silindi");
                }
                return Request.CreateResponse(HttpStatusCode.NotFound, "Bulunamadı");
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Silme Başarısız!");
            }
        }

    }
}