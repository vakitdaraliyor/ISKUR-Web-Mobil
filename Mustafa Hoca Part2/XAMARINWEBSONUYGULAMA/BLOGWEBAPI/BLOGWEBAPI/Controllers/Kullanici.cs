using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLOGWEBAPI.Models;

namespace BLOGWEBAPI.Controllers
{    
    public class KullaniciController : ApiController
    {
        Model1 db = new Model1();
        // GET api/<controller>
        public List<KULLANICI> Get() 
        {            
            return db.KULLANICIs.ToList();
        }

        // GET api/<controller>/5
        public KULLANICI Get(int id)
        {
            KULLANICI k = db.KULLANICIs.Where(k1 => k1.KULLANICI_REFNO == id).SingleOrDefault();
            return k;
        }

        // POST api/<controller>
        public void Post([FromBody]KULLANICI k)
        {
            db.KULLANICIs.Add(k);
            db.SaveChanges();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]KULLANICI k)
        {
            db.Entry(k).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();          
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            KULLANICI k = db.KULLANICIs.Where(k1 => k1.KULLANICI_REFNO == id).SingleOrDefault();
            db.KULLANICIs.Remove(k);
            db.SaveChanges();
        }
    }
}