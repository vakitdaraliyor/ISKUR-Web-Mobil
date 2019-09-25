using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSSession.Model;

namespace WSSession
{
    /// <summary>
    /// WSMARKA için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class WSMARKA : System.Web.Services.WebService
    {

        Model1 db = new Model1();

        [WebMethod(EnableSession = true)]
        public bool GirisYap(string kullaniciadi, string parola)
        {
            var kullanici = db.KULLANICIs.Where(k => k.KULLANICI_ADI == kullaniciadi && k.PAROLA == parola).SingleOrDefault();
            if (kullanici != null)
            {
                Session["GIRIS"] = true;
                return true;
            }
            else
            {
                Session["GIRIS"] = false;
                return false;
            }
        }


        [WebMethod(EnableSession = true)]
        public List<MARKA> GetAllMARKA(string arama)
        {
            if (Session["GIRIS"] == null)
            {
                return null;
            }
            else
            {
                if (Convert.ToBoolean(Session["GIRIS"]) == false)
                {
                    return null;
                }
            }

            if (String.IsNullOrEmpty(arama))
            {
                return db.MARKAs.ToList();
            }
            else
            {
                return db.MARKAs.Where(m => m.MARKA_ADI.Contains(arama)).ToList();
            }
        }
    }
}
