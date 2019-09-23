using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace SOADHEADERWS
{
    /// <summary>
    /// WSKATEGORI için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class WSKATEGORI : System.Web.Services.WebService
    {

        Model1 db = new Model1();

        public GirisDenetle CheckUser;

        bool LoginKontrol(GirisDenetle k)
        {
            YONETICI y = db.YONETICIs.Where(y1 => y1.KULLANICI_ADI == k.prm1 && y1.SIFRESI == k.prm2).SingleOrDefault();
            if (y == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        [WebMethod]
        [SoapHeader("CheckUser")]
        public List<KATEGORI> GetAllKATEGORI(string arama)
        {
            if (LoginKontrol(CheckUser) == false) return null;

            if (String.IsNullOrEmpty(arama) == false)
            {
                return db.KATEGORIs.Where(k => k.KATEGORI_ADI.Contains(arama)).ToList();
            }
            else
            {
                return db.KATEGORIs.ToList();
            }            
        }

        [WebMethod]
        [SoapHeader("CheckUser")]
        public KATEGORI GetKATEGORI(int id)
        {
            if (LoginKontrol(CheckUser) == false) return null;
            KATEGORI k = db.KATEGORIs.Find(id);
            return k;
        }

        [WebMethod]
        [SoapHeader("CheckUser")]
        public void SaveKATEGORI(KATEGORI k)
        {
            if (LoginKontrol(CheckUser) == false) return;
            if (k != null)
            {
                db.KATEGORIs.Add(k);
                db.SaveChanges();
            }
        }

        [WebMethod]
        [SoapHeader("CheckUser")]
        public void UpdateKATEGORI(KATEGORI k)
        {
            if (LoginKontrol(CheckUser) == false) return;
            if (k != null)
            {
                db.Entry(k).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        [WebMethod]
        [SoapHeader("CheckUser")]
        public void DeleteKATEGORI(int id)
        {
            if (LoginKontrol(CheckUser) == false) return;
            KATEGORI k = db.KATEGORIs.Find(id);
            db.KATEGORIs.Remove(k);
            db.SaveChanges();
        }

    }
}
